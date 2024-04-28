using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;



namespace grocery_store.GUI.BanHang
{
    public partial class PayUC : UserControl
    {
        public event EventHandler OKClick;
        public event EventHandler CancelClick;
        public Image Image
        {
            get { return pictureBox_QR.Image; }
            set { pictureBox_QR.Image = value; }
        }

        public PayUC(Image image, List<Item> items, string paymentMethod)
        {
            InitializeComponent();

            this.Image = image;
            this.btn_OK.Click += (sender, e) => OKClick?.Invoke(this, e);
            this.btn_Cancel.Click += (sender, e) => CancelClick?.Invoke(this, e);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetItem", items));

            ReportParameter employeeNameParam = new ReportParameter();
            employeeNameParam.Name = "EmployeeName";
            employeeNameParam.Values.Add("Lương Vũ Đình Duy");
            reportViewer.LocalReport.SetParameters(employeeNameParam);

            ReportParameter paymentMethodParam = new ReportParameter();
            paymentMethodParam.Name = "PaymentMethod";
            paymentMethodParam.Values.Add(paymentMethod);
            reportViewer.LocalReport.SetParameters(paymentMethodParam);

            ReportParameter orderDate = new ReportParameter();
            orderDate.Name = "OrderDate";
            orderDate.Values.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            reportViewer.LocalReport.SetParameters(orderDate);

            reportViewer.RefreshReport();
            
        }
    }
}
