using System;

namespace PrvaKonzolnaAplikacija
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite šest prirodnih brojeva (razdvojenih zarezom):");
            string ulaz = Console.ReadLine();
            string[] pojedinacniUlazi = ulaz.Split(",");
            int[] brojevi = new int[6];
            for (int i = 0; i < 6; i++)
                brojevi[i] = Int32.Parse(pojedinacniUlazi[i]);    
            
            bool pozitivni = true;
            int[] neparni = new int[6];
            int brojNeparnih = 0;

            foreach (var element in brojevi)
            {
                if (element <= 0)
                    pozitivni = false;

                if (element % 2 != 0)
                    neparni[brojNeparnih++] = element;
            }

            string prikaz = pozitivni == true ? "nema" : "ima";
            Console.WriteLine("Među unesenim brojevima " + prikaz + " negativnih brojeva.");
            Console.WriteLine("Neparni brojevi: " + string.Join(" ", neparni[0..brojNeparnih]));
        }

         
    }
}