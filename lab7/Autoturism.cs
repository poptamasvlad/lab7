using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class Autoturism
    {
        private string marca;
        private string model;
        private int anDeFabricatie;
        Motor motor;
        NumarDeUsi numarDeUsi;

        private static int nrAutoturisme = 0;
        private static int putere = 0;

        public Autoturism(string marca, string model, int anDeFabricatie, Motor motor, NumarDeUsi numarDeUsi)
        {
            this.marca = marca;
            this.model = model;
            this.anDeFabricatie = anDeFabricatie;
            this.motor = motor;
            this.numarDeUsi = numarDeUsi;

            Autoturism.nrAutoturisme++;
            if(motor.Putere > putere)
            {
                Autoturism.putere = motor.Putere;
            }
        }

        public string GetDescription()
        {
            return $" Marca:{marca}, Model:{model}, An de Fabricatie:{anDeFabricatie}, Capacitate Cilindrica:{motor.CapacitateCilindrica}" +
                $", Putere: {motor.Putere}, Tip Combustibil: {motor.TipCombustibil}, Numar de Usi: {numarDeUsi.NrDeUsi} ";
        }

        public void PornesteMasina()
        {
            Console.Write("masina porneste "); 
            numarDeUsi.Deschis(false);
            motor.Pornit(true);
        }

        public void OpresteMasina()
        {
            Console.Write("masina se opreste ");
            numarDeUsi.Deschis(true);
            motor.Pornit(false);
        }

        public static int GetNumarAutoturisme()
        {
            return Autoturism.nrAutoturisme;
        }

        public static int GetCelMaiPuternicAutoturism()
        {
            return Autoturism.putere;
        }

        
    }
}
