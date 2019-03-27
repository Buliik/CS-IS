using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace str
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Templates.FormMain());

        }

        static void ZakTest()
        {

            Zakaznik zak = new Zakaznik
            {
                idZak = 1,
                Jmeno = "Frank",
                Prijmeni = "Castle",
                email = "punisher@micro.com",
                Datum_narozeni = new DateTime(1985, 6, 25)
            };

            Console.WriteLine("Testovani funkce zakaznika Insert - Vypis poctu prvku - update - select - delete - Vypis poctu prvku.\n"
                + zak.Jmeno + " " + zak.Prijmeni);

            ZakaznikTable.Insert(zak);

            int count = ZakaznikTable.select().Count;

            zak.Jmeno = "Franta";
            zak.Prijmeni = "Hrad";

            ZakaznikTable.update(zak);

            zak.Jmeno = "a";
            zak.Prijmeni = "b";

            Console.WriteLine("#C: " + count);

            zak = ZakaznikTable.select(1);

            Console.WriteLine(zak.Jmeno + " " + zak.Prijmeni);

            ZakaznikTable.delete(1);

            count = ZakaznikTable.select().Count;

            ZakaznikTable.Insert(zak);

            //Console.WriteLine("Vypis nejpopularnejsich zbrani pro kazdeho zakaznika: \n" + ZakaznikTable.NejpopularnejsiZbrane());

            Console.WriteLine("#C: " + count + "\n" + "Test pro tabulku zakaznik ukoncen, stisknutim libovolne klavesy pokracujte k dalsimu testu.");

            Console.ReadKey();

        }

        static void ZamTest()
        {

            Zamestnanec zam = new Zamestnanec
            {
                idZam = 1,
                Jmeno = "Steve",
                Prijmeni = "Nojobs",
                email = "notworking@microsoft.com",
                Datum_narozeni = new DateTime(1989, 7, 15)
            };

            Console.WriteLine("Testovani funkce zamestnance Insert - Vypis poctu prvku - update - select - delete - Vypis poctu prvku.\n"
                + zam.Jmeno + " " + zam.Prijmeni);

            ZamestnanecTable.insert(zam);

            int count = ZamestnanecTable.select().Count;

            zam.Jmeno = "Zmenil";
            zam.Prijmeni = "Jmeno";

            ZamestnanecTable.update(zam);

            zam.Jmeno = "a";
            zam.Prijmeni = "b";

            Console.WriteLine("#C: " + count);

            zam = ZamestnanecTable.select(1);

            Console.WriteLine(zam.Jmeno + " " + zam.Prijmeni);

            ZamestnanecTable.delete(1);

            count = ZamestnanecTable.select().Count;

            ZamestnanecTable.insert(zam);

            Console.WriteLine("#C: " + count + "\n" + "Test pro tabulku zamestnanec ukoncen, stisknutim libovolne klavesy pokracujte k dalsimu testu.");

            Console.ReadKey();

        }

        static void ZbrTest()
        {

            Zbran zbr = new Zbran
            {
                idZbr = 1,
                Nazev = "AK-47 Kalashnikov",
                Typ_zbrane= "Utocna puska",
                Raze = 7.62,
                Rok_vyroby = 1995
            };

            Console.WriteLine("Testovani funkce zbrane Insert - Vypis poctu prvku - update - select - delete - Vypis poctu prvku.\n"
                + zbr.Nazev + " " + zbr.Typ_zbrane);

            ZbranTable.insert(zbr);

            int count = ZbranTable.select().Count;

            zbr.Nazev = "MP 40";
            zbr.Typ_zbrane = "Samopal";

            ZbranTable.update(zbr);

            zbr.Nazev = "a";
            zbr.Typ_zbrane = "b";

            Console.WriteLine("#C: " + count);

            zbr = ZbranTable.select(1);

            Console.WriteLine(zbr.Nazev + " " + zbr.Typ_zbrane);

            ZbranTable.delete(1);

            count = ZbranTable.select().Count;

            ZbranTable.insert(zbr);

            Console.WriteLine("#C: " + count + "\n" + "Test pro tabulku zbran ukoncen, stisknutim libovolne klavesy pokracujte k dalsimu testu.");

            Console.ReadKey();

        }

        static void SprTest()
        {

            Prostor spr = new Prostor
            {
                idSpr = 1,
                vzdalenost = 10
            };

            Console.WriteLine("Testovani funkce prostoru Insert - Vypis poctu prvku - update - select - delete - Vypis poctu prvku.\n"
                + spr.vzdalenost);

            ProstorTable.insert(spr);

            int count = ProstorTable.select().Count;

            spr.vzdalenost = 50;

            ProstorTable.update(spr);

            spr.vzdalenost = 0;

            Console.WriteLine("#C: " + count);

            spr = ProstorTable.select(1);

            Console.WriteLine(spr.vzdalenost);

            ProstorTable.delete(1);

            count = ProstorTable.select().Count;

            ProstorTable.insert(spr);


            Console.WriteLine("#C: " + count + "\n" + "Test pro tabulku Prostor ukoncen, stisknutim libovolne klavesy pokracujte k dalsimu testu.");
         

            Console.ReadKey();

        }

        static void RezTest()
        {

            Rezervace rez = new Rezervace
            {
                idRez = 1,
                datumVytvoreni = DateTime.Today,
                datumStrelby = new DateTime(2014, 10, 10),
                Zakaznik_idZak = 2,
                Zbran_idZbr = 2,
                Prostor_idSpr = 2
            };


            Console.WriteLine("Testovani funkce Rezervace Insert - Vypis poctu prvku - update - select - delete - Vypis poctu prvku.\n"
                + rez.datumStrelby);

            RezervaceTable.insert(rez);

            int count = RezervaceTable.select().Count;


            rez.datumStrelby = rez.datumStrelby.AddDays(3);

            RezervaceTable.update(rez);

            rez.datumStrelby = rez.datumStrelby.AddDays(3);

            Console.WriteLine("#C: " + count);

            rez = RezervaceTable.select(1);

            RezervaceTable.StrelbaDleRezervace(1, 20, 2);

            Console.WriteLine(rez.datumStrelby);

            RezervaceTable.clean();

            count = RezervaceTable.select().Count;

            Console.WriteLine("#C: " + count + "\n" + "Test pro tabulku rezervace ukoncen, stisknutim libovolne klavesy pokracujte k dalsimu testu.");

            Console.ReadKey();

        }

        static void StrTest()
        {

            Strelba str = new Strelba
            {
                idStr = 1,
                Zacatek = new DateTime(2018, 10, 10, 16, 10, 0),
                Konec = new DateTime(2018, 10, 10, 17, 30, 0),
                Zamestnanec_idZam = 2,
                Zakaznik_idZak = 2,
                Zbran_idZbr = 2,
                Prostor_idSpr = 2
            };

            Console.WriteLine("Testovani funkce Strelba Insert - Vypis poctu prvku - update - select - delete - Vypis poctu prvku.\n"
                + str.Zacatek);

            StrelbaTable.insert(str);

            int count = StrelbaTable.select().Count;

            str.Zacatek = str.Zacatek.AddMinutes(10);

            StrelbaTable.update(str);

            str.Zacatek = str.Zacatek.AddMinutes(10);

            Console.WriteLine("#C: " + count);

            str = StrelbaTable.select(1);

            Console.WriteLine(str.Zacatek);

            StrelbaTable.clean();

            count = StrelbaTable.select().Count;

            Console.WriteLine("#C: " + count + "\n" + "Test pro tabulku Strelba ukoncen, stisknutim libovolne klavesy ukoncite aplikaci.");

            Console.ReadKey();

        }

    }
}
