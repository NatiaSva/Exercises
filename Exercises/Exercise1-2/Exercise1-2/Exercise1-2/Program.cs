using System;
using System.Diagnostics;
using System.Text;
using QuestionOneAndTwo;
namespace Exercise1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            ConverByteToHexString converByteToHexString = new ConverByteToHexString();
            Console.WriteLine("Please enter hexadecimal string value:");
            string hexadecimal = Console.ReadLine();
            Console.WriteLine("Please enter position:");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter bit value(0/1):");
            int bitValue = int.Parse(Console.ReadLine());
            int result = converByteToHexString.SwitchByteHexString(ref hexadecimal, position, bitValue);
            Console.WriteLine("result:" + result);
            Console.WriteLine(hexadecimal);
       

            //Exercise 2
            SubStringBetween subStringBetween = new SubStringBetween();
            Console.WriteLine("Please enter source value:");
            string source = Console.ReadLine();
            Console.WriteLine("Please enter start string value:");
            string startString = Console.ReadLine();
            Console.WriteLine("Please enter end string value:");
            string endString = Console.ReadLine();
            string result2 = subStringBetween.GetSubStringBetween(source, startString, endString);
            Console.WriteLine(result2);
         
        }



    }
}
