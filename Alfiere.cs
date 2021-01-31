using System;
using System.Collections.Generic;
using System.Text;

namespace Scacchi
{
    public class Alfiere : Pezzo
    {
        public Alfiere(Colore schieramento) : base("Alfiere", schieramento) { }

        public override void Muovi(Cella NuovaPosizione)
        {
            if(Math.Abs(NuovaPosizione.Lettera - Posizione.Lettera)  == Math.Abs(NuovaPosizione.Numero - Posizione.Numero))
            {
                Posizione = NuovaPosizione;
            }
            else
            {
                Errore();
            }
        }
    }
}
