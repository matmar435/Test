using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Oblicz
    {
        public float Parsowanie_Float(string x)
        {
            float liczba1;

            if (float.TryParse(x, out liczba1)) { }

            else
            {
                liczba1 = float.Parse(x);
            }

            return liczba1;
        }
        
        public float Dodaj(string x,string y)
        {
            float liczba1 = Parsowanie_Float(x);
            float liczba2 = Parsowanie_Float(y);
           
            float w = liczba1 + liczba2;

            return w;
        }

        public float Odejmij(string x, string y)
        {
            float liczba1 = Parsowanie_Float(x);
            float liczba2 = Parsowanie_Float(y);

            float w = liczba1 - liczba2;

            return w;
        }

        public float Mnóż(string x, string y)
        {
            float liczba1 = Parsowanie_Float(x);
            float liczba2 = Parsowanie_Float(y);

            float w = liczba1 * liczba2;

            return w;
        }

        public float Dziel(string x, string y)
        {
            float liczba1 = Parsowanie_Float(x);
            float liczba2 = Parsowanie_Float(y);

            float w = liczba1 / liczba2;

            return w;
        }
    }
}
