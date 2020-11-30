using System;
using System.Collections.Generic;
using System.Text;

namespace AS3_Buchung.models
{
    class Rechnung
    {
        #region properties
        public string RechnungsNr { get; set; }

        public DateTime RechnungsDatum { get; set; }

        public double SummeNetto { get; set; }

        public double RabattProzent { get; set; }

        public double RabattPreis { get; set; }

        public double NettoMitRabat { get; set; }

        public double UstProzent { get; set; }

        public double UstAufschlag { get; set; }

        public double SummeBrutto { get; set; }
        #endregion

        public void Berechne()
        {
            RabattProzent /= 100;
            RabattPreis = SummeNetto * RabattProzent;
            NettoMitRabat = SummeNetto - (SummeNetto * (RabattProzent / 100));
            UstProzent /= 100;
            UstAufschlag = NettoMitRabat * UstProzent;
            SummeBrutto = NettoMitRabat + UstAufschlag;
        }
    }
}
