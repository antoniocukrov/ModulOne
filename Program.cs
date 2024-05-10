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
                          "(2.)Pretvori sva slova imena i prezimena u velika slova.\n" +
                          "(3.)Pretvori sva slova imena i prezimena u velika slova.\n" +
                          "(4.)Pretvori sva slova imena i prezimena u velika slova.\n" +
                          "(5.)Pretvori sva slova imena i prezimena u velika slova.\n" +
                          "(6.)Pretvori sva slova imena i prezimena u velika slova.\n" +
                          "(7.)Pretvori sva slova imena i prezimena u velika slova.\n" +
                          "Izbor:");

            int izbor = Int32.Parse(Console.ReadLine());

            switch (izbor)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("Hello");
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
    }
}