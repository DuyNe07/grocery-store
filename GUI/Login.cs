using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
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

        private async Task<bool> checkLogin(string Login, string Pass)
        {
            using(var db = new GroceryStoreContext())
            {
                Employee = await db.Employee.Where(e => e.Login == Login && e.Password == Pass).FirstOrDefaultAsync();
                if (Employee != null)
                {
                    return true;
                }
                return false;
            }
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            if (await checkLogin(txtbox_Login.Text, txtbox_Pass.Text))
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
                txtbox_Login.Text = "";
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

    }
}
