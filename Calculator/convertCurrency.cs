using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ConvertCurrency
    {

        string[] currencies =
        {
                "New Zealand Dollar (NZD)" // 0
                ,"United States Dollar (USD)" // 1
                ,"United Arab Emirates Dirham (AED)" // 2
                ,"British Pound  (GBP)" // 3
        };

        public void ToNZD(double money, string fromCurrency, string toCurrency)
        {
            if(toCurrency == "New Zealand Dollar (NZD)")
            {
                if(fromCurrency == currencies[1])
                {
                    //money = money / 0.69092;
                }
                else
                {

                }
            }
        }
    }
}
