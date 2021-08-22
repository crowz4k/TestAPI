using System.Collections.Generic;
using System.Linq;

namespace WebApplication1
{
    public class Order
    {
        public int Id { get; set; }
        public Order()
        {
            OrderLineItems = new List<OrderLineItem>();
        }

        public virtual Customer Customer { get; set; }
        public virtual  List<OrderLineItem> OrderLineItems { get; set; }
        
        public decimal GetTotal()
        {
            return OrderLineItems.Sum(li => li.GetTotal());
        }
    }
}
