using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adres = new Adress("str fgsdf", 56, "A6G6", 8, 9);
            Apartament apartament = new Apartament(adres);

            apartament.AddCamera(new Camera("Living",23,34,12));
            apartament.AddCamera(new Camera("Bucatarie", 23, 34, 12));
            apartament.AddCamera(new Camera("Baie", 23, 34, 12));

            apartament.Tiparire();



        }



    }
}