using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using grocery_store.Models;

namespace grocery_store.API
{
    internal class PaymentQR
    {
        GroceryStoreContext db = new GroceryStoreContext();
        public void Genarate()
        {
            Payment payment = db.Payment.Where(p => p.PaymentId == 2).FirstOrDefault();
            payment.Qr = System.IO.File.ReadAllBytes("C:\\Users\\luong\\UTE\\hk2\\Win\\grocery-store\\Image\\banking.jpg");
            db.Payment.Update(payment);
            db.SaveChanges();
        }
    }
}
