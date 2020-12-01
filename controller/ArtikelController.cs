using System;
using System.Collections.Generic;
using System.Text;
using AS3_Buchung.models;

namespace AS3_Buchung.controller
{
    class ArtikelController
    {
        public static void Run()
        {
            Artikel a1 = new Artikel
            {
                ArtikelNr = "1115",
                Bezeichnung = "Schokoliebe",
                Produkthinweis = "Schokoladen- und Vanilleeis mit Eierlikör, Schokoladensoße, hausgemachter Schlagsahne, Schokomandelsplittern und Cookies"
            };
            Console.WriteLine("Datentyp: " + a1.GetType());
            Console.WriteLine("Artikelnummer: " + a1.ArtikelNr);
            Console.WriteLine("Bezeichnung: " + a1.Bezeichnung);
            Console.WriteLine("Produkthinweis: " + a1.Produkthinweis);
            Console.ReadLine();

            //Zusatzaufgabe: Objektinitialisierer in C#:

            // https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer     
        }
    }
}
