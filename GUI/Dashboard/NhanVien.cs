using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI.Dashboard
{
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();

            employee = gs_context.Employee.Include(e => e.Job).ToList()[1];
            

            // Setup hình ảnh employee
            if (employee.Img == null)
            {
                ptb_emp.BackgroundImage = grocery_store.Properties.Resources.user_img;
            } else
            {
                using (MemoryStream ms = new MemoryStream(employee.Img))
                {
                    Image image = Image.FromStream(ms);

                    // Hiển thị hình ảnh trong PictureBox
                    ptb_emp.BackgroundImage = image;
                }
            }

            // Setup employee cùng ca
            panel_user_inshift.Controls.Clear();
            lb_number.Visible = false;
            List<Employee> employees = gs_context.Employee.Include(e => e.Job).ToList();
            int number = 0;
            int hidden = 0;
            foreach (Employee e in employees)
            {
                bool check = false;
                if (employee.Job.Name == "FullTime")
                {
                    check = true;
                }
                else if (e.Job.Name == employee.Job.Name || e.Job.Name == "FullTime")
                {
                    check = true;
                }
                if (e.EmployeeId == employee.EmployeeId)
                {
                    check = false;
                }
                if (check)
                {
                    if (number * 40 + 5 < 1365)
                    {
                        PictureBox uo = new PictureBox();
                        int size = panel_user_inshift.Size.Height;
                        uo.Size = new Size(size, size);
                        uo.Location = new Point(number * size + 40, 0);
                        if (e.Img == null)
                        {
                            uo.BackgroundImage = grocery_store.Properties.Resources.user_img;
                        }
                        else
                        {
                            using (MemoryStream ms = new MemoryStream(e.Img))
                            {
                                Image image = Image.FromStream(ms);

                                // Hiển thị hình ảnh trong PictureBox
                                uo.BackgroundImage = image;
                            }
                        }
                        uo.BackgroundImageLayout = ImageLayout.Stretch;
                        GunaElipse elip = new GunaElipse();
                        elip.TargetControl = uo;
                        elip.Radius = 140;
                        uo.Tag = "Họ tên: " + e.FirstName + " " + e.LastName + "\nCa làm: " + e.Job.Name;
                        uo.Click += uo_click;
                        uo.Cursor = Cursors.Hand;
                        panel_user_inshift.Controls.Add(uo);
                        number++;
                    }
                    else
                    {
                        hidden++;
                        lb_number.Visible = true;
                        lb_number.Text = "+" + hidden;
                    }

                }
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
                    Employee emp = gs_context.Employee.Find(employee.EmployeeId);
                    emp.Img = File.ReadAllBytes(filePath);
                    gs_context.SaveChanges();
                    using (MemoryStream ms = new MemoryStream(employee.Img))
                    {
                        Image image = Image.FromStream(ms);

                        // Hiển thị hình ảnh trong PictureBox
                        ptb_emp.BackgroundImage = image;
                    }
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



        public bool stop = false;
        public void Timekeeping_lineupdate()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (finish == false)
            {
                if ((now > timeend_shift.Add(TimeSpan.FromMinutes(30)) || now < timestart_shift.Subtract(TimeSpan.FromMinutes(30))))
                {
                    stop = true;
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
                    stop = false;
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
                    lb_timekeeping.Text = "        Kết thúc ca   ";
                }
                else
                {
                    bt_timekeeping.BackColor = Color.MediumSeaGreen;
                    lb_timekeeping.Text = "           Vào ca     ";
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
            if (finish == false && stop == false)
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
                if (stop==false)
                {
                    string notice = "Thời gian online: " + tb_timeonline.Text + "\n";
                    notice += "Thời gian làm việc: " + Math.Round(Checkout.TotalHours - time_delay.TotalHours - timestart_shift.TotalHours, 1).ToString() + " Giờ\n";
                    if (delay_state == true)
                    {
                        notice += "Thời gian trễ ca: " + Math.Round(time_delay.TotalMinutes, 1).ToString() + " Phút";
                    }
                    MessageBox.Show(notice, "Tổng kết!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Đã qua ca hoặc chưa đến ca của bạn!");
                }
                
            }
            Update_bt_timekeeping();
        }

        public DateTime startjob = new DateTime();
        public DateTime endnow = new DateTime();
        private async void NhanVien_Load(object sender, EventArgs e)
        {
            panel_delay_timekeeping.Size = new Size(0, 50);
            panel_delay_timekeeping.BackColor = Color.Red;
            panel_delay_timekeeping.Location = new Point(-1, 0);
            panel_shift.Controls.Add(panel_delay_timekeeping);

            Employee emp = await gs_context.Employee.Include(i => i.Job).Where(i => i.EmployeeId == employee.EmployeeId).FirstOrDefaultAsync();
            startjob = emp.Job.JoinDate;
            endnow = new DateTime();
            if (emp.Job.EndDate.HasValue)
            {
                endnow = emp.Job.EndDate.Value;
            }
            else { endnow = DateTime.Now; }

            for (int i = startjob.Year; i<= endnow.Year;i++)
            {
                cbb_year.Items.Add(i);
            }
            cbb_year.SelectedIndexChanged += cbb_year_SelectedIndexChanged;
            cbb_year.SelectedIndex = 0;

        }

        private void cbb_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_month.Items.Clear();
            int year = (int)cbb_year.SelectedIndex;
            if (startjob.Year != endnow.Year)
            {
                if (year == startjob.Year)
                {
                    for (int i = startjob.Month; i <= 12; i++)
                    {
                        cbb_month.Items.Add(i);
                    }
                }
                else
                {
                    for (int i = 1; i <= endnow.Month; i++)
                    {
                        cbb_month.Items.Add(i);
                    }
                }
            } else
            {
                for (int i = startjob.Month;i<= endnow.Month;i++)
                {
                    cbb_month.Items.Add(i);
                }
            }
            cbb_month.SelectedIndex = 0;
        }

        private async void cbb_month_SelectedValueChanged(object sender, EventArgs e)
        {
            List<EmployeeTimekeeping> employeetimekeepings = await gs_context.EmployeeTimekeeping.Include(et => et.Employee)
                .Include(et => et.Timekeeping)
                .Where(et => et.Employee.EmployeeId == employee.EmployeeId)
                .Where(et => et.Timekeeping.Checkin.Value.Month == (int)cbb_month.SelectedItem).ToListAsync();

            // Tạo một DataTable mới và đặt tên là "dt"
            DataTable dt = new DataTable();

            // Thêm các cột vào DataTable
            dt.Columns.Add("Date", typeof(string)); 
            dt.Columns.Add("Checkin", typeof(string)); 
            dt.Columns.Add("Checkoutt", typeof(string)); 
            dt.Columns.Add("DelayTime", typeof(string)); 
            dt.Columns.Add("TimeWork", typeof(string)); 
            dt.Columns.Add("Note", typeof(string));

            // Summary
            double total_worktime = 0;
            double total_delaytime = 0;


            for (int i = 1; i<= DateTime.DaysInMonth((int)cbb_year.SelectedItem,(int)cbb_month.SelectedItem);i++)
            {
                DateTime d = new DateTime((int)cbb_year.SelectedItem, (int)cbb_month.SelectedItem, i);
                string date = d.ToString("dd/MM/yyyy");
                string checkin = "";
                string checkout = "";
                string delaytime = "";
                string timework = "";
                string note = "Không đi làm";
                foreach (EmployeeTimekeeping emptime  in employeetimekeepings)
                {
                    if (emptime.Timekeeping.Checkin.Value.Day == i)
                    {
                        note = "";
                        checkin = emptime.Timekeeping.Checkin.Value.ToString("HH:mm:ss");
                        if (emptime.Timekeeping.Checkout.HasValue)
                        {
                            checkout = emptime.Timekeeping.Checkout.Value.ToString("HH:mm:ss");
                            timework = Math.Round((emptime.Timekeeping.Checkout.Value.TimeOfDay - emptime.Timekeeping.Checkin.Value.TimeOfDay).TotalHours,2) + " giờ";
                            total_worktime += (emptime.Timekeeping.Checkout.Value.TimeOfDay - emptime.Timekeeping.Checkin.Value.TimeOfDay).TotalHours;
                        } else
                        {
                            note += "Không kết thúc ca! ";
                        }
                        if (emptime.Timekeeping.Checkin.Value.TimeOfDay > timestart_shift)
                        {
                            delaytime = Math.Round((emptime.Timekeeping.Checkin.Value.TimeOfDay - timestart_shift).TotalMinutes,2).ToString() + " phút";
                            note += " Đi trễ!";
                            total_delaytime += (emptime.Timekeeping.Checkin.Value.TimeOfDay - timestart_shift).TotalMinutes;
                        }
                        break;
                    }
                }
                dt.Rows.Add(date, checkin, checkout, delaytime, timework, note);
            }
            dtgv_history.DataSource = dt;
            tb_worktime.Text = Math.Round(total_worktime, 2).ToString();
            tb_delaytime.Text = Math.Round(total_delaytime).ToString();
            tb_evaluate.Text = Math.Round((total_worktime / ((timeend_shift - timestart_shift).TotalHours * DateTime.DaysInMonth((int)cbb_year.SelectedItem, (int)cbb_month.SelectedItem)) * 3), 1).ToString() + "/3";
            tb_checksalary.Text = (24000 * Math.Round(total_worktime)).ToString();
        }
    }
}
