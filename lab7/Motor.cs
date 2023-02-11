using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class Motor
    {
        private int capacitateCilindrica;
        private int putere;
        private string tipCombustibil;

        public Motor(int capacitateCilindrica, int putere, string tipCombustibil)
        {
            this.capacitateCilindrica = capacitateCilindrica;
            this.putere = putere;
            this.tipCombustibil = tipCombustibil;
        }

        public int CapacitateCilindrica
        {
            get { return capacitateCilindrica; }
        }

        public int Putere
        {
            get { return putere; }
        }

        public string TipCombustibil
        {
            get { return tipCombustibil; }
        }

        public void Pornit(bool estePornit)
        {
            if(estePornit)
            {
                Console.WriteLine("brr ");
            }
            else
            {
                Console.WriteLine("par poc pac ");
            }
        }

    }
}
