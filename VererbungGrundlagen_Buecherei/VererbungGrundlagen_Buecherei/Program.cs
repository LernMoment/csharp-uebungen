using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungGrundlagen_Buecherei
{
    class Program
    {
        static void Main(string[] args)
        {
            AusleihbaresMedium einMedium = new AusleihbaresMedium();
            DateTime ausleihEndeIn15Tagen = DateTime.Now.AddDays(15);

            Console.WriteLine($"Überprüfe ob das Medium bis zum {ausleihEndeIn15Tagen} ausgeliehen werden kann.");
            if (einMedium.KannAusgeliehenWerden(ausleihEndeIn15Tagen))
            {
                Console.WriteLine("ERFOLG: Medium kann für 15 Tage ausgeliehen werden.");
            }

            DateTime ausleihEndeIn30Tagen = DateTime.Now.AddDays(30);
            Console.WriteLine($"Überprüfe ob das Medium bis zum {ausleihEndeIn30Tagen} ausgeliehen werden kann.");
            if (einMedium.KannAusgeliehenWerden(ausleihEndeIn30Tagen))
            {
                Console.WriteLine("ERFOLG: Medium kann für 30 Tage ausgeliehen werden.");
            }

            DateTime ausleihEndeIn31Tagen = DateTime.Now.AddDays(31);
            Console.WriteLine($"Überprüfe ob das Medium bis zum {ausleihEndeIn31Tagen} ausgeliehen werden kann.");
            if (!einMedium.KannAusgeliehenWerden(ausleihEndeIn31Tagen))
            {
                Console.WriteLine("ERFOLG: Medium kann nicht für mehr als 30 Tage ausgeliehen werden.");
            }

            // Video ausleihen
            Video tollerFilm = new Video();
            tollerFilm.LeiheAus(DateTime.Now.AddDays(20));
            if (!tollerFilm.KannAusgeliehenWerden(DateTime.Now.AddDays(1)))
            {
                Console.WriteLine("ERFOLG: Film wurde ausgeliehen und kann nicht nochmals ausgeliehen werden.");
            }

            Console.ReadLine();
        }
    }
}
