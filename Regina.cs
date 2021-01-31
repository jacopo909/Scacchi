using System;
using System.Collections.Generic;
using System.Text;

namespace Scacchi
{
    public class Regina : Pezzo
    {
        public Regina(Colore schieramento) : base("Regina", schieramento) { }

        public override void Muovi(Cella NuovaPosizione)
        {
            if (NuovaPosizione.Lettera == Posizione.Lettera || NuovaPosizione.Numero == Posizione.Numero)
            {
                Posizione = NuovaPosizione;
            }
            if (Math.Abs(NuovaPosizione.Lettera - Posizione.Lettera) == Math.Abs(NuovaPosizione.Numero - Posizione.Numero))
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
