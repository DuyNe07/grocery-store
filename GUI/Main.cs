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
        public Main()
        {
            InitializeComponent();
            reset_UC();
            UC_Sell.Visible = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void reset_UC()
        {
            UC_Sell.Visible = false;
            UC_Invoice.Visible = false;
            UC_Good.Visible = false;
            UC_Statistical.Visible = false;
            UC_Staff.Visible = false;
            UC_Manager.Visible = false; 
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_Sell.Visible = true;
            
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_Invoice.Visible = true;
        }

        private void btn_good_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_Good.Visible = true;
        }

        private void btn_statistical_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_Statistical.Visible = true;
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_Staff.Visible = true;
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_Manager.Visible = true;
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
