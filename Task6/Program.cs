using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfImages = 52;
            int imagesInRaw=3;
            int rest = countOfImages % imagesInRaw;
            int countOfRows = (countOfImages - rest) / imagesInRaw;

            Console.WriteLine("Вы можете вывести " + countOfRows + " строк");
            Console.WriteLine("Остаток = " + rest);
        }
    }
}
