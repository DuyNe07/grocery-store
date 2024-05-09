namespace grocery_store.GUI.BanHang
{
    partial class ScanBarCode
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
            this.pictureBox_ScanCode = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ScanCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_ScanCode
            // 
            this.pictureBox_ScanCode.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox_ScanCode.Location = new System.Drawing.Point(193, 165);
            this.pictureBox_ScanCode.Name = "pictureBox_ScanCode";
            this.pictureBox_ScanCode.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox_ScanCode.TabIndex = 1;
            this.pictureBox_ScanCode.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.AnimationHoverSpeed = 0.07F;
            this.btn_cancel.AnimationSpeed = 0.03F;
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_cancel.BorderColor = System.Drawing.Color.Black;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Image = null;
            this.btn_cancel.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_cancel.Location = new System.Drawing.Point(1216, 922);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_cancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_cancel.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_cancel.OnHoverImage = null;
            this.btn_cancel.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(32)))), ((int)(((byte)(78)))));
            this.btn_cancel.Radius = 15;
            this.btn_cancel.Size = new System.Drawing.Size(257, 70);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Huỷ";
            this.btn_cancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_cancel.TextOffsetX = 10;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(506, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Vui lòng đưa mã vạch vào khu vực quét mã";
            // 
            // ScanBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.pictureBox_ScanCode);
            this.Name = "ScanBarCode";
            this.Size = new System.Drawing.Size(1720, 1050);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ScanCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ScanCode;
        public Guna.UI.WinForms.GunaButton btn_cancel;
        private System.Windows.Forms.Label label1;
    }
}
