using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator;


namespace calculator
{
    public class Calculator
    {
        public Calculator()
        {
            
        }
        private string Podaj()
        {
            Console.WriteLine("Podaj liczbę :");
            string x = Console.ReadLine();

            return x;
            
        }

        public void Start()
        {
            Console.WriteLine("Jaką operację chcesz wykonać?\n1-Dodawanie\n2-Odejmowanie\n3-Mnożenie\n4-Dzielenie");

            var operacja = Console.ReadLine();

            Oblicz oblicz = new Oblicz();

            string x = Podaj();
            string y = Podaj();

            switch (operacja)
            {
                
                case "1":                    
                    Console.WriteLine(oblicz.Dodaj(x, y));
                    break;
                case "2":
                    Console.WriteLine(oblicz.Odejmij(x, y));
                    break;

                case "3":
                    Console.WriteLine(oblicz.Mnóż(x, y));
                    break;

                case "4":
                    Console.WriteLine(oblicz.Dziel(x, y));
                    break;
            }
        }
    }
}
