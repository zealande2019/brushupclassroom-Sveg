using System;

namespace ClassRoom
{
    public class Studerende
    {
        public Studerende( string navn, int fødselsdag, int fødselsmåned)
        {
            Navn = navn;
            Fødselsdag = fødselsdag;
            Fødslsmåned = fødselsmåned;

        }

        public string Navn { get; private set; }

        public int Fødselsdag { get; private set; }

        public int Fødslsmåned { get; private set; }

        public string Årstid()
        {
            if (Fødslsmåned == 12 || Fødslsmåned == 1 || Fødslsmåned ==2)
            {
                return "Vinter";
            }

            if (Fødslsmåned == 3 || Fødslsmåned == 4 || Fødslsmåned == 5)
            {
                return "Forår";
            }

            if (Fødslsmåned == 6 || Fødslsmåned == 7 || Fødslsmåned == 8)
            {
                return "Sommer";
            }

            if (Fødslsmåned == 9 || Fødslsmåned == 10 || Fødslsmåned == 11)
            {
                return "Efterår";
            }

            return null;
        }

    }
}