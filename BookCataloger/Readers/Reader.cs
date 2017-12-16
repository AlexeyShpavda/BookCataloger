using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCataloger.Interfaces;
using System.IO;
using BookCataloger.Model;
using BookCataloger.Breakers;


namespace BookCataloger.Readers
{
    public class Reader
    {
        public static void ReadingFile(string fileName)
        {
            string str;
            using (StreamReader sr = new StreamReader(fileName))
            {
                while ((str = sr.ReadLine()) != null)
                {
                    string[] words = LineBreaker.ReturnWordArr('|', str, 0);
                    Greeting.ListOfBooks.Add(new Book(words[0], words[1], words[2], words[3], words[4], words[5]));
                }
            }
        }
    }
}
