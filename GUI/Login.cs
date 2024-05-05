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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void show_password_Click(object sender, EventArgs e)
        {

            // hiển thị password từ * sang text đúng ký tự đã nhập trong txtbox_Pass
            if (txtbox_Pass.PasswordChar == '*')
            {
                Bitmap hidePass = new Bitmap(Properties.Resources.eye_off);
                show_password.Image = hidePass;
                show_password.SizeMode = PictureBoxSizeMode.Zoom;
                show_password.Size = new Size(35, 32);

                txtbox_Pass.PasswordChar = '\0';
            }
            else
            {
                Bitmap showPass = new Bitmap(Properties.Resources.eye_on);
                show_password.Image = showPass;
                show_password.SizeMode = PictureBoxSizeMode.Zoom;
                show_password.Size = new Size(35, 32);

                txtbox_Pass.PasswordChar = '*';
            }
        }
    }
}
