using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segitiga
{
    public class MembuatSegitiga<T>
    {
        public void Create(T tanda)
        {
            Console.WriteLine("      {0}      ", tanda);
            Console.WriteLine("    {0} {1}      ", tanda, tanda);
            Console.WriteLine("  {0} {1} {2}      ", tanda, tanda, tanda);

        }
    }
}
