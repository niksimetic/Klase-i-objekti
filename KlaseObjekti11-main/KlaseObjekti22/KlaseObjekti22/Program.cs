using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseObjekti22
{
    class Program
    {
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            Cetverokut cetverokut = new Cetverokut();

            Console.WriteLine("Upišite stranice za cetverokut: ");
            cetverokut.IspisiStr();

            Console.WriteLine("Upišite stranice za trokut: ");
            trokut.IspisiStr();

            double opsegCetverokuta = cetverokut.Opseg();
            double opsegTrokuta = trokut.Opseg();

            Console.WriteLine("Opseg cetverokuta je: " + opsegCetverokuta);
            Console.WriteLine("Opseg trokuta je: " + opsegTrokuta);

        }
    }
}
