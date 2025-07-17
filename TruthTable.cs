using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Z.Expressions;

namespace karnaugh_map_solver
{
  public class TruthTable
  {
    public int nVars { get; set; }
    public int comb { get; set; }
    public Array Vars { get; set; }
    public bool verif { get; set; }
    public string op { get; set; }
    public DataGridView Table { get; set; }
    public Color c { get; set; }

    public TruthTable(int nVars, string op)
    {
      this.nVars = nVars;
      comb = Convert.ToInt32(Math.Pow(2, nVars));

      op = op.ToLower();
      op = op.Replace(" ", ""); op = op.Replace("^", "&&"); op = op.Replace("v", "||"); op = op.Replace("~", "!");

      this.op = op;

      Vars = Array.CreateInstance(typeof(bool), comb, 5);
    }
  }
}
