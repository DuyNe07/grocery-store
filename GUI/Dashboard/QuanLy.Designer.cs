namespace grocery_store.GUI.Dashboard
{
    partial class QuanLy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_search = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_result = new System.Windows.Forms.Panel();
            this.ptb_status = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.panel_employee_information = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bt_showpass = new System.Windows.Forms.Button();
            this.radiobt_end = new Guna.UI.WinForms.GunaRadioButton();
            this.tb_timeend = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.tb_timestart = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.cbb_shift = new System.Windows.Forms.ComboBox();
            this.cbb_role = new System.Windows.Forms.ComboBox();
            this.ptb_employee = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lb_header = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_list_employee = new System.Windows.Forms.Panel();
            this.dtgv_list_employees = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_update = new Guna.UI.WinForms.GunaButton();
            this.bt_delete = new Guna.UI.WinForms.GunaButton();
            this.bt_add = new Guna.UI.WinForms.GunaButton();
            this.bt_list = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.staging2 = new Guna.UI.WinForms.GunaProgressBar();
            this.staging1 = new Guna.UI.WinForms.GunaProgressBar();
            this.bt_stage3 = new Guna.UI.WinForms.GunaGradiantCircleButton();
            this.bt_stage1 = new Guna.UI.WinForms.GunaGradiantCircleButton();
            this.bt_stage2 = new Guna.UI.WinForms.GunaGradiantCircleButton();
            this.timer_animation = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_status)).BeginInit();
            this.panel_employee_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_employee)).BeginInit();
            this.panel_list_employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_list_employees)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.BaseColor = System.Drawing.Color.White;
            this.tb_search.BorderColor = System.Drawing.Color.Silver;
            this.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_search.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_search.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(27, 28);
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.Size = new System.Drawing.Size(273, 42);
            this.tb_search.TabIndex = 0;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel_result);
            this.panel1.Controls.Add(this.panel_employee_information);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel_list_employee);
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Controls.Add(this.bt_list);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(27, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1673, 903);
            this.panel1.TabIndex = 2;
            // 
            // panel_result
            // 
            this.panel_result.Controls.Add(this.ptb_status);
            this.panel_result.Location = new System.Drawing.Point(3400, 87);
            this.panel_result.Name = "panel_result";
            this.panel_result.Size = new System.Drawing.Size(1673, 721);
            this.panel_result.TabIndex = 5;
            // 
            // ptb_status
            // 
            this.ptb_status.BaseColor = System.Drawing.Color.White;
            this.ptb_status.Image = global::grocery_store.Properties.Resources.check_tv;
            this.ptb_status.Location = new System.Drawing.Point(712, 103);
            this.ptb_status.Name = "ptb_status";
            this.ptb_status.Size = new System.Drawing.Size(250, 250);
            this.ptb_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_status.TabIndex = 0;
            this.ptb_status.TabStop = false;
            this.ptb_status.UseTransfarantBackground = false;
            // 
            // panel_employee_information
            // 
            this.panel_employee_information.Controls.Add(this.panel5);
            this.panel_employee_information.Controls.Add(this.bt_showpass);
            this.panel_employee_information.Controls.Add(this.radiobt_end);
            this.panel_employee_information.Controls.Add(this.tb_timeend);
            this.panel_employee_information.Controls.Add(this.tb_timestart);
            this.panel_employee_information.Controls.Add(this.tb_salary);
            this.panel_employee_information.Controls.Add(this.cbb_shift);
            this.panel_employee_information.Controls.Add(this.cbb_role);
            this.panel_employee_information.Controls.Add(this.ptb_employee);
            this.panel_employee_information.Controls.Add(this.lb_header);
            this.panel_employee_information.Controls.Add(this.label5);
            this.panel_employee_information.Controls.Add(this.label7);
            this.panel_employee_information.Controls.Add(this.label6);
            this.panel_employee_information.Controls.Add(this.label9);
            this.panel_employee_information.Controls.Add(this.label8);
            this.panel_employee_information.Controls.Add(this.label4);
            this.panel_employee_information.Controls.Add(this.label11);
            this.panel_employee_information.Controls.Add(this.label3);
            this.panel_employee_information.Controls.Add(this.tb_password);
            this.panel_employee_information.Controls.Add(this.tb_lastname);
            this.panel_employee_information.Controls.Add(this.label10);
            this.panel_employee_information.Controls.Add(this.tb_account);
            this.panel_employee_information.Controls.Add(this.label2);
            this.panel_employee_information.Controls.Add(this.tb_firstname);
            this.panel_employee_information.Controls.Add(this.label1);
            this.panel_employee_information.Controls.Add(this.tb_id);
            this.panel_employee_information.Location = new System.Drawing.Point(1700, 87);
            this.panel_employee_information.Name = "panel_employee_information";
            this.panel_employee_information.Size = new System.Drawing.Size(1673, 721);
            this.panel_employee_information.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(14, 312);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1641, 3);
            this.panel5.TabIndex = 9;
            // 
            // bt_showpass
            // 
            this.bt_showpass.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_showpass.Location = new System.Drawing.Point(1512, 186);
            this.bt_showpass.Name = "bt_showpass";
            this.bt_showpass.Size = new System.Drawing.Size(52, 31);
            this.bt_showpass.TabIndex = 8;
            this.bt_showpass.Text = "Hiện";
            this.bt_showpass.UseVisualStyleBackColor = true;
            this.bt_showpass.Click += new System.EventHandler(this.bt_showpass_Click);
            // 
            // radiobt_end
            // 
            this.radiobt_end.BaseColor = System.Drawing.SystemColors.Control;
            this.radiobt_end.CheckedOffColor = System.Drawing.Color.Gray;
            this.radiobt_end.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.radiobt_end.FillColor = System.Drawing.Color.White;
            this.radiobt_end.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobt_end.Location = new System.Drawing.Point(1447, 463);
            this.radiobt_end.Name = "radiobt_end";
            this.radiobt_end.Size = new System.Drawing.Size(203, 28);
            this.radiobt_end.TabIndex = 8;
            this.radiobt_end.Text = "Có thời gian kết thúc";
            this.radiobt_end.CheckedChanged += new System.EventHandler(this.radiobt_end_CheckedChanged);
            this.radiobt_end.Click += new System.EventHandler(this.radiobt_end_Click);
            // 
            // tb_timeend
            // 
            this.tb_timeend.BackColor = System.Drawing.Color.Transparent;
            this.tb_timeend.BorderRadius = 1;
            this.tb_timeend.Color = System.Drawing.Color.Silver;
            this.tb_timeend.CustomFormat = "dd/MM/yyyy";
            this.tb_timeend.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.tb_timeend.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.tb_timeend.DisabledColor = System.Drawing.Color.Gray;
            this.tb_timeend.DisplayWeekNumbers = false;
            this.tb_timeend.DPHeight = 0;
            this.tb_timeend.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.tb_timeend.Enabled = false;
            this.tb_timeend.FillDatePicker = false;
            this.tb_timeend.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timeend.ForeColor = System.Drawing.Color.Black;
            this.tb_timeend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tb_timeend.Icon = ((System.Drawing.Image)(resources.GetObject("tb_timeend.Icon")));
            this.tb_timeend.IconColor = System.Drawing.Color.Gray;
            this.tb_timeend.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.tb_timeend.LeftTextMargin = 5;
            this.tb_timeend.Location = new System.Drawing.Point(1215, 458);
            this.tb_timeend.MinimumSize = new System.Drawing.Size(4, 32);
            this.tb_timeend.Name = "tb_timeend";
            this.tb_timeend.Size = new System.Drawing.Size(210, 37);
            this.tb_timeend.TabIndex = 7;
            this.tb_timeend.Tag = "x-x";
            this.tb_timeend.Value = new System.DateTime(2024, 5, 1, 12, 33, 0, 0);
            // 
            // tb_timestart
            // 
            this.tb_timestart.BackColor = System.Drawing.Color.Transparent;
            this.tb_timestart.BorderRadius = 1;
            this.tb_timestart.Color = System.Drawing.Color.Silver;
            this.tb_timestart.CustomFormat = "dd/MM/yyyy";
            this.tb_timestart.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.tb_timestart.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.tb_timestart.DisabledColor = System.Drawing.Color.Gray;
            this.tb_timestart.DisplayWeekNumbers = false;
            this.tb_timestart.DPHeight = 0;
            this.tb_timestart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.tb_timestart.FillDatePicker = false;
            this.tb_timestart.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timestart.ForeColor = System.Drawing.Color.Black;
            this.tb_timestart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tb_timestart.Icon = ((System.Drawing.Image)(resources.GetObject("tb_timestart.Icon")));
            this.tb_timestart.IconColor = System.Drawing.Color.Gray;
            this.tb_timestart.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.tb_timestart.LeftTextMargin = 5;
            this.tb_timestart.Location = new System.Drawing.Point(383, 458);
            this.tb_timestart.MinimumSize = new System.Drawing.Size(4, 32);
            this.tb_timestart.Name = "tb_timestart";
            this.tb_timestart.Size = new System.Drawing.Size(210, 37);
            this.tb_timestart.TabIndex = 6;
            this.tb_timestart.Tag = "x-x";
            this.tb_timestart.Value = new System.DateTime(2024, 5, 1, 12, 33, 0, 0);
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(789, 551);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(210, 37);
            this.tb_salary.TabIndex = 9;
            this.tb_salary.Tag = "money-Lương cơ bản";
            this.tb_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_salary_KeyPress);
            // 
            // cbb_shift
            // 
            this.cbb_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_shift.FormattingEnabled = true;
            this.cbb_shift.Items.AddRange(new object[] {
            "Morning Shift",
            "Afternoon Shift",
            "Night Shift",
            "FullTime"});
            this.cbb_shift.Location = new System.Drawing.Point(1215, 348);
            this.cbb_shift.Name = "cbb_shift";
            this.cbb_shift.Size = new System.Drawing.Size(210, 38);
            this.cbb_shift.TabIndex = 5;
            this.cbb_shift.Tag = "o-Ca làm";
            // 
            // cbb_role
            // 
            this.cbb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_role.FormattingEnabled = true;
            this.cbb_role.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.cbb_role.Location = new System.Drawing.Point(383, 348);
            this.cbb_role.Name = "cbb_role";
            this.cbb_role.Size = new System.Drawing.Size(210, 38);
            this.cbb_role.TabIndex = 4;
            this.cbb_role.Tag = "o-Chức vụ";
            // 
            // ptb_employee
            // 
            this.ptb_employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_employee.BaseColor = System.Drawing.Color.White;
            this.ptb_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_employee.Image = global::grocery_store.Properties.Resources.user_img;
            this.ptb_employee.Location = new System.Drawing.Point(39, 76);
            this.ptb_employee.Name = "ptb_employee";
            this.ptb_employee.Size = new System.Drawing.Size(200, 200);
            this.ptb_employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_employee.TabIndex = 3;
            this.ptb_employee.TabStop = false;
            this.ptb_employee.UseTransfarantBackground = false;
            this.ptb_employee.Click += new System.EventHandler(this.ptb_employee_Click);
            // 
            // lb_header
            // 
            this.lb_header.AutoSize = true;
            this.lb_header.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_header.Location = new System.Drawing.Point(679, 12);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(299, 50);
            this.lb_header.TabIndex = 2;
            this.lb_header.Text = "Thêm nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1067, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ca làm: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1014, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(576, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lương cơ bản:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1001, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 30);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ngày kết thúc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(177, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngày bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chức vụ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1037, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 30);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mật khẩu: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(1202, 180);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(304, 37);
            this.tb_password.TabIndex = 3;
            this.tb_password.Tag = "log-Mật khẩu";
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(367, 224);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(304, 37);
            this.tb_lastname.TabIndex = 1;
            this.tb_lastname.Tag = "o-Tên nhân viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1036, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tài khoản: ";
            // 
            // tb_account
            // 
            this.tb_account.Location = new System.Drawing.Point(1202, 108);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(304, 37);
            this.tb_account.TabIndex = 2;
            this.tb_account.Tag = "log-Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ:";
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(367, 152);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(304, 37);
            this.tb_firstname.TabIndex = 0;
            this.tb_firstname.Tag = "o-Họ nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(367, 88);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(100, 37);
            this.tb_id.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(1075, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 49);
            this.panel3.TabIndex = 3;
            // 
            // panel_list_employee
            // 
            this.panel_list_employee.Controls.Add(this.dtgv_list_employees);
            this.panel_list_employee.Location = new System.Drawing.Point(0, 87);
            this.panel_list_employee.Name = "panel_list_employee";
            this.panel_list_employee.Size = new System.Drawing.Size(1673, 721);
            this.panel_list_employee.TabIndex = 2;
            // 
            // dtgv_list_employees
            // 
            this.dtgv_list_employees.AllowCustomTheming = false;
            this.dtgv_list_employees.AllowUserToAddRows = false;
            this.dtgv_list_employees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dtgv_list_employees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgv_list_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_list_employees.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgv_list_employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_list_employees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_list_employees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_list_employees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgv_list_employees.ColumnHeadersHeight = 40;
            this.dtgv_list_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Role,
            this.Shift,
            this.Salary,
            this.TimeStart,
            this.TimeEnd});
            this.dtgv_list_employees.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgv_list_employees.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgv_list_employees.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_list_employees.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgv_list_employees.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv_list_employees.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgv_list_employees.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgv_list_employees.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgv_list_employees.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgv_list_employees.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_list_employees.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgv_list_employees.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_list_employees.CurrentTheme.Name = null;
            this.dtgv_list_employees.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_list_employees.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgv_list_employees.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_list_employees.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgv_list_employees.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_list_employees.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgv_list_employees.EnableHeadersVisualStyles = false;
            this.dtgv_list_employees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgv_list_employees.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgv_list_employees.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgv_list_employees.HeaderForeColor = System.Drawing.Color.White;
            this.dtgv_list_employees.Location = new System.Drawing.Point(39, 0);
            this.dtgv_list_employees.Name = "dtgv_list_employees";
            this.dtgv_list_employees.ReadOnly = true;
            this.dtgv_list_employees.RowHeadersVisible = false;
            this.dtgv_list_employees.RowHeadersWidth = 51;
            this.dtgv_list_employees.RowTemplate.Height = 40;
            this.dtgv_list_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_list_employees.Size = new System.Drawing.Size(1589, 707);
            this.dtgv_list_employees.TabIndex = 0;
            this.dtgv_list_employees.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtgv_list_employees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_list_employees_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 59;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Họ";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 66;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Tên";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Vai trò";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 98;
            // 
            // Shift
            // 
            this.Shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Shift.DataPropertyName = "Shift";
            this.Shift.HeaderText = "Ca làm";
            this.Shift.MinimumWidth = 6;
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Lương cơ bản";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // TimeStart
            // 
            this.TimeStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TimeStart.DataPropertyName = "TimeStart";
            this.TimeStart.HeaderText = "Ngày bắt đầu";
            this.TimeStart.MinimumWidth = 6;
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.ReadOnly = true;
            this.TimeStart.Width = 161;
            // 
            // TimeEnd
            // 
            this.TimeEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TimeEnd.DataPropertyName = "TimeEnd";
            this.TimeEnd.HeaderText = "Ngày kết thúc";
            this.TimeEnd.MinimumWidth = 6;
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.ReadOnly = true;
            this.TimeEnd.Width = 167;
            // 
            // bt_update
            // 
            this.bt_update.AnimationHoverSpeed = 0.07F;
            this.bt_update.AnimationSpeed = 0.03F;
            this.bt_update.BaseColor = System.Drawing.Color.LightGreen;
            this.bt_update.BorderColor = System.Drawing.Color.Black;
            this.bt_update.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.Color.White;
            this.bt_update.Image = global::grocery_store.Properties.Resources.problem_solving;
            this.bt_update.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_update.Location = new System.Drawing.Point(1495, 3);
            this.bt_update.Name = "bt_update";
            this.bt_update.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.bt_update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_update.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_update.OnHoverImage = null;
            this.bt_update.OnPressedColor = System.Drawing.Color.Black;
            this.bt_update.Radius = 12;
            this.bt_update.Size = new System.Drawing.Size(168, 49);
            this.bt_update.TabIndex = 1;
            this.bt_update.Text = "Sửa";
            this.bt_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.AnimationHoverSpeed = 0.07F;
            this.bt_delete.AnimationSpeed = 0.03F;
            this.bt_delete.BaseColor = System.Drawing.Color.MediumPurple;
            this.bt_delete.BorderColor = System.Drawing.Color.Black;
            this.bt_delete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.Color.White;
            this.bt_delete.Image = global::grocery_store.Properties.Resources.delete_tv;
            this.bt_delete.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_delete.Location = new System.Drawing.Point(1307, 3);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.OnHoverBaseColor = System.Drawing.Color.MediumOrchid;
            this.bt_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_delete.OnHoverImage = null;
            this.bt_delete.OnPressedColor = System.Drawing.Color.Black;
            this.bt_delete.Radius = 12;
            this.bt_delete.Size = new System.Drawing.Size(168, 49);
            this.bt_delete.TabIndex = 1;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_add
            // 
            this.bt_add.AnimationHoverSpeed = 0.07F;
            this.bt_add.AnimationSpeed = 0.03F;
            this.bt_add.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.bt_add.BorderColor = System.Drawing.Color.Black;
            this.bt_add.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.White;
            this.bt_add.Image = global::grocery_store.Properties.Resources.new_employee;
            this.bt_add.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_add.Location = new System.Drawing.Point(1100, 3);
            this.bt_add.Name = "bt_add";
            this.bt_add.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_add.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_add.OnHoverImage = null;
            this.bt_add.OnPressedColor = System.Drawing.Color.Black;
            this.bt_add.Radius = 12;
            this.bt_add.Size = new System.Drawing.Size(188, 49);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Thêm";
            this.bt_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_list
            // 
            this.bt_list.AnimationHoverSpeed = 0.07F;
            this.bt_list.AnimationSpeed = 0.03F;
            this.bt_list.BaseColor = System.Drawing.Color.DarkSalmon;
            this.bt_list.BorderColor = System.Drawing.Color.Black;
            this.bt_list.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_list.ForeColor = System.Drawing.Color.White;
            this.bt_list.Image = global::grocery_store.Properties.Resources.recruitment;
            this.bt_list.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_list.Location = new System.Drawing.Point(810, 3);
            this.bt_list.Name = "bt_list";
            this.bt_list.OnHoverBaseColor = System.Drawing.Color.Coral;
            this.bt_list.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_list.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_list.OnHoverImage = null;
            this.bt_list.OnPressedColor = System.Drawing.Color.Black;
            this.bt_list.Radius = 12;
            this.bt_list.Size = new System.Drawing.Size(244, 49);
            this.bt_list.TabIndex = 1;
            this.bt_list.Text = "Danh sách";
            this.bt_list.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_list.Click += new System.EventHandler(this.bt_list_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.staging2);
            this.panel2.Controls.Add(this.staging1);
            this.panel2.Controls.Add(this.bt_stage3);
            this.panel2.Controls.Add(this.bt_stage1);
            this.panel2.Controls.Add(this.bt_stage2);
            this.panel2.Location = new System.Drawing.Point(618, 814);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 70);
            this.panel2.TabIndex = 0;
            // 
            // staging2
            // 
            this.staging2.BorderColor = System.Drawing.Color.Black;
            this.staging2.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.staging2.IdleColor = System.Drawing.Color.Gainsboro;
            this.staging2.Location = new System.Drawing.Point(253, 29);
            this.staging2.Name = "staging2";
            this.staging2.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.staging2.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.staging2.Radius = 5;
            this.staging2.Size = new System.Drawing.Size(113, 15);
            this.staging2.TabIndex = 1;
            this.staging2.Visible = false;
            // 
            // staging1
            // 
            this.staging1.BorderColor = System.Drawing.Color.Black;
            this.staging1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.staging1.IdleColor = System.Drawing.Color.Gainsboro;
            this.staging1.Location = new System.Drawing.Point(70, 29);
            this.staging1.Name = "staging1";
            this.staging1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.staging1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.staging1.Radius = 5;
            this.staging1.Size = new System.Drawing.Size(113, 15);
            this.staging1.TabIndex = 1;
            this.staging1.Visible = false;
            // 
            // bt_stage3
            // 
            this.bt_stage3.AnimationHoverSpeed = 0.07F;
            this.bt_stage3.AnimationSpeed = 0.03F;
            this.bt_stage3.BaseColor1 = System.Drawing.Color.LightGray;
            this.bt_stage3.BaseColor2 = System.Drawing.Color.Gray;
            this.bt_stage3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_stage3.ForeColor = System.Drawing.Color.White;
            this.bt_stage3.Image = null;
            this.bt_stage3.ImageSize = new System.Drawing.Size(52, 52);
            this.bt_stage3.Location = new System.Drawing.Point(386, 20);
            this.bt_stage3.Name = "bt_stage3";
            this.bt_stage3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_stage3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_stage3.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_stage3.OnHoverImage = null;
            this.bt_stage3.OnPressedColor = System.Drawing.Color.Black;
            this.bt_stage3.Size = new System.Drawing.Size(30, 30);
            this.bt_stage3.TabIndex = 1;
            // 
            // bt_stage1
            // 
            this.bt_stage1.AnimationHoverSpeed = 0.07F;
            this.bt_stage1.AnimationSpeed = 0.03F;
            this.bt_stage1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.bt_stage1.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.bt_stage1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_stage1.ForeColor = System.Drawing.Color.White;
            this.bt_stage1.Image = null;
            this.bt_stage1.ImageSize = new System.Drawing.Size(52, 52);
            this.bt_stage1.Location = new System.Drawing.Point(20, 20);
            this.bt_stage1.Name = "bt_stage1";
            this.bt_stage1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_stage1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_stage1.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_stage1.OnHoverImage = null;
            this.bt_stage1.OnPressedColor = System.Drawing.Color.Black;
            this.bt_stage1.Size = new System.Drawing.Size(30, 30);
            this.bt_stage1.TabIndex = 1;
            // 
            // bt_stage2
            // 
            this.bt_stage2.AnimationHoverSpeed = 0.07F;
            this.bt_stage2.AnimationSpeed = 0.03F;
            this.bt_stage2.BaseColor1 = System.Drawing.Color.LightGray;
            this.bt_stage2.BaseColor2 = System.Drawing.Color.Gray;
            this.bt_stage2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_stage2.ForeColor = System.Drawing.Color.White;
            this.bt_stage2.Image = null;
            this.bt_stage2.ImageSize = new System.Drawing.Size(52, 52);
            this.bt_stage2.Location = new System.Drawing.Point(203, 20);
            this.bt_stage2.Name = "bt_stage2";
            this.bt_stage2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_stage2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_stage2.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_stage2.OnHoverImage = null;
            this.bt_stage2.OnPressedColor = System.Drawing.Color.Black;
            this.bt_stage2.Size = new System.Drawing.Size(30, 30);
            this.bt_stage2.TabIndex = 1;
            // 
            // timer_animation
            // 
            this.timer_animation.Interval = 5;
            this.timer_animation.Tick += new System.EventHandler(this.timer_animation_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::grocery_store.Properties.Resources.Search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(314, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_search);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "QuanLy";
            this.Size = new System.Drawing.Size(1720, 1050);
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.panel1.ResumeLayout(false);
            this.panel_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_status)).EndInit();
            this.panel_employee_information.ResumeLayout(false);
            this.panel_employee_information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_employee)).EndInit();
            this.panel_list_employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_list_employees)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox tb_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGradiantCircleButton bt_stage2;
        private Guna.UI.WinForms.GunaButton bt_list;
        private Guna.UI.WinForms.GunaProgressBar staging1;
        private Guna.UI.WinForms.GunaGradiantCircleButton bt_stage1;
        private Guna.UI.WinForms.GunaButton bt_add;
        private Guna.UI.WinForms.GunaProgressBar staging2;
        private Guna.UI.WinForms.GunaGradiantCircleButton bt_stage3;
        private Guna.UI.WinForms.GunaButton bt_update;
        private Guna.UI.WinForms.GunaButton bt_delete;
        private System.Windows.Forms.Panel panel_list_employee;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgv_list_employees;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeEnd;
        private System.Windows.Forms.Timer timer_animation;
        private System.Windows.Forms.Panel panel_employee_information;
        private System.Windows.Forms.Label lb_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.ComboBox cbb_role;
        private Guna.UI.WinForms.GunaCirclePictureBox ptb_employee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.ComboBox cbb_shift;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuDatePicker tb_timestart;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaRadioButton radiobt_end;
        private Bunifu.UI.WinForms.BunifuDatePicker tb_timeend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bt_showpass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.Panel panel_result;
        private Guna.UI.WinForms.GunaCirclePictureBox ptb_status;
    }
}
