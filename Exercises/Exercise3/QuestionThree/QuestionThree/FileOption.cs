using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionThree
{
    public class FileOption
    {
        public int status { get; set; }

        public void CopySourceToDestination(FileInfo sourceFile, FileInfo destinationFile)
        {
           
            try
            {
                using (Stream stream = sourceFile.OpenRead())
                using (Stream streamDestination = destinationFile.OpenWrite())
                {

                    byte[] buffer = new byte[128];
                    int actuallyRead = stream.Read(buffer, 0, buffer.Length);
                    string s = System.Text.ASCIIEncoding.UTF8.GetString(buffer,0, actuallyRead);
                    byte[] desBytes = System.Text.ASCIIEncoding.UTF8.GetBytes(s);
                    streamDestination.Write(desBytes);
                    status = 0;
                    return;
                }
            }
            catch (FileNotFoundException)
            {
                status = -1;
                Console.WriteLine("Error: The file specified could not be found.");
            }
            catch (System.Exception excpt)
            {
                status = -1;
                Console.WriteLine(excpt.Message);
            }


        }

    }
}
