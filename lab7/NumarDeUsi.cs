using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class NumarDeUsi
    {
        private int nrDeUsi;

        public NumarDeUsi(int nrDeUsi)
        {
            this.nrDeUsi = nrDeUsi;
        }

        public int NrDeUsi
        {
            get { return nrDeUsi; }
        }

        public void Deschis(bool esteDeschis)
        {
            if(esteDeschis)
            {
                Console.Write("click ");
            }
            else
            {
                Console.Write("clack ");
            }
        }
    }
}
