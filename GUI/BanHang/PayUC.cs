using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public PayUC(Image image)
        {
            InitializeComponent();
            this.Image = image;
            this.btn_OK.Click += (sender, e) => OKClick?.Invoke(this, e);
            this.btn_Cancel.Click += (sender, e) => CancelClick?.Invoke(this, e);
        }
    }
}
