using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace karnaugh_map_solver
{
  public partial class solver_form : Form
  {
    public solver_form()
    {
      InitializeComponent();
    }

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

    private void btn_exit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void close_button_Paint(object sender, PaintEventArgs e)
    {
      this.Close();
    }

    private void min_button_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void top_panel_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void sidebar_panel_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }
  }
}
