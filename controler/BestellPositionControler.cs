using System;
using System.Collections.Generic;
using System.Text;
using AS3_Buchung.models;

namespace AS3_Buchung.controler
{
    class BestellPositionControler
    {
        public static void Run()
        {
            List<BestellPosition> liste = new List<BestellPosition>
                    {
                        new BestellPosition(1, 1),
                        new BestellPosition(2, 1),
                        new BestellPosition(3, 1),
                        new BestellPosition(10, 1),
                    };
            foreach (var element in liste)
            {
                Console.WriteLine("Datentyp: " + element.GetType());
                Console.WriteLine("Menge: " + element.Anzahl);
                Console.WriteLine("Servicekosten in EUR: " + Math.Round(element.ServiceKostenInEuro, 2).ToString("0.00"));
                Console.WriteLine("PositionsNr (Zusatzaufgabe): " + element.PositionsNr);
                Console.WriteLine();
            }
            Console.ReadLine();

            //Zusatzaufgabe: Objektinitialisierer in C#:

            // https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer  
        }
    }
}
