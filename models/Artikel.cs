using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AS3_Buchung.models
{
    class Artikel
    {
        #region properties
        public string ArtikelNr { get; set; }

        public string Bezeichnung { get; set; }

        public string Produkthinweis { get; set; }

        public double EinzelPreis { get; set; }
        #endregion

        public Artikel()
        {

        }

    }
}
