using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Adress
    {
        public string Strada { get; set; }

        public int Numarul { get; set; }

        public string Scara { get; set; }

        public int NumarApartament { get; set; }
    
        public int Etaj { get; set; }

        public Adress(string strada,int numarul, string scara,int numarApartament,int etaj )
        {
          this.Strada = strada;
            this.Numarul = numarul;
            this.Scara = scara;
            this.NumarApartament = numarApartament;
            this.Etaj = etaj;

            
        }

        public string GetDescription()
        {
         
            string description = $"{Strada},{Numarul},{Scara},{Etaj},{NumarApartament}";
            return description ;
        }
    }
}
