using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexaDatatyperKata
{
    public class Delivery
    {
        private int OrderNumber;
        public string ProductName;
        public double Price;
        public string DeliveryDate;
        public double Weight;

        public Delivery(string ProductName, double Price, int OrderNumber, string DeliveryDate, double Weight)
        {
            
            ProductName = "trampoline";
            Price = 3100;
            OrderNumber = 73217418;
            DeliveryDate = "Fredag, 18:00";
            Weight = 50;





        }

        public Delivery(string ProductName)
        {
            this.ProductName = ProductName;
        }
    }
}
