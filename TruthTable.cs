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

    public bool Operations(bool a, bool b, bool c, bool d)
    {
      bool temp = false;
      try
      {
        if (nVars == 2) temp = Eval.Execute<bool>(op, new { a, b });
        if (nVars == 3) temp = Eval.Execute<bool>(op, new { a, b, c });
        if (nVars == 4) temp = Eval.Execute<bool>(op, new { a, b, c, d });
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        verif = true;
      }
      return temp;
    }

    public void InsertValues()
    {
      int temp;
      int div = 1;
      bool value = true, a, b, c, d, F;

      for (int indexV = 0; indexV < nVars; indexV++)
      {
        temp = comb / (2 * div);
        for (int indexXYZW = 0; indexXYZW < comb; indexXYZW++)
        {
          if (indexXYZW % temp == 0)
            value = !value;
          Vars.SetValue(value, indexXYZW, indexV);
          a = Convert.ToBoolean(Vars.GetValue(indexXYZW, 0));
          b = Convert.ToBoolean(Vars.GetValue(indexXYZW, 1));
          c = Convert.ToBoolean(Vars.GetValue(indexXYZW, 2));
          d = Convert.ToBoolean(Vars.GetValue(indexXYZW, 3));
          F = Operations(a, b, c, d);
          Vars.SetValue(F, indexXYZW, nVars);
        }
        div *= 2;
      }
    }

    public void CreateTable()
    {
      for (int i = 0; i < comb; i++)
        for (int j = 0; j < nVars + 1; j++)
          Table[j, i].Value = ((Convert.ToBoolean(Vars.GetValue(i, j)) == true) ? 1 : 0);
    }

    public void SelectMinTerms()
    {
      for (int i = 0; i < comb; i++)
        if ((Convert.ToBoolean(Vars.GetValue(i, nVars)) == true))
          Table[nVars, i].Style.BackColor = c;
    }

    public void ClearMinTerms()
    {
      for (int i = 0; i < comb; i++)
        Table[nVars, i].Style.BackColor = Color.FromArgb(61, 61, 61);
    }
  }
}
