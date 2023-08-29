using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        private string nume { get; set; }

        private string prenume { get; set; }

        private string  cnp { get; set; }

        public  static int nrStudenti = 0;

        public Student( string Nume,string Prenume,string  CNP)
        {
            this.nume = Nume;
            this.prenume = Prenume;
            this.cnp = CNP;
            Student.nrStudenti++;
        }

        
    }
}
