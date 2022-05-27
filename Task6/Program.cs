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
            int[] images = new int[52];
            int rest = images.Length % 3;
            int countOfRows = (images.Length - rest) / 3;

            Console.WriteLine("Вы можете вывести " + countOfRows + " строк");
           
        }
    }
}
