using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Payment
    {
        public Payment()
        {
                
        }

        public Payment(int id, int orderId, double totalPrice, bool status, int paymentTypeId)
        {
            Id = id;
            OrderId = orderId;
            TotalPrice = totalPrice;
            Status = status;    
            PaymentTypeId = paymentTypeId;
                
        }

        public int Id { get; set; }
        public int OrderId { get; set; }
        public double TotalPrice { get; set; }
        public bool Status { get; set; }
        public int PaymentTypeId { get; set; }
        public virtual PaymentType PaymentType { get; set; }

    }
}
