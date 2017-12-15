using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCataloger.Breakers
{
    class LineBreaker
    {
        static public string[] ReturnWordArr(char symbol, string str, short index)
        {
            return str.Split(new char[] { symbol }, StringSplitOptions.RemoveEmptyEntries).Skip(index).ToArray();
        }
    }
}
