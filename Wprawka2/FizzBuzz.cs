using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// FizzBuzz application
/// print value from for loop
/// print i 
/// if i divisible by 3 then Fizz
/// if i divisible by 5 then Buzz
/// </summary>
namespace Wprawka2
{
    public class FizzBuzz

    {
        public static string GetVal(int input)
        {
            //throw new NotImplementedException();
            //return "1";
            if (input % 3 == 0)
            {
                return "Fizz";
            }else if (input == 5)
            {
                return "Buzz";
            }
            return input.ToString();

        }
    }
}
