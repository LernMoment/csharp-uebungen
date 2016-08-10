using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungGrundlagen_Buecherei
{
    public class AusleihbaresMedium
    {
        private bool istAusgeliehen = false;
        // Standardwert für DateTime ist 1/1/0001 12:00:00 AM was 
        // DateTime.MinValue entspricht
        private DateTime ausgeliehenBis = new DateTime();

        public void LeiheAus(DateTime ausleiheEnde)
        {
            if (KannAusgeliehenWerden(ausleiheEnde))
            {
                istAusgeliehen = true;
                ausgeliehenBis = ausleiheEnde;
            }
        }

        public bool KannAusgeliehenWerden(DateTime gewuenschtesAusleihDatum)
        {
            if (istAusgeliehen)
            {
                return false;
            }

            if (BerechneDifferenzInTagen(DateTime.Now, gewuenschtesAusleihDatum) > 30)
            {
                return false;
            }

            return true;
        }

        private int BerechneDifferenzInTagen(DateTime von, DateTime bis)
        {
            TimeSpan differenz = bis.Subtract(von);
            return differenz.Days;
        }
    }
}
