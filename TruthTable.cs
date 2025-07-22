using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Z.Expressions;

namespace karnaugh_map_solver
{
  public class TruthTable
  {
    public int nvars { get; set; }
    public int comb { get; set; }
    public Array tableValues { get; set; }
    public bool verif { get; set; }
    public string op { get; set; }
    public DataGridView table { get; set; }
    public Color c { get; set; }
    public Color sc { get; set; }

    public TruthTable(int nvars, string op, DataGridView table)
    {
      this.nvars = nvars;
      comb = (int)Math.Pow(2, nvars);
      this.op = op;
      tableValues = Array.CreateInstance(typeof(bool), comb, 5);
      this.table = table;
    }

    public bool Operations(bool a, bool b, bool c, bool d)
    {
      try
      {
        return
          (nvars == 2) ? Eval.Execute<bool>(op, new { a, b }) :
          (nvars == 3) ? Eval.Execute<bool>(op, new { a, b, c }) :
          (nvars == 4) ? Eval.Execute<bool>(op, new { a, b, c, d }) :
          false;
      }
      catch (Exception ex)
      {
        verif = true;
      }
      return false;
    }

    public void InsertValues()
    {
      int temp;
      int div = 1;
      bool value = true, a, b, c, d, F;

      for (int indexV = 0; indexV < nvars; indexV++)
      {
        temp = comb / (2 * div);
        for (int indexXYZW = 0; indexXYZW < comb; indexXYZW++)
        {
          if (indexXYZW % temp == 0)
            value = !value;
          tableValues.SetValue(value, indexXYZW, indexV);
          a = (bool)tableValues.GetValue(indexXYZW, 0);
          b = (bool)tableValues.GetValue(indexXYZW, 1);
          c = (bool)tableValues.GetValue(indexXYZW, 2);
          d = (bool)tableValues.GetValue(indexXYZW, 3);
          F = Operations(a, b, c, d);
          tableValues.SetValue(F, indexXYZW, nvars);
        }
        div *= 2;
      }
    }

    public void CreateTable(int cmode)
    {
      c = (cmode == 0) ? ColorTranslator.FromHtml("#f09536") : ColorTranslator.FromHtml("#f1a33c");
      sc = (cmode == 0) ? ColorTranslator.FromHtml("#ffffff") : ColorTranslator.FromHtml("#1e1e1e");

      for (int i = 0; i < comb; i++)
        for (int j = 0; j < nvars + 1; j++)
          table[j, i].Value = ((bool)(tableValues.GetValue(i, j)) == true) ? 1 : 0;
      for (int i = 0; i < comb; i++)
        table[nvars, i].Style.BackColor = sc;
      for (int i = 0; i < comb; i++)
        if ((bool)tableValues.GetValue(i, nvars) == true)
          table[nvars, i].Style.BackColor = c;
    }
  }
}
