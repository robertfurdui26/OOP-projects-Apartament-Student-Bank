using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Apartament
    {
        public Adress ApartamentAdress { get; set; }

        public List<Camera>camera { get; set; }

        public Apartament( Adress apartamentAdress )
        {
            this.ApartamentAdress = apartamentAdress;
            camera = new List<Camera>();
        }

        public void AddCamera( Camera cam)
        {
            camera.Add( cam );
        }

        public void Tiparire()
        {
            Console.WriteLine("Adresa apartamentului");
            Console.WriteLine(ApartamentAdress.GetDescription());

            Console.WriteLine("Camerele din apartament");
             
            foreach(var cam in camera)
            {
                Console.WriteLine(cam.GetDescription());
            }

            double totalArea = Suprafata();
            Console.WriteLine($"Suprafata apartamentului totala este {totalArea} metri patrati.");
        }

        public double Suprafata()
        {
            double totalArea = 0;

            foreach(var cam in camera)
            {
                totalArea += cam.latime * cam.inaltime * cam.lungime;
            }

            return totalArea;
        }



    }
}
