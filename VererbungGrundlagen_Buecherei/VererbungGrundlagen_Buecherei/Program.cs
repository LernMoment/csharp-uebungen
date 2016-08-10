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
            List<AusleihbaresMedium> buecherei = new List<AusleihbaresMedium>();
            Video einVideo = new Video();

            buecherei.Add(new Video());
            buecherei.Add(einVideo);
            buecherei.Add(new Software());
            buecherei.Add(new Software());

            DateTime morgen = DateTime.Today.AddDays(1);
            DateTime naechsteWoche = DateTime.Today.AddDays(8);
            DateTime naechstenMonat = DateTime.Today.AddDays(35);

            foreach (var medium in buecherei)
            {
                Console.WriteLine("Medium kann bis morgen ausgeliehen werden: " + medium.KannAusgeliehenWerden(morgen));
                Console.WriteLine("Medium kann bis für 8 Tage ausgeliehen werden: " + medium.KannAusgeliehenWerden(naechsteWoche));
                Console.WriteLine("Medium kann bis für 35 Tage ausgeliehen werden: " + medium.KannAusgeliehenWerden(naechstenMonat));
            }

            Console.ReadLine();
        }
    }
}
