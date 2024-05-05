using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace grocery_store.API
{
    internal class PaymentQR
    {
        GroceryStoreContext db = new GroceryStoreContext();
        public async void Genarate()
        {
            List<Payment> payments = await db.Payment.ToListAsync();
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            payments.Where(p => p.Name == "Momo").FirstOrDefault().Qr = System.IO.File.ReadAllBytes("..\\..\\Image\\momo.jpg");
            payments.Where(p => p.Name == "Ngân hàng").FirstOrDefault().Qr = System.IO.File.ReadAllBytes("..\\..\\Image\\banking.jpg");
            payments.Where(p => p.Name == "Tiền").FirstOrDefault().Qr = System.IO.File.ReadAllBytes("..\\..\\Image\\cash.png");
            payments.Where(p => p.Name == "Thẻ").FirstOrDefault().Qr = System.IO.File.ReadAllBytes("..\\..\\Image\\credit-card.png");

            db.UpdateRange(payments);
            await db.SaveChangesAsync();
        }

    }
}
