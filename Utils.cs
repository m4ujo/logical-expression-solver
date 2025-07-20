using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace karnaugh_map_solver
{
  public static class Utils
  {
    public static string ToMintermMap(this Group group)
    {
      if (group.Count == 0)
        throw new ArgumentException("The group must contain at least one term");

      var terms = group.ToList();
      var first_term_list = terms.First().ToList();

      for (int n = 1; n < terms.Count; n++)
        for (int i = 0; i < first_term_list.Count; i++)
          if (terms[n][i] != first_term_list[i])
            first_term_list[i] = '-';

      return string.Join("", first_term_list);
    }

    public static string ToSOPExpression(this Coverage coverage)
    {
      var result = new StringBuilder();
      var groups = coverage.OrderBy(g => g.Count).ToList();
      for (int g = 0; g < groups.Count; g++)
      {
        result.Append(groups[g].ToMintermExpression());
        if (g != (groups.Count - 1))
          result.Append(" + ");
      }

      return result.ToString();
    }

    public static string ToMintermExpression(this Group group)
    {
      var map = group.ToMintermMap();

      var result = new StringBuilder(map.Length);
      for (int i = 0; i < map.Length; i++)
        if (map[i] != '-')
        {
          var letter = (char)('A' + i);
          //var letter = (char)('p' + i);
          result.Append(letter);
          result.Append(map[i] == '0' ? "\'" : "");
        }

      return result.ToString();
    }

    public static Tuple<string, string> PrintCoverage(this Coverage coverage)
    {
      var result = new StringBuilder();
      Console.WriteLine($"Coverage: {coverage.Cost.Value}");

      foreach (var g in coverage)
      {
        result.Append("{");
        var terms = g.ToList();
        for (int i = 0; i < terms.Count; i++)
        {
          if (i != terms.Count - 1) result.Append(terms[i] + " - ");
          else
            result.Append(terms[i]);
        }

        if (g.IsEssential.Value) result.Append("} \n\r");
        else
          Console.WriteLine("");
      }

      return new Tuple<string, string>(result.ToString(), coverage.ToSOPExpression());
    }

    public static Tuple<string, string> PrintCoverages(this KMap map, bool only_min = true)
    {
      var resultT = new Tuple<string, string>("", "");
      var coverages = map.Minimize();
      if (coverages.Count == 0)
        return new Tuple<string, string>("", "");
      var min_cost = coverages.Min(c => c.Cost.Value);
      foreach (var coverage in coverages)
      {
        if (only_min && coverage.Cost.Value > min_cost)
          continue;
        resultT = coverage.PrintCoverage();
      }

      return resultT;
    }

    public static string ToBinaryString(this long num, int num_bits)
    {
      return Convert.ToString(num, 2).PadLeft(num_bits, '0');
    }

    public static int Hamming(string s1, string s2)
    {
      Debug.Assert(s1.Length == s2.Length);

      int d = 0;
      for (int i = 0; i < s1.Length; i++)
        if (s1[i] != s2[i])
          d++;
      return d;
    }
  }
}
