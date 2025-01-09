using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveToSeven___Endpoints.Controllers;

namespace FiveToSeven___Endpoints.Services
{
    public class ReverseItNumberService
    {

        public string ReverseNumber(string number)
        {

            string reversedNumber = new string(number.ToCharArray().Reverse().ToArray());


            return $"You entered {number}, reversed is {reversedNumber}";
        }
    }

}