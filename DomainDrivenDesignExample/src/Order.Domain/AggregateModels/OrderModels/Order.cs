using System;
using Order.Domain.AggregateModels.BuyerModels;
using Order.Domain.SeedWork;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Order : BaseEntity, IAggregateRoot
    {
        public DateTime OrderDate { get; private set; }
        public string Description { get; private set; }
        public int BuyerId { get; private set; }
        public Buyer Buyer { get; private set; }
        public bool OrderStatus { get; private set; }
        public Address Address { get; private set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        public Order(DateTime orderDate, string description, int buyerId, Buyer buyer, bool orderStatus, Address address, ICollection<OrderItem> orderItems)
        {
            if (orderDate < DateTime.Now)
                throw new Exception("Sipariş tarihi geçmiş zamanda olamaz.");
            OrderDate = orderDate;
            Description = description;
            BuyerId = buyerId;
            Buyer = buyer;
            OrderStatus = orderStatus;
            Address = address;
            OrderItems = orderItems;
        }

        public void AddOrderItem(int quantity,decimal price,int productId)
        {
            OrderItem item = new OrderItem(quantity, price, productId);
            OrderItems.Add(item);
        }
    }
}

