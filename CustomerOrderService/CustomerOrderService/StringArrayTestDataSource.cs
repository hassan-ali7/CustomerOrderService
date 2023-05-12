using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public class StringArrayTestDataSource
    {
        public IEnumerator GetEnumerator()
        {
            yield return new string[] { "2", "4", "6" };
            yield return new string[] { "3", "4", "5" };
            yield return new string[] { "6", "8", "10" };
        }
    }
}
