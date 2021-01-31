using System;
using System.Collections.Generic;
using System.Text;

namespace Scacchi
{
    public class Cavallo : Pezzo
    {
        public Cavallo(Colore schieramento) : base("Cavallo", schieramento) { }

        public override void Muovi(Cella NuovaPosizione)
        {
            int h = Math.Abs(NuovaPosizione.Numero - Posizione.Numero);
            int v = Math.Abs(NuovaPosizione.Lettera - Posizione.Lettera);
            if((h == 3 && v == 1) || (h == 1 && v == 3))
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
