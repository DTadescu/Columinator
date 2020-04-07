using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Columinator.Data
{
    class StringBuilder
    {
        public static string getDirectory (string filePath)
        {
            int count = 0;
            string dirPath = "";
            if (filePath.Length > 0)
            {
                for (int i = filePath.Length - 1; i > 0; i--)
                {
                    count++;
                    if ((char)filePath[i] == '\\') break;
                }
                dirPath = filePath.Substring(0, filePath.Length-count);
            }

            return dirPath;
        }
    }
}
