using System;

namespace WhileLoop
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
            //*kastsete arv piiramatu

            //boolean --> true/false
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN: ");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Vale PIN. Proovi uuesti.");
                }

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
