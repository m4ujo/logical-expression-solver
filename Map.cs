using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace karnaugh_map_solver
{
  public class Map
  {
    public int columns { get; set; }
    public int rows { get; set; }
    public TruthTable truthT;
    public Array matrix;
    public DataGridView DataMap { get; set; }
    public Color c { get; set; }

    public Map(TruthTable truthT)
    {
      this.truthT = truthT;
      if (this.truthT.nVars % 2 == 0)
        rows = columns = Convert.ToInt32(Math.Sqrt(Math.Pow(2, this.truthT.nVars)));
      else
      {
        columns = Convert.ToInt32(Math.Sqrt(Math.Pow(2, this.truthT.nVars + 1)));
        rows = columns / 2;
      }

      matrix = Array.CreateInstance(typeof(bool), rows, columns);
    }
  }
}
