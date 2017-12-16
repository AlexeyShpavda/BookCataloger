using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCataloger.Interfaces;
using System.IO;

namespace BookCataloger.Writers
{

    public class Writer
    {
        public static void WriteToFiles(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var item in Greeting.ListOfBooks)
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }
    }
}
