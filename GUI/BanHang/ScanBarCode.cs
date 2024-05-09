using AForge.Video;
using AForge.Video.DirectShow;
using grocery_store.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace grocery_store.GUI.BanHang
{
    public partial class ScanBarCode : UserControl
    {
        private VideoCaptureDevice FinalFrame = null;
        public string barcode = null;
        //public event EventHandler CancelClick;
        public ScanBarCode()
        {
            InitializeComponent();
        }

        private bool isCancelled = false;

        public string ScanBarCodeAsync()
        {
            while (!isCancelled)
            {
                string barcode = Scan().Result;
                if (barcode != null)
                {
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
            return null;
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
            using (GroceryStoreContext db = new GroceryStoreContext())
            {
                return db.ProductDetail.Any(x => x.BarCode == barcode);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            StopWebcam();
            this.Dispose();
            isCancelled = true;
        }
    }
}
