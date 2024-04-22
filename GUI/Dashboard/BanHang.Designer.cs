using System.Drawing;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label_totalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_enterCode = new System.Windows.Forms.TextBox();
            this.panel_products = new System.Windows.Forms.Panel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_enterCode = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_scan = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.comboBox_paymentMethod = new System.Windows.Forms.ComboBox();
            this.panel_products.SuspendLayout();
            this.pictureBox_ScanCode = new System.Windows.Forms.PictureBox();
            this.pictureBox_ScanCode.BringToFront();
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
            // txtbox_enterCode
            // 
            this.txtbox_enterCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.txtbox_enterCode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbox_enterCode.Location = new System.Drawing.Point(133, 64);
            this.txtbox_enterCode.Name = "txtbox_enterCode";
            this.txtbox_enterCode.Size = new System.Drawing.Size(324, 47);
            this.txtbox_enterCode.TabIndex = 10;
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
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = true;
            this.bunifuButton1.AnimationSpeed = 20;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Thanh toán";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges7;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.Black;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.Black;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.IdleBorderRadius = 30;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = true;
            this.bunifuButton1.Location = new System.Drawing.Point(133, 938);
            this.bunifuButton1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.Black;
            this.bunifuButton1.OnDisabledState.BorderRadius = 30;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.onHoverState.BorderRadius = 30;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnIdleState.BorderRadius = 30;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnPressedState.BorderRadius = 30;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(260, 60);
            this.bunifuButton1.TabIndex = 7;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // btn_enterCode
            // 
            this.btn_enterCode.AllowAnimations = true;
            this.btn_enterCode.AllowMouseEffects = true;
            this.btn_enterCode.AllowToggling = true;
            this.btn_enterCode.AnimationSpeed = 20;
            this.btn_enterCode.AutoGenerateColors = false;
            this.btn_enterCode.AutoRoundBorders = false;
            this.btn_enterCode.AutoSizeLeftIcon = true;
            this.btn_enterCode.AutoSizeRightIcon = true;
            this.btn_enterCode.BackColor = System.Drawing.Color.Transparent;
            this.btn_enterCode.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_enterCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_enterCode.BackgroundImage")));
            this.btn_enterCode.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_enterCode.ButtonText = "Nhập mã";
            this.btn_enterCode.ButtonTextMarginLeft = 0;
            this.btn_enterCode.ColorContrastOnClick = 45;
            this.btn_enterCode.ColorContrastOnHover = 45;
            this.btn_enterCode.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btn_enterCode.CustomizableEdges = borderEdges8;
            this.btn_enterCode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_enterCode.DisabledBorderColor = System.Drawing.Color.Black;
            this.btn_enterCode.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_enterCode.DisabledForecolor = System.Drawing.Color.Black;
            this.btn_enterCode.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_enterCode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_enterCode.ForeColor = System.Drawing.Color.Black;
            this.btn_enterCode.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_enterCode.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_enterCode.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btn_enterCode.IconMarginLeft = 11;
            this.btn_enterCode.IconPadding = 10;
            this.btn_enterCode.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_enterCode.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_enterCode.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btn_enterCode.IconSize = 25;
            this.btn_enterCode.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_enterCode.IdleBorderRadius = 30;
            this.btn_enterCode.IdleBorderThickness = 1;
            this.btn_enterCode.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_enterCode.IdleIconLeftImage = global::grocery_store.Properties.Resources.scanner;
            this.btn_enterCode.IdleIconRightImage = null;
            this.btn_enterCode.IndicateFocus = true;
            this.btn_enterCode.Location = new System.Drawing.Point(760, 41);
            this.btn_enterCode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btn_enterCode.Name = "btn_enterCode";
            this.btn_enterCode.OnDisabledState.BorderColor = System.Drawing.Color.Black;
            this.btn_enterCode.OnDisabledState.BorderRadius = 30;
            this.btn_enterCode.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_enterCode.OnDisabledState.BorderThickness = 1;
            this.btn_enterCode.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_enterCode.OnDisabledState.ForeColor = System.Drawing.Color.Black;
            this.btn_enterCode.OnDisabledState.IconLeftImage = null;
            this.btn_enterCode.OnDisabledState.IconRightImage = null;
            this.btn_enterCode.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_enterCode.onHoverState.BorderRadius = 30;
            this.btn_enterCode.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_enterCode.onHoverState.BorderThickness = 1;
            this.btn_enterCode.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btn_enterCode.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_enterCode.onHoverState.IconLeftImage = null;
            this.btn_enterCode.onHoverState.IconRightImage = null;
            this.btn_enterCode.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_enterCode.OnIdleState.BorderRadius = 30;
            this.btn_enterCode.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_enterCode.OnIdleState.BorderThickness = 1;
            this.btn_enterCode.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_enterCode.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_enterCode.OnIdleState.IconLeftImage = global::grocery_store.Properties.Resources.scanner;
            this.btn_enterCode.OnIdleState.IconRightImage = null;
            this.btn_enterCode.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_enterCode.OnPressedState.BorderRadius = 30;
            this.btn_enterCode.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_enterCode.OnPressedState.BorderThickness = 1;
            this.btn_enterCode.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_enterCode.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btn_enterCode.OnPressedState.IconLeftImage = null;
            this.btn_enterCode.OnPressedState.IconRightImage = null;
            this.btn_enterCode.Size = new System.Drawing.Size(257, 70);
            this.btn_enterCode.TabIndex = 4;
            this.btn_enterCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_enterCode.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_enterCode.TextMarginLeft = 0;
            this.btn_enterCode.TextPadding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_enterCode.UseDefaultRadiusAndThickness = true;
            this.btn_enterCode.Click += new System.EventHandler(this.btn_enterCode_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.AllowAnimations = true;
            this.btn_scan.AllowMouseEffects = true;
            this.btn_scan.AllowToggling = true;
            this.btn_scan.AnimationSpeed = 20;
            this.btn_scan.AutoGenerateColors = false;
            this.btn_scan.AutoRoundBorders = false;
            this.btn_scan.AutoSizeLeftIcon = true;
            this.btn_scan.AutoSizeRightIcon = true;
            this.btn_scan.BackColor = System.Drawing.Color.Transparent;
            this.btn_scan.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_scan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_scan.BackgroundImage")));
            this.btn_scan.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_scan.ButtonText = "Quét mã";
            this.btn_scan.ButtonTextMarginLeft = 0;
            this.btn_scan.ColorContrastOnClick = 45;
            this.btn_scan.ColorContrastOnHover = 45;
            this.btn_scan.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btn_scan.CustomizableEdges = borderEdges9;
            this.btn_scan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_scan.DisabledBorderColor = System.Drawing.Color.Black;
            this.btn_scan.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_scan.DisabledForecolor = System.Drawing.Color.Black;
            this.btn_scan.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_scan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_scan.ForeColor = System.Drawing.Color.Black;
            this.btn_scan.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_scan.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_scan.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btn_scan.IconMarginLeft = 11;
            this.btn_scan.IconPadding = 10;
            this.btn_scan.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_scan.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_scan.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_scan.IconSize = 25;
            this.btn_scan.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_scan.IdleBorderRadius = 30;
            this.btn_scan.IdleBorderThickness = 1;
            this.btn_scan.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_scan.IdleIconLeftImage = global::grocery_store.Properties.Resources.code;
            this.btn_scan.IdleIconRightImage = null;
            this.btn_scan.IndicateFocus = true;
            this.btn_scan.Location = new System.Drawing.Point(1345, 41);
            this.btn_scan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.OnDisabledState.BorderColor = System.Drawing.Color.Black;
            this.btn_scan.OnDisabledState.BorderRadius = 30;
            this.btn_scan.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_scan.OnDisabledState.BorderThickness = 1;
            this.btn_scan.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_scan.OnDisabledState.ForeColor = System.Drawing.Color.Black;
            this.btn_scan.OnDisabledState.IconLeftImage = null;
            this.btn_scan.OnDisabledState.IconRightImage = null;
            this.btn_scan.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_scan.onHoverState.BorderRadius = 30;
            this.btn_scan.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_scan.onHoverState.BorderThickness = 1;
            this.btn_scan.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btn_scan.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_scan.onHoverState.IconLeftImage = null;
            this.btn_scan.onHoverState.IconRightImage = null;
            this.btn_scan.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_scan.OnIdleState.BorderRadius = 30;
            this.btn_scan.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_scan.OnIdleState.BorderThickness = 1;
            this.btn_scan.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_scan.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_scan.OnIdleState.IconLeftImage = global::grocery_store.Properties.Resources.code;
            this.btn_scan.OnIdleState.IconRightImage = null;
            this.btn_scan.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_scan.OnPressedState.BorderRadius = 30;
            this.btn_scan.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_scan.OnPressedState.BorderThickness = 1;
            this.btn_scan.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_scan.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btn_scan.OnPressedState.IconLeftImage = null;
            this.btn_scan.OnPressedState.IconRightImage = null;
            this.btn_scan.Size = new System.Drawing.Size(244, 70);
            this.btn_scan.TabIndex = 3;
            this.btn_scan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_scan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_scan.TextMarginLeft = 0;
            this.btn_scan.TextPadding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_scan.UseDefaultRadiusAndThickness = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // comboBox_paymentMethod
            // 
            this.comboBox_paymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.comboBox_paymentMethod.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_paymentMethod.FormattingEnabled = true;
            this.comboBox_paymentMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_paymentMethod.ItemHeight = 45;
            this.comboBox_paymentMethod.Items.AddRange(new object[] {
            "Momo",
            "Tiền mặt",
            "QR",
            "Thẻ"});
            this.comboBox_paymentMethod.Location = new System.Drawing.Point(692, 945);
            this.comboBox_paymentMethod.Name = "comboBox_paymentMethod";
            this.comboBox_paymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_paymentMethod.Size = new System.Drawing.Size(325, 53);
            this.comboBox_paymentMethod.TabIndex = 12;
            // 
            // pictureBox_ScanCode
            // 
            this.pictureBox_ScanCode.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox_ScanCode.Location = new System.Drawing.Point(383, 147);
            this.pictureBox_ScanCode.Name = "pictureBox_ScanCode";
            this.pictureBox_ScanCode.Size = new System.Drawing.Size(788, 428);
            this.pictureBox_ScanCode.TabIndex = 0;
            this.pictureBox_ScanCode.TabStop = false;
            this.pictureBox_ScanCode.Visible = false;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_paymentMethod);
            this.Controls.Add(this.panel_products);
            this.Controls.Add(this.txtbox_enterCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_totalPrice);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enterCode);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.pictureBox_ScanCode);
            this.Name = "BanHang";
            this.Size = new System.Drawing.Size(1720, 1050);
            this.panel_products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ScanCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_scan;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_enterCode;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.Label label_totalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_enterCode;
        private System.Windows.Forms.Panel panel_products;
        private System.Windows.Forms.ComboBox comboBox_paymentMethod;
        private PictureBox pictureBox_ScanCode;
    }
}
