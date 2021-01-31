using System;
using System.Collections.Generic;
using System.Text;

namespace Scacchi
{
    public abstract class Pezzo
    {
        private Cella posizione; // definisco l'attributo posizione

        public string Tipo { get; private set; }
        public Colore Schieramento { get; set; }

        public Cella Posizione
        {
            get => posizione;
            set 
            {
                if (posizione != null)
                
                    posizione.Pezzo = null;
                    posizione = value;
                    posizione.Pezzo = this;
                
            }
            
        }

        public string Name => GetType().Name; // Restituisce il tipo della classe
        public virtual string ShortName => Name.Substring(0, 3);

        protected Pezzo(string tipo, Colore schieramento)
        {
            Tipo = tipo;
            Schieramento = schieramento;
        }
        public override string ToString()
        {
            return $"{Name} {Schieramento} in {Posizione}";
        }
        public abstract void Muovi(Cella NuovaPosizione);
        

        protected void Errore()
        {

            throw new Exception($"Mossa per {Name} non valida");
        }

    }
}
