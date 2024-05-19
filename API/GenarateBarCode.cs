using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;
using grocery_store.Models;

namespace grocery_store.API
{
    internal class GenarateBarCode
    {
        GroceryStoreContext db = new GroceryStoreContext();
        //tôi muốn lấy tất cả các product dưới cơ sở dữ liệu sau đó tạo ra barcode cho từng product và lưu các ảnh vào trongthu mục image của project
        public void Genarate()
        {
            List<ProductDetail> productDetails = db.ProductDetail.ToList();
            foreach (ProductDetail product in productDetails)
            {
                //tạo ra barcode cho từng product
                BarcodeWriter writer = new BarcodeWriter();
                writer.Format = BarcodeFormat.CODE_128;
                writer.Options = new EncodingOptions
                {
                    Height = 100,
                    Width = 300
                };
                Bitmap bitmap = writer.Write(product.BarCode);
                bitmap.Save("C:\\Users\\luong\\UTE\\hk2\\Win\\grocery-store\\Image\\BarCode\\" + product.Sku + ".png");
            }
        }
        public void test()
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.CODE_128;
            writer.Options = new EncodingOptions
            {
                Height = 60,
                Width = 360
            };
            Bitmap bitmap = writer.Write("123456789");
            bitmap.Save("C:\\Users\\luong\\1234.png");
        }
    }
}
