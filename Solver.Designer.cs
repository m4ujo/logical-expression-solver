namespace karnaugh_map_solver
{
  partial class form__solver
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form__solver));
      this.panel__sidebar = new System.Windows.Forms.Panel();
      this.panel__fill_table = new System.Windows.Forms.Panel();
      this.lbl__change_mode = new System.Windows.Forms.Button();
      this.lbl__exit = new System.Windows.Forms.Button();
      this.lbl__title = new System.Windows.Forms.Label();
      this.panel__top = new System.Windows.Forms.Panel();
      this.btn__top_min = new System.Windows.Forms.Panel();
      this.btn__top_close = new System.Windows.Forms.Panel();
      this.panel__equation = new System.Windows.Forms.Panel();
      this.panel__container_kmap = new System.Windows.Forms.Panel();
      this.panel__simpl_expr = new System.Windows.Forms.Panel();
      this.panel__tbx__simpl__expr = new System.Windows.Forms.Panel();
      this.tbx__simpl_expr = new System.Windows.Forms.TextBox();
      this.lbl__simpl_expr = new System.Windows.Forms.Label();
      this.panel__container_calculator = new System.Windows.Forms.Panel();
      this.panel__calculator = new System.Windows.Forms.Panel();
      this.panel__nud__n_vars = new System.Windows.Forms.Panel();
      this.hidenudarrows = new System.Windows.Forms.Panel();
      this.nud__n_vars = new System.Windows.Forms.NumericUpDown();
      this.lbl__nvars = new System.Windows.Forms.Label();
      this.btn__op_or = new System.Windows.Forms.Button();
      this.btn__op_result = new System.Windows.Forms.Button();
      this.btn__op_and = new System.Windows.Forms.Button();
      this.btn__op_not = new System.Windows.Forms.Button();
      this.btn__op_clear = new System.Windows.Forms.Button();
      this.btn__var_x = new System.Windows.Forms.Button();
      this.btn__var_y = new System.Windows.Forms.Button();
      this.btn__second_parenth = new System.Windows.Forms.Button();
      this.btn__var_z = new System.Windows.Forms.Button();
      this.btn__first_parenth = new System.Windows.Forms.Button();
      this.btn__var_w = new System.Windows.Forms.Button();
      this.panel__tbx__function = new System.Windows.Forms.Panel();
      this.tbx__function = new System.Windows.Forms.TextBox();
      this.panel__container_truthtable = new System.Windows.Forms.Panel();
      this.panel__sidebar.SuspendLayout();
      this.panel__top.SuspendLayout();
      this.panel__equation.SuspendLayout();
      this.panel__container_kmap.SuspendLayout();
      this.panel__simpl_expr.SuspendLayout();
      this.panel__tbx__simpl__expr.SuspendLayout();
      this.panel__container_calculator.SuspendLayout();
      this.panel__calculator.SuspendLayout();
      this.panel__nud__n_vars.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nud__n_vars)).BeginInit();
      this.panel__tbx__function.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel__sidebar
      // 
      this.panel__sidebar.BackColor = System.Drawing.Color.Transparent;
      this.panel__sidebar.Controls.Add(this.panel__fill_table);
      this.panel__sidebar.Controls.Add(this.lbl__change_mode);
      this.panel__sidebar.Controls.Add(this.lbl__exit);
      this.panel__sidebar.Controls.Add(this.lbl__title);
      this.panel__sidebar.Location = new System.Drawing.Point(0, 0);
      this.panel__sidebar.Name = "panel__sidebar";
      this.panel__sidebar.Size = new System.Drawing.Size(230, 650);
      this.panel__sidebar.TabIndex = 0;
      this.panel__sidebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.handleFormMov);
      // 
      // panel__fill_table
      // 
      this.panel__fill_table.BackColor = System.Drawing.Color.Black;
      this.panel__fill_table.Enabled = false;
      this.panel__fill_table.Location = new System.Drawing.Point(229, 41);
      this.panel__fill_table.Name = "panel__fill_table";
      this.panel__fill_table.Size = new System.Drawing.Size(972, 609);
      this.panel__fill_table.TabIndex = 72;
      this.panel__fill_table.Visible = false;
      // 
      // lbl__change_mode
      // 
      this.lbl__change_mode.BackColor = System.Drawing.Color.Transparent;
      this.lbl__change_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.lbl__change_mode.Cursor = System.Windows.Forms.Cursors.Hand;
      this.lbl__change_mode.FlatAppearance.BorderSize = 0;
      this.lbl__change_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl__change_mode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl__change_mode.ForeColor = System.Drawing.Color.Black;
      this.lbl__change_mode.Location = new System.Drawing.Point(0, 533);
      this.lbl__change_mode.Margin = new System.Windows.Forms.Padding(0);
      this.lbl__change_mode.Name = "lbl__change_mode";
      this.lbl__change_mode.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
      this.lbl__change_mode.Size = new System.Drawing.Size(230, 42);
      this.lbl__change_mode.TabIndex = 73;
      this.lbl__change_mode.Text = "Light Mode";
      this.lbl__change_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lbl__change_mode.UseVisualStyleBackColor = false;
      this.lbl__change_mode.Click += new System.EventHandler(this.lbl__change_mode_Click);
      this.lbl__change_mode.MouseLeave += new System.EventHandler(this.panel__sidebar__mouse_leave);
      this.lbl__change_mode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel__sidebar__mouse_move);
      // 
      // lbl__exit
      // 
      this.lbl__exit.BackColor = System.Drawing.Color.Transparent;
      this.lbl__exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.lbl__exit.Cursor = System.Windows.Forms.Cursors.Hand;
      this.lbl__exit.FlatAppearance.BorderSize = 0;
      this.lbl__exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl__exit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl__exit.ForeColor = System.Drawing.Color.Black;
      this.lbl__exit.Location = new System.Drawing.Point(0, 580);
      this.lbl__exit.Margin = new System.Windows.Forms.Padding(0);
      this.lbl__exit.Name = "lbl__exit";
      this.lbl__exit.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
      this.lbl__exit.Size = new System.Drawing.Size(230, 42);
      this.lbl__exit.TabIndex = 3;
      this.lbl__exit.Text = "Exit";
      this.lbl__exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lbl__exit.UseVisualStyleBackColor = false;
      this.lbl__exit.Click += new System.EventHandler(this.exitEvent);
      this.lbl__exit.MouseLeave += new System.EventHandler(this.panel__sidebar__mouse_leave);
      this.lbl__exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel__sidebar__mouse_move);
      // 
      // lbl__title
      // 
      this.lbl__title.AutoSize = true;
      this.lbl__title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl__title.ForeColor = System.Drawing.Color.Black;
      this.lbl__title.Location = new System.Drawing.Point(23, 71);
      this.lbl__title.Margin = new System.Windows.Forms.Padding(0);
      this.lbl__title.Name = "lbl__title";
      this.lbl__title.Size = new System.Drawing.Size(137, 96);
      this.lbl__title.TabIndex = 0;
      this.lbl__title.Text = "Logical\r\nExpression\r\nSolver";
      // 
      // panel__top
      // 
      this.panel__top.BackColor = System.Drawing.Color.Transparent;
      this.panel__top.Controls.Add(this.btn__top_min);
      this.panel__top.Controls.Add(this.btn__top_close);
      this.panel__top.Location = new System.Drawing.Point(229, 0);
      this.panel__top.Name = "panel__top";
      this.panel__top.Size = new System.Drawing.Size(972, 41);
      this.panel__top.TabIndex = 72;
      this.panel__top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.handleFormMov);
      // 
      // btn__top_min
      // 
      this.btn__top_min.BackColor = System.Drawing.Color.Transparent;
      this.btn__top_min.BackgroundImage = global::karnaugh_map_solver.Properties.Resources.min_button_small;
      this.btn__top_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btn__top_min.Location = new System.Drawing.Point(919, 13);
      this.btn__top_min.Name = "btn__top_min";
      this.btn__top_min.Size = new System.Drawing.Size(15, 15);
      this.btn__top_min.TabIndex = 4;
      this.btn__top_min.Click += new System.EventHandler(this.minEvent);
      // 
      // btn__top_close
      // 
      this.btn__top_close.BackColor = System.Drawing.Color.Transparent;
      this.btn__top_close.BackgroundImage = global::karnaugh_map_solver.Properties.Resources.close_button_small;
      this.btn__top_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btn__top_close.Location = new System.Drawing.Point(940, 13);
      this.btn__top_close.Name = "btn__top_close";
      this.btn__top_close.Size = new System.Drawing.Size(15, 15);
      this.btn__top_close.TabIndex = 3;
      this.btn__top_close.Click += new System.EventHandler(this.exitEvent);
      // 
      // panel__equation
      // 
      this.panel__equation.Controls.Add(this.panel__container_kmap);
      this.panel__equation.Controls.Add(this.panel__container_calculator);
      this.panel__equation.Controls.Add(this.panel__container_truthtable);
      this.panel__equation.Location = new System.Drawing.Point(229, 41);
      this.panel__equation.Name = "panel__equation";
      this.panel__equation.Size = new System.Drawing.Size(972, 609);
      this.panel__equation.TabIndex = 73;
      // 
      // panel__container_kmap
      // 
      this.panel__container_kmap.BackColor = System.Drawing.Color.Transparent;
      this.panel__container_kmap.Controls.Add(this.panel__simpl_expr);
      this.panel__container_kmap.Location = new System.Drawing.Point(456, 0);
      this.panel__container_kmap.Name = "panel__container_kmap";
      this.panel__container_kmap.Size = new System.Drawing.Size(516, 609);
      this.panel__container_kmap.TabIndex = 2;
      // 
      // panel__simpl_expr
      // 
      this.panel__simpl_expr.Controls.Add(this.panel__tbx__simpl__expr);
      this.panel__simpl_expr.Controls.Add(this.lbl__simpl_expr);
      this.panel__simpl_expr.Location = new System.Drawing.Point(78, 535);
      this.panel__simpl_expr.Name = "panel__simpl_expr";
      this.panel__simpl_expr.Size = new System.Drawing.Size(383, 43);
      this.panel__simpl_expr.TabIndex = 0;
      // 
      // panel__tbx__simpl__expr
      // 
      this.panel__tbx__simpl__expr.BackColor = System.Drawing.Color.WhiteSmoke;
      this.panel__tbx__simpl__expr.Controls.Add(this.tbx__simpl_expr);
      this.panel__tbx__simpl__expr.Location = new System.Drawing.Point(154, 7);
      this.panel__tbx__simpl__expr.Name = "panel__tbx__simpl__expr";
      this.panel__tbx__simpl__expr.Size = new System.Drawing.Size(213, 30);
      this.panel__tbx__simpl__expr.TabIndex = 76;
      // 
      // tbx__simpl_expr
      // 
      this.tbx__simpl_expr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbx__simpl_expr.BackColor = System.Drawing.Color.WhiteSmoke;
      this.tbx__simpl_expr.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbx__simpl_expr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbx__simpl_expr.ForeColor = System.Drawing.Color.Black;
      this.tbx__simpl_expr.Location = new System.Drawing.Point(11, 4);
      this.tbx__simpl_expr.Name = "tbx__simpl_expr";
      this.tbx__simpl_expr.ReadOnly = true;
      this.tbx__simpl_expr.ShortcutsEnabled = false;
      this.tbx__simpl_expr.Size = new System.Drawing.Size(193, 22);
      this.tbx__simpl_expr.TabIndex = 50;
      // 
      // lbl__simpl_expr
      // 
      this.lbl__simpl_expr.AutoSize = true;
      this.lbl__simpl_expr.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl__simpl_expr.Location = new System.Drawing.Point(10, 14);
      this.lbl__simpl_expr.Name = "lbl__simpl_expr";
      this.lbl__simpl_expr.Size = new System.Drawing.Size(138, 17);
      this.lbl__simpl_expr.TabIndex = 75;
      this.lbl__simpl_expr.Text = "Simplified expression:";
      // 
      // panel__container_calculator
      // 
      this.panel__container_calculator.BackColor = System.Drawing.Color.Transparent;
      this.panel__container_calculator.Controls.Add(this.panel__calculator);
      this.panel__container_calculator.Location = new System.Drawing.Point(0, 0);
      this.panel__container_calculator.Name = "panel__container_calculator";
      this.panel__container_calculator.Size = new System.Drawing.Size(291, 609);
      this.panel__container_calculator.TabIndex = 0;
      // 
      // panel__calculator
      // 
      this.panel__calculator.BackColor = System.Drawing.Color.Gainsboro;
      this.panel__calculator.Controls.Add(this.panel__nud__n_vars);
      this.panel__calculator.Controls.Add(this.lbl__nvars);
      this.panel__calculator.Controls.Add(this.btn__op_or);
      this.panel__calculator.Controls.Add(this.btn__op_result);
      this.panel__calculator.Controls.Add(this.btn__op_and);
      this.panel__calculator.Controls.Add(this.btn__op_not);
      this.panel__calculator.Controls.Add(this.btn__op_clear);
      this.panel__calculator.Controls.Add(this.btn__var_x);
      this.panel__calculator.Controls.Add(this.btn__var_y);
      this.panel__calculator.Controls.Add(this.btn__second_parenth);
      this.panel__calculator.Controls.Add(this.btn__var_z);
      this.panel__calculator.Controls.Add(this.btn__first_parenth);
      this.panel__calculator.Controls.Add(this.btn__var_w);
      this.panel__calculator.Controls.Add(this.panel__tbx__function);
      this.panel__calculator.Location = new System.Drawing.Point(28, 112);
      this.panel__calculator.Name = "panel__calculator";
      this.panel__calculator.Size = new System.Drawing.Size(234, 265);
      this.panel__calculator.TabIndex = 75;
      // 
      // panel__nud__n_vars
      // 
      this.panel__nud__n_vars.BackColor = System.Drawing.Color.WhiteSmoke;
      this.panel__nud__n_vars.Controls.Add(this.hidenudarrows);
      this.panel__nud__n_vars.Controls.Add(this.nud__n_vars);
      this.panel__nud__n_vars.Location = new System.Drawing.Point(133, 210);
      this.panel__nud__n_vars.Name = "panel__nud__n_vars";
      this.panel__nud__n_vars.Size = new System.Drawing.Size(76, 35);
      this.panel__nud__n_vars.TabIndex = 73;
      // 
      // hidenudarrows
      // 
      this.hidenudarrows.BackColor = System.Drawing.Color.WhiteSmoke;
      this.hidenudarrows.Location = new System.Drawing.Point(39, 3);
      this.hidenudarrows.Name = "hidenudarrows";
      this.hidenudarrows.Size = new System.Drawing.Size(30, 30);
      this.hidenudarrows.TabIndex = 76;
      // 
      // nud__n_vars
      // 
      this.nud__n_vars.BackColor = System.Drawing.Color.White;
      this.nud__n_vars.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.nud__n_vars.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nud__n_vars.Location = new System.Drawing.Point(14, 6);
      this.nud__n_vars.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.nud__n_vars.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.nud__n_vars.Name = "nud__n_vars";
      this.nud__n_vars.Size = new System.Drawing.Size(49, 25);
      this.nud__n_vars.TabIndex = 0;
      this.nud__n_vars.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.nud__n_vars.ValueChanged += new System.EventHandler(this.nud__n_vars_ValueChanged);
      // 
      // lbl__nvars
      // 
      this.lbl__nvars.AutoSize = true;
      this.lbl__nvars.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl__nvars.Location = new System.Drawing.Point(24, 218);
      this.lbl__nvars.Name = "lbl__nvars";
      this.lbl__nvars.Size = new System.Drawing.Size(103, 17);
      this.lbl__nvars.TabIndex = 74;
      this.lbl__nvars.Text = "Number of vars";
      // 
      // btn__op_or
      // 
      this.btn__op_or.BackColor = System.Drawing.Color.Honeydew;
      this.btn__op_or.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn__op_or.FlatAppearance.BorderSize = 0;
      this.btn__op_or.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn__op_or.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn__op_or.ForeColor = System.Drawing.Color.Black;
      this.btn__op_or.Location = new System.Drawing.Point(169, 115);
      this.btn__op_or.Name = "btn__op_or";
      this.btn__op_or.Size = new System.Drawing.Size(40, 40);
      this.btn__op_or.TabIndex = 64;
      this.btn__op_or.Text = "+";
      this.btn__op_or.UseVisualStyleBackColor = false;
      this.btn__op_or.Click += new System.EventHandler(this.insertText);
      // 
      // btn__op_result
      // 
      this.btn__op_result.BackColor = System.Drawing.Color.AliceBlue;
      this.btn__op_result.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn__op_result.FlatAppearance.BorderSize = 0;
      this.btn__op_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn__op_result.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn__op_result.ForeColor = System.Drawing.Color.Black;
      this.btn__op_result.Location = new System.Drawing.Point(169, 163);
      this.btn__op_result.Name = "btn__op_result";
      this.btn__op_result.Size = new System.Drawing.Size(40, 40);
      this.btn__op_result.TabIndex = 65;
      this.btn__op_result.Text = "=";
      this.btn__op_result.UseVisualStyleBackColor = false;
      this.btn__op_result.Click += new System.EventHandler(this.btn__op_result_Click);
      // 
      // btn__op_and
      // 
      this.btn__op_and.BackColor = System.Drawing.Color.Honeydew;
      this.btn__op_and.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn__op_and.FlatAppearance.BorderSize = 0;
      this.btn__op_and.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn__op_and.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn__op_and.ForeColor = System.Drawing.Color.Black;
      this.btn__op_and.Location = new System.Drawing.Point(121, 115);
      this.btn__op_and.Name = "btn__op_and";
      this.btn__op_and.Size = new System.Drawing.Size(40, 40);
      this.btn__op_and.TabIndex = 63;
      this.btn__op_and.Text = ".";
      this.btn__op_and.UseVisualStyleBackColor = false;
      this.btn__op_and.Click += new System.EventHandler(this.insertText);
      // 
      // btn__op_not
      // 
      this.btn__op_not.BackColor = System.Drawing.Color.Honeydew;
      this.btn__op_not.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn__op_not.FlatAppearance.BorderSize = 0;
      this.btn__op_not.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn__op_not.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn__op_not.ForeColor = System.Drawing.Color.Black;
      this.btn__op_not.Location = new System.Drawing.Point(121, 163);
      this.btn__op_not.Name = "btn__op_not";
      this.btn__op_not.Size = new System.Drawing.Size(40, 40);
      this.btn__op_not.TabIndex = 67;
      this.btn__op_not.Text = "~";
      this.btn__op_not.UseVisualStyleBackColor = false;
      this.btn__op_not.Click += new System.EventHandler(this.insertText);
      // 
      // btn__op_clear
      // 
      this.btn__op_clear.BackColor = System.Drawing.Color.MistyRose;
      this.btn__op_clear.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn__op_clear.FlatAppearance.BorderSize = 0;
      this.btn__op_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn__op_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn__op_clear.ForeColor = System.Drawing.Color.Black;
      this.btn__op_clear.Location = new System.Drawing.Point(25, 69);
      this.btn__op_clear.Name = "btn__op_clear";
      this.btn__op_clear.Size = new System.Drawing.Size(88, 40);
      this.btn__op_clear.TabIndex = 66;
      this.btn__op_clear.Text = "AC";
      this.btn__op_clear.UseVisualStyleBackColor = false;
      this.btn__op_clear.Click += new System.EventHandler(this.btn__op_clear_Click);
      // 
      // btn__var_x
      // 
      this.btn__var_x.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn__var_x.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn__var_x.FlatAppearance.BorderSize = 0;
      this.btn__var_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn__var_x.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn__var_x.ForeColor = System.Drawing.Color.Black;
      this.btn__var_x.Location = new System.Drawing.Point(25, 115);
      this.btn__var_x.Name = "btn__var_x";
      this.btn__var_x.Size = new System.Drawing.Size(40, 40);
      this.btn__var_x.TabIndex = 57;
      this.btn__var_x.Text = "A";
      this.btn__var_x.UseVisualStyleBackColor = false;
      this.btn__var_x.Click += new System.EventHandler(this.insertText);
      // 
      // btn__var_y
      // 
      this.btn__var_y.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn__var_y.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn__var_y.FlatAppearance.BorderSize = 0;
      this.btn__var_y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn__var_y.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn__var_y.ForeColor = System.Drawing.Color.Black;
      this.btn__var_y.Location = new System.Drawing.Point(73, 115);
      this.btn__var_y.Name = "btn__var_y";
      this.btn__var_y.Size = new System.Drawing.Size(40, 40);
      this.btn__var_y.TabIndex = 58;
      this.btn__var_y.Text = "B";
      this.btn__var_y.UseVisualStyleBackColor = false;
      this.btn__var_y.Click += new System.EventHandler(this.insertText);
      // 
      // btn__second_parenth
      // 
      this.btn__second_parenth.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn__second_parenth.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn__second_parenth.FlatAppearance.BorderSize = 0;
      this.btn__second_parenth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn__second_parenth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn__second_parenth.ForeColor = System.Drawing.Color.Black;
      this.btn__second_parenth.Location = new System.Drawing.Point(169, 69);
      this.btn__second_parenth.Name = "btn__second_parenth";
      this.btn__second_parenth.Size = new System.Drawing.Size(40, 40);
      this.btn__second_parenth.TabIndex = 62;
      this.btn__second_parenth.Text = ")";
      this.btn__second_parenth.UseVisualStyleBackColor = false;
      this.btn__second_parenth.Click += new System.EventHandler(this.insertText);
      // 
      // btn__var_z
      // 
      this.btn__var_z.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn__var_z.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn__var_z.FlatAppearance.BorderSize = 0;
      this.btn__var_z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn__var_z.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn__var_z.ForeColor = System.Drawing.Color.Black;
      this.btn__var_z.Location = new System.Drawing.Point(25, 163);
      this.btn__var_z.Name = "btn__var_z";
      this.btn__var_z.Size = new System.Drawing.Size(40, 40);
      this.btn__var_z.TabIndex = 59;
      this.btn__var_z.Text = "C";
      this.btn__var_z.UseVisualStyleBackColor = false;
      this.btn__var_z.Click += new System.EventHandler(this.insertText);
      // 
      // btn__first_parenth
      // 
      this.btn__first_parenth.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn__first_parenth.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn__first_parenth.FlatAppearance.BorderSize = 0;
      this.btn__first_parenth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn__first_parenth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn__first_parenth.ForeColor = System.Drawing.Color.Black;
      this.btn__first_parenth.Location = new System.Drawing.Point(121, 69);
      this.btn__first_parenth.Name = "btn__first_parenth";
      this.btn__first_parenth.Size = new System.Drawing.Size(40, 40);
      this.btn__first_parenth.TabIndex = 61;
      this.btn__first_parenth.Text = "(";
      this.btn__first_parenth.UseVisualStyleBackColor = false;
      this.btn__first_parenth.Click += new System.EventHandler(this.insertText);
      // 
      // btn__var_w
      // 
      this.btn__var_w.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn__var_w.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn__var_w.FlatAppearance.BorderSize = 0;
      this.btn__var_w.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn__var_w.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn__var_w.ForeColor = System.Drawing.Color.Black;
      this.btn__var_w.Location = new System.Drawing.Point(73, 163);
      this.btn__var_w.Name = "btn__var_w";
      this.btn__var_w.Size = new System.Drawing.Size(40, 40);
      this.btn__var_w.TabIndex = 60;
      this.btn__var_w.Text = "D";
      this.btn__var_w.UseVisualStyleBackColor = false;
      this.btn__var_w.Click += new System.EventHandler(this.insertText);
      // 
      // panel__tbx__function
      // 
      this.panel__tbx__function.BackColor = System.Drawing.Color.WhiteSmoke;
      this.panel__tbx__function.Controls.Add(this.tbx__function);
      this.panel__tbx__function.Location = new System.Drawing.Point(25, 26);
      this.panel__tbx__function.Name = "panel__tbx__function";
      this.panel__tbx__function.Size = new System.Drawing.Size(184, 30);
      this.panel__tbx__function.TabIndex = 72;
      // 
      // tbx__function
      // 
      this.tbx__function.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbx__function.BackColor = System.Drawing.Color.WhiteSmoke;
      this.tbx__function.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbx__function.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbx__function.ForeColor = System.Drawing.Color.Black;
      this.tbx__function.Location = new System.Drawing.Point(11, 4);
      this.tbx__function.Name = "tbx__function";
      this.tbx__function.ShortcutsEnabled = false;
      this.tbx__function.Size = new System.Drawing.Size(164, 22);
      this.tbx__function.TabIndex = 50;
      this.tbx__function.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.tbx__function.Enter += new System.EventHandler(this.setLastCursorPos);
      this.tbx__function.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx__function_KeyPress);
      this.tbx__function.Leave += new System.EventHandler(this.setLastCursorPos);
      // 
      // panel__container_truthtable
      // 
      this.panel__container_truthtable.BackColor = System.Drawing.Color.Transparent;
      this.panel__container_truthtable.Location = new System.Drawing.Point(291, 0);
      this.panel__container_truthtable.Name = "panel__container_truthtable";
      this.panel__container_truthtable.Size = new System.Drawing.Size(166, 609);
      this.panel__container_truthtable.TabIndex = 1;
      // 
      // form__solver
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1200, 650);
      this.Controls.Add(this.panel__top);
      this.Controls.Add(this.panel__sidebar);
      this.Controls.Add(this.panel__equation);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "form__solver";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LES - Equation";
      this.Load += new System.EventHandler(this.form__solver_Load);
      this.panel__sidebar.ResumeLayout(false);
      this.panel__sidebar.PerformLayout();
      this.panel__top.ResumeLayout(false);
      this.panel__equation.ResumeLayout(false);
      this.panel__container_kmap.ResumeLayout(false);
      this.panel__simpl_expr.ResumeLayout(false);
      this.panel__simpl_expr.PerformLayout();
      this.panel__tbx__simpl__expr.ResumeLayout(false);
      this.panel__tbx__simpl__expr.PerformLayout();
      this.panel__container_calculator.ResumeLayout(false);
      this.panel__calculator.ResumeLayout(false);
      this.panel__calculator.PerformLayout();
      this.panel__nud__n_vars.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.nud__n_vars)).EndInit();
      this.panel__tbx__function.ResumeLayout(false);
      this.panel__tbx__function.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel__sidebar;
    private System.Windows.Forms.Label lbl__title;
    private System.Windows.Forms.Button lbl__exit;
    private System.Windows.Forms.Panel btn__top_min;
    private System.Windows.Forms.Panel btn__top_close;
    private System.Windows.Forms.Panel panel__top;
    private System.Windows.Forms.Panel panel__equation;
    private System.Windows.Forms.Panel panel__container_kmap;
    private System.Windows.Forms.Panel panel__container_truthtable;
    private System.Windows.Forms.Panel panel__container_calculator;
    private System.Windows.Forms.Panel panel__fill_table;
    private System.Windows.Forms.Button lbl__change_mode;
    private System.Windows.Forms.Panel panel__calculator;
    private System.Windows.Forms.Button btn__op_or;
    private System.Windows.Forms.Button btn__op_result;
    private System.Windows.Forms.Button btn__op_and;
    private System.Windows.Forms.Button btn__op_not;
    private System.Windows.Forms.Button btn__op_clear;
    private System.Windows.Forms.Button btn__var_x;
    private System.Windows.Forms.Button btn__var_y;
    private System.Windows.Forms.Button btn__second_parenth;
    private System.Windows.Forms.Button btn__var_z;
    private System.Windows.Forms.Button btn__first_parenth;
    private System.Windows.Forms.Button btn__var_w;
    private System.Windows.Forms.Panel panel__tbx__function;
    private System.Windows.Forms.TextBox tbx__function;
    private System.Windows.Forms.Panel panel__nud__n_vars;
    private System.Windows.Forms.NumericUpDown nud__n_vars;
    private System.Windows.Forms.Label lbl__nvars;
    private System.Windows.Forms.Panel hidenudarrows;
    private System.Windows.Forms.Panel panel__simpl_expr;
    private System.Windows.Forms.Label lbl__simpl_expr;
    private System.Windows.Forms.Panel panel__tbx__simpl__expr;
    private System.Windows.Forms.TextBox tbx__simpl_expr;
  }
}

