using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segitiga
{
    class Program
    {
        static void Main(string[] args)
        {
            SegitigaSamaSisi<String> samasisi = new SegitigaSamaSisi<string>();
            samasisi.CreateSamaSisi("$", 6);
        }
    }
}
