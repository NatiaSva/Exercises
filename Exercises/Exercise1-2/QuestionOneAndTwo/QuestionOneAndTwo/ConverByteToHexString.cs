using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOneAndTwo
{
    public class ConverByteToHexString
    {

        public int SwitchByteHexString(ref string hexNumberString, int position, int bitValue)
        {

            string binaryval = "";
            binaryval = Convert.ToString(Convert.ToInt32(hexNumberString, 16), 2);
            binaryval = binaryval.PadLeft(((binaryval.Length / 8) + 1) * 8, '0');
            char[] binaryChars = binaryval.ToCharArray();
            int[] arr = new int[binaryChars.Length];
            string[] s = new string[binaryChars.Length];

            for (int i = 0; i < binaryChars.Length; i++)
            {
                s[i] = binaryChars[i].ToString();
                arr[i] = int.Parse(s[i]);
            }

            if (position >= arr.Length)
            {
                return -1;
            }
            else
            {
                arr[arr.Length - position - 1] = bitValue;
            }

            string binary = "";
            for (int i = 0; i < arr.Length; i++)
            {
                binary += arr[i];
            }

            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }
            hexNumberString = result.ToString();
            Trace.WriteLine("sucessfully converted to hexadecimal: " + hexNumberString);
            return 0;


        }
    }
}
