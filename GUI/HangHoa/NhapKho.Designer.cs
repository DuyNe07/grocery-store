namespace grocery_store.GUI.HangHoa_
{
    partial class NhapKho
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
            this.danh_sach_san_pham_main = new Guna.UI.WinForms.GunaPanel();
            this.SuspendLayout();
            // 
            // danh_sach_san_pham_main
            // 
            this.danh_sach_san_pham_main.BackColor = System.Drawing.Color.White;
            this.danh_sach_san_pham_main.Location = new System.Drawing.Point(50, 50);
            this.danh_sach_san_pham_main.Name = "danh_sach_san_pham_main";
            this.danh_sach_san_pham_main.Size = new System.Drawing.Size(1630, 850);
            this.danh_sach_san_pham_main.TabIndex = 3;
            // 
            // NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.danh_sach_san_pham_main);
            this.Name = "NhapKho";
            this.Size = new System.Drawing.Size(1730, 950);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel danh_sach_san_pham_main;
    }
}
