using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;

namespace karnaugh_map_solver
{
  public partial class form__solver : Form
  {
    #region Variables

    private bool cmodeVald { get; set; } = true;
    private int cmode { get; set; } = 1;
    private int cursorPositionTbx { get; set; }
    private TruthTable table { get; set; }
    private Map map { get; set; }
    private List<Dictionary<string, string>> COLORS { get; set; } = new List<Dictionary<string, string>>
    {
      new Dictionary<string, string> {
        { "bg0", "#dcdcdc" },
        { "bg1", "#ffffff" },
        { "fg", "#000000" },
        { "btnacpar", "#808080" },
        { "btnvar", "#fafafa" },
        { "btnop", "#f09536" },
      },
      new Dictionary<string, string> {
        { "bg0", "#000000" },
        { "bg1", "#1e1e1e" },
        { "fg", "#ffffff" },
        { "btnacpar", "#a5a5a5" },
        { "btnvar", "#333333" },
        { "btnop", "#f1a33c" },
      },
    };
    private DataGridView dgv__table { get; set; } = new DataGridView();
    private DataGridView dgv__map { get; set; } = new DataGridView();
    private HashSet<long> onSet { get; set; } = new HashSet<long>();
    private Tuple<string, string> result { get; set; }

    #endregion

    #region Calculator

    #region FormBehavior

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

    private void handleFormMov(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void exitEvent(object sender, EventArgs e)
    {
      Close();
    }
    private void minEvent(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }

    private void lbl__equation_Click(object sender, EventArgs e)
    {
      panel__equation.Visible = true;
      panel__fill_table.Visible = false;
    }

    private void lbl__fill_table_Click(object sender, EventArgs e)
    {
      panel__fill_table.Visible = true;
      panel__equation.Visible = false;
    }

    #endregion

    #region ColorModeManagement

    private void lbl__change_mode_Click(object sender, EventArgs e)
    {
      cmodeVald = !cmodeVald;
      cmode = (cmodeVald) ? 1 : 0;
      lbl__change_mode.Text = (cmodeVald) ? "Light Mode" : "Dark Mode";
      initColorMode();
      Calculate();
    }

    private void initColorMode()
    {
      panel__sidebar.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg0"]}");
      panel__calculator.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg0"]}");
      panel__tbx__simpl__expr.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg0"]}");
      tbx__simpl_expr.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg0"]}");
      foreach (Control label in panel__sidebar.Controls)
        label.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");
      BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");

      panel__tbx__function.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      tbx__function.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      panel__simpl_expr.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      panel__nud__n_vars.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      nud__n_vars.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      hidenudarrows.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      btn__var_x.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      btn__var_y.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      btn__var_z.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      btn__var_w.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      btn__op_and.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnop"]}");
      btn__op_or.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnop"]}");
      btn__op_not.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnop"]}");
      btn__op_result.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnop"]}");

      foreach (Control btn in panel__calculator.Controls)
        btn.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");
      tbx__function.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");
      nud__n_vars.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");
      lbl__simpl_expr.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");
      tbx__simpl_expr.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");

      btn__op_clear.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnacpar"]}");
      btn__first_parenth.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnacpar"]}");
      btn__second_parenth.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnacpar"]}");
      btn__op_clear.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      btn__first_parenth.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      btn__second_parenth.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");

      dgv__table.GridColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg0"]}");
      dgv__table.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg0"]}");
      dgv__table.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");
      dgv__table.DefaultCellStyle.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      dgv__table.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");
      dgv__table.EnableHeadersVisualStyles = false;

      dgv__map.GridColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg0"]}");
      dgv__map.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg0"]}");
      dgv__map.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");
      dgv__map.RowHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg0"]}");
      dgv__map.RowHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");
      dgv__map.DefaultCellStyle.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      dgv__map.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");
      dgv__map.EnableHeadersVisualStyles = false;

      lbl__change_mode.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg0"]}");
      lbl__exit.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg0"]}");
    }

    #endregion

    #region PanelCalculator

    private void initPanelCalculator()
    {
      panel__calculator.Left = (panel__container_calculator.ClientSize.Width - panel__calculator.Width) / 2;
      panel__calculator.Top = (panel__container_calculator.ClientSize.Height - panel__calculator.Height) / 2;
    }

    private void insertText(object sender, EventArgs e)
    {
      tbx__function.Text = tbx__function.Text.Insert(cursorPositionTbx, (sender as Button).Text);
      cursorPositionTbx = tbx__function.Text.Length;
    }

    private void tbx__function_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != 0x041 && e.KeyChar != 0x042 && e.KeyChar != 0x043 && e.KeyChar != 0x044 &&
          e.KeyChar != 0x07E && e.KeyChar != 0x028 && e.KeyChar != 0x029 &&
          e.KeyChar != 0x08 && e.KeyChar != 0x02E && e.KeyChar != 0x02B)
        e.Handled = true;
    }

    private void setLastCursorPos(object sender, EventArgs e)
    {
      cursorPositionTbx = tbx__function.SelectionStart;
    }
    private void btn__op_clear_Click(object sender, EventArgs e)
    {
      tbx__function.Clear();
      tbx__simpl_expr.Clear();
      cursorPositionTbx = 0;
      createDGVTable();
      createDGVMap();
    }
    private bool validExpression(string expr)
    {
      return
        (nud__n_vars.Value == 2 && (expr.Contains("c") || expr.Contains("d") ||
        expr.Contains("C") || expr.Contains("D"))) ?
        false : (nud__n_vars.Value == 3 && (expr.Contains("d") || expr.Contains("D"))) ?
        false : true;
    }
    private string formatExpression(string expr)
    {
      expr = expr.Replace(".", "&&");
      expr = expr.Replace("+", "||");
      expr = expr.Replace("~", "!");

      expr = expr.ToLower();

      return expr;
    }
    private void nud__n_vars_ValueChanged(object sender, EventArgs e)
    {
      createDGVTable();
      createDGVMap();
      tbx__simpl_expr.Clear();
    }

    #endregion

    #region PanelTruthTable

    private void dgv_SelectionChanged(object sender, EventArgs e)
    {
      (sender as DataGridView).ClearSelection();
    }
    string[] literalVars = { "A", "B", "C", "D" };
    private void createDGVTable()
    {
      int n = (int)nud__n_vars.Value, cellSize = 30;

      dgv__table.DataSource = null;
      dgv__table.Columns.Clear();

      for (int i = 0; i <= n; i++)
      {
        if (i == n)
          dgv__table.Columns.Add("", "F");
        else
          dgv__table.Columns.Add("", literalVars[i]);
      }

      for (int j = 0; j < Convert.ToInt32(Math.Pow(2, n)); j++)
        dgv__table.Rows.Add();

      //for (int i = 0; i < n + 1; i++)
      //  dgv__table.Columns[i].Width = 30;
      foreach (DataGridViewColumn column in dgv__table.Columns)
        column.Width = cellSize;
      foreach (DataGridViewRow row in dgv__table.Rows)
        row.Height = cellSize;

      dgv__table.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, (byte)(0));
      dgv__table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      dgv__table.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, (byte)(0));
      dgv__table.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgv__table.BorderStyle = BorderStyle.None;
      dgv__table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

      dgv__table.SelectionChanged += new EventHandler(this.dgv_SelectionChanged);
      dgv__table.Enabled = false;
      dgv__table.ColumnHeadersHeight = cellSize;
      dgv__table.Width = (n + 1) * cellSize + 1;
      dgv__table.Height = ((int)Math.Pow(2, n) + 1) * cellSize;
      dgv__table.ScrollBars = ScrollBars.None;
      dgv__table.RowHeadersVisible = false;
      dgv__table.AllowUserToAddRows = false;
      dgv__table.Left = (panel__container_truthtable.ClientSize.Width - dgv__table.Width) / 2;
      dgv__table.Top = (panel__container_truthtable.ClientSize.Height - dgv__table.Height) / 2;
      panel__container_truthtable.Controls.Add(dgv__table);
    }

    #endregion

    #region PanelKMap

    private void createDGVMap()
    {
      int n = (int)nud__n_vars.Value, cellSize = 60;

      dgv__map.DataSource = null;
      dgv__map.Columns.Clear();

      if (n == 2)
      {
        cellSize = 140;
        dgv__map.Columns.Add("", "B'"); dgv__map.Columns.Add("", "B");
        dgv__map.Rows.Add(); dgv__map.Rows.Add();
        dgv__map.Rows[0].HeaderCell.Value = "A'"; dgv__map.Rows[1].HeaderCell.Value = "A";

      }
      else if (n == 3)
      {
        cellSize = 80;
        dgv__map.Columns.Add("", "B'C'"); dgv__map.Columns.Add("", "B'C");
        dgv__map.Columns.Add("", "BC"); dgv__map.Columns.Add("", "BC'");
        dgv__map.Rows.Add(); dgv__map.Rows.Add();
        dgv__map.Rows[0].HeaderCell.Value = "A'"; dgv__map.Rows[1].HeaderCell.Value = "A";
      }
      else if (n == 4)
      {
        cellSize = 80;
        dgv__map.Columns.Add("", "C'D'"); dgv__map.Columns.Add("", "C'D");
        dgv__map.Columns.Add("", "CD"); dgv__map.Columns.Add("", "CD'");
        dgv__map.Rows.Add(); dgv__map.Rows.Add();
        dgv__map.Rows.Add(); dgv__map.Rows.Add();
        dgv__map.Rows[0].HeaderCell.Value = "A'B'"; dgv__map.Rows[1].HeaderCell.Value = "A'B";
        dgv__map.Rows[2].HeaderCell.Value = "AB"; dgv__map.Rows[3].HeaderCell.Value = "AB'";
      }

      foreach (DataGridViewColumn column in dgv__map.Columns)
        column.Width = cellSize;
      foreach (DataGridViewRow row in dgv__map.Rows)
        row.Height = cellSize;

      dgv__map.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, (byte)(0));
      dgv__map.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, (byte)(0));
      dgv__map.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      dgv__map.DefaultCellStyle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, (byte)(0));
      dgv__map.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

      dgv__map.BorderStyle = BorderStyle.None;
      dgv__map.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      dgv__map.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

      dgv__map.SelectionChanged += new EventHandler(dgv_SelectionChanged);
      dgv__map.Enabled = false;
      dgv__map.AllowUserToAddRows = false;
      dgv__map.ScrollBars = ScrollBars.None;
      dgv__map.RowHeadersWidth = 70;
      dgv__map.ColumnHeadersHeight = 50;
      dgv__map.Size = new Size(dgv__map.Columns.Count * cellSize + dgv__map.RowHeadersWidth, dgv__map.Rows.Count * cellSize + dgv__map.ColumnHeadersHeight);
      dgv__map.Left = (panel__container_kmap.ClientSize.Width - dgv__map.Width) / 2;
      dgv__map.Top = (panel__container_kmap.ClientSize.Height - dgv__map.Height) / 2;

      panel__simpl_expr.Location = new Point((panel__container_kmap.ClientSize.Width - panel__simpl_expr.Width) / 2, dgv__map.Top + dgv__map.Height + 30);
      panel__container_kmap.Controls.Add(dgv__map);
    }

    #endregion

    #endregion

    public form__solver()
    {
      InitializeComponent();
    }

    private void Calculate()
    {
      if (tbx__function.Text.Length != 0)
      {
        if (validExpression(tbx__function.Text))
        {
          table = new TruthTable((int)nud__n_vars.Value, formatExpression(tbx__function.Text), dgv__table);
          table.InsertValues();
          map = new Map(table, dgv__map);
          if (table.verif)
            MessageBox.Show("Enter a valid function", "Uncomputed function");
          else
          {
            tbx__simpl_expr.Clear();

            table.CreateTable(cmode);

            onSet.Clear();
            for (int i = 0; i < table.comb; i++)
              if (Convert.ToInt32(table.tableValues.GetValue(i, (int)nud__n_vars.Value)) == 1)
                onSet.Add(long.Parse(i.ToString()));

            KMap kmap = new KMap((int)nud__n_vars.Value, onSet, new HashSet<long>() { });
            result = kmap.PrintCoverages(true);
            tbx__simpl_expr.Text = 
              (((int)nud__n_vars.Value == 2 && onSet.Count == 4) || 
              ((int)nud__n_vars.Value == 3 && onSet.Count == 8) || 
              ((int)nud__n_vars.Value == 4 && onSet.Count == 16)) ? 
              "1" : result.Item2;

            map.FillMap();
            map.CreateMap(cmode);
          }
        }
        else
          MessageBox.Show("Don't use terms that don't correspond to the number of variables specified.", "Terms out of context");
      }
    }

    private void form__solver_Load(object sender, EventArgs e)
    {
      initPanelCalculator();
      createDGVTable();
      createDGVMap();
      initColorMode();
    }

    private void btn__op_result_Click(object sender, EventArgs e)
    {
      Calculate();
    }

    private void panel__sidebar__mouse_leave(object sender, EventArgs e)
    {
      initColorMode();
      if (cmode == 1)
        (sender as Button).BackColor = Color.FromArgb(0, 0, 0);
      else
        (sender as Button).BackColor = Color.FromArgb(218, 218, 218);
    }

    private void panel__sidebar__mouse_move(object sender, MouseEventArgs e)
    {
      initColorMode();
      if (cmode == 1)
        (sender as Button).BackColor = Color.FromArgb(20, 20, 20);
      else
        (sender as Button).BackColor = Color.FromArgb(229, 229, 229);
    }
  }
}
