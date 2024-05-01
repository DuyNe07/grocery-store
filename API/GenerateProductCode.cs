using grocery_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace grocery_store.API
{
    internal class GenerateProductCode
    {
        public string GenerateSKU(string productName, string category, string supplier)
        {
            // Loại bỏ khoảng trắng từ chuỗi đầu vào
            productName = productName.Trim();
            category = category.Trim();
            supplier = supplier.Trim();

            // Băm lần lượt name, category, supplier và ghép lại để tạo SKU
            string nameHash = GenerateHash(productName);
            string categoryHash = GenerateHash(category);
            string supplierHash = GenerateHash(supplier);

            // Chọn vị trí khác nhau của mỗi chuỗi hash để tạo SKU
            string sku = $"{categoryHash.Substring(2, 3)}{supplierHash.Substring(4, 3)}{nameHash.Substring(0, 4)}";
            return sku;
        }



        private string GenerateHash(string input)
        {
            SHA256 sha256Hash = SHA256.Create();
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Chuyển đổi mảng byte sang chuỗi hex
            StringBuilder hexBuilder = new StringBuilder();
            foreach (byte b in bytes)
            {
                hexBuilder.Append(b.ToString("X2"));
            }
            string hexString = hexBuilder.ToString();

            // Chuyển đổi chuỗi hex thành chuỗi số
            StringBuilder numberBuilder = new StringBuilder();
            foreach (char c in hexString)
            {
                // Chỉ lấy các ký tự số từ chuỗi hex
                if (char.IsDigit(c))
                {
                    numberBuilder.Append(c);
                }
            }

            // Lấy 9 chữ số đầu tiên
            string numericString = numberBuilder.ToString();
            string sku = numericString.Substring(0, Math.Min(9, numericString.Length));
            return sku;
        }




    }
}
