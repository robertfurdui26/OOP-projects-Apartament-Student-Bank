using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Camera
    {
        public string name { get; set; }
        public int lungime { get; set; }
        public int inaltime { get; set; }
        public int latime { get; set; }

        public Camera(string Name,int Lungime,int Inaltime,int Latime)
        {
            this.name = Name;

            this.inaltime = Inaltime;
            this.latime = Latime;
            this.lungime = Lungime;

            
        }

        public string GetDescription()
        {
            return $"Camera : {name}";
        }


    }
}
