using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasseRum = new KlasseRum();

            Studerende studerende1 = new Studerende("Dennis", 11,2 );
            Studerende studerende2 = new Studerende("Alexander", 12, 3);

            klasseRum.KlasseNavn = "3B";
            klasseRum.SemesterStart = new DateTime(2018, 9, 4);
            
            klasseRum.Klasseliste.Add(studerende1);
            klasseRum.Klasseliste.Add(studerende2);

            foreach (var studerende in klasseRum.Klasseliste)
            {
                Console.WriteLine(studerende.Navn);
            }



            Console.ReadLine();
        }
    }
}
