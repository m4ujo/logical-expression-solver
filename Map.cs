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
    public Array ChangeValues(Array f, int im, int iM)
    {
      Array m = f;
      var temp = new Object[truthT.nVars + 1];

      for (int j = 0; j < truthT.nVars + 1; j++)
      {
        temp[j] = m.GetValue(im, j);
        m.SetValue(m.GetValue(iM, j), im, j);
        m.SetValue(temp[j], iM, j);
      }

      return m;
    }

    public void FillMap()
    {
      if (truthT.nVars == 3 || truthT.nVars == 4)
      {
        for (int i = 0, j = 0; i < truthT.comb && j < truthT.comb; i++, j++)
          if (i == 2 || i == 6 || i == 10 || i == 14)
            truthT.Vars = ChangeValues(truthT.Vars, i, i + 1);

        if (truthT.nVars == 4)
          for (int j = 0; j < truthT.comb; j++)
            if (j == 8 || j == 9 || j == 10 || j == 11)
              truthT.Vars = ChangeValues(truthT.Vars, j, j + 4);
      }

      int index = 0;
      for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++, index++)
          matrix.SetValue(truthT.Vars.GetValue(index, truthT.nVars), i, j);
    }

    public void CreateMap()
    {
      for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
          DataMap[j, i].Value = ((Convert.ToBoolean(matrix.GetValue(i, j)) == true) ? 1 : 0);
    }

    public void MapColor()
    {
      for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
          if (Convert.ToBoolean(DataMap[j, i].Value) == true)
            DataMap[j, i].Style.BackColor = c;
    }

    public void ClearMap()
    {
      for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
          DataMap[j, i].Style.BackColor = Color.FromArgb(61, 61, 61);
    }
  }
}
