using System;
using System.Collections.Generic;
using System.Text;
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
            var bp6 = new BestellPosition(6, 4) { Artikel = new Artikel { EinzelPreis = 3.50, ArtikelNr = "9836", Bezeichnung = "Cappuccino" } };
            var bp7 = new BestellPosition(7, 1) { Artikel = new Artikel { EinzelPreis = 6.50, ArtikelNr = "1115", Bezeichnung = "Schokoliebe", Produkthinweis = "Schokoladen- und Vanilleeis mit Eierlikör, Schokoladensoße, hausgemachter Schlagsahne, Schokomandelsplittern und Cookies" } };
            var bp8 = new BestellPosition(8, 1) { Artikel = new Artikel { EinzelPreis = 3.00, ArtikelNr = "1548", Bezeichnung = "Pistazien-Eis", Produkthinweis = "Pistazieneis aus 100% sizilianischen Pistazien (aus Bronte)" } };
            var bp9 = new BestellPosition(9, 2) { Artikel = new Artikel { EinzelPreis = 3.80, ArtikelNr = "3759", Bezeichnung = "Prosecco", Produkthinweis = "1 Glas Cavalier Blanc de Blanc Brut" } };
            var bp10 = new BestellPosition(10, 2) { Artikel = new Artikel { EinzelPreis = 4.70, ArtikelNr = "3405", Bezeichnung = "Bruschetta", Produkthinweis = "6 Bruschetta mit hausgemachtem Pesto, Tomate, Zwiebel & frischem Parmesan überbacken" } };
            var bp11 = new BestellPosition(11, 4) { Artikel = new Artikel { EinzelPreis = 3.50, ArtikelNr = "9836", Bezeichnung = "Cappuccino" } };
            var bp12 = new BestellPosition(12, 1) { Artikel = new Artikel { EinzelPreis = 6.50, ArtikelNr = "1115", Bezeichnung = "Schokoliebe", Produkthinweis = "Schokoladen- und Vanilleeis mit Eierlikör, Schokoladensoße, hausgemachter Schlagsahne, Schokomandelsplittern und Cookies" } };
            var bp13 = new BestellPosition(13, 1) { Artikel = new Artikel { EinzelPreis = 3.00, ArtikelNr = "1548", Bezeichnung = "Pistazien-Eis", Produkthinweis = "Pistazieneis aus 100% sizilianischen Pistazien (aus Bronte)" } };
            var bp14 = new BestellPosition(14, 2) { Artikel = new Artikel { EinzelPreis = 3.80, ArtikelNr = "3759", Bezeichnung = "Prosecco", Produkthinweis = "1 Glas Cavalier Blanc de Blanc Brut" } };
            var bp15 = new BestellPosition(15, 2) { Artikel = new Artikel { EinzelPreis = 4.70, ArtikelNr = "3405", Bezeichnung = "Bruschetta", Produkthinweis = "6 Bruschetta mit hausgemachtem Pesto, Tomate, Zwiebel & frischem Parmesan überbacken" } };
            var bp16 = new BestellPosition(16, 4) { Artikel = new Artikel { EinzelPreis = 3.50, ArtikelNr = "9836", Bezeichnung = "Cappuccino" } };
            var bp17 = new BestellPosition(17, 1) { Artikel = new Artikel { EinzelPreis = 6.50, ArtikelNr = "1115", Bezeichnung = "Schokoliebe", Produkthinweis = "Schokoladen- und Vanilleeis mit Eierlikör, Schokoladensoße, hausgemachter Schlagsahne, Schokomandelsplittern und Cookies" } };
            var bp18 = new BestellPosition(18, 1) { Artikel = new Artikel { EinzelPreis = 3.00, ArtikelNr = "1548", Bezeichnung = "Pistazien-Eis", Produkthinweis = "Pistazieneis aus 100% sizilianischen Pistazien (aus Bronte)" } };
            var bp19 = new BestellPosition(19, 2) { Artikel = new Artikel { EinzelPreis = 3.80, ArtikelNr = "3759", Bezeichnung = "Prosecco", Produkthinweis = "1 Glas Cavalier Blanc de Blanc Brut" } };
            var bp20 = new BestellPosition(20, 2) { Artikel = new Artikel { EinzelPreis = 4.70, ArtikelNr = "3405", Bezeichnung = "Bruschetta", Produkthinweis = "6 Bruschetta mit hausgemachtem Pesto, Tomate, Zwiebel & frischem Parmesan überbacken" } };
            var bp21 = new BestellPosition(21, 4) { Artikel = new Artikel { EinzelPreis = 3.50, ArtikelNr = "9836", Bezeichnung = "Cappuccino" } };
            var bp22 = new BestellPosition(22, 1) { Artikel = new Artikel { EinzelPreis = 6.50, ArtikelNr = "1115", Bezeichnung = "Schokoliebe", Produkthinweis = "Schokoladen- und Vanilleeis mit Eierlikör, Schokoladensoße, hausgemachter Schlagsahne, Schokomandelsplittern und Cookies" } };
            var bp23 = new BestellPosition(23, 1) { Artikel = new Artikel { EinzelPreis = 3.00, ArtikelNr = "1548", Bezeichnung = "Pistazien-Eis", Produkthinweis = "Pistazieneis aus 100% sizilianischen Pistazien (aus Bronte)" } };
            var bp24 = new BestellPosition(24, 2) { Artikel = new Artikel { EinzelPreis = 3.80, ArtikelNr = "3759", Bezeichnung = "Prosecco", Produkthinweis = "1 Glas Cavalier Blanc de Blanc Brut" } };
            var bp25 = new BestellPosition(25, 2) { Artikel = new Artikel { EinzelPreis = 4.70, ArtikelNr = "3405", Bezeichnung = "Bruschetta", Produkthinweis = "6 Bruschetta mit hausgemachtem Pesto, Tomate, Zwiebel & frischem Parmesan überbacken" } };
            var bp26 = new BestellPosition(26, 4) { Artikel = new Artikel { EinzelPreis = 3.50, ArtikelNr = "9836", Bezeichnung = "Cappuccino" } };
            var bp27 = new BestellPosition(27, 1) { Artikel = new Artikel { EinzelPreis = 6.50, ArtikelNr = "1115", Bezeichnung = "Schokoliebe", Produkthinweis = "Schokoladen- und Vanilleeis mit Eierlikör, Schokoladensoße, hausgemachter Schlagsahne, Schokomandelsplittern und Cookies" } };
            var bp28 = new BestellPosition(28, 1) { Artikel = new Artikel { EinzelPreis = 3.00, ArtikelNr = "1548", Bezeichnung = "Pistazien-Eis", Produkthinweis = "Pistazieneis aus 100% sizilianischen Pistazien (aus Bronte)" } };
            var bp29 = new BestellPosition(29, 2) { Artikel = new Artikel { EinzelPreis = 3.80, ArtikelNr = "3759", Bezeichnung = "Prosecco", Produkthinweis = "1 Glas Cavalier Blanc de Blanc Brut" } };
            var bp30 = new BestellPosition(30, 2) { Artikel = new Artikel { EinzelPreis = 4.70, ArtikelNr = "3405", Bezeichnung = "Bruschetta", Produkthinweis = "6 Bruschetta mit hausgemachtem Pesto, Tomate, Zwiebel & frischem Parmesan überbacken" } };
            var bp31 = new BestellPosition(31, 4) { Artikel = new Artikel { EinzelPreis = 3.50, ArtikelNr = "9836", Bezeichnung = "Cappuccino" } };
            var bp32 = new BestellPosition(32, 1) { Artikel = new Artikel { EinzelPreis = 6.50, ArtikelNr = "1115", Bezeichnung = "Schokoliebe", Produkthinweis = "Schokoladen- und Vanilleeis mit Eierlikör, Schokoladensoße, hausgemachter Schlagsahne, Schokomandelsplittern und Cookies" } };
            var bp33 = new BestellPosition(33, 1) { Artikel = new Artikel { EinzelPreis = 3.00, ArtikelNr = "1548", Bezeichnung = "Pistazien-Eis", Produkthinweis = "Pistazieneis aus 100% sizilianischen Pistazien (aus Bronte)" } };
            var bp34 = new BestellPosition(34, 2) { Artikel = new Artikel { EinzelPreis = 3.80, ArtikelNr = "3759", Bezeichnung = "Prosecco", Produkthinweis = "1 Glas Cavalier Blanc de Blanc Brut" } };
            var bp35 = new BestellPosition(35, 2) { Artikel = new Artikel { EinzelPreis = 4.70, ArtikelNr = "3405", Bezeichnung = "Bruschetta", Produkthinweis = "6 Bruschetta mit hausgemachtem Pesto, Tomate, Zwiebel & frischem Parmesan überbacken" } };
            var bp36 = new BestellPosition(36, 4) { Artikel = new Artikel { EinzelPreis = 3.50, ArtikelNr = "9836", Bezeichnung = "Cappuccino" } };
            var bp37 = new BestellPosition(37, 1) { Artikel = new Artikel { EinzelPreis = 6.50, ArtikelNr = "1115", Bezeichnung = "Schokoliebe", Produkthinweis = "Schokoladen- und Vanilleeis mit Eierlikör, Schokoladensoße, hausgemachter Schlagsahne, Schokomandelsplittern und Cookies" } };
            var bp38 = new BestellPosition(38, 1) { Artikel = new Artikel { EinzelPreis = 3.00, ArtikelNr = "1548", Bezeichnung = "Pistazien-Eis", Produkthinweis = "Pistazieneis aus 100% sizilianischen Pistazien (aus Bronte)" } };
            var bp39 = new BestellPosition(39, 2) { Artikel = new Artikel { EinzelPreis = 3.80, ArtikelNr = "3759", Bezeichnung = "Prosecco", Produkthinweis = "1 Glas Cavalier Blanc de Blanc Brut" } };
            var bp40 = new BestellPosition(40, 2) { Artikel = new Artikel { EinzelPreis = 4.70, ArtikelNr = "3405", Bezeichnung = "Bruschetta", Produkthinweis = "6 Bruschetta mit hausgemachtem Pesto, Tomate, Zwiebel & frischem Parmesan überbacken" } };


            b1.AddBestellPosition(bp1);
            b1.AddBestellPosition(bp2);
            b1.AddBestellPosition(bp3);
            b1.AddBestellPosition(bp4);
            b1.AddBestellPosition(bp5);
            b1.AddBestellPosition(bp6);
            b1.AddBestellPosition(bp7);
            b1.AddBestellPosition(bp8);
            b1.AddBestellPosition(bp9);
            b1.AddBestellPosition(bp10);
            b1.AddBestellPosition(bp11);
            b1.AddBestellPosition(bp12);
            b1.AddBestellPosition(bp13);
            b1.AddBestellPosition(bp14);
            b1.AddBestellPosition(bp15);
            b1.AddBestellPosition(bp16);
            b1.AddBestellPosition(bp17);
            b1.AddBestellPosition(bp18);
            b1.AddBestellPosition(bp19);
            b1.AddBestellPosition(bp20);
            b1.AddBestellPosition(bp21);
            b1.AddBestellPosition(bp22);
            b1.AddBestellPosition(bp23);
            b1.AddBestellPosition(bp24);
            b1.AddBestellPosition(bp25);
            b1.AddBestellPosition(bp26);
            b1.AddBestellPosition(bp27);
            b1.AddBestellPosition(bp28);
            b1.AddBestellPosition(bp29);
            b1.AddBestellPosition(bp30);
            b1.AddBestellPosition(bp31);
            b1.AddBestellPosition(bp32);
            b1.AddBestellPosition(bp33);
            b1.AddBestellPosition(bp34);
            b1.AddBestellPosition(bp35);
            b1.AddBestellPosition(bp36);
            b1.AddBestellPosition(bp37);
            b1.AddBestellPosition(bp38);
            b1.AddBestellPosition(bp39);
            b1.AddBestellPosition(bp40);

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
