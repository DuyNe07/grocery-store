using grocery_store.GUI.BanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using grocery_store.Models;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Threading;

namespace grocery_store.GUI.Dashboard
{
    public partial class BanHang : UserControl
    {
        List<Item> items = new List<Item>();
        GroceryStoreContext db = new GroceryStoreContext();
        public event EventHandler ButtonClick;

        public BanHang()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            panel_products.Controls.Clear();
            int y_start = 30;
            foreach (Item item in items)
            {
                item.Location = new Point(70, y_start);
                item.BackColor = Color.White;

                panel_products.Controls.Add(item);
                y_start += 90;
            }
        }

        // Thêm biến này vào lớp của bạn
        private VideoCaptureDevice FinalFrame = null;
        private CancellationTokenSource cancellationTokenSource;

        private async void btn_scan_Click(object sender, EventArgs e)
        {
            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                FinalFrame.SignalToStop();
                FinalFrame.WaitForStop();
                FinalFrame = null;
                this.pictureBox_ScanCode.Visible = false;
                return;
            }

            this.pictureBox_ScanCode.Visible = true;
            this.pictureBox_ScanCode.BringToFront();
            cancellationTokenSource = new CancellationTokenSource();
            await ScanBarcodeAsync(cancellationTokenSource.Token);
        }

        private async Task ScanBarcodeAsync(CancellationToken cancellationToken)
        {
            this.pictureBox_ScanCode.Visible = true;
            FilterInfoCollection CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            FinalFrame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(async (s, eventArgs) =>
            {
                this.pictureBox_ScanCode.Image = (Bitmap)eventArgs.Frame.Clone();
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode((Bitmap)eventArgs.Frame.Clone());
                if (result != null)
                {
                    this.Invoke((MethodInvoker)delegate {
                        this.pictureBox_ScanCode.Visible = false;
                    });
                    MessageBox.Show(result.Text);
                    FinalFrame.SignalToStop();
                    FinalFrame.WaitForStop();
                    FinalFrame = null;
                    cancellationTokenSource.Cancel();
                    return;
                }
                await Task.Delay(1);
            });
            FinalFrame.Start();
            await Task.Delay(-1, cancellationToken);
        }

        private async void updateTotal()
        {
            int total = await Task.Run(() => CalculateTotal());
            UpdateUITotal(total);
        }

        private int CalculateTotal()
        {
            int total = 0;
            foreach (Item item in items)
            {
                string priceWithoutSeparators = item.Price.Replace(".", "");
                total += int.Parse(priceWithoutSeparators) * int.Parse(item.Quantity);
            }
            return total;
        }

        private void UpdateUITotal(int total)
        {
            // Kiểm tra xem có cần chuyển sang luồng giao diện người dùng không nếu có thì chuyển
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<int>(UpdateUITotal), total);
                return;
            }

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
            string formattedTotal = total.ToString("N0");

            label_totalPrice.Text = formattedTotal;
            label_totalPrice.Location = new Point(1075 - label_totalPrice.Width / 2, 763);
        }


        private void btn_enterCode_Click(object sender, EventArgs e)
        {
            if(txtbox_enterCode.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm");
                return;
            }
            else
            {
                Product product = db.Product.Where(p => p.Sku == txtbox_enterCode.Text).FirstOrDefault();
                if (product == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm");
                    return;
                }
                else
                {
                    //kiểm tra xem sản phẩm đã có trong danh sách chưa nếu có thì cộng dồn số lượng
                    foreach (Item i in items)
                    {
                        if (i.NameProduct == product.Name)
                        {
                            int quantity = int.Parse(i.Quantity);
                            quantity += 1;
                            i.Quantity = quantity.ToString();
                            return;
                        }
                    }
                    Item item = new Item(product);
                    item.label_price.Location = new Point(590 - (item.label_price.Width / 2), 35);
                    item.ButtonClick += async (s, args) =>
                    {
                        items.Remove(item);
                        refresh();
                        updateTotal();
                    };
                    item.QuantityChanged += (s, args) =>
                    {
                        updateTotal();
                    };
                    items.Add(item);
                    updateTotal();
                    refresh();
                }
            }
        }
    }
}
