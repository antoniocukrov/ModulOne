using System;
using System.Linq;

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
                    Console.WriteLine(ObrnutoIme(ime,prezime));
                    break;
                case 4:
                    Console.WriteLine(Hacker(ime, prezime));
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

        static string ObrnutoIme(string i, string j)
        {
            char[] ime = i.ToLower().ToCharArray();
            char[] prezime = j.ToLower().ToCharArray();
            Array.Reverse(ime);
            Array.Reverse(prezime);
            string emi = new string(ime);

            string emizerp = new string(prezime);
            return (emi.First().ToString().ToUpper() + emi.Substring(1) + " " + emizerp.First().ToString().ToUpper() + emizerp.Substring(1));
           
        }

        static string Hacker(string i, string j)
        {
            string punoIme = i.ToUpper() + " " + j.ToUpper();
            char[] hackerIme = punoIme.ToUpper().ToCharArray();

            for(int b = 0; b < hackerIme.Length;b++)
            {
                switch (hackerIme[b])
                {
                    case 'A':
                        hackerIme[b] = '4';
                        break;
                    case 'E':
                        hackerIme[b] = '3';
                        break;
                    case 'I':
                        hackerIme[b] = '1';
                        break;
                    case 'O':
                        hackerIme[b] = '0';
                        break;
                    case 'S':
                        hackerIme[b] = '5';
                        break;
                    case 'T':
                        hackerIme[b] = '7';
                        break;
                    case 'Z':
                        hackerIme[b] = '2';
                        break;
                    case 'G':
                        hackerIme[b] = '6';
                        break;
                    default: break;
                }
            }
            string hackerFullname = new string(hackerIme);
            return hackerFullname;
        }
        
    }
}