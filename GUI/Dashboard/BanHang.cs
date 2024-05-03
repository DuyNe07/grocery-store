using AForge.Video;
using AForge.Video.DirectShow;
using grocery_store.GUI.BanHang;
using grocery_store.GUI.HoaDon;
using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace grocery_store.GUI.Dashboard
{
    public partial class BanHang : UserControl
    {
        #region Biến cần thiết
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VI");
        List<Item> items = new List<Item>();
        GroceryStoreContext db = new GroceryStoreContext();
        private VideoCaptureDevice FinalFrame = null;
        private CancellationTokenSource cancellationTokenSource;
        #endregion

        public BanHang()
        {
            InitializeComponent();
        }

        #region Event Control
        // INFO : Sự kiện khi nhấn nút quét mã vạch
        private void btn_scan_Click(object sender, EventArgs e)
        {
            ScanBarCode scanBarCode = new ScanBarCode();
            this.Controls.Add(scanBarCode);
            scanBarCode.BringToFront();
            scanBarCode.Location = new Point(0, 0);
            scanBarCode.CancelClick += (s, args) =>
            {
                scanBarCode.StopWebcam();
                scanBarCode.Dispose();
                this.Controls.Remove(scanBarCode);
            };
            scanBarCode.ScanBarCodeAsync().ContinueWith((task) =>
            {
                string barcode = task.Result;
                addItem(barcode);
                scanBarCode.StopWebcam();
                this.Controls.Remove(scanBarCode);
            });
            //if (FinalFrame != null && FinalFrame.IsRunning)
            //{
            //    FinalFrame.SignalToStop();
            //    FinalFrame.WaitForStop();
            //    FinalFrame = null;
            //    this.pictureBox_ScanCode.Visible = false;
            //    return;
            //}

            //this.pictureBox_ScanCode.Visible = true;
            //this.pictureBox_ScanCode.BringToFront();
            //this.pictureBox_ScanCode.Location = new Point(100, 100);
            //cancellationTokenSource = new CancellationTokenSource();

            //// Khởi chạy webcam ở luồng chính
            //this.pictureBox_ScanCode.Visible = true;
            //FilterInfoCollection CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //FinalFrame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);
            //FinalFrame.NewFrame += new NewFrameEventHandler(async (s, eventArgs) =>
            //{
            //    Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            //    frame.RotateFlip(RotateFlipType.RotateNoneFlipX);
            //    this.pictureBox_ScanCode.Image = frame;
            //    BarcodeReader reader = new BarcodeReader();
            //    var result = reader.Decode((Bitmap)eventArgs.Frame.Clone());

            //    // Khi phát hiện ra mã vạch
            //    if (result != null)
            //    {
            //        // Khởi chạy 1 luồng mới để chạy ZXing nhận dạng mã vạch
            //        string barcode = await Task.Run(() => result.Text);

            //        // Dừng luồng webcam
            //        FinalFrame.SignalToStop();
            //        FinalFrame.WaitForStop();
            //        FinalFrame = null;
            //        cancellationTokenSource.Cancel();

            //        // Dừng webcam và thêm sản phẩm vào danh sách
            //        this.Invoke((MethodInvoker)delegate
            //        {
            //            this.pictureBox_ScanCode.Visible = false;
            //            addItem(barcode);
            //        });

            //        return;
            //    }
            //    await Task.Delay(1);
            //});
            //FinalFrame.Start();
        }

        // INFO : Sự kiện khi nhấn nút xác nhận
        private void btn_enterCode_Click(object sender, EventArgs e)
        {
            if (X.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                addItem(X.Text);
            }
        }

        private async void btn_pay_Click(object sender, EventArgs e)
        {
            if (items.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào giỏ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int pay = comboBox_paymentMethod.SelectedIndex + 1;
            Payment payment = await db.Payment.FirstOrDefaultAsync(p => p.PaymentId == pay);

            if (payment == null)
            {
                MessageBox.Show("Phương thức thanh toán không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await updateBarCode();
            PayUC payUC = new PayUC(Image.FromStream(new System.IO.MemoryStream(payment.Qr)), 
                items, payment.Name, "Lương Vũ Đình Duy");
            payUC.Location = new Point(150, 100);
            payUC.OKClick += async (s, args) =>
            {
                await UpdateOrder(payment);
                items.Clear();
                this.Controls.Remove(payUC);
                refresh();
                updateTotal();
                comboBox_paymentMethod.SelectedIndex = -1;
            };
            payUC.CancelClick += (s, args) =>
            {
                payUC.Dispose();
                this.Controls.Remove(payUC);
            };
            this.Controls.Add(payUC);
            payUC.BringToFront();
        }

        private async Task updateBarCode()
        {
            foreach (Item item in items)
            {
                item.generate_barcode();
            }
        }

        #endregion

        #region Tính tổng tiền của đơn

        // INFO : Cập nhật tổng tiền
        private async void updateTotal()
        {
            int total = await Task.Run(() => CalculateTotal());
            UpdateUITotal(total);
        }

        // INFO : Tính tổng tiền trên luồng khác
        private int CalculateTotal()
        {
            int total = 0;
            foreach (Item item in items)
            {
                int price = int.Parse(item.Price.Replace(".", ""));
                int quantity = item.Quantity;
                total += price * quantity;
            }
            return total;
        }


        // INFO : Cập nhật giao diện tổng tiền 
        private void UpdateUITotal(int total)
        {
            // Kiểm tra xem có cần chuyển sang luồng giao diện người dùng không nếu có thì chuyển
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<int>(UpdateUITotal), total);
                return;
            }
            string formattedTotal = total.ToString("N0", culture);

            label_totalPrice.Text = formattedTotal;
            label_totalPrice.Location = new Point(1075 - label_totalPrice.Width / 2, 763);
        }

        #endregion

        #region Danh sách item
        // INFO : Cập nhật lại giao diện
        private void refresh()
        {
            panel_products.Controls.Clear();
            int y_start = 30;
            foreach (Item item in items)
            {
                item.Location = new Point(70, y_start);
                item.BackColor = Color.White;
                updateUnitPrice();
                item.label_marketPrice.Location = new Point(490 - (item.label_totalLine.Width / 2), 35);
                panel_products.Controls.Add(item);
                y_start += 90;
            }
        }

        // INFO : Cập nhật đơn giá của từng sản phẩm
        private void updateUnitPrice()
        {
            foreach (Item item in items)
            {
                int quantity = item.Quantity;
                int marketPrice = int.Parse(item.label_marketPrice.Text.Replace(".", ""));
                int lineTotal = quantity * marketPrice;

                string formattedTotal = lineTotal.ToString("N0", culture);
                item.label_totalLine.Text = formattedTotal;
                item.label_totalLine.Location = new Point(715 - (item.label_totalLine.Width / 2), 35);
            }
        }


        #endregion

        #region Item
        // INFO : Kiểm tra Item và thêm Item vào danh sách
        private async void addItem(string productBarCode)
        {
            Product product = await db.Product
                .Include(p => p.ProductDetail)
                .Where(p => p.ProductDetail.Any(pd => pd.BarCode == productBarCode))
                .FirstAsync();

            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm");
                return;
            }
            
            //int quantityInStock = product.ProductDetail.First(pd => pd.BarCode == productBarCode).QuantityInStock;
            if (items.Any(i => i.NameProduct == product.Name))
            {
                var item = items.First(i => i.NameProduct == product.Name);
                if (!await CheckQuantityInStock(item))
                {
                    MessageBox.Show("Sản phẩm không đủ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                item.Quantity += 1;
            }
            else
            {
                Item newItem = new Item(product);
                newItem.inputBarCode = productBarCode;
                if (!await CheckQuantityInStock(newItem))
                {
                    MessageBox.Show("Sản phẩm không đủ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    newItem.Dispose();
                    return;
                }
                addEventItem(newItem);
                items.Add(newItem);
            }

            refresh();
            updateTotal();
        }

        // INFO : Thêm sự kiện cho Item
        private void addEventItem(Item item)
        {
            item.RemoveClick += async (s, args) =>
            {
                items.Remove(item);
                refresh();
                updateTotal();
            };

            item.QuantityChanged += async (s, args) =>
            {
                //INFO: Kiểm tra xem sản phẩm còn hàng không và cập nhật giá tiền

                if (item.Num_quantity.Text == "" || !int.TryParse(item.Num_quantity.Text, out int quantity) || item.Quantity < 0)
                {
                    item.Num_quantity.Text = "0";
                    return;
                }

                bool check = await CheckQuantityInStock(item);
                if (!check)
                {
                    MessageBox.Show("Sản phẩm không đủ hàng", "Thông báo",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    item.Quantity = 0;
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        updateUnitPrice();
                        updateTotal();
                    });
                }
            };
        }

        // INFO : Kiểm tra số lượng hàng còn trong kho
        private async Task<bool> CheckQuantityInStock(Item item)
        {
            ProductDetail productDetail = db.ProductDetail.First(pd => pd.BarCode == item.inputBarCode);

            return productDetail.QuantityInStock >= item.Quantity;
        }

        #endregion

        #region DataLayer

        private async Task UpdateOrder(Payment payment)
        {
            ShopOrder shopOrder = new ShopOrder();
            shopOrder.OrderDate = DateTime.Now;
            shopOrder.SubTotal = int.Parse(label_totalPrice.Text.Replace(".", ""));
            shopOrder.Payment = payment;

            Main main = (Main)this.Parent.Parent;
            // Modify this later
            shopOrder.EmployeeId = 17; //main.Employee.EmployeeId; 

            List<OrderLine> orderLines = await CreateOrderLinesAsync(shopOrder);
            shopOrder.OrderLine = orderLines;


            db.ShopOrder.Add(shopOrder);
            db.OrderLine.AddRange(orderLines);
            await db.SaveChangesAsync();
            await UpdateStockProduct();
        }
        private async Task<List<OrderLine>> CreateOrderLinesAsync(ShopOrder shopOrder)
        {
            List<OrderLine> orderLines = new List<OrderLine>();
            foreach (Item item in items)
            {
                OrderLine orderLine = new OrderLine();
                orderLine.Price = int.Parse(item.Price.Replace(".", "")) * int.Parse(item.Num_quantity.Value.ToString());
                orderLine.Product = await db.Product.FirstOrDefaultAsync(p => p.Name == item.NameProduct);
                orderLine.Quantity = item.Quantity;
                orderLine.ShopOrder = shopOrder;
                orderLines.Add(orderLine);
            }
            return orderLines;
        }

        private async Task UpdateStockProduct()
        {
            var productIds = items.Select(i => i.Product.ProductId).ToList();
            var products = await db.Product.Where(p => productIds.Contains(p.ProductId)).ToDictionaryAsync(p => p.ProductId, p => p);

            foreach (Item item in items)
            {
                ProductDetail productDetail = db.ProductDetail.First(pd => pd.BarCode == item.inputBarCode);
                productDetail.QuantityInStock -= item.Quantity;
                db.ProductDetail.Update(productDetail);
            }
            await db.SaveChangesAsync();
        }

        #endregion

        //private async void gunaButton1_Click_1(object sender, EventArgs e)
        //{
        //    if (this.Controls.ContainsKey("Bill"))
        //    {
        //        this.Controls.RemoveByKey("Bill");
        //        return;
        //    }
        //    Employee employee = await db.Employee.FindAsync(3);
        //    List<OrderLine> orderLines = await CreateOrderLinesAsync(new ShopOrder());
        //    Bill bill = new Bill(2);
        //    bill.Location = new Point(500, 200);
        //    bill.AutoSize = true;
        //    bill.AutoScroll = false;
        //    this.Controls.Add(bill);
        //    bill.BringToFront();
        //}
    }
}
