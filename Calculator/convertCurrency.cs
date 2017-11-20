using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ConvertCurrency
    {
        // Information from link: http://www.x-rates.com/table/?from=NZD&amount=1 - Accessed on 15/11/2017, 10:11 AM

        string[] currencies =
        {
                "New Zealand Dollar (NZD)" // 0
                ,"United States Dollar (USD)" // 1
                ,"United Arab Emirates Dirham (AED)" // 2
                ,"British Pound  (GBP)" // 3
        };

        double USDtoNZD = 0.69092;
        double AEDtoNZD = 2.525638;
        double GBPtoNZD = 0.522565;
        public double ToMoney;

        public ConvertCurrency(double USDtoNZD, double AEDtoNZD, double GBPtoNZD)
        {

        }

        public string[] Currencies { get => currencies; set => currencies = value; }

        public void ToNZD(double fromMoney, string fromCurrency, string toCurrency)
        {

            if (toCurrency == "New Zealand Dollar (NZD)")
            {
                if (fromCurrency == Currencies[1])
                {
                    fromMoney = fromMoney / USDtoNZD;
                    ToMoney = fromMoney;
                }
                else if (fromCurrency == Currencies[2])
                {
                    fromMoney = fromMoney / AEDtoNZD;
                    ToMoney = fromMoney;
                }
                else if (fromCurrency == Currencies[3])
                {
                    fromMoney = fromMoney / GBPtoNZD;
                    ToMoney = fromMoney;
                }
            }
        }
    }
}
