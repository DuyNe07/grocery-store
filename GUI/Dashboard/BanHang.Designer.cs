﻿using System.Drawing;
using System.Windows.Forms;

namespace grocery_store.GUI.Dashboard
{
    partial class BanHang
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
            this.label_totalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.panel_products = new System.Windows.Forms.Panel();
            this.comboBox_paymentMethod = new Guna.UI.WinForms.GunaComboBox();
            this.btn_pay = new Guna.UI.WinForms.GunaButton();
            this.btn_scan = new Guna.UI.WinForms.GunaButton();
            this.btn_enterCode = new Guna.UI.WinForms.GunaButton();
            this.pictureBox_ScanCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ScanCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(685, 884);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phương thức thanh toán ";
            // 
            // label_totalPrice
            // 
            this.label_totalPrice.AutoSize = true;
            this.label_totalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.label_totalPrice.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_totalPrice.ForeColor = System.Drawing.Color.Black;
            this.label_totalPrice.Location = new System.Drawing.Point(1406, 938);
            this.label_totalPrice.Name = "label_totalPrice";
            this.label_totalPrice.Padding = new System.Windows.Forms.Padding(10);
            this.label_totalPrice.Size = new System.Drawing.Size(53, 58);
            this.label_totalPrice.TabIndex = 8;
            this.label_totalPrice.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(1358, 884);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tổng tiền";
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(213)))));
            this.X.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.X.Location = new System.Drawing.Point(133, 64);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(324, 47);
            this.X.TabIndex = 10;
            // 
            // panel_products
            // 
            this.panel_products.AutoScroll = true;
            this.panel_products.AutoScrollMargin = new System.Drawing.Size(0, 30);
            this.panel_products.BackColor = System.Drawing.Color.PeachPuff;
            this.panel_products.Location = new System.Drawing.Point(108, 151);
            this.panel_products.Name = "panel_products";
            this.panel_products.Size = new System.Drawing.Size(1490, 700);
            this.panel_products.TabIndex = 11;
            // 
            // comboBox_paymentMethod
            // 
            this.comboBox_paymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.comboBox_paymentMethod.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.comboBox_paymentMethod.BorderColor = System.Drawing.Color.Silver;
            this.comboBox_paymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_paymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_paymentMethod.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.comboBox_paymentMethod.ForeColor = System.Drawing.Color.Black;
            this.comboBox_paymentMethod.FormattingEnabled = true;
            this.comboBox_paymentMethod.Items.AddRange(new object[] {
            "Momo",
            "Banking",
            "Tiền mặt",
            "Thẻ"});
            this.comboBox_paymentMethod.Location = new System.Drawing.Point(743, 946);
            this.comboBox_paymentMethod.Name = "comboBox_paymentMethod";
            this.comboBox_paymentMethod.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(188)))), ((int)(((byte)(159)))));
            this.comboBox_paymentMethod.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.comboBox_paymentMethod.Size = new System.Drawing.Size(228, 52);
            this.comboBox_paymentMethod.TabIndex = 13;
            // 
            // btn_pay
            // 
            this.btn_pay.AnimationHoverSpeed = 0.07F;
            this.btn_pay.AnimationSpeed = 0.03F;
            this.btn_pay.BackColor = System.Drawing.Color.Transparent;
            this.btn_pay.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_pay.BorderColor = System.Drawing.Color.Black;
            this.btn_pay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn_pay.ForeColor = System.Drawing.Color.Black;
            this.btn_pay.Image = null;
            this.btn_pay.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_pay.Location = new System.Drawing.Point(133, 936);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btn_pay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_pay.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_pay.OnHoverImage = null;
            this.btn_pay.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_pay.Radius = 15;
            this.btn_pay.Size = new System.Drawing.Size(260, 60);
            this.btn_pay.TabIndex = 14;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.AnimationHoverSpeed = 0.07F;
            this.btn_scan.AnimationSpeed = 0.03F;
            this.btn_scan.BackColor = System.Drawing.Color.Transparent;
            this.btn_scan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_scan.BorderColor = System.Drawing.Color.Black;
            this.btn_scan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn_scan.ForeColor = System.Drawing.Color.Black;
            this.btn_scan.Image = global::grocery_store.Properties.Resources.scanner;
            this.btn_scan.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_scan.Location = new System.Drawing.Point(1310, 41);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btn_scan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_scan.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_scan.OnHoverImage = null;
            this.btn_scan.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_scan.Radius = 15;
            this.btn_scan.Size = new System.Drawing.Size(257, 70);
            this.btn_scan.TabIndex = 16;
            this.btn_scan.Text = "Quét mã";
            this.btn_scan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_scan.TextOffsetX = 12;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // btn_enterCode
            // 
            this.btn_enterCode.AnimationHoverSpeed = 0.07F;
            this.btn_enterCode.AnimationSpeed = 0.03F;
            this.btn_enterCode.BackColor = System.Drawing.Color.Transparent;
            this.btn_enterCode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_enterCode.BorderColor = System.Drawing.Color.Black;
            this.btn_enterCode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn_enterCode.ForeColor = System.Drawing.Color.Black;
            this.btn_enterCode.Image = global::grocery_store.Properties.Resources.text;
            this.btn_enterCode.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_enterCode.Location = new System.Drawing.Point(692, 41);
            this.btn_enterCode.Name = "btn_enterCode";
            this.btn_enterCode.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btn_enterCode.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_enterCode.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_enterCode.OnHoverImage = null;
            this.btn_enterCode.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_enterCode.Radius = 15;
            this.btn_enterCode.Size = new System.Drawing.Size(257, 70);
            this.btn_enterCode.TabIndex = 15;
            this.btn_enterCode.Text = "Nhập mã";
            this.btn_enterCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_enterCode.TextOffsetX = 10;
            this.btn_enterCode.Click += new System.EventHandler(this.btn_enterCode_Click);
            // 
            // pictureBox_ScanCode
            // 
            this.pictureBox_ScanCode.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox_ScanCode.Location = new System.Drawing.Point(30, 219);
            this.pictureBox_ScanCode.Name = "pictureBox_ScanCode";
            this.pictureBox_ScanCode.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox_ScanCode.TabIndex = 0;
            this.pictureBox_ScanCode.TabStop = false;
            this.pictureBox_ScanCode.Visible = false;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.btn_enterCode);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.comboBox_paymentMethod);
            this.Controls.Add(this.panel_products);
            this.Controls.Add(this.X);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_totalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_ScanCode);
            this.Name = "BanHang";
            this.Size = new System.Drawing.Size(1720, 1050);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ScanCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_totalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Panel panel_products;
        private PictureBox pictureBox_ScanCode;
        private Guna.UI.WinForms.GunaComboBox comboBox_paymentMethod;
        private Guna.UI.WinForms.GunaButton btn_pay;
        private Guna.UI.WinForms.GunaButton btn_enterCode;
        private Guna.UI.WinForms.GunaButton btn_scan;
    }
}
