namespace Shatably.Models
{
    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }

    public enum paymentMethod
    {
        CashOnDelivery,
        CreditCard,
        PayPal,
        Installment
    }
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalPrice { get; set; }

        public paymentMethod PaymentMethod { get; set; }
        public string UserId { get; set; }
        //fk
        public User User { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }



    }


}
