using System;
using System.Collections.Generic;
using System.Text;

namespace AS3_Buchung.models
{
    class Kunde
    {
        public int TischNr { get; set; }

        public string KundenNr { get; set; }

        public string Name { get; set; }

        public string Ort { get; set; }

        public string PLZ { get; set; }

        public string Strasse { get; set; }

        public Kunde(List<Bestellung> bestellungen)
        {

        }
    }
}
