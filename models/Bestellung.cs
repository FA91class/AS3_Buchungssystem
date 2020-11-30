using System;
using System.Collections.Generic;
using System.Text;

namespace AS3_Buchung.models
{
    class Bestellung
    {
        public string bestellNr;
        public DateTime bestellDatum;
        public List<BestellPosition> bestellPositionen;

        public Rechnung Rechnung = new Rechnung();

        public string BestellNr
        {
            get
            {
                return bestellNr;
            }
            set
            {
                if (value == null)
                    throw new NullReferenceException();
                else
                    bestellNr = value;
            }
        }

        public DateTime BestellDatum
        {
            get
            {
                return bestellDatum;
            }
            set
            {
                if (value == null)
                    throw new NullReferenceException();
                else
                    bestellDatum = value;
            }
        }

        public Bestellung(string BestellNr, DateTime BestellDatum)
        {
            this.bestellNr = BestellNr;
            this.bestellDatum = BestellDatum;
            this.Rechnung.RechnungsNr = bestellNr;
            this.Rechnung.RechnungsDatum = BestellDatum;

            this.bestellPositionen = new List<BestellPosition>();
        }

        public void AddBestellPosition(BestellPosition bp)
        {
            this.bestellPositionen.Add(bp);
            for (int i = 0; i < bp.Anzahl; i++)
            {
                this.Rechnung.SummeNetto += bp.Artikel.EinzelPreis;
            }            
        }

    }
}
