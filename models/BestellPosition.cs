using System;
using System.Collections.Generic;
using System.Text;

namespace AS3_Buchung.models
{
    class BestellPosition
    {
        private int anzahl;

        public BestellPosition(int anzahl)
        {
            this.anzahl = anzahl;

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

        public int PositionsNr { get; set; }

        public double ServiceKostenInEuro { get; }
    }
}
