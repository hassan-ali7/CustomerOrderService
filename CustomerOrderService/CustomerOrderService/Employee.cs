using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public class Employee
    {
        public string Name { get; set; }
        public bool ContainsIllegalChars()
        {
            if (this.Name.Contains("$"))
            {
                return true;
            }
            return false;
        }
    }
}
