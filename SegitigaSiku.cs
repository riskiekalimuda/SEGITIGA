using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segitiga
{
    public class SegitigaSiku<T>
    {
        public void CreateSiku(T icon, int jmlBaris)
        {
            for (int i = 1; i <= jmlBaris; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(icon);
                }
                Console.WriteLine();
            }
        }
    }
}
