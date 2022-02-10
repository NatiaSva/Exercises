using System;
using System.IO;
using QuestionThree;

namespace Exercise3
{
    class Program
    {
        public static readonly FileInfo sourceFile = new FileInfo(@"C:\Users\Nati\Desktop\EssenceGroup\source.data");
        public static readonly FileInfo destinationFile = new FileInfo(@"C:\Users\Nati\Desktop\EssenceGroup\destination.data");
        static void Main(string[] args)
        {
            FileOption fileOption = new FileOption();
            fileOption.CopySourceToDestination(sourceFile, destinationFile);
          
        }


       

    }
}
