using grocery_store.Models;
using Guna.UI.WinForms;
using Microsoft.EntityFrameworkCore;
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
    public partial class QuanLy : UserControl
    {
        public GroceryStoreContext gs_context = new GroceryStoreContext();

        public QuanLy()
        {
            InitializeComponent();
            Update_List_Employees();
        }


        private void QuanLy_Load(object sender, EventArgs e)
        {
            tb_timestart.Value = DateTime.Now;
            tb_timeend.Value = DateTime.Now.AddDays(30);
            cbb_role.SelectedIndex = 0;
            cbb_shift.SelectedIndex = 0;
            int Y = panel_result.Location.Y;
            panel_result.Location = new Point(panel1.Size.Width * 2, Y);
            panel_employee_information.Location = new Point(panel1.Size.Width, Y);
            panel_list_employee.Location = new Point(0, Y);
        }

        #region Danh sách
        public async void Update_List_Employees()
        {
            List<Employee> employees = await gs_context.Employee.Include(e => e.Job).ToListAsync();
            DataTable dt = new DataTable();

            // Thêm các cột vào dt
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("Role", typeof(string));
            dt.Columns.Add("Shift", typeof(string));
            dt.Columns.Add("Salary", typeof(string));
            dt.Columns.Add("TimeStart", typeof(string));
            dt.Columns.Add("TimeEnd", typeof(string));

            foreach (Employee e in employees)
            {
                string ID = e.EmployeeId.ToString();
                string FirstName = e.FirstName.ToString();
                string LastName = e.LastName.ToString();
                string Role = e.Role.ToString();
                string Shift = e.Job.Name.ToString();
                string Salary = e.Job.Salary.ToString("#,##0") + " VNĐ";
                string TimeStart = e.Job.JoinDate.ToString("dd/MM/yyyy");
                string TimeEnd = "";
                if (e.Job.EndDate.HasValue)
                {
                    TimeEnd = e.Job.EndDate.Value.ToString("dd/MM/yyyy");
                }
                dt.Rows.Add(ID, FirstName, LastName, Role, Shift, Salary, TimeStart, TimeEnd);
            }

            dtgv_list_employees.DataSource = dt;
        }



        #endregion

        #region Animation
        public int state = 1; // 1: List, 2: Add, 3: Xóa or Sửa
        public int mode = 1; // 1: Add, 2: Update/Delete

        public void Set_StateButton(GunaGradiantCircleButton bt, bool on = false)
        {
            if (on)
            {
                bt.BaseColor1 = Color.SlateBlue;
                bt.BaseColor2 = Color.Fuchsia;
            } else
            {
                bt.BaseColor1 = Color.LightGray;
                bt.BaseColor2 = Color.Gray;
            }
        }

        public void Set_BiggerButton(GunaGradiantCircleButton bt)
        {
            int width = bt.Size.Width;
            int height = bt.Size.Height;
            bt.Size = new Size(width+2,height+2);
            int X = bt.Location.X;
            int Y = bt.Location.Y;
            bt.Location = new Point(X-1,Y-1);
        }

        public void Set_NormalSizeButton(GunaGradiantCircleButton bt)
        {
            int width = bt.Size.Width;
            int height = bt.Size.Height;
            bt.Size = new Size(width-20,height-20);
            int X = bt.Location.X;
            int Y = bt.Location.Y;
            bt.Location = new Point(X+10,Y+10);
        }


        private void timer_animation_Tick(object sender, EventArgs e)
        {
            doing_animation = true; 
            if (state == 2)
            {
                staging1.Visible = true;
                int progess = staging1.Value;
                staging1.Value = progess + 2;
                if (progess % 10 == 0)
                {
                    Set_BiggerButton(bt_stage2);
                }
                int X = panel_list_employee.Location.X;
                int Y = panel_list_employee.Location.Y;
                panel_list_employee.Location = new Point(X - (int)(panel1.Size.Width / 49),Y);
                X = panel_employee_information.Location.X;
                Y = panel_employee_information.Location.Y;
                panel_employee_information.Location = new Point(X- (int)(panel1.Size.Width / 49), Y);
                X = panel_result.Location.X;
                Y = panel_result.Location.Y;
                panel_result.Location = new Point(X - (int)(panel1.Size.Width / 49), Y);
                if (progess == 100)
                {
                    timer_animation.Stop();
                    Set_StateButton(bt_stage2, true);
                    Set_NormalSizeButton(bt_stage2);
                    staging1.Value = 0;
                    staging1.Visible = false;
                    Set_StateButton(bt_stage1, false);
                    panel_employee_information.Location = new Point(0, Y);
                    doing_animation = false;
                }
            }
            else if (state == 3)
            {
                staging2.Visible = true;
                int progess = staging2.Value;
                staging2.Value = progess + 2;
                if (progess % 10 == 0)
                {
                    Set_BiggerButton(bt_stage3);
                }
                int X = panel_list_employee.Location.X;
                int Y = panel_list_employee.Location.Y;
                panel_list_employee.Location = new Point(X - (int)(panel1.Size.Width / 49), Y);
                X = panel_employee_information.Location.X;
                Y = panel_employee_information.Location.Y;
                panel_employee_information.Location = new Point(X - (int)(panel1.Size.Width / 49), Y);
                X = panel_result.Location.X;
                Y = panel_result.Location.Y;
                panel_result.Location = new Point(X - (int)(panel1.Size.Width / 49), Y);
                if (progess == 100)
                {
                    timer_animation.Stop();
                    Set_StateButton(bt_stage3, true);
                    Set_NormalSizeButton(bt_stage3);
                    staging2.Value = 0;
                    staging2.Visible = false;
                    Set_StateButton(bt_stage2, false);
                    panel_result.Location = new Point(0, Y);
                    doing_animation = false;
                }
            }
        }


        #endregion

        #region Add, Delete, Update
        private void ptb_employee_Click(object sender, EventArgs e)
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
                    using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(filePath)))
                    {
                        Image image = Image.FromStream(ms);

                        // Hiển thị hình ảnh trong PictureBox
                        ptb_employee.Image = image;
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại sau!");
                }
            }
        }

        public bool ischecked = false;
        private void radiobt_end_CheckedChanged(object sender, EventArgs e)
        {
            ischecked = radiobt_end.Checked;
            if (radiobt_end.Checked)
            {
                tb_timeend.Enabled = true;
            }
            else
            {
                tb_timeend.Enabled = false;
            }
        }

        private void radiobt_end_Click(object sender, EventArgs e)
        {
            if (radiobt_end.Checked && !ischecked)
            {
                radiobt_end.Checked = false;
            }
            else
            {
                radiobt_end.Checked = true;
                ischecked = false;
            }
        }


        private async void bt_add_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 2;
                mode = 1;
                timer_animation.Start();
            } else if (state == 2 && mode == 1) 
            {
                List<Control> controls = new List<Control>
                {
                    tb_firstname,tb_lastname,tb_account,tb_password,cbb_role,cbb_shift,tb_timestart,tb_timeend,tb_salary
                };
                bool check = true;
                foreach (Control control in controls) 
                {
                    string[] tag = control.Tag.ToString().Split('-');
                    string type = tag[0];
                    string mess = tag[1];
                    if (type == "x") continue;
                    if (control.Text.Trim() == "")
                    {
                        MessageBox.Show("Vui lòng không để trống thông tin " + mess,"Thiếu thông tin!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        check = false;
                        break;
                    } else
                    {
                        if (type == "log" && control.Text.Trim().Length < 6)
                        {
                            MessageBox.Show(mess + " không được ít hơn 6 kí tự!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            check = false;
                            break;
                        }
                    }
                }
                if (tb_timeend.Value <= tb_timestart.Value && radiobt_end.Checked)
                {
                    MessageBox.Show("Thời gian kết thúc không được nhỏ hơn bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = false;
                }
                if (check)
                {
                    try
                    {
                        Job job = new Job
                        {
                            JoinDate = tb_timestart.Value,
                            Salary = decimal.Parse(tb_salary.Text),
                            Name = cbb_shift.SelectedItem.ToString()
                        };
                        if (radiobt_end.Checked)
                        {
                            job.EndDate = tb_timeend.Value;
                        }
                        await gs_context.Job.AddAsync(job);
                        await gs_context.SaveChangesAsync();
                        Employee employee = new Employee
                        {
                            FirstName = tb_firstname.Text,
                            LastName = tb_lastname.Text,
                            Role = cbb_role.SelectedItem.ToString(),
                            Job = job
                        };
                        if (ptb_employee.Image != grocery_store.Properties.Resources.user_img)
                        {
                            Image image = ptb_employee.Image;
                            using (MemoryStream ms = new MemoryStream())
                            {
                                image.Save(ms, image.RawFormat);
                                employee.Img = ms.ToArray();
                            }
                        }
                        await gs_context.Employee.AddAsync(employee);
                        await gs_context.SaveChangesAsync();
                        ptb_status.Image = grocery_store.Properties.Resources.check_tv;
                        Clear_state2();
                        state = 3;
                        timer_animation.Start();
                        MessageBox.Show("Thành công!");
                    } catch
                    {
                        ptb_status.Image = grocery_store.Properties.Resources.cross_tv;
                        state = 3;
                        timer_animation.Start();
                        MessageBox.Show("Đã có lối xảy ra!");
                    }
                }
            }
        }
        private void tb_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự nhập vào không phải là số và không phải là phím backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Chặn ký tự nhập vào bằng cách hủy sự kiện KeyPress
                e.Handled = true;
            }
        }

        public void Clear_state2()
        {
            tb_id.Text = "";
            tb_firstname.Text = "";
            tb_lastname.Text = "";
            tb_account.Text = "";
            tb_password.Text = "";
            tb_password.UseSystemPasswordChar = true;
            bt_showpass.Text = "Hiện";
            tb_timestart.Value = DateTime.Now;
            tb_timeend.Value = DateTime.Now.AddDays(30);
            cbb_role.SelectedIndex = 0;
            cbb_shift.SelectedIndex = 0;
            tb_salary.Text = "";
            ptb_employee.Image = grocery_store.Properties.Resources.user_img;
        }

        private void bt_showpass_Click(object sender, EventArgs e)
        {
            if (tb_password.UseSystemPasswordChar)
            {
                tb_password.UseSystemPasswordChar = false;
                bt_showpass.Text = "Ẩn";
            } else
            {
                tb_password.UseSystemPasswordChar = true;
                bt_showpass.Text = "Hiện";
            }
        }

        private bool doing_animation = false;
        private void bt_list_Click(object sender, EventArgs e)
        {
            if (!doing_animation)
            {
                int Y = panel_result.Location.Y;
                panel_result.Location = new Point(panel1.Size.Width * 2, Y);
                panel_employee_information.Location = new Point(panel1.Size.Width, Y);
                Clear_state2();
                panel_list_employee.Location = new Point(0, Y);
                Update_List_Employees();
                Set_StateButton(bt_stage1, true);
                Set_StateButton(bt_stage2);
                Set_StateButton(bt_stage3);
                state = 1;
                bt_add.Enabled = true;
            }
        }

        private async void dtgv_list_employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                bt_add.Enabled = false;
                int ID = int.Parse(dtgv_list_employees.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                mode = 2;
                Employee employee = await gs_context.Employee.Include(w => w.Job).Where(w => w.EmployeeId == ID).FirstAsync();
                tb_id.Text = ID.ToString();
                tb_firstname.Text = employee.FirstName;
                tb_lastname.Text = employee.LastName;
                tb_account.Text = employee.Login;
                tb_password.Text = employee.Password;
                tb_password.UseSystemPasswordChar = true;
                bt_showpass.Text = "Hiện";
                tb_timestart.Value = employee.Job.JoinDate;
                if (employee.Job.EndDate.HasValue)
                {
                    tb_timeend.Value = employee.Job.EndDate.Value;
                    radiobt_end.Checked = true;
                    ischecked = false;
                }
                else
                {
                    tb_timeend.Value = employee.Job.JoinDate.AddDays(30);
                }
                if (employee.Img != null)
                {
                    using (MemoryStream ms = new MemoryStream(employee.Img))
                        ptb_employee.Image = Image.FromStream(ms);
                }
                cbb_role.SelectedItem = employee.Role;
                cbb_shift.SelectedItem = employee.Job.Name;
                tb_salary.Text = employee.Job.Salary.ToString("0");
                state = 2;
                timer_animation.Start();
            }
        }

        private async void bt_delete_Click(object sender, EventArgs e)
        {
            if (state == 2 && mode == 2)
            {
                try
                {
                    Employee employee = await gs_context.Employee.Include(x => x.Job).Where(x => x.EmployeeId == int.Parse(tb_id.Text)).FirstAsync();
                    Job job = employee.Job;
                    gs_context.Employee.Remove(employee);
                    await gs_context.SaveChangesAsync();
                    gs_context.Job.Remove(job);
                    await gs_context.SaveChangesAsync();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    state = 3;
                    ptb_status.Image = grocery_store.Properties.Resources.check_tv;
                    timer_animation.Start();
                }
                catch
                {
                    ptb_status.Image = grocery_store.Properties.Resources.cross_tv;
                    state = 3;
                    timer_animation.Start();
                    MessageBox.Show("Đã có lối xảy ra!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void bt_update_Click(object sender, EventArgs e)
        {
            if (state == 2 && mode == 2)
            {
                List<Control> controls = new List<Control>
                {
                    tb_firstname,tb_lastname,tb_account,tb_password,cbb_role,cbb_shift,tb_timestart,tb_timeend,tb_salary
                };
                bool check = true;
                foreach (Control control in controls)
                {
                    string[] tag = control.Tag.ToString().Split('-');
                    string type = tag[0];
                    string mess = tag[1];
                    if (type == "x") continue;
                    if (control.Text.Trim() == "")
                    {
                        MessageBox.Show("Vui lòng không để trống thông tin " + mess, "Thiếu thông tin!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        check = false;
                        break;
                    }
                    else
                    {
                        if (type == "log" && control.Text.Trim().Length < 6)
                        {
                            MessageBox.Show(mess + " không được ít hơn 6 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            check = false;
                            break;
                        }
                    }
                }
                if (tb_timeend.Value <= tb_timestart.Value && radiobt_end.Checked)
                {
                    MessageBox.Show("Thời gian kết thúc không được nhỏ hơn bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = false;
                }
                if (check)
                {
                    try
                    {
                        Employee employee = await gs_context.Employee.Include(x => x.Job).Where(x => x.EmployeeId == int.Parse(tb_id.Text)).FirstAsync();
                        Job job = employee.Job;
                        job.Salary = int.Parse(tb_salary.Text);
                        job.JoinDate = tb_timestart.Value;
                        if (radiobt_end.Checked)
                            job.EndDate = tb_timeend.Value;
                        job.Name = cbb_shift.SelectedItem.ToString();
                        await gs_context.SaveChangesAsync();
                        employee.FirstName = tb_firstname.Text;
                        employee.LastName = tb_lastname.Text;
                        employee.Login = tb_account.Text;
                        employee.Password = tb_password.Text;
                        employee.Role = cbb_role.SelectedItem.ToString();
                        employee.Job = job;
                        if (ptb_employee.Image != grocery_store.Properties.Resources.user_img)
                        {
                            Image image = ptb_employee.Image;
                            using (MemoryStream ms = new MemoryStream())
                            {
                                image.Save(ms, image.RawFormat);
                                employee.Img = ms.ToArray();
                            }
                        }
                        await gs_context.SaveChangesAsync();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        state = 3;
                        ptb_status.Image = grocery_store.Properties.Resources.check_tv;
                        timer_animation.Start();
                    }
                    catch
                    {
                        ptb_status.Image = grocery_store.Properties.Resources.cross_tv;
                        state = 3;
                        timer_animation.Start();
                        MessageBox.Show("Đã có lối xảy ra!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


    }
}
