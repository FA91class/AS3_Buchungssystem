using System;
using System.Collections.Generic;
using System.Text;

namespace AS3_Buchung.models
{
    class Rechnung
    {
        private double sumNetto;

        private double rabatProzent;

        public string BerechnungsNr { get; set; }

        public DateTime BerechnungsDatum { get; set; }

        public double SummeNetto { get; set; }

        public double RabatProzent { get; set; }

        public double RabatPreis { get; set; }

        public double NettoMitRabat { get; set; }

        public double UstProzent { get; set; }

        public double UstAufschlag { get; set; }

        public double SummeBruto { get; set; }

        public void Berechne()
        {

        }
    }
}
