using System;
using System.Collections.Generic;
using System.Text;

namespace Scacchi
{
    public class Re : Pezzo
    {
        public Re(Colore schieramento) : base("Re", schieramento) { }
        public override void Muovi(Cella NuovaPosizione)
        {
            int l = Math.Abs(NuovaPosizione.Lettera - Posizione.Lettera);
            int n = Math.Abs(NuovaPosizione.Numero - Posizione.Numero);
            if(l <= 1 && n <= 1 && n + l >= 1)
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
