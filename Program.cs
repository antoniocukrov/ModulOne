using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ModulOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // operacije/metode nad varijablom:
            string rijec = "Hrvatska";
            Console.WriteLine(rijec.ToLower());

            // escape characters: \n \\ \" \'
            Console.WriteLine("Ovo je neki,\ntekst u \"navodnicima\" !?");


            int broj = 1024;
            Console.WriteLine(broj);
            Console.WriteLine(broj.ToString());

            Convert.ToString(broj);
            Int32.Parse(broj.ToString());
            Console.WriteLine(broj);

            // string je niz znakova:

            string jelo = "Lasagna";
            Console.WriteLine(jelo.First());
            Console.WriteLine(jelo.Last());
            Console.WriteLine(jelo.Substring(1));
            Console.WriteLine(jelo.Substring(2, 3));
            Console.WriteLine(jelo.IndexOf('n'));
            Console.WriteLine(jelo.IndexOf("gn"));
            Console.WriteLine(jelo.IndexOf('ž'));

            string recenica = "Jedna obična rečenica";
            string[] rijeci = recenica.Split(' ');

            string red = "1234;Pero;Perić;ulica;14"; // CSV

            Console.WriteLine(red.Replace("Pero", "Marko"));

            var polja = red.Split(';');
            Console.WriteLine(red.Split(';').Last());

            var x = Int32.Parse(red.Split(';').First()).ToString().Split().Length;

            string[] tekst = recenica.Split(' ');

            if (tekst.Length > 0)
            {
                Console.WriteLine(tekst[1]);
                tekst[0] = "To";
                Console.WriteLine(tekst.ToString());
            }

            // string[] ljubimci;
            // string[] ljubimci = new string[2];
            // string[] ljubimci = new string[] { "pas", "mačka", "ribica" };
            string[] ljubimci = { "pas", "mačka", "ribica" };

            ljubimci[2] = "hrčak";

            short[] ocjene = { 1, -2, 2, -3, 3, -4, 4, -5, 5 };

            // dvodimenzionalni niz 

            int[,] matrica = new int[10, 10];
            matrica[1, 4] = 10;

            // ArrayList Collection

            ArrayList kolekcija = new ArrayList();
            kolekcija.Add(1);

            Console.WriteLine(kolekcija[0]);

            // Samo int-ovi
            List<int> brojevi = new List<int>();

            // Dodavanje namirnica u popis (* Foreach *) <------------
            string[] namirnice = new string[] { "Med", "Kruh", "Jaja", "Salata", "Kulen" };
            var popis = string.Empty;
            foreach (string n in namirnice)
            {
                popis += ", " + n;
            }
            Console.WriteLine(popis);

            // Ispiši sve neparne brojeve od 0 do 10 

            int petlja = 0;
            while (petlja < 10)
            {
                Console.WriteLine(petlja);
                // petlja++;

                if (petlja % 2 == 0)
                    petlja++;
                else if (petlja % 2 == 1)
                    petlja += 2;
            }

            Console.ReadKey();
        }
    }
}
