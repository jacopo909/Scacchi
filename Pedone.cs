using System;
using System.Collections.Generic;
using System.Text;

namespace Scacchi
{
    public class Pedone : Pezzo
    {
        public Pedone(Colore schieramento) : base("Pedone", schieramento) { }

        public override void Muovi(Cella NuovaPosizione)
        {
            if (NuovaPosizione.Lettera == Posizione.Lettera)
            {
                int segno = Schieramento == Colore.Bianco ? +1 : -1;
                int start = Schieramento == Colore.Bianco ? 2 : 7;
                if (NuovaPosizione.Numero == Posizione.Numero + segno)
                {
                    Posizione = NuovaPosizione;
                }
                else if (Posizione.Numero == start && NuovaPosizione.Numero == Posizione.Numero + segno * 2)
                {
                    Posizione = NuovaPosizione;
                }
                else
                    Errore();


            }
            else
                Errore();
        }
    }
}
