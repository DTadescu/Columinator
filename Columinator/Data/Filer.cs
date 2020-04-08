using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Columinator.Data
{
    class Filer
    {
        public static string[] getRowsFromFile(string path, int ignorable)
        {
            if (File.Exists(path))
            {
                try
                {
                    string text = File.ReadAllText(path);
                    string[] rows = text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries); //разделение на строки, удаление пустых строк
                    //string[] rows = File.ReadAllLines(path);
                    if (rows.Length <= ignorable) return null;
                    string[] rows_out = new string[rows.Length - ignorable];
                    for (int i = 0; i < rows_out.Length; i++)
                    {
                        rows_out[i] = rows[i + ignorable];
                    }
                    return rows_out;
                }
                catch
                {
                    return null;
                }
            }
            else return null;
        }

        public static async void WriteFile(string path, string text)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, false, Encoding.Default))
                {
                    
                    await writer.WriteAsync(text);
                }
            }
            catch
            {

            }
        }
    }
}
