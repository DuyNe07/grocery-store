using grocery_store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI
{
    public partial class Main : Form
    {
        public Employee Employee { get; set; }
        private Dashboard.BanHang UC_Sell;
        private Dashboard.HoaDon UC_Invoice;
        private Dashboard.HangHoa UC_Good;
        private Dashboard.ThongKe UC_Statistical;
        private Dashboard.NhanVien UC_Staff;
        private Dashboard.QuanLy UC_Manager;

       
        public Main()
        {
            InitializeComponent();
            #region Windows Form Designer generated code
            UC_Sell = new grocery_store.GUI.Dashboard.BanHang();
            UC_Manager = new grocery_store.GUI.Dashboard.QuanLy();
            UC_Staff = new grocery_store.GUI.Dashboard.NhanVien();
            UC_Statistical = new grocery_store.GUI.Dashboard.ThongKe();
            UC_Invoice = new grocery_store.GUI.Dashboard.HoaDon();
            UC_Good = new grocery_store.GUI.Dashboard.HangHoa();
            // UC_Sell
            // 
            this.UC_Sell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_Sell.Location = new System.Drawing.Point(0, 0);
            this.UC_Sell.Name = "UC_Sell";
            this.UC_Sell.Size = new System.Drawing.Size(1620, 1050);
            this.UC_Sell.TabIndex = 0;
            // 
            // UC_Manager
            // 
            this.UC_Manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.UC_Manager.Location = new System.Drawing.Point(0, 0);
            this.UC_Manager.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Manager.Name = "UC_Manager";
            this.UC_Manager.Size = new System.Drawing.Size(1620, 1050);
            this.UC_Manager.TabIndex = 5;
            // 
            // UC_Staff
            // 
            this.UC_Staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.UC_Staff.Location = new System.Drawing.Point(0, 0);
            this.UC_Staff.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Staff.Name = "UC_Staff";
            this.UC_Staff.Size = new System.Drawing.Size(1620, 1050);
            this.UC_Staff.TabIndex = 4;
            // 
            // UC_Statistical
            // 
            this.UC_Statistical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.UC_Statistical.Location = new System.Drawing.Point(0, 0);
            this.UC_Statistical.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Statistical.Name = "UC_Statistical";
            this.UC_Statistical.Size = new System.Drawing.Size(1620, 1050);
            this.UC_Statistical.TabIndex = 3;
            // 
            // UC_Invoice
            // 
            this.UC_Invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.UC_Invoice.Location = new System.Drawing.Point(0, 0);
            this.UC_Invoice.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Invoice.Name = "UC_Invoice";
            this.UC_Invoice.Size = new System.Drawing.Size(1620, 1050);
            this.UC_Invoice.TabIndex = 1;
            // 
            // UC_Good
            // 
            this.UC_Good.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.UC_Good.Location = new System.Drawing.Point(0, 0);
            this.UC_Good.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Good.Name = "UC_Good";
            this.UC_Good.Size = new System.Drawing.Size(1620, 1050);
            this.UC_Good.TabIndex = 2;
            // 

            #endregion

            SetView(1, 0, 0, 0, 0, 0);
            //SetView(0, 0, 1, 0, 0, 0);
        }

        

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            SetView(1, 0, 0, 0, 0, 0);
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            SetView(0, 1, 0, 0, 0, 0);
        }

        private void btn_good_Click(object sender, EventArgs e)
        {
            SetView(0, 0, 1, 0, 0, 0);
        }

        private void btn_statistical_Click(object sender, EventArgs e)
        {
            SetView(0, 0, 0, 1, 0, 0);
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            SetView(0, 0, 0, 0, 1, 0);
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            SetView(0, 0, 0, 0, 0, 1);
        }

        private void SetView(int sell, int invoice, int good, int stat, int staff, int manage)
        {
            panel_UC.Controls.Remove(sell == 1 ? null : UC_Sell);
            panel_UC.Controls.Remove(invoice == 1 ? null : UC_Invoice);
            panel_UC.Controls.Remove(good == 1 ? null : UC_Good);
            panel_UC.Controls.Remove(stat == 1 ? null : UC_Statistical);
            panel_UC.Controls.Remove(staff == 1 ? null : UC_Staff);
            panel_UC.Controls.Remove(manage == 1 ? null : UC_Manager);

            panel_UC.Controls.Add(sell == 1 ? UC_Sell : null);
            panel_UC.Controls.Add(invoice == 1 ? UC_Invoice : null);
            panel_UC.Controls.Add(good == 1 ? UC_Good : null);
            panel_UC.Controls.Add(stat == 1 ? UC_Statistical : null);
            panel_UC.Controls.Add(staff == 1 ? UC_Staff : null);
            panel_UC.Controls.Add(manage == 1 ? UC_Manager : null);
        }


        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        public void setEmployee(Employee employee)
        {
            this.Employee = employee;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
