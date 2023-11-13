using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (StreamReader reader = new StreamReader("D:\\Kletki.txt"))
            {
                string line = null;
                stringBuilder.Append("[");
                while ((line = reader.ReadLine()) != null)
                {
                    stringBuilder.Append("[");
                    for (int i = 0; i < line.Length; i++)
                    {
                        stringBuilder.Append(line[i]);
                        if(i + 1< line.Length)
                        {
                            stringBuilder.Append(",");
                        }
                    }
                    stringBuilder.Append("],");
                    stringBuilder.AppendLine();
                }
                stringBuilder.Append("]");


            }


            using (StreamWriter write = new StreamWriter("D:\\Kletki1.txt"))
            {
                write.WriteLine(stringBuilder);
            }

            Console.ReadLine();
        }
    }
}
