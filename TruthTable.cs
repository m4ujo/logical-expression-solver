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

    public TruthTable(int nvars, string op)
    {
      this.nvars = nvars;
      comb = Convert.ToInt32(Math.Pow(2, nvars));
      this.op = op;
      tableValues = Array.CreateInstance(typeof(bool), comb, 5);
    }

    public bool Operations(bool x, bool y, bool z, bool w)
    {
      bool temp = false;
      try
      {
        if (nvars == 2) temp = Eval.Execute<bool>(op, new { x, y });
        if (nvars == 3) temp = Eval.Execute<bool>(op, new { x, y, z });
        if (nvars == 4) temp = Eval.Execute<bool>(op, new { x, y, z, w });
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
      bool value = true, x, y, z, w, F;

      for (int indexV = 0; indexV < nvars; indexV++)
      {
        temp = comb / (2 * div);
        for (int indexXYZW = 0; indexXYZW < comb; indexXYZW++)
        {
          if (indexXYZW % temp == 0)
            value = !value;
          tableValues.SetValue(value, indexXYZW, indexV);
          x = Convert.ToBoolean(tableValues.GetValue(indexXYZW, 0));
          y = Convert.ToBoolean(tableValues.GetValue(indexXYZW, 1));
          z = Convert.ToBoolean(tableValues.GetValue(indexXYZW, 2));
          w = Convert.ToBoolean(tableValues.GetValue(indexXYZW, 3));
          F = Operations(x, y, z, w);
          tableValues.SetValue(F, indexXYZW, nvars);
        }
        div *= 2;
      }
    }

    public void CreateTable()
    {
      for (int i = 0; i < comb; i++)
        for (int j = 0; j < nvars + 1; j++)
          table[j, i].Value = ((Convert.ToBoolean(tableValues.GetValue(i, j)) == true) ? 1 : 0);
      for (int i = 0; i < comb; i++)
        table[nvars, i].Style.BackColor = Color.FromArgb(255, 255, 255);
      for (int i = 0; i < comb; i++)
        if ((Convert.ToBoolean(tableValues.GetValue(i, nvars)) == true))
          table[nvars, i].Style.BackColor = c;
    }
  }
}
