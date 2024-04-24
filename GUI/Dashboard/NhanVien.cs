using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        // Ca làm
        // 7-> 22: FullTime, 7 -> 11h30: Morning Shift, 12h30 -> 17h: Afternoon Shift, 17h -> 22h: Night Shift
        public TimeSpan timestart_shift;
        public TimeSpan timeend_shift;

        // Trạng thái chấm công
        public bool timekeeping_state = false;
        public bool finish = false;
        public bool delay_state = false;
        public TimeSpan time_delay = new TimeSpan(0,0,0);

        public NhanVien()
        {
            InitializeComponent();

            employee = gs_context.Employee.Include(e => e.Job).ToList()[1];
            

            // Setup hình ảnh employee
            string employee_imgpath = "./Employee_img";
            if (!Directory.Exists(employee_imgpath))
            {
                Directory.CreateDirectory(employee_imgpath);
            }
            string filename = employee_imgpath + employee.EmployeeId.ToString() + "-" + employee.FirstName + ".png";
            if (!File.Exists(filename))
            {
                ptb_emp.BackgroundImage = grocery_store.Properties.Resources.user_img;
            } else
            {
                ptb_emp.BackgroundImage = Image.FromFile(filename);
            }

            // Setup thông tin employee
            tb_lastname.Text = employee.LastName;
            tb_firstname.Text = employee.FirstName;
            tb_role.Text = employee.Role;
            Job job = employee.Job;
            if (job != null)
            {
                switch (job.Name)
                {
                    case "FullTime": 
                        {
                            timestart_shift = new TimeSpan(7, 0, 0);
                            timeend_shift = new TimeSpan(22, 0, 0);
                            tb_jobname.Text = "Từ 7h00 đến 22h00 (" + job.Name + ")";
                            lb_timestart.Text = "07:00";
                            lb_timeend.Text = "22:00";
                            break;
                        }
                    case "Morning Shift":
                        {
                            timestart_shift = new TimeSpan(7, 0, 0);
                            timeend_shift = new TimeSpan(11, 30, 0);
                            tb_jobname.Text = "Từ 7h00 đến 11h30 (" + job.Name + ")";
                            lb_timestart.Text = "07:00";
                            lb_timeend.Text = "11:30";
                            break;
                        }
                    case "Afternoon Shift":
                        {
                            timestart_shift = new TimeSpan(12, 30, 0);
                            timeend_shift = new TimeSpan(17, 0, 0);
                            tb_jobname.Text = "Từ 12h30 đến 17h00 (" + job.Name + ")";
                            lb_timestart.Text = "12:30";
                            lb_timeend.Text = "17:00";
                            break;
                        }
                    case "Night Shift":
                        {
                            timestart_shift = new TimeSpan(17, 0, 0);
                            timeend_shift = new TimeSpan(22,0,0);
                            tb_jobname.Text = "Từ 17h00 đến 22h00 (" + job.Name + ")";
                            lb_timestart.Text = "17:00";
                            lb_timeend.Text = "22:00";
                            break;
                        } 
                }
            }

            // Setup Time Online
            timer_online.Start();
            // Setup TimeKeeping
            TimeKeeping_Check();
            Update_bt_timekeeping();
            timer_timekeeping.Start();
        }

        public TimeSpan Checkout;
        public void TimeKeeping_Check()
        {
            List<EmployeeTimekeeping> emp_timekeeping = gs_context.EmployeeTimekeeping
                .Include(e => e.Employee) // Bao gồm thông tin về Employee
                .Include(e => e.Timekeeping) // Bao gồm thông tin về Timekeeping
                .ToList();

            foreach (EmployeeTimekeeping e in emp_timekeeping)
            {
                if (e.EmployeeId == employee.EmployeeId)
                {
                    if (e.Timekeeping.Checkin.HasValue && e.Timekeeping.Checkin.Value.Date == DateTime.Now.Date)
                    {
                        if (e.Timekeeping.Checkin.Value.TimeOfDay > timestart_shift)
                        {
                            time_delay = e.Timekeeping.Checkin.Value.TimeOfDay - timestart_shift;
                            delay_state = true;
                        }
                        timekeeping_state = true;
                        lb_status.ForeColor = Color.Gold;
                        lb_status.Text = "Đang chấm công!";
                        if (e.Timekeeping.Checkout.HasValue)
                        {
                            finish = true;
                            Checkout = e.Timekeeping.Checkout.Value.TimeOfDay;
                            lb_status.ForeColor = Color.Green;
                            lb_status.Text = "Đã chấm công ca làm hôm nay!";

                        }
                    }
                }
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            panel_delay_timekeeping.Size = new Size(0, 50);
            panel_delay_timekeeping.BackColor = Color.Red;
            panel_delay_timekeeping.Location = new Point(-1, 0);
            panel_shift.Controls.Add(panel_delay_timekeeping);
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
                    string filename = employee_imgpath + employee.EmployeeId.ToString() + "-" + employee.FirstName + ".png";
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

        private void timer_timekeeping_Tick(object sender, EventArgs e)
        {
            Timekeeping_lineupdate();
        }

        public bool panel_reset_state = false;
        public void reset_panelstate()
        {
            if (!panel_reset_state)
            {
                panel_ready.Size = new Size(0, 0);
                panel_inshift.Size = new Size(0, 0);
                panel_endshift.Size = new Size(0, 0);
                panel_ready.GradientBottomLeft = Color.SeaGreen;
                panel_ready.GradientBottomRight = Color.SeaGreen;
                panel_ready.GradientTopLeft = Color.PaleGreen;
                panel_ready.GradientTopRight = Color.PaleGreen;

                panel_inshift.GradientBottomLeft = Color.Yellow;
                panel_inshift.GradientBottomRight = Color.Yellow;
                panel_inshift.GradientTopLeft = Color.LemonChiffon;
                panel_inshift.GradientTopRight = Color.OldLace;

                panel_endshift.GradientBottomLeft = Color.Orange;
                panel_endshift.GradientBottomRight = Color.Orange;
                panel_endshift.GradientTopLeft = Color.NavajoWhite;
                panel_endshift.GradientTopRight = Color.AntiqueWhite;
            } 
            panel_reset_state = true;
        }

        public Panel panel_delay_timekeeping = new Panel();


        public void Timekeeping_lineupdate()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (finish == false)
            {
                if ((now > timeend_shift.Add(TimeSpan.FromMinutes(30)) || now < timestart_shift.Subtract(TimeSpan.FromMinutes(30))))
                {
                    lb_status.ForeColor = Color.Red;
                    lb_status.Text = "Đã qua hoặc chưa đến ca của bạn!";
                    panel_ready.Size = new Size(200, 50);
                    panel_inshift.Size = new Size(1225, 50);
                    panel_endshift.Size = new Size(200, 50);
                    panel_inshift.GradientBottomLeft = Color.Red;
                    panel_inshift.GradientBottomRight = Color.Red;
                    panel_inshift.GradientTopLeft = Color.Red;
                    panel_ready.GradientBottomLeft = Color.Red;
                    panel_ready.GradientBottomRight = Color.Red;
                    panel_ready.GradientTopLeft = Color.Red;
                    panel_endshift.GradientBottomLeft = Color.Red;
                    panel_endshift.GradientBottomRight = Color.Red;
                    panel_endshift.GradientTopLeft = Color.Red;
                    panel_reset_state = false;
                }
                else
                {
                    reset_panelstate();
                    if (now >= timestart_shift.Subtract(TimeSpan.FromMinutes(30)) && now < timestart_shift)
                    {
                        lb_status.ForeColor = Color.Green;
                        lb_status.Text = "Chuẩn bị vào ca";
                        double second = (now - timestart_shift.Subtract(TimeSpan.FromMinutes(30))).TotalSeconds;
                        int width = (int)(second * panel_rootready.Size.Width / 1800);
                        panel_ready.Size = new Size(width, 50);
                        return;
                    }
                    if (now >= timestart_shift && now <= timeend_shift)
                    {
                        panel_ready.Size = new Size(200, 50);
                        double second = (now - timestart_shift).TotalSeconds;
                        int width = (int)(second * panel_shift.Size.Width / (timeend_shift.TotalSeconds - timestart_shift.TotalSeconds));
                        if (timekeeping_state == false)
                        {
                            panel_inshift.Location = new Point(width + 1, 0);
                            panel_delay_timekeeping.Size = new Size(width, 50);
                            panel_delay_timekeeping.Location = new Point(0, 0);
                            lb_status.ForeColor = Color.Red;
                            lb_status.Text = "Trễ " + ((int)(now - timestart_shift).TotalMinutes).ToString() + " phút!";
                        }
                        else
                        {
                            double second2 = time_delay.TotalSeconds;
                            int width2 = (int)(second2 * panel_shift.Size.Width / (timeend_shift.TotalSeconds - timestart_shift.TotalSeconds));
                            lb_status.ForeColor = Color.Gold;
                            lb_status.Text = "Đang chấm công!";
                            if (delay_state == true)
                            {
                                panel_inshift.Location = new Point(width2 + 1, 0);
                                panel_delay_timekeeping.Location = new Point(0, 0);
                                panel_delay_timekeeping.Size = new Size(width2, 50);
                            }
                            panel_inshift.Location = new Point(width2 + 1, 0);
                            panel_inshift.Size = new Size(width - width2, 50);
                        }
                        return;
                    }
                    if (now > timeend_shift && now <= timeend_shift.Add(TimeSpan.FromMinutes(30)))
                    {
                        int width_shift = panel_shift.Size.Width;
                        double second2 = time_delay.TotalSeconds;
                        int width2 = (int)(second2 * panel_shift.Size.Width / (timeend_shift.TotalSeconds - timestart_shift.TotalSeconds));
                        if (delay_state == true)
                        {
                            panel_inshift.Location = new Point(width2 + 1, 0);
                            panel_delay_timekeeping.Location = new Point(0, 0);
                            panel_delay_timekeeping.Size = new Size(width2, 50);
                        }
                        panel_inshift.Location = new Point(width2 + 1, 0);
                        panel_inshift.Size = new Size(width_shift - width2, 50);

                        lb_status.ForeColor = Color.Gold;
                        lb_status.Text = "Sắp hết ca!";
                        double second = (now - timeend_shift).TotalSeconds;
                        int width = (int)(second * panel_rootendshift.Size.Width / 3600);
                        panel_endshift.Size = new Size(width, 50);


                    }
                }
            } else
            {
                lb_status.ForeColor = Color.Green;
                lb_status.Text = "Đã chấm công ca làm hôm nay!";
                panel_ready.Size = new Size(200, 50);
                double second2 = time_delay.TotalSeconds;
                int width2 = (int)(second2 * panel_shift.Size.Width / (timeend_shift.TotalSeconds - timestart_shift.TotalSeconds));
                
                double second = Checkout.TotalSeconds - timestart_shift.TotalSeconds;
                int width = (int)(second * panel_shift.Size.Width / (timeend_shift.TotalSeconds - timestart_shift.TotalSeconds));
                
                if (delay_state == true)
                {
                    panel_delay_timekeeping.Location = new Point(0, 0);
                    panel_delay_timekeeping.Size = new Size(width2, 50);
                }
                panel_inshift.Location = new Point(width2 + 1, 0);
                panel_inshift.Size = new Size(width - width2, 50);
                panel_endshift.Size = new Size(200, 50);
            }
        }

        public void Update_bt_timekeeping()
        {
            if (finish == false)
            {
                if (timekeeping_state == true)
                {
                    bt_timekeeping.BackColor = Color.OrangeRed;
                    lb_timekeeping.Text = "Kết thúc chấm công";
                }
                else
                {
                    bt_timekeeping.BackColor = Color.MediumSeaGreen;
                    lb_timekeeping.Text = " Bắt đầu chấm công";
                }
            } else
            {
                bt_timekeeping.BackColor = Color.MediumSeaGreen;
                lb_timekeeping.Text = "             Xem         ";
            }
            
        }

        public void Update_TimeKeeping_Checkout()
        {
            List<EmployeeTimekeeping> emp_timekeeping = gs_context.EmployeeTimekeeping
                .Include(e => e.Employee) // Bao gồm thông tin về Employee
                .Include(e => e.Timekeeping) // Bao gồm thông tin về Timekeeping
                .ToList();

            foreach (EmployeeTimekeeping e in emp_timekeeping)
            {
                if (e.EmployeeId == employee.EmployeeId)
                {
                    if (e.Timekeeping.Checkin.HasValue && e.Timekeeping.Checkin.Value.Date == DateTime.Now.Date)
                    {
                        if (!e.Timekeeping.Checkout.HasValue)
                        {
                            e.Timekeeping.Checkout = DateTime.Now;
                            Checkout = DateTime.Now.TimeOfDay;
                            finish = true;
                            break;
                        }
                    }
                }
            }

            gs_context.SaveChanges();
        }

        private void bt_timekeeping_Click(object sender, EventArgs e)
        {
            if (finish == false)
            {
                if (timekeeping_state == true)
                {
                    try
                    {
                        Update_TimeKeeping_Checkout();
                        Update_bt_timekeeping();
                    }
                    catch
                    {
                        MessageBox.Show("Đã có lỗi xảy ra!");
                    }

                }
                else
                {
                    try
                    {
                        Timekeeping timekeeping = new Timekeeping
                        {
                            Checkin = DateTime.Now
                        };
                        gs_context.Timekeeping.Add(timekeeping);
                        gs_context.SaveChanges();
                        EmployeeTimekeeping emp_time = new EmployeeTimekeeping
                        {
                            EmployeeId = employee.EmployeeId,
                            TimekeepingId = timekeeping.TimekeepingId
                        };
                        gs_context.EmployeeTimekeeping.Add(emp_time);
                        gs_context.SaveChanges();
                        TimeKeeping_Check();
                    }
                    catch
                    {
                        MessageBox.Show("Đã có lỗi xảy ra! ");
                    }

                }
            } else
            {
                string notice = "Thời gian online: " + tb_timeonline.Text + "\n";
                notice += "Thời gian làm việc: " + Math.Round(Checkout.TotalHours - time_delay.TotalHours - timestart_shift.TotalHours,1).ToString() + " Giờ\n";
                if (delay_state == true)
                {
                    notice += "Thời gian trễ ca: " + Math.Round(time_delay.TotalMinutes,1).ToString() + " Phút";
                }
                MessageBox.Show(notice,"Tổng kết!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
