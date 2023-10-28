using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KAFWebAdmin.HelperClasses
{
    public  class CurrencyToWords
    {
        public   string KDToWords(decimal doubleNumber)
        {
            var beforeFloatingPoint = (int)Math.Floor(doubleNumber);
            var beforeFloatingPointWord = $"{NumberToWords(beforeFloatingPoint)} KD";
            var afterFloatingPointWord =
                $"{NumberToWords((int)((doubleNumber - beforeFloatingPoint) * 1000))} Fills";
            return $"{beforeFloatingPointWord} and {afterFloatingPointWord}";
        }

        public string BDTToWords(decimal doubleNumber)
        {
            var beforeFloatingPoint = (int)Math.Floor(doubleNumber);
            var beforeFloatingPointWord = $"{NumberToWords(beforeFloatingPoint)} Taka";
            var afterFloatingPointWord =
                $"{NumberToWords((int)((doubleNumber - beforeFloatingPoint) * 100))} Paisa";
            return $"{beforeFloatingPointWord} and {afterFloatingPointWord}";
        }

        private string NumberToWords(int number)
        {
            if (number == 0)
                return "Zero";

            if (number < 0)
                return "Minus " + NumberToWords(Math.Abs(number));

            var words = "";

            if (number / 1000000000 > 0)
            {
                words += NumberToWords(number / 1000000000) + " Billion ";
                number %= 1000000000;
            }

            if (number / 1000000 > 0)
            {
                words += NumberToWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if (number / 1000 > 0)
            {
                words += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if (number / 100 > 0)
            {
                words += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            words = SmallNumberToWord(number, words);

            return words;
        }

        private string SmallNumberToWord(int number, string words)
        {
            if (number <= 0) return words;
            if (words != "")
                words += " ";

            var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Ewelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }
            return words;
        }
    }
}