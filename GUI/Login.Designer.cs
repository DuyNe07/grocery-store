namespace grocery_store.GUI
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.bnf_username = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_passwd = new System.Windows.Forms.TextBox();
            this.bnf_passwd = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Copyright = new System.Windows.Forms.Label();
            this.logo_Code = new System.Windows.Forms.PictureBox();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.guna_login = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btn_minimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_close = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_Code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtbox_ID.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_ID.Location = new System.Drawing.Point(751, 278);
            this.txtbox_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.Size = new System.Drawing.Size(304, 51);
            this.txtbox_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(528, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "User name:";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(584, 444);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(465, 81);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::grocery_store.Properties.Resources.login1;
            this.gunaPictureBox1.Location = new System.Drawing.Point(-4, -6);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(499, 721);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::grocery_store.Properties.Resources.logo;
            this.gunaPictureBox2.Location = new System.Drawing.Point(-27, 170);
            this.gunaPictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(536, 160);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gunaPictureBox2.TabIndex = 4;
            this.gunaPictureBox2.TabStop = false;
            // 
            // bnf_username
            // 
            this.bnf_username.ElipseRadius = 0;
            this.bnf_username.TargetControl = this.txtbox_ID;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(548, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 50);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // txtbox_passwd
            // 
            this.txtbox_passwd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtbox_passwd.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_passwd.Location = new System.Drawing.Point(751, 341);
            this.txtbox_passwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_passwd.Name = "txtbox_passwd";
            this.txtbox_passwd.Size = new System.Drawing.Size(304, 51);
            this.txtbox_passwd.TabIndex = 6;
            // 
            // bnf_passwd
            // 
            this.bnf_passwd.ElipseRadius = 0;
            this.bnf_passwd.TargetControl = this.txtbox_passwd;
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.BackColor = System.Drawing.Color.Transparent;
            this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Copyright.Location = new System.Drawing.Point(743, 646);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(162, 18);
            this.Copyright.TabIndex = 13;
            this.Copyright.Text = "Develop by Vượt cạn";
            // 
            // logo_Code
            // 
            this.logo_Code.BackColor = System.Drawing.Color.Transparent;
            this.logo_Code.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo_Code.Image = global::grocery_store.Properties.Resources.code__2_;
            this.logo_Code.Location = new System.Drawing.Point(699, 631);
            this.logo_Code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo_Code.Name = "logo_Code";
            this.logo_Code.Size = new System.Drawing.Size(37, 50);
            this.logo_Code.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_Code.TabIndex = 12;
            this.logo_Code.TabStop = false;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = global::grocery_store.Properties.Resources.user;
            this.gunaPictureBox3.Location = new System.Drawing.Point(632, 43);
            this.gunaPictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(260, 229);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox3.TabIndex = 16;
            this.gunaPictureBox3.TabStop = false;
            // 
            // guna_login
            // 
            this.guna_login.Radius = 0;
            this.guna_login.TargetControl = this.btn_login;
            // 
            // btn_minimize
            // 
            this.btn_minimize.ActiveImage = null;
            this.btn_minimize.AllowAnimations = true;
            this.btn_minimize.AllowBuffering = false;
            this.btn_minimize.AllowToggling = false;
            this.btn_minimize.AllowZooming = true;
            this.btn_minimize.AllowZoomingOnFocus = false;
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(144)))));
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_minimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_minimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.ErrorImage")));
            this.btn_minimize.FadeWhenInactive = false;
            this.btn_minimize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_minimize.ForeColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.ImageActive = null;
            this.btn_minimize.ImageLocation = null;
            this.btn_minimize.ImageMargin = 0;
            this.btn_minimize.ImageSize = new System.Drawing.Size(29, 29);
            this.btn_minimize.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btn_minimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.InitialImage")));
            this.btn_minimize.Location = new System.Drawing.Point(1023, 0);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Rotation = 0;
            this.btn_minimize.ShowActiveImage = true;
            this.btn_minimize.ShowCursorChanges = true;
            this.btn_minimize.ShowImageBorders = false;
            this.btn_minimize.ShowSizeMarkers = false;
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimize.TabIndex = 18;
            this.btn_minimize.ToolTipText = "";
            this.btn_minimize.WaitOnLoad = false;
            this.btn_minimize.Zoom = 0;
            this.btn_minimize.ZoomSpeed = 10;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.ActiveImage = null;
            this.btn_close.AllowAnimations = true;
            this.btn_close.AllowBuffering = false;
            this.btn_close.AllowToggling = false;
            this.btn_close.AllowZooming = true;
            this.btn_close.AllowZoomingOnFocus = false;
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_close.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_close.ErrorImage")));
            this.btn_close.FadeWhenInactive = false;
            this.btn_close.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = global::grocery_store.Properties.Resources.close_bold_svgrepo_com;
            this.btn_close.ImageActive = null;
            this.btn_close.ImageLocation = null;
            this.btn_close.ImageMargin = 0;
            this.btn_close.ImageSize = new System.Drawing.Size(31, 29);
            this.btn_close.ImageZoomSize = new System.Drawing.Size(32, 30);
            this.btn_close.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_close.InitialImage")));
            this.btn_close.Location = new System.Drawing.Point(1053, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Rotation = 0;
            this.btn_close.ShowActiveImage = true;
            this.btn_close.ShowCursorChanges = true;
            this.btn_close.ShowImageBorders = false;
            this.btn_close.ShowSizeMarkers = false;
            this.btn_close.Size = new System.Drawing.Size(32, 30);
            this.btn_close.TabIndex = 17;
            this.btn_close.ToolTipText = "";
            this.btn_close.WaitOnLoad = false;
            this.btn_close.Zoom = 0;
            this.btn_close.ZoomSpeed = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1084, 679);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.gunaPictureBox3);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.logo_Code);
            this.Controls.Add(this.txtbox_ID);
            this.Controls.Add(this.txtbox_passwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_Code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Bunifu.Framework.UI.BunifuElipse bnf_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_passwd;
        private Bunifu.Framework.UI.BunifuElipse bnf_passwd;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.PictureBox logo_Code;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaElipse guna_login;
        private Bunifu.UI.WinForms.BunifuImageButton btn_minimize;
        private Bunifu.UI.WinForms.BunifuImageButton btn_close;
    }
}