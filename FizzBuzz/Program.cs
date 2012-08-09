using System;
using System.Globalization;
using System.Text;

namespace FizzBuzz
{
    public class Program
    {
        static void Main()
        {
            Program prog = new Program();
            StringBuilder builder = new StringBuilder();

            for (int i=1; i < 101; i++)
            {
                builder.AppendLine(prog.CalculateFizzBuzz(i)); // not optimal
            }

            Console.Out.Write(builder.ToString());
        }


        public string CalculateFizzBuzz(int i)
        {
            string returnVal;

            if (i % 15 == 0)
            {
                returnVal = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                returnVal = "Fizz";
            }
            else if (i % 5 == 0)
            {
                returnVal = "Buzz";
            }
            else
            {
                returnVal = i.ToString(CultureInfo.InvariantCulture);
            }

            return returnVal;
        }
    }
}
