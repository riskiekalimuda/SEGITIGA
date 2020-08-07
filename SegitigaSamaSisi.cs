using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segitiga
{
    public class SegitigaSamaSisi<T>
    {
        public void CreateSamaSisi(T icon, int jmlBaris)
        {
            for (int i = 1; i <= jmlBaris; i++)
            {
                for (int k = 1; k <= jmlBaris-i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i+(i-1); j++)
                {
                    Console.Write(icon);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
