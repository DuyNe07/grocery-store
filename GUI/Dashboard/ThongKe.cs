using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI.Dashboard
{
    public partial class ThongKe : UserControl
    {
        GroceryStoreContext db = new GroceryStoreContext();
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VI");
        private float totalThisMonth = 0;
        private float totalLastMonth = 0;
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            loadPanel();
            loadDataPieChart();
            loadDataChart(input_dateStart.Value, input_dateEnd.Value);
        }

        #region Panel
        private void loadPanel()
        {
            List<ShopOrder> list = db.ShopOrder.Include("OrderLine").Include("OrderLine.Product").ToList();

            loadRenueve(list);
            loadNumOrder(list);
            loadProfit(list);
        }

        private void loadRenueve(List<ShopOrder> list)
        {
            float totalThisMonth = 0;
            float totalLastMonth = 0;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            foreach (var item in list)
            {
                if (item.OrderDate.Month == month && item.OrderDate.Year == year)
                {
                    totalThisMonth += (float)item.SubTotal;
                }
                if (item.OrderDate.Month == month - 1 && item.OrderDate.Year == year)
                {
                    totalLastMonth += (float)item.SubTotal;
                }
            }
            int increase = (int)Math.Round((totalThisMonth - totalLastMonth) / totalLastMonth * 100);

            if (increase < 0)
            {
                label_increase_revenue.ForeColor = Color.Red;
                label_increase_revenue.Text = "↘" + increase.ToString("N0", culture) + "%";
            }
            else
            {
                label_increase_revenue.ForeColor = Color.Green;
                label_increase_revenue.Text = "↗" + increase.ToString("N0", culture) + "%";
            }
            label_increase_revenue.Location = new Point(label2.Location.X - label_increase_revenue.Width, label_increase_revenue.Location.Y);
            label_revenue.Text = totalThisMonth.ToString("N0", culture);
            label_revenue.Location = new Point(header_renueve.Location.X + header_renueve.Width - label_revenue.Width, label_revenue.Location.Y);
            this.totalThisMonth = totalThisMonth;
            this.totalLastMonth = totalLastMonth;
        }

        private void loadNumOrder(List<ShopOrder> list)
        {
            float totalThisMonth = 0;
            float totalLastMonth = 0;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            foreach (var item in list)
            {
                if (item.OrderDate.Month == month && item.OrderDate.Year == year)
                {
                    totalThisMonth += 1;
                }
                if (item.OrderDate.Month == month - 1 && item.OrderDate.Year == year)
                {
                    totalLastMonth += 1;
                }
            }
            int increase = (int)Math.Round((totalThisMonth - totalLastMonth) / totalLastMonth * 100);
            if (increase < 0)
            {
                label_increase_numOrder.ForeColor = Color.Red;
                label_increase_numOrder.Text = "↘" + increase.ToString("N0", culture) + "%";
            }
            else
            {
                label_increase_numOrder.ForeColor = Color.Green;
                label_increase_numOrder.Text = "↗" + increase.ToString("N0", culture) + "%";
            }
            label_increase_numOrder.Location = new Point(label5.Location.X - label_increase_numOrder.Width, label_increase_numOrder.Location.Y);
            label_numOfOrder.Text = totalThisMonth.ToString("N0", culture);
            label_numOfOrder.Location = new Point(header_numOrder.Location.X + header_numOrder.Width - label_numOfOrder.Width, label_numOfOrder.Location.Y);
        }

        private void loadProfit(List<ShopOrder> orders)
        {
            float incomePricethisMonth = 0;
            float incomePricelastMonth = 0;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            foreach (ShopOrder shopOrder in orders)
            {
                if (shopOrder.OrderDate.Month == month && shopOrder.OrderDate.Year == year)
                {
                    foreach (Product product in shopOrder.OrderLine.Select(x => x.Product))
                    {
                        incomePricethisMonth += (float)product.CostPrice;
                    }
                }
                if (shopOrder.OrderDate.Month == month - 1 && shopOrder.OrderDate.Year == year)
                {
                    foreach (Product product in shopOrder.OrderLine.Select(x => x.Product))
                    {
                        incomePricelastMonth += (float)product.CostPrice;
                    }
                }
            }
            float profitthisMonth = totalThisMonth - incomePricethisMonth;
            float profitlastMonth = totalLastMonth - incomePricelastMonth;

            int increase = (int)Math.Round((profitthisMonth - profitlastMonth) / profitlastMonth * 100);

            label_profit.Text = profitthisMonth.ToString("N0", culture);
            label_profit.Location = new Point(header_profit.Location.X + header_profit.Width - label_profit.Width, label_profit.Location.Y);

            if (increase < 0)
            {
                label_increase_profit.ForeColor = Color.Red;
                label_increase_profit.Text = "↘" + increase.ToString("N0", culture) + "%";
            }
            else
            {
                label_increase_profit.ForeColor = Color.Green;
                label_increase_profit.Text = "↗" + increase.ToString("N0", culture) + "%";
            }
            label_increase_profit.Location = new Point(label2.Location.X - label_increase_profit.Width, label_increase_profit.Location.Y);

        }
        #endregion


        #region PieChart
        private void loadDataPieChart()
        {
            var data = db.ViewStatistical.ToList();
            this.reportViewer.LocalReport.DataSources.Clear();
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetViewStatistical", data));
            this.reportViewer.RefreshReport();
        }

        #endregion

        #region DataChart
        private void loadDataChart(DateTime startDate, DateTime endDate)
        {
            var oldDataSource = this.reportViewer.LocalReport.DataSources.FirstOrDefault(ds => ds.Name == "DataSetRevenueTime");
            if (oldDataSource != null)
            {
                this.reportViewer.LocalReport.DataSources.Remove(oldDataSource);
            }
            var result = db.Set<RevenueTime>().FromSqlRaw("SELECT * FROM FUNC_RevenueTime({0},{1})", startDate, endDate).ToList();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("OrderDate", typeof(DateTime));
            dataTable.Columns.Add("Revenue", typeof(decimal));
            dataTable.Columns.Add("SubTotal", typeof(decimal));
            dataTable.Columns.Add("ProductName", typeof(string));
            dataTable.Columns.Add("MonthYear", typeof(string));

            foreach (var item in result)
            {
                dataTable.Rows.Add(item.OrderDate, item.Revenue, item.SubTotal, item.ProductName, item.MonthYear);
            }

            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetRevenueTime", dataTable));
            this.reportViewer.RefreshReport();
        }

        private void input_dateStart_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (input_dateStart.Value < input_dateEnd.Value)
            {
                loadDataChart(input_dateStart.Value, input_dateEnd.Value);
            }
            else
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void input_dateStart_Validated(object sender, EventArgs e)
        {
            if(input_dateStart.Value > input_dateEnd.Value)
            {
                input_dateStart.Value = input_dateEnd.Value - new TimeSpan(360, 0, 0);
            }
        }

        private void input_dateEnd_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (input_dateStart.Value < input_dateEnd.Value)
            {
                loadDataChart(input_dateStart.Value, input_dateEnd.Value);
            }
            else
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void input_dateEnd_Validated(object sender, EventArgs e)
        {
            if (input_dateStart.Value > input_dateEnd.Value)
            {
                input_dateStart.Value = input_dateEnd.Value - new TimeSpan(360, 0, 0);
            }
        }

        #endregion
    }
}
