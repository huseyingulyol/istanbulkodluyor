using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public Order()
        {
            
        }

        public Order(int id, int productId, DateTime startDate, DateTime endDate, int customerId, int quantity, int paymentId)
        {
            Id = id;
            ProductId = productId;
            StartDate = startDate;
            EndDate = endDate;
            CustomerId = customerId;
            Quantity = quantity;
            PaymentId = paymentId;
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public int PaymentId { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual Payment Payment { get; set; }



    }
}
