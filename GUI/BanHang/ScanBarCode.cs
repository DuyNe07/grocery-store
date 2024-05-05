using AForge.Video.DirectShow;
using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using grocery_store.Models;

namespace grocery_store.GUI.BanHang
{
    public partial class ScanBarCode : UserControl
    {
        private VideoCaptureDevice FinalFrame = null;
        public event EventHandler CancelClick;
        public ScanBarCode()
        {
            InitializeComponent();
            this.btn_cancel.Click += (sender, e) => CancelClick?.Invoke(this, e);
        }

        public async Task<string> ScanBarCodeAsync()
        {
            while (true)
            {
                string barcode = await Scan();
                if (checkProduct(barcode))
                {
                    return barcode;
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Task<string> Scan()
        {
            var tcs = new TaskCompletionSource<string>();

            FilterInfoCollection CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            FinalFrame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler((s, eventArgs) =>
            {
                Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
                frame.RotateFlip(RotateFlipType.RotateNoneFlipX);
                Bitmap frameForPictureBox = (Bitmap)frame.Clone();
                this.pictureBox_ScanCode.Image = frameForPictureBox;
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(frame);

                if (result != null)
                {
                    tcs.SetResult(result.Text);
                    StopWebcam();
                }
            });
            FinalFrame.Start();

            return tcs.Task;
        }

        public void StopWebcam()
        {
            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                FinalFrame.SignalToStop();
                FinalFrame.WaitForStop();
                FinalFrame = null;
            }
        }

        private bool checkProduct(string barcode)
        {
            using(GroceryStoreContext db = new GroceryStoreContext())
            {
                return db.ProductDetail.Any(x => x.BarCode == barcode);
            }
        }
    }
}
