using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iffittely
{
    class Program
    {
        static void Main(string[] args)
        {

            // Aiheena tänään on if-else-elseif -kontrollirakenne

            string luku; // käyttäjä syöttää tähän iän 
            int ika;
            bool ok;

            Console.Write("Anna ikäsi: ");
            luku = Console.ReadLine();
            int.TryParse(luku, out ika);

            // yhtäsuuruusvertailu ==
            // muista että sijoitusoperaattori on =
            // erisuuri kuin !=
            // < pienempi kuin > suurempi kuin
            // <= pienempi tai yhtäsuuri kuin >=

            if (ok)  //eli jos syöte on ok, eli true
            {
                if (ika > 0)
                { }
                    if (ika < 18)
                    {
                        //lohko, joka toteutetaan silloin kun if:in ehto
                        // on tosi
                        Console.WriteLine("Olet alaikäinen.");
                    }
                    else
                    {
                        Console.WriteLine("Olet täysi-ikäinen.");

                        if (ika <= 65)
                        {
                            Console.WriteLine("Olet työikäinen.");
                        }
                    else {
                        Console.WriteLine("Olet eläkeläinen.");

                        }
                    }
            }
            else
            {
                Console.WriteLine("Anna positiivinen kokonaisluku!");
            }

            else
            {
                Console.WriteLine("Tarkista syötteesi!");
            }

            Console.WriteLine("Paina ENTER lopettaaksesi.");
            Console.ReadLine();
        }
    }
}
