using System;
using System.Collections.Generic;
using System.Linq;

namespace karnaugh_map_solver
{
  public class KMap
  {
    SortedSet<string> on_set_binary;
    SortedSet<string> dc_set_binary;

    public int NumberOfVariables { get; private set; }

    public HashSet<long> ONSet { get; set; }

    public HashSet<long> DCSet { get; set; }

    public KMap(int number_of_variables, HashSet<long> on_set, HashSet<long> dc_set)
    {
      NumberOfVariables = number_of_variables;
      ONSet = on_set;
      DCSet = dc_set;

      on_set_binary = new SortedSet<string>(ONSet.Select(e => e.ToBinaryString(number_of_variables)));
      dc_set_binary = new SortedSet<string>(DCSet.Select(e => e.ToBinaryString(number_of_variables)));

      foreach (var a in on_set_binary)
      {
        Console.WriteLine(a);
      }
    }

    public HashSet<Coverage> Minimize()
    {
      Coverage groups = new Coverage();

      foreach (var one in on_set_binary)
        groups.Add(new Group() { one });

      foreach (var dc in dc_set_binary)
        groups.Add(new Group() { dc });

      Coverage previous_groups = null;
      while (previous_groups == null || !groups.Equals(previous_groups))
      {
        previous_groups = groups;
        groups = MergeGroups(groups);
        groups = RemoveSubsets(groups);
      }

      groups = MarkEssential(groups);
      groups = RemoveRedundant(groups);

      return GetCoverages(groups);
    }

    Coverage MergeGroups(Coverage groups)
    {
      var merged = new Coverage();
      foreach (var g1 in groups)
        foreach (var g2 in groups)
        {
          if (g1.Intersect(g2).Count() == 0 && AreGroupsAdjacent(g1, g2))
          {
            var new_group = new Group(g1.Union(g2));
            merged.Add(new_group);
          }

        }

      return new Coverage(groups.Union(merged));
    }

    bool AreGroupsAdjacent(Group group1, Group group2)
    {
      if (group1.Count != group2.Count)
        return false;

      var matched_in_group2 = new Group();
      foreach (var term1 in group1)
      {
        var matched = false;
        foreach (var term2 in group2)
        {

          if (matched_in_group2.Contains(term2))
            continue;
          else if (Utils.Hamming(term1, term2) == 1)
          {
            matched = true;
            matched_in_group2.Add(term2);
            break;
          }
        }

        if (!matched)
          return false;
      }

      return true;
    }

    HashSet<Coverage> GetCoverages(Coverage groups)
    {
      var essential = new Coverage(groups.Where(g => g.IsEssential.Value));
      var available_groups_list = groups.Except(essential).OrderBy(g => g.Count);
      return new HashSet<Coverage>(NavigateCoverages(essential, available_groups_list, true));
    }

    IEnumerable<Coverage> NavigateCoverages(Coverage selected_groups, IEnumerable<Group> available_groups_list, bool check_coverage)
    {
      var solutions = new List<Coverage>();

      if (check_coverage && IsValidCoverage(selected_groups, out Coverage coverage))
        solutions.Add(coverage);

      if (!available_groups_list.Any())
        return solutions;

      var left_branch_groups = new Coverage(selected_groups) { available_groups_list.First() };
      var right_branch_groups = new Coverage(selected_groups);

      var next_available_groups_list = available_groups_list.Skip(1);
      var left_branch_coverages = NavigateCoverages(left_branch_groups, next_available_groups_list, true);
      var right_branch_coverages = NavigateCoverages(right_branch_groups, next_available_groups_list, false);

      return solutions.Union(left_branch_coverages).Union(right_branch_coverages);
    }

    bool IsValidCoverage(Coverage selected_groups, out Coverage coverage)
    {
      coverage = null;
      var on_set = new SortedSet<string>(on_set_binary);

      foreach (var g in selected_groups)
        on_set.ExceptWith(g);

      if (on_set.Any())
        return false;
      else
      {
        coverage = new Coverage(selected_groups) { Cost = CoverageCost(selected_groups) };
        return true;
      }
    }

    private long CoverageCost(Coverage selected_groups)
    {
      long cost = 0;
      foreach (var g in selected_groups)
      {
        var n = (long)Math.Log(g.Count, 2);
        cost += (NumberOfVariables - n);
      }
      return cost;
    }

    Coverage RemoveSubsets(Coverage groups)
    {
      var not_subsets = new Coverage();
      foreach (var candidate_subset in groups)
        if (!groups.Any(candidate_superset => candidate_subset.IsProperSubsetOf(candidate_superset)))
          not_subsets.Add(candidate_subset);

      return not_subsets;
    }

    Coverage MarkEssential(Coverage groups)
    {
      foreach (var g1 in groups)
      {
        var remaining_terms = new Group(g1.Except(dc_set_binary));
        foreach (var g2 in groups)
          if (!g1.Equals(g2))
            remaining_terms.ExceptWith(g2);

        if (remaining_terms.Count > 0)
          g1.IsEssential = true;
        else
          g1.IsEssential = false;
      }

      return groups;
    }

    Coverage RemoveRedundant(Coverage groups)
    {
      var redundant = new Coverage();
      var essential = new Coverage(groups.Where(g => g.IsEssential.Value));

      foreach (var g in groups)
      {
        if (g.IsEssential.Value)
          continue;

        var remaining_terms = new Group(g);
        foreach (var e in essential)
          remaining_terms.ExceptWith(e);
        if (remaining_terms.Count == 0)
          redundant.Add(g);
      }

      return new Coverage(groups.Except(redundant));
    }
  }
}
