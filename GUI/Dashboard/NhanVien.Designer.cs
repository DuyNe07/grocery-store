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
            this.elipse_bt_save = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipse_ptb_emp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer_online = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.elipse_bt_timekeeping = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer_timekeeping = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bt_save.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_emp)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_shift.SuspendLayout();
            this.panel_rootendshift.SuspendLayout();
            this.panel_rootready.SuspendLayout();
            this.bt_timekeeping.SuspendLayout();
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
            this.tb_firstname.TabIndex = 4;
            // 
            // tb_role
            // 
            this.tb_role.Location = new System.Drawing.Point(1302, 70);
            this.tb_role.Name = "tb_role";
            this.tb_role.ReadOnly = true;
            this.tb_role.Size = new System.Drawing.Size(279, 38);
            this.tb_role.TabIndex = 4;
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
            this.tb_jobname.TabIndex = 4;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(401, 68);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.ReadOnly = true;
            this.tb_lastname.Size = new System.Drawing.Size(261, 38);
            this.tb_lastname.TabIndex = 4;
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
            this.label5.Location = new System.Drawing.Point(1192, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vị trí: ";
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
            this.ptb_emp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_emp.BackgroundImage")));
            this.ptb_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_emp.Location = new System.Drawing.Point(39, 12);
            this.ptb_emp.Name = "ptb_emp";
            this.ptb_emp.Size = new System.Drawing.Size(170, 170);
            this.ptb_emp.TabIndex = 0;
            this.ptb_emp.TabStop = false;
            // 
            // elipse_bt_save
            // 
            this.elipse_bt_save.ElipseRadius = 40;
            this.elipse_bt_save.TargetControl = this.bt_save;
            // 
            // elipse_ptb_emp
            // 
            this.elipse_ptb_emp.ElipseRadius = 100;
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
            this.elipse_bt_timekeeping.ElipseRadius = 40;
            this.elipse_bt_timekeeping.TargetControl = this.bt_timekeeping;
            // 
            // timer_timekeeping
            // 
            this.timer_timekeeping.Interval = 1000;
            this.timer_timekeeping.Tick += new System.EventHandler(this.timer_timekeeping_Tick);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
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
            this.panel_shift.ResumeLayout(false);
            this.panel_rootendshift.ResumeLayout(false);
            this.panel_rootready.ResumeLayout(false);
            this.bt_timekeeping.ResumeLayout(false);
            this.bt_timekeeping.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_emp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse elipse_bt_save;
        private Bunifu.Framework.UI.BunifuElipse elipse_ptb_emp;
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
        private Bunifu.Framework.UI.BunifuElipse elipse_bt_timekeeping;
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
    }
}
