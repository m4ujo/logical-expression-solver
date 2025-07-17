namespace karnaugh_map_solver
{
  partial class solver_form
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.sidebar_panel = new System.Windows.Forms.Panel();
      this.btn_exit = new System.Windows.Forms.Button();
      this.equation_panel = new System.Windows.Forms.Panel();
      this.btn_fill = new System.Windows.Forms.Button();
      this.btn_equation = new System.Windows.Forms.Button();
      this.label_title = new System.Windows.Forms.Label();
      this.top_panel = new System.Windows.Forms.Panel();
      this.min_button = new System.Windows.Forms.Panel();
      this.close_button = new System.Windows.Forms.Panel();
      this.sidebar_panel.SuspendLayout();
      this.top_panel.SuspendLayout();
      this.SuspendLayout();
      // 
      // sidebar_panel
      // 
      this.sidebar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
      this.sidebar_panel.Controls.Add(this.btn_exit);
      this.sidebar_panel.Controls.Add(this.equation_panel);
      this.sidebar_panel.Controls.Add(this.btn_fill);
      this.sidebar_panel.Controls.Add(this.btn_equation);
      this.sidebar_panel.Controls.Add(this.label_title);
      this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
      this.sidebar_panel.Name = "sidebar_panel";
      this.sidebar_panel.Size = new System.Drawing.Size(230, 600);
      this.sidebar_panel.TabIndex = 0;
      this.sidebar_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sidebar_panel_MouseDown);
      // 
      // btn_exit
      // 
      this.btn_exit.BackColor = System.Drawing.Color.Transparent;
      this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_exit.FlatAppearance.BorderSize = 0;
      this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_exit.ForeColor = System.Drawing.Color.White;
      this.btn_exit.Location = new System.Drawing.Point(0, 281);
      this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
      this.btn_exit.Name = "btn_exit";
      this.btn_exit.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
      this.btn_exit.Size = new System.Drawing.Size(230, 42);
      this.btn_exit.TabIndex = 3;
      this.btn_exit.Text = "Exit";
      this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btn_exit.UseVisualStyleBackColor = false;
      this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
      // 
      // equation_panel
      // 
      this.equation_panel.Location = new System.Drawing.Point(230, 31);
      this.equation_panel.Name = "equation_panel";
      this.equation_panel.Size = new System.Drawing.Size(970, 569);
      this.equation_panel.TabIndex = 1;
      // 
      // btn_fill
      // 
      this.btn_fill.BackColor = System.Drawing.Color.Transparent;
      this.btn_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_fill.FlatAppearance.BorderSize = 0;
      this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_fill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_fill.ForeColor = System.Drawing.Color.White;
      this.btn_fill.Location = new System.Drawing.Point(0, 239);
      this.btn_fill.Margin = new System.Windows.Forms.Padding(0);
      this.btn_fill.Name = "btn_fill";
      this.btn_fill.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
      this.btn_fill.Size = new System.Drawing.Size(230, 42);
      this.btn_fill.TabIndex = 2;
      this.btn_fill.Text = "Truthtable filling";
      this.btn_fill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btn_fill.UseVisualStyleBackColor = false;
      // 
      // btn_equation
      // 
      this.btn_equation.BackColor = System.Drawing.Color.Transparent;
      this.btn_equation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btn_equation.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_equation.FlatAppearance.BorderSize = 0;
      this.btn_equation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_equation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_equation.ForeColor = System.Drawing.Color.White;
      this.btn_equation.Location = new System.Drawing.Point(0, 197);
      this.btn_equation.Margin = new System.Windows.Forms.Padding(0);
      this.btn_equation.Name = "btn_equation";
      this.btn_equation.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
      this.btn_equation.Size = new System.Drawing.Size(230, 42);
      this.btn_equation.TabIndex = 1;
      this.btn_equation.Text = "Equation";
      this.btn_equation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btn_equation.UseVisualStyleBackColor = false;
      // 
      // label_title
      // 
      this.label_title.AutoSize = true;
      this.label_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label_title.ForeColor = System.Drawing.Color.White;
      this.label_title.Location = new System.Drawing.Point(23, 51);
      this.label_title.Margin = new System.Windows.Forms.Padding(0);
      this.label_title.Name = "label_title";
      this.label_title.Size = new System.Drawing.Size(137, 96);
      this.label_title.TabIndex = 0;
      this.label_title.Text = "Logical\r\nExpression\r\nSolver";
      // 
      // top_panel
      // 
      this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
      this.top_panel.Controls.Add(this.min_button);
      this.top_panel.Controls.Add(this.close_button);
      this.top_panel.Location = new System.Drawing.Point(230, 0);
      this.top_panel.Name = "top_panel";
      this.top_panel.Size = new System.Drawing.Size(970, 31);
      this.top_panel.TabIndex = 2;
      this.top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDown);
      // 
      // min_button
      // 
      this.min_button.BackColor = System.Drawing.Color.Transparent;
      this.min_button.BackgroundImage = global::karnaugh_map_solver.Properties.Resources.min_button_small;
      this.min_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.min_button.Location = new System.Drawing.Point(921, 8);
      this.min_button.Name = "min_button";
      this.min_button.Size = new System.Drawing.Size(15, 15);
      this.min_button.TabIndex = 4;
      this.min_button.Click += new System.EventHandler(this.min_button_Click);
      // 
      // close_button
      // 
      this.close_button.BackColor = System.Drawing.Color.Transparent;
      this.close_button.BackgroundImage = global::karnaugh_map_solver.Properties.Resources.close_button_small;
      this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.close_button.Location = new System.Drawing.Point(943, 8);
      this.close_button.Name = "close_button";
      this.close_button.Size = new System.Drawing.Size(15, 15);
      this.close_button.TabIndex = 3;
      this.close_button.Click += new System.EventHandler(this.btn_exit_Click);
      // 
      // solver_form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1200, 600);
      this.Controls.Add(this.top_panel);
      this.Controls.Add(this.sidebar_panel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.Name = "solver_form";
      this.Text = "Form1";
      this.sidebar_panel.ResumeLayout(false);
      this.sidebar_panel.PerformLayout();
      this.top_panel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel sidebar_panel;
    private System.Windows.Forms.Label label_title;
    private System.Windows.Forms.Button btn_equation;
    private System.Windows.Forms.Button btn_fill;
    private System.Windows.Forms.Button btn_exit;
    private System.Windows.Forms.Panel equation_panel;
    private System.Windows.Forms.Panel top_panel;
    private System.Windows.Forms.Panel min_button;
    private System.Windows.Forms.Panel close_button;
  }
}

