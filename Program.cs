namespace Przypomnienie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witam, to jest program przypominający.");

            string ulubionaPotrawa = "Spaghetti";
            int wiek = 26;
            decimal kieszonkowe = 50m;
            char rozmiar = 'S';
            bool czyEkstraRozmiar = true;

            Console.WriteLine($"Mam {wiek} lat i lubię {ulubionaPotrawa}.");

            for (int i = 0; i < 50; i++)
                Console.WriteLine("Jestem głodny");

            Console.WriteLine("Podaj koszt jednej porcji Twojej ulubione potrawy: ");

            decimal cena = decimal.Parse(Console.ReadLine());

            int porcje = (int)(kieszonkowe / cena);
            if (porcje < 1) 
                Console.WriteLine($"Brak kieszonkowych na {ulubionaPotrawa}.");
            else 
                Console.WriteLine($"Możesz kupić {porcje} porcji {ulubionaPotrawa}.");

            string zmienionyRozmiar = ZmienRozmiar(rozmiar);
            Console.WriteLine(zmienionyRozmiar);
            Console.WriteLine(ZmienRozmiarExtra('S', true));
            Console.WriteLine(ZmienRozmiarExtra('S', false));
            Console.WriteLine(ZmienRozmiarExtra('M', true));
            Console.WriteLine(ZmienRozmiarExtra('M', false));
            Console.WriteLine(ZmienRozmiarExtra('L', true));
            Console.WriteLine(ZmienRozmiarExtra('L', false));
            Console.ReadKey();


            Console.WriteLine(SumaLiczb(5));
            Console.WriteLine(Silnia(5));
            Console.WriteLine(CzyLiczbaPierwsza(7));
            Console.WriteLine(CzyPalindrom("kajak"));
            Console.WriteLine(CzyPalindrom("kotek"));
            Console.WriteLine(CzyAnagram("kot", "tok"));
            Console.WriteLine(CzyAnagram("kot", "kotek"));
            Console.WriteLine("Naciśnij Enter aby zakończyć...");
            Console.ReadLine();
        }





        static string ZmienRozmiar(char rozmiar)
        {
            if (rozmiar == 'S') 
                return "Small";
            else if (rozmiar == 'M') 
                return "Medium";
            else 
                return "Large";
        }

        static string ZmienRozmiarExtra(char rozmiar, bool czyRozmiarExtra)
        {
            if (rozmiar == 'S' && czyRozmiarExtra == true) 
                return "Extra Small";
            else if (rozmiar == 'S' && czyRozmiarExtra == false) 
                return "Small";
            else if (rozmiar == 'M') 
                return "Medium";
            else
            {
                if (czyRozmiarExtra == true) 
                    return "Extra Large";
                else 
                    return "Large";
            }
        }


        static int SumaLiczb(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++) 
                suma += i;
            return suma;
        }

        static int Silnia(int n)
        {
            int silnia = 1;
            for (int i = 1; i <= n; i++) 
                silnia *= i;
            return silnia;
        }

        static bool CzyLiczbaPierwsza(int n)
        {
            if (n < 2) 
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++) 
                if (n % i == 0) 
                    return false;                
            return true;
        }

        static bool CzyPalindrom(string napis)
        {
            for (int i = 0; i < napis.Length / 2; i++)
                if (napis[i] != napis[napis.Length - 1 - i])
                    return false;
            return true;
        }

        static bool CzyAnagram(string napis1, string napis2)
        {
            if (napis1.Length != napis2.Length)
                return false;
            char[] znaki1 = napis1.ToCharArray();
            char[] znaki2 = napis2.ToCharArray();
            Array.Sort(znaki1);
            Array.Sort(znaki2);
            for (int i = 0; i < napis1.Length; i++)
                if (znaki1[i] != znaki2[i])
                    return false;
            return true;
        }
    }
}