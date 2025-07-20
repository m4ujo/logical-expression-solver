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
  }
}
