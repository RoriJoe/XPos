using System;

namespace com.agungsetiawan.xpos.Common
{
    public class KodeTransaksiHelper
    {

        static string today = DateTime.Now.ToString("ddMMyyyy");

        public static String Get(string lastCode)
        {
            string last = lastCode;

            string date = "";

            if (!string.IsNullOrEmpty(last))
            {
                date = last.Substring(2, 8);
            }

            int currentNumber, nextNumber;

            if (date.Equals(today))
            {
                currentNumber = int.Parse(last.Substring(10, 3));
                nextNumber = currentNumber + 1;
                return GenerateNextCode(nextNumber);
            }
            else if (!date.Equals(today) || string.IsNullOrEmpty(last))
            {
                nextNumber = 1;
                return GenerateNextCode(nextNumber);
            }

            return null;

        }

        private static String GenerateNextCode(int nextNumber)
        {
            string nextNumberString = nextNumber.ToString().PadLeft(3, '0');
            string nextCode = "TS" + today + nextNumberString;
            return nextCode;
        }
    }
}
