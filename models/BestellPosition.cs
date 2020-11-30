using System;
using System.Collections.Generic;
using System.Text;

namespace AS3_Buchung.models
{
    class BestellPosition
    {
        private int anzahl;
        public int PositionsNr;

        public Artikel Artikel { get; set; }

        public BestellPosition(int positionsNr, int anzahl)
        {
            this.anzahl = anzahl;
            this.PositionsNr = positionsNr;

            ServiceKostenInEuro = Math.Round(Anzahl * 0.5, 2);
        }

        public int Anzahl
        {
            get
            {
                return anzahl;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                else
                    anzahl = value;
            }
        }

        public double ServiceKostenInEuro { get; }
    }
}
