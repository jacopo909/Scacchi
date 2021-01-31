using System;
using System.Collections.Generic;
using System.Text;

namespace Scacchi
{
    public class Scacchiera
    {
        public static Scacchiera Istanza { get; } = new Scacchiera();
        public IDictionary<string, Cella> Celle { get; } = new Dictionary<string, Cella>();

        private Scacchiera()
        {
            for (char c = 'A'; c <= 'H'; c++)
            {
                    for(int n = 1;  n <= 8; n++)
                {
                    Celle.Add($"{c}{n}", new Cella(c, n));
                }
            }
        }
        public Cella GetCella(char lettera, int numero)
        {
            string key = $"{lettera}{numero}";
            if (Celle.ContainsKey(key))
            {
                return Celle(key);
                
            }
            throw new Exception($"Cella {key} non trovata ");
        }

        private static void PrintLetters(ref string s,int cellsize)
        {
            s += " ";
            for(char c = 'A'; c <= 'H'; c++)
            {
                s += $"| {c} ".PadRight(cellsize + 1);
            }
            s += "|\n";
        }
        private static void PrintLine(ref string s,int cellsize)
        {
            s += " |".PadRight(cellsize * 11, '-') + "-\n";
        }
        public void Print()
        {
            string s = "";
            int cellsize = 3;
            PrintLetters(ref s, cellsize);
            PrintLine(ref s, cellsize);
            for(int n = 8; n >= 1; n--)
            {
                s += $"{n}";
                for(char c='A'; c <= 'H'; c++)
                {
                    Cella cella = GetCella(c, n);
                    if (cella.Pezzo != null)
                        s += cella.Pezzo.ShortName.PadRight(cellsize);
                    else
                        s += $"".PadRight(cellsize);
                    s += "!";
                }
                s += "\n";
                PrintLine(ref s, cellsize);
            }
            PrintLetters(ref s, cellsize);
            Console.WriteLine(s);
        }

    }
}
