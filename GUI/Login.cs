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
    public partial class Login : Form
    {
        public Employee Employee { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private async Task<bool> checkLogin(string ID)
        {
            int id = int.Parse(ID);
            Employee = await Employee.Login(id);
            if (Employee == null)
            {
                return false;
            }
            return true;
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            if (await checkLogin(txtbox_ID.Text))
            {
                Main main = new Main();
                main.Employee = Employee;
                main.FormClosed += Main_FormClosed;
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                txtbox_ID.Text = "";
            }
        }

        // kiểm tra điều kiện nếu form Main tắt thì hiển thị lại form đăng nhập
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

    }
}
