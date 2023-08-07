using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[8];

            Console.WriteLine("Enter names");
            for(int i=0;i<names.Length; i++)
            {
                names[i]=Console.ReadLine();
            }
            Console.WriteLine("Araay Elements are");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();

        }
    }
}
