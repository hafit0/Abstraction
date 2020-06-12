using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction.Interface
{
    public class Warteg : IToko
    {
        public void esteh()
        {
            Console.WriteLine("Es Teh\t\t: Rp. 2500;");
        }
        public void nasiayam()
        {
            Console.WriteLine("Nasi ayam\t: Rp.11000;");
        }
    }
}
