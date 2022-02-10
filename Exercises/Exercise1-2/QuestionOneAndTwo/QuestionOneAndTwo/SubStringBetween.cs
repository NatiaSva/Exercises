using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionOneAndTwo
{
    public class SubStringBetween
    {

        public  string GetSubStringBetween(string source, string startString, string endString)
        {
            int pos1 = source.IndexOf(startString);
            int pos2 = source.IndexOf(endString);
            int adjustedPos1 = pos1 + startString.Length;
           

            if (pos1 == -1 && pos2 == -1)
            {
                return "";

            }
            if (pos1 == -1)
            {
                return source.Substring(0, adjustedPos1 + (pos2 - adjustedPos1));

            }
            if (pos2 == -1)
            {
                return source.Substring(adjustedPos1, source.Length - adjustedPos1);

            }
            return source.Substring(adjustedPos1, pos2 - adjustedPos1);
        }

    }
}
