using grocery_store.Models;
using Microsoft.Reporting.WinForms;
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
    public partial class ThongKe : UserControl
    {
        GroceryStoreContext db = new GroceryStoreContext();
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VI");
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            using(GroceryStoreContext db = new GroceryStoreContext())
            {
                var data = db.ShopOrder.ToList();
                
                ReportDataSource rds = new ReportDataSource("DataSetShopOrder", data);
                this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.LocalReport.DataSources.Add(rds);
                this.reportViewer.RefreshReport();
                loadPanel();
            }
        }

        private void loadPanel()
        {
            List<ShopOrder> list = db.ShopOrder.ToList();

            loadRenueve(list);
            loadNumOrder(list);
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

    }
}
