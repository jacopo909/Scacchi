using System;

namespace Scacchi
{
    public class Torre : Pezzo
    {
        public Torre(Colore schieramento) : base("Torre", schieramento) { }

        public override void Muovi(Cella NuovaPosizione)
        {
            if(NuovaPosizione.Lettera == Posizione.Lettera || NuovaPosizione.Numero == Posizione.Numero)
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
