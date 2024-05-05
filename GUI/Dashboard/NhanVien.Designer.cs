using System.Drawing;
using System.Windows.Forms;

namespace grocery_store.GUI.Dashboard
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.tb_role = new System.Windows.Forms.TextBox();
            this.tb_timeonline = new System.Windows.Forms.TextBox();
            this.tb_jobname = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_save = new System.Windows.Forms.Panel();
            this.lb_save = new System.Windows.Forms.Label();
            this.ptb_emp = new System.Windows.Forms.PictureBox();
            this.elipse_bt_save = new Guna.UI.WinForms.GunaElipse(this.components);
            this.elipse_ptb_emp = new Guna.UI.WinForms.GunaElipse(this.components);
            this.timer_online = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_user_inshift = new System.Windows.Forms.Panel();
            this.lb_number = new System.Windows.Forms.Label();
            this.lb_timeend = new System.Windows.Forms.Label();
            this.lb_timestart = new System.Windows.Forms.Label();
            this.panel_shift = new System.Windows.Forms.Panel();
            this.panel_inshift = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.panel_rootendshift = new System.Windows.Forms.Panel();
            this.panel_endshift = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.panel_rootready = new System.Windows.Forms.Panel();
            this.panel_ready = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bt_timekeeping = new System.Windows.Forms.Panel();
            this.lb_timekeeping = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.elipse_bt_timekeeping = new Guna.UI.WinForms.GunaElipse(this.components);
            this.timer_timekeeping = new System.Windows.Forms.Timer(this.components);
            this.panel_history = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tb_checksalary = new System.Windows.Forms.TextBox();
            this.tb_evaluate = new System.Windows.Forms.TextBox();
            this.tb_delaytime = new System.Windows.Forms.TextBox();
            this.tb_worktime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cbb_year = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_month = new System.Windows.Forms.ComboBox();
            this.dtgv_history = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkoutt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bt_save.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_emp)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_user_inshift.SuspendLayout();
            this.panel_shift.SuspendLayout();
            this.panel_rootendshift.SuspendLayout();
            this.panel_rootready.SuspendLayout();
            this.bt_timekeeping.SuspendLayout();
            this.panel_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_history)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_firstname);
            this.panel1.Controls.Add(this.tb_role);
            this.panel1.Controls.Add(this.tb_timeonline);
            this.panel1.Controls.Add(this.tb_jobname);
            this.panel1.Controls.Add(this.tb_lastname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(24, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1675, 260);
            this.panel1.TabIndex = 1;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(795, 68);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.ReadOnly = true;
            this.tb_firstname.Size = new System.Drawing.Size(279, 38);
            this.tb_firstname.TabIndex = 1;
            // 
            // tb_role
            // 
            this.tb_role.Location = new System.Drawing.Point(1302, 70);
            this.tb_role.Name = "tb_role";
            this.tb_role.ReadOnly = true;
            this.tb_role.Size = new System.Drawing.Size(279, 38);
            this.tb_role.TabIndex = 2;
            // 
            // tb_timeonline
            // 
            this.tb_timeonline.Location = new System.Drawing.Point(529, 201);
            this.tb_timeonline.Name = "tb_timeonline";
            this.tb_timeonline.ReadOnly = true;
            this.tb_timeonline.Size = new System.Drawing.Size(109, 38);
            this.tb_timeonline.TabIndex = 4;
            this.tb_timeonline.Text = "00:00:00";
            this.tb_timeonline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_jobname
            // 
            this.tb_jobname.Location = new System.Drawing.Point(401, 137);
            this.tb_jobname.Name = "tb_jobname";
            this.tb_jobname.ReadOnly = true;
            this.tb_jobname.Size = new System.Drawing.Size(1180, 38);
            this.tb_jobname.TabIndex = 3;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(401, 68);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.ReadOnly = true;
            this.tb_lastname.Size = new System.Drawing.Size(261, 38);
            this.tb_lastname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(726, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1151, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chức vụ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thời gian online:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 38);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ca làm: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bt_save);
            this.panel2.Controls.Add(this.ptb_emp);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 259);
            this.panel2.TabIndex = 0;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(225)))), ((int)(((byte)(163)))));
            this.bt_save.Controls.Add(this.lb_save);
            this.bt_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_save.Location = new System.Drawing.Point(39, 197);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(170, 45);
            this.bt_save.TabIndex = 2;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // lb_save
            // 
            this.lb_save.AutoSize = true;
            this.lb_save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_save.Location = new System.Drawing.Point(36, 7);
            this.lb_save.Name = "lb_save";
            this.lb_save.Size = new System.Drawing.Size(98, 31);
            this.lb_save.TabIndex = 0;
            this.lb_save.Text = "Đổi ảnh";
            this.lb_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // ptb_emp
            // 
            this.ptb_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_emp.Location = new System.Drawing.Point(39, 12);
            this.ptb_emp.Name = "ptb_emp";
            this.ptb_emp.Size = new System.Drawing.Size(170, 170);
            this.ptb_emp.TabIndex = 0;
            this.ptb_emp.TabStop = false;
            // 
            // elipse_bt_save
            // 
            this.elipse_bt_save.Radius = 20;
            this.elipse_bt_save.TargetControl = this.bt_save;
            // 
            // elipse_ptb_emp
            // 
            this.elipse_ptb_emp.Radius = 30;
            this.elipse_ptb_emp.TargetControl = this.ptb_emp;
            // 
            // timer_online
            // 
            this.timer_online.Interval = 1000;
            this.timer_online.Tick += new System.EventHandler(this.timer_online_Tick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel_user_inshift);
            this.panel3.Controls.Add(this.lb_timeend);
            this.panel3.Controls.Add(this.lb_timestart);
            this.panel3.Controls.Add(this.panel_shift);
            this.panel3.Controls.Add(this.panel_rootendshift);
            this.panel3.Controls.Add(this.panel_rootready);
            this.panel3.Controls.Add(this.bt_timekeeping);
            this.panel3.Controls.Add(this.lb_status);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.panel3.Location = new System.Drawing.Point(24, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1675, 259);
            this.panel3.TabIndex = 2;
            // 
            // panel_user_inshift
            // 
            this.panel_user_inshift.Controls.Add(this.lb_number);
            this.panel_user_inshift.Location = new System.Drawing.Point(222, 207);
            this.panel_user_inshift.Name = "panel_user_inshift";
            this.panel_user_inshift.Size = new System.Drawing.Size(1428, 40);
            this.panel_user_inshift.TabIndex = 8;
            // 
            // lb_number
            // 
            this.lb_number.AutoSize = true;
            this.lb_number.Location = new System.Drawing.Point(1370, 5);
            this.lb_number.Name = "lb_number";
            this.lb_number.Size = new System.Drawing.Size(54, 31);
            this.lb_number.TabIndex = 0;
            this.lb_number.Text = "+10";
            this.lb_number.Visible = false;
            // 
            // lb_timeend
            // 
            this.lb_timeend.AutoSize = true;
            this.lb_timeend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timeend.Location = new System.Drawing.Point(1418, 107);
            this.lb_timeend.Name = "lb_timeend";
            this.lb_timeend.Size = new System.Drawing.Size(65, 28);
            this.lb_timeend.TabIndex = 7;
            this.lb_timeend.Text = "22:00";
            // 
            // lb_timestart
            // 
            this.lb_timestart.AutoSize = true;
            this.lb_timestart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timestart.Location = new System.Drawing.Point(192, 107);
            this.lb_timestart.Name = "lb_timestart";
            this.lb_timestart.Size = new System.Drawing.Size(65, 28);
            this.lb_timestart.TabIndex = 7;
            this.lb_timestart.Text = "07:00";
            // 
            // panel_shift
            // 
            this.panel_shift.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_shift.Controls.Add(this.panel_inshift);
            this.panel_shift.Location = new System.Drawing.Point(224, 138);
            this.panel_shift.Name = "panel_shift";
            this.panel_shift.Size = new System.Drawing.Size(1225, 50);
            this.panel_shift.TabIndex = 6;
            // 
            // panel_inshift
            // 
            this.panel_inshift.BackColor = System.Drawing.Color.Transparent;
            this.panel_inshift.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_inshift.BackgroundImage")));
            this.panel_inshift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_inshift.BorderRadius = 1;
            this.panel_inshift.GradientBottomLeft = System.Drawing.Color.Yellow;
            this.panel_inshift.GradientBottomRight = System.Drawing.Color.Yellow;
            this.panel_inshift.GradientTopLeft = System.Drawing.Color.LemonChiffon;
            this.panel_inshift.GradientTopRight = System.Drawing.Color.OldLace;
            this.panel_inshift.Location = new System.Drawing.Point(0, 0);
            this.panel_inshift.Name = "panel_inshift";
            this.panel_inshift.Quality = 10;
            this.panel_inshift.Size = new System.Drawing.Size(0, 50);
            this.panel_inshift.TabIndex = 0;
            // 
            // panel_rootendshift
            // 
            this.panel_rootendshift.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_rootendshift.Controls.Add(this.panel_endshift);
            this.panel_rootendshift.Location = new System.Drawing.Point(1449, 138);
            this.panel_rootendshift.Name = "panel_rootendshift";
            this.panel_rootendshift.Size = new System.Drawing.Size(200, 50);
            this.panel_rootendshift.TabIndex = 6;
            // 
            // panel_endshift
            // 
            this.panel_endshift.BackColor = System.Drawing.Color.Transparent;
            this.panel_endshift.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_endshift.BackgroundImage")));
            this.panel_endshift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_endshift.BorderRadius = 1;
            this.panel_endshift.GradientBottomLeft = System.Drawing.Color.Orange;
            this.panel_endshift.GradientBottomRight = System.Drawing.Color.Orange;
            this.panel_endshift.GradientTopLeft = System.Drawing.Color.NavajoWhite;
            this.panel_endshift.GradientTopRight = System.Drawing.Color.AntiqueWhite;
            this.panel_endshift.Location = new System.Drawing.Point(0, 0);
            this.panel_endshift.Name = "panel_endshift";
            this.panel_endshift.Quality = 10;
            this.panel_endshift.Size = new System.Drawing.Size(0, 50);
            this.panel_endshift.TabIndex = 0;
            // 
            // panel_rootready
            // 
            this.panel_rootready.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_rootready.Controls.Add(this.panel_ready);
            this.panel_rootready.Location = new System.Drawing.Point(25, 138);
            this.panel_rootready.Name = "panel_rootready";
            this.panel_rootready.Size = new System.Drawing.Size(200, 50);
            this.panel_rootready.TabIndex = 6;
            // 
            // panel_ready
            // 
            this.panel_ready.BackColor = System.Drawing.Color.Transparent;
            this.panel_ready.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_ready.BackgroundImage")));
            this.panel_ready.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_ready.BorderRadius = 1;
            this.panel_ready.GradientBottomLeft = System.Drawing.Color.SeaGreen;
            this.panel_ready.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.panel_ready.GradientTopLeft = System.Drawing.Color.PaleGreen;
            this.panel_ready.GradientTopRight = System.Drawing.Color.PaleGreen;
            this.panel_ready.Location = new System.Drawing.Point(0, 0);
            this.panel_ready.Name = "panel_ready";
            this.panel_ready.Quality = 10;
            this.panel_ready.Size = new System.Drawing.Size(0, 50);
            this.panel_ready.TabIndex = 0;
            // 
            // bt_timekeeping
            // 
            this.bt_timekeeping.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bt_timekeeping.Controls.Add(this.lb_timekeeping);
            this.bt_timekeeping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_timekeeping.Location = new System.Drawing.Point(1358, 13);
            this.bt_timekeeping.Name = "bt_timekeeping";
            this.bt_timekeeping.Size = new System.Drawing.Size(292, 45);
            this.bt_timekeeping.TabIndex = 5;
            this.bt_timekeeping.Click += new System.EventHandler(this.bt_timekeeping_Click);
            // 
            // lb_timekeeping
            // 
            this.lb_timekeeping.AutoSize = true;
            this.lb_timekeeping.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timekeeping.Location = new System.Drawing.Point(27, 7);
            this.lb_timekeeping.Name = "lb_timekeeping";
            this.lb_timekeeping.Size = new System.Drawing.Size(226, 31);
            this.lb_timekeeping.TabIndex = 0;
            this.lb_timekeeping.Text = " Bắt đầu chấm công";
            this.lb_timekeeping.Click += new System.EventHandler(this.bt_timekeeping_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.LimeGreen;
            this.lb_status.Location = new System.Drawing.Point(142, 72);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(162, 28);
            this.lb_status.TabIndex = 4;
            this.lb_status.Text = "Chuẩn bị vào ca";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 28);
            this.label11.TabIndex = 4;
            this.label11.Text = "Nhân viên cùng ca: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tình trạng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(475, 50);
            this.label7.TabIndex = 4;
            this.label7.Text = "Thông tin ca làm hôm nay";
            // 
            // elipse_bt_timekeeping
            // 
            this.elipse_bt_timekeeping.Radius = 20;
            this.elipse_bt_timekeeping.TargetControl = this.bt_timekeeping;
            // 
            // timer_timekeeping
            // 
            this.timer_timekeeping.Interval = 1000;
            this.timer_timekeeping.Tick += new System.EventHandler(this.timer_timekeeping_Tick);
            // 
            // panel_history
            // 
            this.panel_history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_history.Controls.Add(this.textBox5);
            this.panel_history.Controls.Add(this.tb_checksalary);
            this.panel_history.Controls.Add(this.tb_evaluate);
            this.panel_history.Controls.Add(this.tb_delaytime);
            this.panel_history.Controls.Add(this.tb_worktime);
            this.panel_history.Controls.Add(this.label18);
            this.panel_history.Controls.Add(this.label17);
            this.panel_history.Controls.Add(this.label16);
            this.panel_history.Controls.Add(this.label15);
            this.panel_history.Controls.Add(this.label14);
            this.panel_history.Controls.Add(this.panel4);
            this.panel_history.Controls.Add(this.label12);
            this.panel_history.Controls.Add(this.cbb_year);
            this.panel_history.Controls.Add(this.label10);
            this.panel_history.Controls.Add(this.cbb_month);
            this.panel_history.Controls.Add(this.dtgv_history);
            this.panel_history.Controls.Add(this.label13);
            this.panel_history.Controls.Add(this.label9);
            this.panel_history.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_history.Location = new System.Drawing.Point(25, 585);
            this.panel_history.Name = "panel_history";
            this.panel_history.Size = new System.Drawing.Size(1674, 383);
            this.panel_history.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1523, 302);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(142, 38);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Không";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_checksalary
            // 
            this.tb_checksalary.Location = new System.Drawing.Point(1523, 245);
            this.tb_checksalary.Name = "tb_checksalary";
            this.tb_checksalary.ReadOnly = true;
            this.tb_checksalary.Size = new System.Drawing.Size(142, 38);
            this.tb_checksalary.TabIndex = 11;
            this.tb_checksalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_evaluate
            // 
            this.tb_evaluate.Location = new System.Drawing.Point(1523, 185);
            this.tb_evaluate.Name = "tb_evaluate";
            this.tb_evaluate.ReadOnly = true;
            this.tb_evaluate.Size = new System.Drawing.Size(142, 38);
            this.tb_evaluate.TabIndex = 11;
            this.tb_evaluate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_delaytime
            // 
            this.tb_delaytime.Location = new System.Drawing.Point(1520, 127);
            this.tb_delaytime.Name = "tb_delaytime";
            this.tb_delaytime.ReadOnly = true;
            this.tb_delaytime.Size = new System.Drawing.Size(142, 38);
            this.tb_delaytime.TabIndex = 11;
            this.tb_delaytime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_worktime
            // 
            this.tb_worktime.Location = new System.Drawing.Point(1520, 70);
            this.tb_worktime.Name = "tb_worktime";
            this.tb_worktime.ReadOnly = true;
            this.tb_worktime.Size = new System.Drawing.Size(142, 38);
            this.tb_worktime.TabIndex = 11;
            this.tb_worktime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1154, 305);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(343, 31);
            this.label18.TabIndex = 10;
            this.label18.Text = "Lương thực tế (Liên hệ quản lý): ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1154, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 31);
            this.label17.TabIndex = 10;
            this.label17.Text = "Lương dự kiến:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1154, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 31);
            this.label16.TabIndex = 10;
            this.label16.Text = "Đánh giá:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1151, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(271, 31);
            this.label15.TabIndex = 10;
            this.label15.Text = "Tổng thời gian trễ (phút):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1151, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(267, 31);
            this.label14.TabIndex = 10;
            this.label14.Text = "Tổng thời gian làm (giờ):";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(1141, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 358);
            this.panel4.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(918, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 31);
            this.label12.TabIndex = 8;
            this.label12.Text = "Năm: ";
            // 
            // cbb_year
            // 
            this.cbb_year.FormattingEnabled = true;
            this.cbb_year.Location = new System.Drawing.Point(1004, 28);
            this.cbb_year.Name = "cbb_year";
            this.cbb_year.Size = new System.Drawing.Size(108, 39);
            this.cbb_year.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(723, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 31);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tháng: ";
            // 
            // cbb_month
            // 
            this.cbb_month.FormattingEnabled = true;
            this.cbb_month.Location = new System.Drawing.Point(824, 28);
            this.cbb_month.Name = "cbb_month";
            this.cbb_month.Size = new System.Drawing.Size(74, 39);
            this.cbb_month.TabIndex = 7;
            this.cbb_month.SelectedValueChanged += new System.EventHandler(this.cbb_month_SelectedValueChanged);
            // 
            // dtgv_history
            // 
            this.dtgv_history.AllowCustomTheming = false;
            this.dtgv_history.AllowUserToAddRows = false;
            this.dtgv_history.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dtgv_history.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_history.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgv_history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_history.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_history.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_history.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_history.ColumnHeadersHeight = 40;
            this.dtgv_history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Checkin,
            this.Checkoutt,
            this.DelayTime,
            this.TimeWork,
            this.Note});
            this.dtgv_history.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgv_history.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgv_history.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_history.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgv_history.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv_history.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgv_history.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgv_history.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgv_history.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgv_history.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_history.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgv_history.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_history.CurrentTheme.Name = null;
            this.dtgv_history.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_history.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgv_history.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_history.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgv_history.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_history.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv_history.EnableHeadersVisualStyles = false;
            this.dtgv_history.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgv_history.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgv_history.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgv_history.HeaderForeColor = System.Drawing.Color.White;
            this.dtgv_history.Location = new System.Drawing.Point(24, 73);
            this.dtgv_history.Name = "dtgv_history";
            this.dtgv_history.ReadOnly = true;
            this.dtgv_history.RowHeadersVisible = false;
            this.dtgv_history.RowHeadersWidth = 51;
            this.dtgv_history.RowTemplate.Height = 40;
            this.dtgv_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_history.Size = new System.Drawing.Size(1088, 287);
            this.dtgv_history.TabIndex = 6;
            this.dtgv_history.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Ngày";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 86;
            // 
            // Checkin
            // 
            this.Checkin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Checkin.DataPropertyName = "Checkin";
            this.Checkin.HeaderText = "Checkin";
            this.Checkin.MinimumWidth = 6;
            this.Checkin.Name = "Checkin";
            this.Checkin.ReadOnly = true;
            this.Checkin.Width = 111;
            // 
            // Checkoutt
            // 
            this.Checkoutt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Checkoutt.DataPropertyName = "Checkoutt";
            this.Checkoutt.HeaderText = "Checkout";
            this.Checkoutt.MinimumWidth = 6;
            this.Checkoutt.Name = "Checkoutt";
            this.Checkoutt.ReadOnly = true;
            this.Checkoutt.Width = 125;
            // 
            // DelayTime
            // 
            this.DelayTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DelayTime.DataPropertyName = "DelayTime";
            this.DelayTime.HeaderText = "Thời gian trễ";
            this.DelayTime.MinimumWidth = 6;
            this.DelayTime.Name = "DelayTime";
            this.DelayTime.ReadOnly = true;
            this.DelayTime.Width = 155;
            // 
            // TimeWork
            // 
            this.TimeWork.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TimeWork.DataPropertyName = "TimeWork";
            this.TimeWork.HeaderText = "Thời gian làm việc";
            this.TimeWork.MinimumWidth = 6;
            this.TimeWork.Name = "TimeWork";
            this.TimeWork.ReadOnly = true;
            this.TimeWork.Width = 204;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1151, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 50);
            this.label13.TabIndex = 5;
            this.label13.Text = "Thống kê";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 50);
            this.label9.TabIndex = 5;
            this.label9.Text = "Dữ liệu lịch sử";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel_history);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NhanVien";
            this.Size = new System.Drawing.Size(1720, 1050);
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.bt_save.ResumeLayout(false);
            this.bt_save.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_emp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_user_inshift.ResumeLayout(false);
            this.panel_user_inshift.PerformLayout();
            this.panel_shift.ResumeLayout(false);
            this.panel_rootendshift.ResumeLayout(false);
            this.panel_rootready.ResumeLayout(false);
            this.bt_timekeeping.ResumeLayout(false);
            this.bt_timekeeping.PerformLayout();
            this.panel_history.ResumeLayout(false);
            this.panel_history.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_history)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_emp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaElipse elipse_bt_save;
        private Guna.UI.WinForms.GunaElipse elipse_ptb_emp;
        private System.Windows.Forms.Panel bt_save;
        private System.Windows.Forms.Label lb_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.TextBox tb_role;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_timeonline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer_online;
        private System.Windows.Forms.TextBox tb_jobname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel bt_timekeeping;
        private System.Windows.Forms.Label lb_timekeeping;
        private Guna.UI.WinForms.GunaElipse elipse_bt_timekeeping;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel_rootready;
        private System.Windows.Forms.Panel panel_shift;
        private System.Windows.Forms.Panel panel_rootendshift;
        private Bunifu.UI.WinForms.BunifuGradientPanel panel_inshift;
        private Bunifu.UI.WinForms.BunifuGradientPanel panel_endshift;
        private Bunifu.UI.WinForms.BunifuGradientPanel panel_ready;
        private System.Windows.Forms.Label lb_timeend;
        private System.Windows.Forms.Label lb_timestart;
        private System.Windows.Forms.Timer timer_timekeeping;
        private System.Windows.Forms.Panel panel_user_inshift;
        private System.Windows.Forms.Label lb_number;
        private System.Windows.Forms.Panel panel_history;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_month;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgv_history;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbb_year;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_worktime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tb_checksalary;
        private System.Windows.Forms.TextBox tb_evaluate;
        private System.Windows.Forms.TextBox tb_delaytime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkoutt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}