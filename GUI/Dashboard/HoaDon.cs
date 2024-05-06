using grocery_store.GUI.HoaDon;
using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace grocery_store.GUI.Dashboard
{
    public partial class HoaDon : UserControl
    {
        GroceryStoreContext db = new GroceryStoreContext();
        private int selectedInvoiceId = 0;
        public HoaDon()
        {
            InitializeComponent();
        }

        private async void HoaDon_Load(object sender, EventArgs e)
        {
            await loadDataGridView();
        }

        private async Task loadDataGridView()
        {
            
            
            DataTable invoiceTable = new DataTable();
            invoiceTable.Columns.Add("ShopOrderId", typeof(int));
            invoiceTable.Columns.Add("OrderDate", typeof(string));
            invoiceTable.Columns.Add("SubTotal", typeof(string));
            invoiceTable.Columns.Add("PaymentMethod", typeof(string));
            invoiceTable.Columns.Add("NameEmp", typeof(string));

            List<ViewInvoice> invoiceList = await db.ViewInvoice.ToListAsync();
            invoiceList = invoiceList.GroupBy(x => x.ShopOrderId).Select(x => x.First()).ToList();
            foreach (ViewInvoice invoice in invoiceList)
            {
                invoiceTable.Rows.Add(invoice.ShopOrderId,invoice.FormattedOrderDate, invoice.FormattedSubTotal, invoice.PaymentMethod, invoice.NameEmp);
            }
            gridview_invoice.DataSource = invoiceTable;
        }

        private void gridview_invoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int shopOrderId = Convert.ToInt32(gridview_invoice.Rows[e.RowIndex].Cells[0].Value);
            showInvoice(shopOrderId);
        }

        private void showInvoice(int shopOrderId)
        {
            Bill bill = new Bill(shopOrderId);
            this.Controls.Add(bill);
            bill.Location = new Point(180, 0);
            bill.BringToFront();
            bill.Visible = true;
            bill.CloseClick += (sender, e) =>
            {
                this.Controls.Remove(bill);
                bill.Dispose();
            };
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            int shopOrderId = Convert.ToInt32(gridview_invoice.Rows[selectedInvoiceId].Cells[0].Value);
            showInvoice(shopOrderId);
        }

        private void gridview_invoice_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedInvoiceId = e.RowIndex;
        }

        private async void btn_search_Click(object sender, EventArgs e)
        {
            string searchValue = input_search.Text;
            if (searchValue != "")
            {
                DataTable invoiceTable = new DataTable();

                if (invoiceTable != null)
                {
                    invoiceTable.Clear();
                }

                invoiceTable.Columns.Add("ShopOrderId", typeof(int));
                invoiceTable.Columns.Add("OrderDate", typeof(string));
                invoiceTable.Columns.Add("SubTotal", typeof(string));
                invoiceTable.Columns.Add("PaymentMethod", typeof(string));
                invoiceTable.Columns.Add("NameEmp", typeof(string));

                List<ViewInvoice> invoiceList = db.ViewInvoice.ToList();
                invoiceList = invoiceList.GroupBy(x => x.ShopOrderId).Select(x => x.First()).ToList();

                foreach (ViewInvoice invoice in invoiceList)
                {
                    if (invoice.PaymentMethod.ToLower().Contains(searchValue.ToLower()) || invoice.NameEmp.ToLower().Contains(searchValue.ToLower()) || invoice.OrderDate.ToString("dd/MM/yyyy HH:mm:ss").Contains(searchValue) || invoice.ShopOrderId.ToString().Contains(searchValue))
                    {
                        invoiceTable.Rows.Add(invoice.ShopOrderId, invoice.FormattedOrderDate, invoice.FormattedSubTotal, invoice.PaymentMethod, invoice.NameEmp);
                    }
                }

                gridview_invoice.DataSource = invoiceTable;
            }
            else
            {
                await loadDataGridView();
            }
        }
    }
}
