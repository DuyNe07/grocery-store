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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtbox_Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_Pass = new System.Windows.Forms.TextBox();
            this.show_password = new System.Windows.Forms.PictureBox();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.btn_login = new Guna.UI.WinForms.GunaButton();
            this.btn_minimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_close = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.show_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_Login
            // 
            this.txtbox_Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Login.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtbox_Login.Location = new System.Drawing.Point(767, 288);
            this.txtbox_Login.Name = "txtbox_Login";
            this.txtbox_Login.Size = new System.Drawing.Size(304, 40);
            this.txtbox_Login.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(762, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(762, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // txtbox_Pass
            // 
            this.txtbox_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Pass.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtbox_Pass.Location = new System.Drawing.Point(767, 381);
            this.txtbox_Pass.Name = "txtbox_Pass";
            this.txtbox_Pass.PasswordChar = '*';
            this.txtbox_Pass.Size = new System.Drawing.Size(304, 40);
            this.txtbox_Pass.TabIndex = 4;
            // 
            // show_password
            // 
            this.show_password.BackColor = System.Drawing.Color.White;
            this.show_password.Image = global::grocery_store.Properties.Resources.eye_on;
            this.show_password.Location = new System.Drawing.Point(1024, 381);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(45, 40);
            this.show_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show_password.TabIndex = 23;
            this.show_password.TabStop = false;
            this.show_password.Click += new System.EventHandler(this.show_password_Click);
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(1070, 381);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(0, 0);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 19;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.label3);
            this.gunaGradientPanel1.GradiantColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(105)))), ((int)(((byte)(182)))));
            this.gunaGradientPanel1.GradiantColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(136)))), ((int)(((byte)(198)))));
            this.gunaGradientPanel1.GradiantColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(175)))), ((int)(((byte)(209)))));
            this.gunaGradientPanel1.GradiantColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(700, 600);
            this.gunaGradientPanel1.TabIndex = 17;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // btn_login
            // 
            this.btn_login.AnimationHoverSpeed = 0.07F;
            this.btn_login.AnimationSpeed = 0.03F;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_login.BorderColor = System.Drawing.Color.Black;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Image = global::grocery_store.Properties.Resources.login;
            this.btn_login.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_login.Location = new System.Drawing.Point(767, 484);
            this.btn_login.Name = "btn_login";
            this.btn_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btn_login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_login.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_login.OnHoverImage = null;
            this.btn_login.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_login.Radius = 15;
            this.btn_login.Size = new System.Drawing.Size(304, 62);
            this.btn_login.TabIndex = 16;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_login.TextOffsetX = 30;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
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
            this.btn_minimize.Location = new System.Drawing.Point(1104, 0);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Rotation = 0;
            this.btn_minimize.ShowActiveImage = true;
            this.btn_minimize.ShowCursorChanges = true;
            this.btn_minimize.ShowImageBorders = false;
            this.btn_minimize.ShowSizeMarkers = false;
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimize.TabIndex = 7;
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
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_close.Location = new System.Drawing.Point(1134, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Rotation = 0;
            this.btn_close.ShowActiveImage = true;
            this.btn_close.ShowCursorChanges = true;
            this.btn_close.ShowImageBorders = false;
            this.btn_close.ShowSizeMarkers = false;
            this.btn_close.Size = new System.Drawing.Size(32, 30);
            this.btn_close.TabIndex = 6;
            this.btn_close.ToolTipText = "";
            this.btn_close.WaitOnLoad = false;
            this.btn_close.Zoom = 0;
            this.btn_close.ZoomSpeed = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logo.Image = global::grocery_store.Properties.Resources.takeeasy;
            this.Logo.Location = new System.Drawing.Point(854, 67);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(168, 138);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 5;
            this.Logo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vladimir Script", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 145);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 600);
            this.Controls.Add(this.show_password);
            this.Controls.Add(this.gunaTransfarantPictureBox1);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.txtbox_Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.show_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_Pass;
        private System.Windows.Forms.PictureBox Logo;
        private Bunifu.UI.WinForms.BunifuImageButton btn_minimize;
        private Bunifu.UI.WinForms.BunifuImageButton btn_close;
        private Guna.UI.WinForms.GunaButton btn_login;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private System.Windows.Forms.PictureBox show_password;
        private System.Windows.Forms.Label label3;
    }
}