using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction.Interface
{
    public class Burjo : IToko
    {
        public void esteh()
        {
            Console.WriteLine("Es Teh\t\t: Rp. 2000;");
        }
        public void nasiayam()
        {
            Console.WriteLine("Nasi ayam\t: Rp.10000;");
        }
    }
}
