using System;

namespace PINValidationThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prog küsib kasutajal sisestada PIN-kood
            //prog võrdleb kasutaja sisestatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234
            //prog kuvab "Tere tulemast!"
            //kui sisestatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti."
            //*3 katset

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta pin");
                int userPin = Convert.ToInt32(Console.ReadLine());

                if (userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    //break;
                    i = 3;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
                }
                
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
