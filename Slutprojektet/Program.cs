using System;

namespace Slutprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b1 = new Board();
            
            Instructions();
            b1.Draw();
            
            Console.ReadLine();
        }
        private static void Instructions(){
            Console.WriteLine("Välkommen till mitt spel!\nDetta är ett spel där du ska ta hand om en bondgård.\n");
            Console.WriteLine("Hur ska man tolka brädet?\n0:tom plats\n1:affär\n2:vattenkanna\n3:skottkärra\n4:trädgårdshacka\n5:grödor");
        }
    }
}
