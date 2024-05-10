using System;

namespace ModulOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molimo upišite Vaše dragocijeno ime i prezime.");
            Console.WriteLine("Ova aplikacije nije u vlasništvu Spycorpa, i uopće \nne prikupljamo Vaše privatne podatke.!\n");
            Console.Write("Ime:");
            string ime = Console.ReadLine();
            Console.Write("Prezime:");
            string prezime = Console.ReadLine();

            Console.WriteLine("\nPozdrav {0}, dobrodošao u sustav Spycorpa! Kako Vam možemo pomoći?", ime);
            Console.WriteLine("U nastavku molimo odaberite Vaš zahtjev i potvrdite tipkom ENTER.\n");

            Console.Write("(1.)Pretvori sva slova imena i prezimena u velika slova.\n" +
                          "(2.)Saznaj koliko ima slova u tvome imenu i prezimenu.\n" +
                          "(3.)Obrni svoje ime i prezime.\n" +
                          "(4.)Pretvori svoje ime i prezime u H4CK3R 5P33K!\n" +
                          "(5.)Saznaj svoje inicijale.\n" +
                          "(6.)Saznaj trenutan datum i vrijeme.\n" +
                          "(7.)Saznaj vremensku temperaturu u Hrvatskoj.\n" +
                          "Izbor:");

            int izbor = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (izbor)
            {
                case 1:
                    Console.WriteLine(VelikoSlovo(ime, prezime));
                    break;
                case 2:
                    Console.WriteLine("U tvome imenu i prezimenu ima {0} slova.", BrojMiSlova(ime,prezime));
                    break;
                case 3:
                    Console.WriteLine("Hello");
                    break;
                case 4:
                    Console.WriteLine("Hello");
                    break;
                case 5:
                    Console.WriteLine("Hello");
                    break;
                case 6:
                    Console.WriteLine("Hello");
                    break;
                case 7:
                    Console.WriteLine("Hello");
                    break;
                default:
                    Console.WriteLine("Izbor nije valjan, molim ponoviti unos.");
                    break;
            }

            Console.ReadKey();
        }

        static string VelikoSlovo(string i, string j)
        {
            return i.ToUpper() + " " + j.ToUpper();
        }

        static int BrojMiSlova(string i, string j)
        {
            return i.Length + j.Length;
        }
        
    }
}