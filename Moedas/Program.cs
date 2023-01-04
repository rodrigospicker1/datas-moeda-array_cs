using System;
using System.Globalization;

namespace Moedas{

    public static class Program{

        public static void Main(string[] args){

            Console.Clear();

            decimal valor = 10.24m;
            Console.WriteLine(
                valor.ToString(
                    "C",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );

            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
            
        }

    }

}