using System;
using System.Collections.Generic;
using System.Text;
using AS3_Buchung.controler;
using AS3_Buchung.helper;
using AS3_Buchung.models;

namespace AS3_Buchung.calsses
{
    class KonsolenDrucker
    {
        public void RechnungsAusgabe(Kunde kunde)
        {
            var i = 0;
            var v = 0;
            foreach (var bestellung in kunde.Bestellungen)
            {
                i++;
                SeitenKopf(i);
                RechnungsKopf(kunde, bestellung);
                RechnungsFuss(bestellung.Rechnung);
                Console.WriteLine("\r\n");
                PositionsKopf();
                foreach (var position in bestellung.bestellPositionen)
                {
                    v++;
                    if (v > 20)
                    {
                        i++;
                        v = 0;
                        Console.WriteLine("\r\n");
                        PositionsKopf();
                    }
                    PositionsZeile(position);
                }
            }
        }

        private void SeitenKopf(int seite)
        {
            var test = "Seite " + seite + " ";
            Console.WriteLine(test.PadLeft(Console.WindowWidth));
        }
        private void RechnungsKopf(Kunde kunde, Bestellung bestellung)
        {
            Console.WriteLine(kunde.Name + "\t\t\t\t\t\t\t\t\t Rechnungsdatum: " + bestellung.Rechnung.RechnungsDatum.Date.ToString("d"));
            Console.WriteLine(kunde.Strasse + "\t\t\t\t\t\t\t\t Rechnungsnummer: " + bestellung.Rechnung.RechnungsNr);
            Console.WriteLine(kunde.PLZ + " " + kunde.Ort + "\t\t\t\t\t\t\t\t\t Kundennummer: " + kunde.KundenNr);
            Console.WriteLine("\nIhre Bestellung " + bestellung.BestellNr + " vom " + bestellung.BestellDatum.Date.ToString("d") + "\n");
        }
        private void RechnungsFuss(Rechnung rechnung)
        {
            var rabattProzent = Convert.ToInt32(rechnung.RabattProzent * 100); var nettoSummeAusgabe = "Summe netto     " + string.Format("{0:0.00}", rechnung.SummeNetto) + " \n";
            var rabattAusgabe = "RabattProzent (" + rabattProzent + "%)     " + string.Format("{0:0.00}", rechnung.RabattPreis) + " \n";
            var nettoRabattAusgabe = "Summe netto abzgl. RabattProzent     " + string.Format("{0:0.00}", rechnung.NettoMitRabat) + " \n";
            var ustAusgabe = "USt(" + rechnung.UstProzent * 100 + "%)     " + string.Format("{0:0.00}", rechnung.UstAufschlag) + " \n";
            var bruttoAusgabe = "Summe brutto     " + string.Format("{0:0.00}", rechnung.SummeBrutto) + " \n";

            Console.Write(nettoSummeAusgabe.PadLeft(Console.WindowWidth));
            Console.Write(rabattAusgabe.PadLeft(Console.WindowWidth));
            Console.Write(nettoRabattAusgabe.PadLeft(Console.WindowWidth));
            Console.Write(ustAusgabe.PadLeft(Console.WindowWidth));
            Console.Write(bruttoAusgabe.PadLeft(Console.WindowWidth));
        }
        private void PositionsKopf()
        {
            Console.WriteLine("Position\tArtikelNr\tBezeichnung\t\t\tEinzelpreis(EUR)\tMenge\t\tPreis(EUR)");
        }
        private void PositionsZeile(BestellPosition bestellPosition)
        {
            Console.WriteLine(bestellPosition.PositionsNr + "\t\t" + bestellPosition.Artikel.ArtikelNr + "\t\t" + bestellPosition.Artikel.Bezeichnung + "\t\t\t" + string.Format("{0:0.00}", bestellPosition.Artikel.EinzelPreis) + "\t\t\t" + bestellPosition.Anzahl + "\t\t" + string.Format("{0:0.00}", bestellPosition.Artikel.EinzelPreis * bestellPosition.Anzahl));
        }
    }
}
