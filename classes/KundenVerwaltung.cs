using System;
using System.Collections.Generic;
using System.Text;
using AS3_Buchung.controler;
using AS3_Buchung.models;

namespace AS3_Buchung.classes
{
    class KundenVerwaltung
    {
        public List<Kunde> Kunden { get; } = new List<Kunde>();
        public KundenVerwaltung()
        {
            var b1 = new Bestellung("B123456", new DateTime(2019, 10, 13)) { Rechnung = new Rechnung { RechnungsNr = "R123456", RechnungsDatum = new DateTime(2019, 10, 14), RabattProzent = 2, UstProzent = 19 } };

            var bp1 = new BestellPosition(1, 4) { Artikel = new Artikel { EinzelPreis = 3.50, ArtikelNr = "9836", Bezeichnung = "Cappuccino" } };
            var bp2 = new BestellPosition(3, 1) { Artikel = new Artikel { EinzelPreis = 6.50, ArtikelNr = "1115", Bezeichnung = "Schokoliebe", Produkthinweis = "Schokoladen- und Vanilleeis mit Eierlikör, Schokoladensoße, hausgemachter Schlagsahne, Schokomandelsplittern und Cookies" } };
            var bp3 = new BestellPosition(2, 1) { Artikel = new Artikel { EinzelPreis = 3.00, ArtikelNr = "1548", Bezeichnung = "Pistazien-Eis", Produkthinweis = "Pistazieneis aus 100% sizilianischen Pistazien (aus Bronte)" } };
            var bp4 = new BestellPosition(5, 2) { Artikel = new Artikel { EinzelPreis = 3.80, ArtikelNr = "3759", Bezeichnung = "Prosecco", Produkthinweis = "1 Glas Cavalier Blanc de Blanc Brut" } };
            var bp5 = new BestellPosition(4, 2) { Artikel = new Artikel { EinzelPreis = 4.70, ArtikelNr = "3405", Bezeichnung = "Bruschetta", Produkthinweis = "6 Bruschetta mit hausgemachtem Pesto, Tomate, Zwiebel & frischem Parmesan überbacken" } };


            b1.AddBestellPosition(bp1);
            b1.AddBestellPosition(bp2);
            b1.AddBestellPosition(bp3);
            b1.AddBestellPosition(bp4);
            b1.AddBestellPosition(bp5);


            b1.Rechnung.Berechne();

            Kunden.Add(new Kunde(new List<Bestellung> { b1 })
            {
                KundenNr = "K123456",
                Name = "Sandra Richter",
                Strasse = "Bleibtreustraße 99",
                PLZ = "12345",
                Ort = "Berlin",
            });
        }
    }
}
