namespace grocery_store.GUI.BanHang
{
    partial class PayUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_QR = new System.Windows.Forms.PictureBox();
            this.btn_OK = new Guna.UI.WinForms.GunaButton();
            this.btn_Cancel = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng thực hiện thanh toán";
            // 
            // pictureBox_QR
            // 
            this.pictureBox_QR.Location = new System.Drawing.Point(70, 95);
            this.pictureBox_QR.Name = "pictureBox_QR";
            this.pictureBox_QR.Size = new System.Drawing.Size(350, 350);
            this.pictureBox_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_QR.TabIndex = 1;
            this.pictureBox_QR.TabStop = false;
            // 
            // btn_OK
            // 
            this.btn_OK.AnimationHoverSpeed = 0.07F;
            this.btn_OK.AnimationSpeed = 0.03F;
            this.btn_OK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(131)))));
            this.btn_OK.BorderColor = System.Drawing.Color.Black;
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_OK.ForeColor = System.Drawing.Color.Black;
            this.btn_OK.Image = null;
            this.btn_OK.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_OK.Location = new System.Drawing.Point(43, 472);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(148)))), ((int)(((byte)(118)))));
            this.btn_OK.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_OK.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_OK.OnHoverImage = null;
            this.btn_OK.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(68)))));
            this.btn_OK.Radius = 15;
            this.btn_OK.Size = new System.Drawing.Size(169, 50);
            this.btn_OK.TabIndex = 11;
            this.btn_OK.Text = "Hoàn thành";
            this.btn_OK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AnimationHoverSpeed = 0.07F;
            this.btn_Cancel.AnimationSpeed = 0.03F;
            this.btn_Cancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.btn_Cancel.BorderColor = System.Drawing.Color.Black;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Image = null;
            this.btn_Cancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Cancel.Location = new System.Drawing.Point(280, 472);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_Cancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Cancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Cancel.OnHoverImage = null;
            this.btn_Cancel.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.btn_Cancel.Radius = 15;
            this.btn_Cancel.Size = new System.Drawing.Size(169, 50);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Thoát";
            this.btn_Cancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PayUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.pictureBox_QR);
            this.Controls.Add(this.label1);
            this.Name = "PayUC";
            this.Size = new System.Drawing.Size(490, 542);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_QR;
        private Guna.UI.WinForms.GunaButton btn_OK;
        private Guna.UI.WinForms.GunaButton btn_Cancel;
    }
}
