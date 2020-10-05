using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AS3_Buchung.models
{
    class Artikel
    {
        private int artikelNr;

        private string bezeichnung;

        private string produkthinweis;

        public Artikel()
        {
            this.artikelNr = ArtikelNr;
            this.bezeichnung = Bezeichnung;
            this.produkthinweis = Produkthinweis;
        }

        public int ArtikelNr { get; set; }

        public string Bezeichnung { get; set; }

        public string Produkthinweis { get; set; }
    }
}
