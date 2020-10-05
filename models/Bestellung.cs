using System;
using System.Collections.Generic;
using System.Text;

namespace AS3_Buchung.models
{
    class Bestellung
    {
        public string bestellNr;
        public DateTime bestellDatum;

        public Bestellung(string BestellNr, DateTime BestellDatum)
        {
            this.bestellNr = BestellNr;
            this.bestellDatum = BestellDatum;
        }

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
    }
}
