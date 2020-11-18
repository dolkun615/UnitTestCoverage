using System;

namespace FinanceCalculator
{
    public class Calculator
    {
       static public string GetOrderCategory (double amount)
        {
            string result = "";
            if (amount < 100)
                result = "Small";
            if (amount >= 100)
                result = "Large";
            return result;
        }

        static public int AddNumbers (int a, int b)
        {
           int c = a + b;
            return c;
        }
    }
}
