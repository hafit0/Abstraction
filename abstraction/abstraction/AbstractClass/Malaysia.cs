using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction.AbstractClass
{
    public class Malaysia : Negara
    {
        public override void ibukota()
        {
            Console.WriteLine("Ibukota\t\t: Kuala Lumpur");
        }
        public override void Lagu()
        {
            Console.WriteLine("Lagu Kebangsaan\t: Negaraku");
        }
        public override void MataUang()
        {
            Console.WriteLine("Mata Uang\t: Ringgit");
        }
    }
}
