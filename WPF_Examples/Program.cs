using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WPF_Examples
{

     class Converter
    {

        public delegate void WarningHandler(string message);
        WarningHandler _warning;

        public void RegisterWarningHandler(WarningHandler del)
        {
            _warning = del;
        }
        public int HexToDec(string hexNum)
        {
            hexNum = hexNum.Trim();
            hexNum = hexNum.ToUpper();
            foreach (char ch in hexNum)
            {
                if (!"0123456789ABCDEF".Contains(ch))
                {
                    //Console.WriteLine("Такого числа не существует - " + hexNum);
                    if(_warning!= null)
                        _warning("Такого числа не существует - " + hexNum);
                    return 0;
                }
            }
            int temp = 0;
            int result = 0;
            for (int i = 0; i < hexNum.Length; i++)
            {
                if ("ABCDEF".Contains(hexNum[i]))
                {
                    switch (hexNum[i])
                    {
                        case 'A':
                            temp = 10;
                            break;
                        case 'B':
                            temp = 11;
                            break;
                        case 'C':
                            temp = 12;
                            break;
                        case 'D':
                            temp = 13;
                            break;
                        case 'E':
                            temp = 14;
                            break;
                        case 'F':
                            temp = 15;
                            break;
                    }
                }
                else
                {
                    temp = Int32.Parse(hexNum[i].ToString());
                }
                result += temp * (int)Math.Pow(16, hexNum.Length - i - 1);
            }
            
            return result;
        }
        public static string DecToHex(string decString)
        {
            int decNum = 0;
            if (!Int32.TryParse(decString, out decNum))
            {
                Console.WriteLine("Такого числа не существует - " + decString);
                return "0";
            }
            int temp = 0;
            string result = "";
            while (decNum > 0)
            {
                temp = decNum % 16;
                decNum = decNum / 16;
                if (temp > 9)
                {
                    switch (temp)
                    {
                        case 10:
                            result += "A";
                            break;
                        case 11:
                            result += "B";
                            break;
                        case 12:
                            result += "C";
                            break;
                        case 13:
                            result += "D";
                            break;
                        case 14:
                            result += "E";
                            break;
                        case 15:
                            result += "F";
                            break;
                    }
                }
                else
                {
                    result += temp;
                }
            }
            char[] res = result.ToCharArray();
            Array.Reverse(res);

            return new string(res);
        }
    }
}
