using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AS3_Buchung.models
{
    class Artikel
    {
        #region const
        private int artikelNr;

        private string bezeichnung;

        private string produkthinweis;
        #endregion

        #region properties
        public int ArtikelNr { get; set; }

        public string Bezeichnung { get; set; }

        public string Produkthinweis { get; set; }
        #endregion

        public Artikel()
        {
            this.artikelNr = ArtikelNr;
            this.bezeichnung = Bezeichnung;
            this.produkthinweis = Produkthinweis;
        }

    }
}
