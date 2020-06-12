using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction.AbstractClass
{
    public class Indonesia : Negara
    {
        public override void ibukota()
        {
            Console.WriteLine("Ibukota\t\t: Jakarta");
        }
        public override void Lagu()
        {
            Console.WriteLine("Lagu Kebangsaan\t: Indonesia Raya");
        }
        public override void MataUang()
        {
            Console.WriteLine("Mata Uang\t: Rupiah");
        }
    }
}
