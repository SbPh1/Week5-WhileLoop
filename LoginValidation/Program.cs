using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus;
            //programm küsib kasutajal sisestada parool;
            //programm kontrollib, kas mõlemad, nii kasutajatunus
            //kui ka parool on õiged;
            //kui mõlemad,kasutajatunnus ja parool on õiged
            //programm kuvab konsoolis "Tere tulemast!"
            //kui kasutajatunnus või parool on vale, siis
            //proigramm kuvab "Sisselogimine ebaõnnestus, proovi uuesti"
            //kt:admin, pr admin1234
            //kasutjal on 3 katset

            int i = 0;

            while (1 < 3)

            {
                Console.WriteLine("Sisestage kasutajatunnus");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisestage parool");
                string userpassword = Console.ReadLine();

                if (userName == "admin" && userpassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                    //i = 3;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
                }
                
            }
            Console.WriteLine("Kena päeva");
        }
        
    }
}
