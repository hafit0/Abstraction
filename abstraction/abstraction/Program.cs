using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abstraction.AbstractClass;
using abstraction.Interface;

namespace abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t------ ABSTRACTION -----\t\n");

            Negara negara;
            negara = new Indonesia();
            negara.ibukota();
            negara.Lagu();
            negara.MataUang();
            
            Console.WriteLine();

            negara = new Malaysia();
            negara.ibukota();
            negara.Lagu();
            negara.MataUang();

            Console.WriteLine("\n\t------ INTERFACE -----\t\n");

            IToko toko;
            toko = new Burjo();
            toko.esteh();
            toko.nasiayam();

            Console.WriteLine();

            toko = new Warteg();
            toko.esteh();
            toko.nasiayam();

            Console.ReadKey();
        }
    }
}
