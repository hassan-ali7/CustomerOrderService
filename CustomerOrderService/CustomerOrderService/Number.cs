using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public class Number
    {
        public bool AreAllNumbersEven(int[] numbers)
        {
            bool areAllNumbersEven = true;
            foreach(int number in numbers) 
            {
                if(number % 2 != 0)
                {
                   return areAllNumbersEven = false;
                } 
                
            }
            return areAllNumbersEven;
        }
        public bool IsStringArrayOfEvenNumbers(string[] numbers)
        {
            bool isStringArrayOfEvenNumbers = true;
            foreach(string number in numbers) 
            {
                if (int.Parse(number) % 2 != 0)
                {
                    return isStringArrayOfEvenNumbers = false;
                }
            }
            return isStringArrayOfEvenNumbers;  
        }
    }
}
