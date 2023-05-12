using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public class CustomerOrder
    {
        public void ApplyDiscount(Customer customer, Order order)
        {
            if (customer.CustomerType == CustomerType.Premium)
            {
                order.Amount = order.Amount - ((order.Amount * 10) / 100);
            }
            else if (customer.CustomerType == CustomerType.SpecialCustomer)
            {
                order.Amount = order.Amount - ((order.Amount * 20) / 100);
            }
        }
    }
}
