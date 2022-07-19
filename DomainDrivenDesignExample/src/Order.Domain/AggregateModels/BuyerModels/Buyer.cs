using System;
using System.ComponentModel;
using Order.Domain.SeedWork;

namespace Order.Domain.AggregateModels.BuyerModels
{ 
    public class Buyer:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}

