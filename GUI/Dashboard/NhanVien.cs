using grocery_store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI.Dashboard
{
    public partial class NhanVien : UserControl
    {
        public GroceryStoreContext gs_context = new GroceryStoreContext();


        // Vì chưa có login nên đặt đại employee
        public Employee employee;
        public NhanVien()
        {
            InitializeComponent();

            employee = gs_context.Employee.First();

            // Setup hình ảnh employee
            string employee_imgpath = "./Employee_img";
            if (!Directory.Exists(employee_imgpath))
            {
                Directory.CreateDirectory(employee_imgpath);
            }
            string filename = employee_imgpath + "employee.EmployeeId.ToString()" + "-" + employee.FirstName + ".png";
            if (!File.Exists(filename))
            {
                ptb_emp.BackgroundImage = grocery_store.Properties.Resources.user_img;
            } else
            {
                ptb_emp.BackgroundImage = Image.FromFile(filename);
            }

            // Setup thông tin employee
            tb_firstname.Text = employee.FirstName;
            tb_lastname.Text = employee.LastName;
            tb_role.Text = employee.Role;

            // Setup Time Online
            timer_online.Start();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void timer_online_Tick(object sender, EventArgs e)
        {
            string time_current_str = tb_timeonline.Text;
            TimeSpan time_current = TimeSpan.Parse(time_current_str);
            time_current = time_current.Add(TimeSpan.FromSeconds(1));
            tb_timeonline.Text = time_current.ToString(@"hh\:mm\:ss");
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ảnh PNG (*.png)|*.png";
            openFileDialog.Title = "Chọn một tập tin ảnh PNG";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Lấy đường dẫn của tập tin đã chọn
                string filePath = openFileDialog.FileName;

                try
                {
                    // Load ảnh từ tập tin
                    Image image = Image.FromFile(filePath);
                    string employee_imgpath = "./Employee_img";
                    if (!Directory.Exists(employee_imgpath))
                    {
                        Directory.CreateDirectory(employee_imgpath);
                    }
                    string filename = employee_imgpath + "employee.EmployeeId.ToString()" + "-" + employee.FirstName + ".png";
                    image.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
                    ptb_emp.BackgroundImage = image;
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại sau!");
                }
            }
        }
    }
}
