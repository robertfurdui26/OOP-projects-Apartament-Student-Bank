using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Banc
    {
        private decimal sold;

        public Banc(decimal soldInitial)
        {
            sold = soldInitial;
        }

        public void DepuneBani( decimal suma)
        {
            if (suma > 0)
            {
                sold += suma;
                Console.WriteLine($"Ai depus {suma} lei in cont.Soldul actual este de {sold}");
            }
            else
            {
                Console.WriteLine("Suma depusa trebuie sa fie mai mare decat 0.");
            };
        }


        public void ExtrageBani(decimal suma)
        {
            if (suma > 0 && suma <= sold)
            {
                sold -= suma;
                Console.WriteLine($"Ai extras {suma} lei din cont.Soldul actual este de {sold}");
            }
            else
            {
                Console.WriteLine("Nu ai suficienti bani in cont sau suma este invalida");
            }
        }

        public void AfiseazaSold()
        {
            Console.WriteLine($"Soldul este de {sold}");
        }
    }
}
