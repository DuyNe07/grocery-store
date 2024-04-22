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
            this.panel2 = new System.Windows.Forms.Panel();
            this.elipse_bt_save = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipse_ptb_emp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ptb_emp = new System.Windows.Forms.PictureBox();
            this.bt_save = new System.Windows.Forms.Panel();
            this.lb_save = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.tb_role = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_timeonline = new System.Windows.Forms.TextBox();
            this.timer_online = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_emp)).BeginInit();
            this.bt_save.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_lastname);
            this.panel1.Controls.Add(this.tb_role);
            this.panel1.Controls.Add(this.tb_timeonline);
            this.panel1.Controls.Add(this.tb_firstname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(24, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1675, 260);
            this.panel1.TabIndex = 1;
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
            // elipse_bt_save
            // 
            this.elipse_bt_save.ElipseRadius = 40;
            this.elipse_bt_save.TargetControl = this.bt_save;
            // 
            // elipse_ptb_emp
            // 
            this.elipse_ptb_emp.ElipseRadius = 60;
            this.elipse_ptb_emp.TargetControl = this.ptb_emp;
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
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(383, 68);
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
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(795, 68);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.ReadOnly = true;
            this.tb_lastname.Size = new System.Drawing.Size(279, 38);
            this.tb_lastname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thời gian online:";
            // 
            // tb_timeonline
            // 
            this.tb_timeonline.Location = new System.Drawing.Point(529, 147);
            this.tb_timeonline.Name = "tb_timeonline";
            this.tb_timeonline.ReadOnly = true;
            this.tb_timeonline.Size = new System.Drawing.Size(109, 38);
            this.tb_timeonline.TabIndex = 4;
            this.tb_timeonline.Text = "00:00:00";
            this.tb_timeonline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer_online
            // 
            this.timer_online.Interval = 1000;
            this.timer_online.Tick += new System.EventHandler(this.timer_online_Tick);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NhanVien";
            this.Size = new System.Drawing.Size(1720, 1050);
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_emp)).EndInit();
            this.bt_save.ResumeLayout(false);
            this.bt_save.PerformLayout();
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
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_role;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.TextBox tb_timeonline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer_online;
    }
}
