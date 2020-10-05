using System;
using System.Collections.Generic;
using System.Text;
using AS3_Buchung.models;

namespace AS3_Buchung.controler
{
    class BestellungControler
    {
        public static void Run()
        {
            Bestellung b1 = new Bestellung("123456", DateTime.Now);

            Console.WriteLine("Datentyp: " + b1.GetType());
            Console.WriteLine("BestellDatum: " + b1.BestellDatum);
            Console.WriteLine("BestellNr: " + b1.BestellNr);
            Console.ReadLine();

            //Zusatzaufgabe: Objektinitialisierer in C#:

            // https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer  
        }
    }
}
