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
            // Băm lần lượt name, category, supplier và ghép lại để tạo SKU
            string nameHash = GenerateHash(productName);
            string categoryHash = GenerateHash(category);
            string supplierHash = GenerateHash(supplier);
            // Tạo SKU từ các chuỗi hash
            string sku = $"{nameHash}.{categoryHash}.{supplierHash}";
            return sku;
        }

        private string GenerateHash(string input)
        {
            SHA256 sha256Hash = SHA256.Create();
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            //Lấy 3 kí tự đầu và 3 kí tự cuối 
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 3 && i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            //for (int i = bytes.Length - 3; i < bytes.Length; i++) {
            //    if (i >= 0) {
            //        builder.Append(bytes[i].ToString("x2")); // Chuyển đổi byte thành hex và thêm vào chuỗi
            //    }
            //}
            return builder.ToString();
        }

    }
}
