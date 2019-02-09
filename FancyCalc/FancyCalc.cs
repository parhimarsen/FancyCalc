using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
            double result = 0;
            string[] values = new string[2];
            List<string> replaceWords = new List<string>();
            if (expression == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                for (int i = 0; i < expression.Length; i++)
                {
                    switch (expression[i])
                    {
                        case ('+'):
                            values = expression.Split('+');
                            for (int j = 0; j < values.Length; j++)
                            {
                                string replaced = Regex.Replace(values[j], @"[^0-9$,]", "");
                                replaceWords.Add(replaced);
                            }
                            if (replaceWords[0] != "" || replaceWords[1] != "")
                                result = Convert.ToDouble(replaceWords[0]) + Convert.ToDouble(replaceWords[1]);
                            break;
                        case ('-'):
                            values = expression.Split('-');
                            for (int j = 0; j < values.Length; j++)
                            {
                                string replaced = Regex.Replace(values[j], @"[^0-9$,]", "");
                                replaceWords.Add(replaced);
                            }
                            if (replaceWords[0] != "" || replaceWords[1] != "")
                                result = Convert.ToDouble(replaceWords[0]) - Convert.ToDouble(replaceWords[1]);
                            break;
                        case ('*'):
                            values = expression.Split('*');
                            for (int j = 0; j < values.Length; j++)
                            {
                                string replaced = Regex.Replace(values[j], @"[^0-9$,]", "");
                                replaceWords.Add(replaced);
                            }
                            if (replaceWords[0] != "" || replaceWords[1] != "")
                                result = Convert.ToDouble(replaceWords[0]) * Convert.ToDouble(replaceWords[1]);
                            break;
                        case ('/'):
                            values = expression.Split('/');
                            for (int j = 0; j < values.Length; j++)
                            {
                                string replaced = Regex.Replace(values[j], @"[^0-9$,]", "");
                                replaceWords.Add(replaced);
                            }
                            if (Convert.ToInt16(values[1]) != 0 || replaceWords[0] != "" || replaceWords[1] != "")
                            {
                                result = Convert.ToDouble(replaceWords[0]) / Convert.ToDouble(replaceWords[1]);
                            }
                            else
                            {
                                throw new System.DivideByZeroException();
                            }
                            break;
                    }
                }
                return result;
            }
        }
    }
}
