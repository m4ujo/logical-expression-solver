using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace karnaugh_map_solver
{
  public partial class form__solver : Form
  {
    #region Variables
    private bool cmodeVald { get; set; } = false;
    private int cursorPositionTbx { get; set; }
    private TruthTable table { get; set; }
    private List<Dictionary<string, string>> COLORS { get; set; } = new List<Dictionary<string, string>>
    {
      new Dictionary<string, string> {
        { "bg0", "#fafafa" },
        { "bg1", "#ffffff" },
        { "fg", "#000000" },
        { "btnacpar", "#808080" },
        { "btnvar", "#e5e5e5" },
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

    #endregion

    public form__solver()
    {
      InitializeComponent();
    }

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

      int cmode;
      cmode = (cmodeVald) ? 1 : 0;
      lbl__change_mode.Text = (cmodeVald) ? "Light Mode" : "Dark Mode";

      initColorMode(cmode);
    }

    private void initColorMode(int cmode)
    {
      panel__sidebar.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg0"]}");
      panel__calculator.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg0"]}");
      foreach (Control label in panel__sidebar.Controls)
        label.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");
      BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");

      panel__tbx__function.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnvar"]}");
      tbx__function.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnvar"]}");
      panel__nud__n_vars.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnvar"]}");
      nud__n_vars.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnvar"]}");
      btn__var_x.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnvar"]}");
      btn__var_y.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnvar"]}");
      btn__var_z.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnvar"]}");
      btn__var_w.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnvar"]}");
      btn__op_and.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnop"]}");
      btn__op_or.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnop"]}");
      btn__op_not.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnop"]}");
      btn__op_result.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnop"]}");

      foreach (Control btn in panel__calculator.Controls)
        btn.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");
      tbx__function.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");
      nud__n_vars.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["fg"]}");

      btn__op_clear.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnacpar"]}");
      btn__first_parenth.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnacpar"]}");
      btn__second_parenth.BackColor = ColorTranslator.FromHtml($"{COLORS[cmode]["btnacpar"]}");
      btn__op_clear.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      btn__first_parenth.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
      btn__second_parenth.ForeColor = ColorTranslator.FromHtml($"{COLORS[cmode]["bg1"]}");
    }

    #endregion

    #region CalculatorBehavior

    private void insertText(object sender, EventArgs e)
    {
      tbx__function.Text = tbx__function.Text.Insert(cursorPositionTbx, (sender as Button).Text);
      cursorPositionTbx = tbx__function.Text.Length;
    }

    private void tbx__function_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != 0x078 && e.KeyChar != 0x079 && e.KeyChar != 0x07A && e.KeyChar != 0x077 &&
          e.KeyChar != 0x07E && e.KeyChar != 0x028 && e.KeyChar != 0x029 && e.KeyChar != 0x020 &&
          e.KeyChar != 0x08 && e.KeyChar != 0x076 && e.KeyChar != 0x05E)
        e.Handled = true;
    }

    private void setLastCursorPos(object sender, EventArgs e)
    {
      cursorPositionTbx = tbx__function.SelectionStart;
    }
    private void btn__op_clear_Click(object sender, EventArgs e)
    {
      tbx__function.Clear();
      cursorPositionTbx = 0;
    }
    private string formatExpression(string expr)
    {
      expr = expr.Replace(".", "&&");
      expr = expr.Replace("+", "||");
      expr = expr.Replace("~", "!");
      return expr;
    }

    #endregion

    private void form__solver_Load(object sender, EventArgs e)
    {
      initColorMode(0);
    }

    private void btn__op_result_Click(object sender, EventArgs e)
    {

    }
  }
}
