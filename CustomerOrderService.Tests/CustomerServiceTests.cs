﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService.Tests
{
    public class CustomerServiceTests
    {
        [TestFixture(CustomerType.Premium, 100.00, TypeArgs = new Type[] { typeof(CustomerType), typeof(double) })]
        public class CustomerOrderServiceTests<T1, T2>
        {
            private T1 customerType;
            private T2 minOrder;

            public CustomerOrderServiceTests(T1 customerType, T2 minOrder)
            {
                this.customerType = customerType;
                this.minOrder = minOrder;
            }

            [TestCase]
            public void TestMethod()
            {
                Assert.That(customerType, Is.TypeOf<CustomerType>());
                Assert.That(minOrder, Is.TypeOf<double>());
            }
        }
        [TestFixture(CustomerType.Basic)]
        public class CustomerOrderServiceTests
        {
            private CustomerType customerType;
            private double minOrder;
            public CustomerOrderServiceTests(CustomerType customerType, double minOrder)
            {
                this.customerType = customerType;
                this.minOrder = minOrder;
            }
            public CustomerOrderServiceTests(CustomerType customerType) : this(customerType, 0)
            {
            }
            //public CustomerOrderServiceTests(CustomerType customerType)
            //{
            //    this.customerType = customerType;
            //}
            [TestCase]
            public void TestMethod()
            {
                Assert.IsTrue((customerType == CustomerType.Basic && minOrder == 0 || customerType == CustomerType.Premium && minOrder > 0));
            }
            [TestCase]
            public void When_PremiumCustomer_Expect_10PercentDiscount()
            {
                Customer premiumCustomer = new Customer
                {
                    CustomerId = 1,
                    CustomerName = "George",
                    CustomerType = CustomerType.Premium
                };
                Order order = new Order
                {
                    OrderId = 1,
                    ProductId = 212,
                    ProductQuantity = 1,
                    Amount = 150
                };
                CustomerOrder customerOrderService = new CustomerOrder();
                customerOrderService.ApplyDiscount(premiumCustomer, order);
                Assert.AreEqual(order.Amount, 135);
            }
        }
    }
}
