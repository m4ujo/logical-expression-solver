using System;
using System.Windows.Forms;
using System.Drawing;

namespace karnaugh_map_solver
{
  public class Map
  {
    public int columns { get; set; }
    public int rows { get; set; }
    public TruthTable truthT { get; set; }
    public Array matrix { get; set; }
    public DataGridView map { get; set; }
    public Color c { get; set; }
    public Color sc { get; set; }

    public Map(TruthTable truthT, DataGridView map)
    {
      this.truthT = truthT;
      if (this.truthT.nvars % 2 == 0)
        rows = columns = (int)(Math.Sqrt(Math.Pow(2, this.truthT.nvars)));
      else
      {
        columns = (int)(Math.Sqrt(Math.Pow(2, this.truthT.nvars + 1)));
        rows = columns / 2;
      }
      this.map = map;
      matrix = Array.CreateInstance(typeof(bool), rows, columns);
    }
    public Array ChangeValues(Array f, int im, int iM)
    {
      Array m = f;
      var temp = new Object[truthT.nvars + 1];

      for (int j = 0; j < truthT.nvars + 1; j++)
      {
        temp[j] = m.GetValue(im, j);
        m.SetValue(m.GetValue(iM, j), im, j);
        m.SetValue(temp[j], iM, j);
      }

      return m;
    }

    public void FillMap()
    {
      if (truthT.nvars == 3 || truthT.nvars == 4)
      {
        for (int i = 0, j = 0; i < truthT.comb && j < truthT.comb; i++, j++)
          if (i == 2 || i == 6 || i == 10 || i == 14)
            truthT.tableValues = ChangeValues(truthT.tableValues, i, i + 1);

        if (truthT.nvars == 4)
          for (int j = 0; j < truthT.comb; j++)
            if (j == 8 || j == 9 || j == 10 || j == 11)
              truthT.tableValues = ChangeValues(truthT.tableValues, j, j + 4);
      }

      int index = 0;
      for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++, index++)
          matrix.SetValue(truthT.tableValues.GetValue(index, truthT.nvars), i, j);
    }

    public void CreateMap(int cmode)
    {
      c = (cmode == 0) ? ColorTranslator.FromHtml("#f09536") : ColorTranslator.FromHtml("#f1a33c");
      sc = (cmode == 0) ? ColorTranslator.FromHtml("#ffffff") : ColorTranslator.FromHtml("#1e1e1e");

      for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
          map[j, i].Value = ((Convert.ToBoolean(matrix.GetValue(i, j)) == true) ? 1 : 0);

      for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
          map[j, i].Style.BackColor = sc;

      for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
          if (Convert.ToBoolean(map[j, i].Value) == true)
            map[j, i].Style.BackColor = c;
    }
  }
}
