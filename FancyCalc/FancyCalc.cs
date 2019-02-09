using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(int a, int b)
        {
            //throw new NotImplementedException();
            return Convert.ToDouble(a + b);
        }


        public double Subtract(int a, int b)
        {
            //throw new NotImplementedException();
            return Convert.ToDouble(a - b);
        }


        public double Multiply(int a, int b)
        {
            return Convert.ToDouble(a * b);
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            string[] words = expression.Split(' ');
            switch (words[1])
            {
                case ("+"):
                    return Convert.ToDouble(words[0]) + Convert.ToDouble(words[2]);
                    break;
                case ("-"):
                    return Convert.ToDouble(words[0]) - Convert.ToDouble(words[2]);
                    break;
                case ("*"):
                    return Convert.ToDouble(words[0]) * Convert.ToDouble(words[2]);
                    break;
                case ("/"):
                    if (Convert.ToInt16(words[2]) != 0)
                    {
                        return Convert.ToDouble(words[0]) / Convert.ToDouble(words[2]);
                    }
                    else
                    {
                        throw new System.DivideByZeroException();
                    }
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }

        }
    }
}
