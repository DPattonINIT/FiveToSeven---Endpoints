using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSeven___Endpoints.Services
{
    public class OddOrEvenService
    {
        public string CheckOddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                return $"{number} is even.";
            }
            else
            {
                return $"{number} is odd.";
            }
        }
    }
}