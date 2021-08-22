namespace WebApplication1
{
    public class OrderLineItem
    {
        public int Id { get; set; }
        public OrderLineItem()
        {
        }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        public int Quantity { get; set; }

        public decimal GetTotal()
        {
            return Quantity * Product.Price;
        }
    }
}