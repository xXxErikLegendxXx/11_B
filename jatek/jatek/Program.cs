using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml;

namespace jatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Karakter felépítés
            
            Console.Write("Hogy hívnak?: ");
            string nev = Console.ReadLine();
            if(nev == "")
            {
                Console.WriteLine("Narrátor: Na jó akkor legyen a neved Béla");
                Thread.Sleep(1000);
                nev = "Béla";
            }   
            Console.WriteLine($"Narrátor: Üdvözlet {nev}!");
            Thread.Sleep(1000);
            Console.WriteLine("Narrátor: Sok szerencsét!"); //Ezt a mondatot fogadd meg ha a képességeket választod!
            Thread.Sleep(2000);

            Console.Clear();

            int pontszam = 10;
            int e = 0;
            int gy = 0;
            int i = 0;
            int k = 0;
            int se = 0;

            Console.WriteLine($"Erő = {e}");
            Thread.Sleep(500);
            Console.WriteLine($"GYorsaság = {gy}");
            Thread.Sleep(500);
            Console.WriteLine($"Inteligencia = {i}");
            Thread.Sleep(500);
            Console.WriteLine($"Karizma = {k}");
            Thread.Sleep(500);
            Console.WriteLine($"SzErencse = {se}");
            Thread.Sleep(500);
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine($"{pontszam} pontot tudsz felhasználni.");

            while (true)
            {
                Console.Write("Erő:");

                string ero_szam = Console.ReadLine();

                if(int.TryParse(ero_szam,out int ero) && ero >= 0 && ero <= 10)
                {
                    e = ero;
                    pontszam -= ero;
                    break;
                }
            }

            while (true)
            {
                Console.Write("GYorsaság:");

                string gyorsasag_szam = Console.ReadLine();

                if (int.TryParse(gyorsasag_szam, out int gyorsasag) && gyorsasag >= 0 && gyorsasag <= pontszam)
                {
                    gy = gyorsasag;
                    pontszam -= gyorsasag;
                    break;
                }
            }

            while (true)
            {
                Console.Write("Inteligencia:");

                string inteligencia_szam = Console.ReadLine();

                if (int.TryParse(inteligencia_szam, out int inteligencia) && inteligencia >= 0 && inteligencia <= pontszam)
                {
                    i = inteligencia;
                    pontszam -= inteligencia;
                    break;
                }
            }

            while (true)
            {
                Console.Write("Karizma:");

                string karizma_szam = Console.ReadLine();

                if (int.TryParse(karizma_szam, out int karizma) && karizma >= 0 && karizma <= pontszam)
                { 
                    k = karizma;
                    pontszam -= karizma;
                    break;
                }
            }

            while (true)
            {
                Console.Write("SzErencse:");

                string szerencse_szam = Console.ReadLine();

                if (int.TryParse(szerencse_szam, out int szerencse) && szerencse >= 0 && szerencse <= pontszam)
                {
                    se = szerencse;
                    pontszam -= szerencse;
                    break;
                }
            }

            Console.WriteLine(pontszam);


            //Marad még pontod
            while (pontszam > 0)
            {
                Console.WriteLine($"Narrátor: Nem tudom észrevetted-e,de még van {pontszam} pontod");

                Console.WriteLine("Narrátor: Felszeretnéd használni őket? (Igen/Nem):");
                string felhasznal = Console.ReadLine().ToLower();

                while(felhasznal != "igen" && felhasznal !="nem")
                {
                    Console.WriteLine("Narrátor: Fel szeretnéd használni őket? (Igen/Nem):");
                    felhasznal = Console.ReadLine().ToLower();
                }

                if (felhasznal == "nem")
                {
                      break;
                }
                else if (felhasznal == "igen")
                {
                
                    Console.WriteLine($"Erő = {e}");//lovagitorna, sárkány
                    Thread.Sleep(500);
                    Console.WriteLine($"GYorsaság = {gy}");//sárkány
                    Thread.Sleep(500);
                    Console.WriteLine($"Inteligencia = {i}");//varázsló
                    Thread.Sleep(500);
                    Console.WriteLine($"Karizma = {k}");//sárkány (kovács)
                    Thread.Sleep(500);
                    Console.WriteLine($"SzErencse = {se}"); //varázsló, lovagitorna, sárkány
                    Thread.Sleep(500);
                    Console.WriteLine();
                    Thread.Sleep(500);

                    Console.WriteLine($"Narrátor: Maradék elkölthető pont:{pontszam}");

                    Console.WriteLine("Narrátor: Válasz egy képességet amire felakarod használni a maradék pontodat(E /GY /I /K /SE)");
                    string maradek_pont = Console.ReadLine().ToLower();

                    while (true)
                    {
                        if (maradek_pont == "e")
                        {
                            e += pontszam;
                            pontszam = 0;
                            break;
                        }

                        else if (maradek_pont == "gy")
                        {
                            gy += pontszam;
                            pontszam = 0;
                            break;
                        }

                        else if (maradek_pont == "i")
                        {
                            i += pontszam;
                            pontszam = 0;
                            break;
                        }
                        else if (maradek_pont == "k")
                        {
                            k += pontszam;
                            pontszam = 0;
                            break;
                        }
                        else if (maradek_pont == "se")
                        {
                            se += pontszam;
                            pontszam = 0;
                            break;
                        }
                        else if (maradek_pont == "egyikse")
                        {
                            pontszam = 0;
                            break;
                        }

                        Console.WriteLine("Narrátor: Válasz egy képességet amire felakarod használni a maradék pontodat(E /GY /I /K /SE)");

                        maradek_pont = Console.ReadLine().ToLower();
                    }
                }
            }

            //üdvözlés
            Console.Clear();
            Console.WriteLine($"Vendéglátó: Üdvözlet utazó!");
            Thread.Sleep(1000);

            Console.WriteLine("Vendéglátó: Mi szél hozott ide?");
            Thread.Sleep(5000);

            Console.WriteLine("Vendéglátó: Nem vagy a legbeszédesebb kedvedben");
            Thread.Sleep(1000);
            Console.WriteLine("Vendéglátó: Na, de nem is baj");
            Thread.Sleep(1000);
            Console.WriteLine("Vendéglátó: Melyik szobának a kulcsát szeretnéd választani 1-től 10-ig? ");

            int kulcs = 0;
            int lehetosegek = 0;
            int penz = 0;
            string szoba_szam = Console.ReadLine();


            while (true)
            {

                //Ha minden jól megy
                if (int.TryParse(szoba_szam, out int szam) && szam > 0 && szam <= 10)
                {

                    kulcs = szam;
                    if(szam == 3 || szam == 8)
                    {
                        Console.WriteLine($"{nev}: *Rámutat a {szam}-as kulcsra");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine($"{nev}: *Rámutat a {szam}-es kulcsra");
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine("Vendéglátó: Tessék a kulcs");
                    Thread.Sleep(1000);
                    Console.WriteLine("Vendéglátó: Jó pihenést !");
                    Thread.Sleep(1000);
                    break;
                }
                //Ha nagyobb számot mondasz
                else if (int.TryParse(szoba_szam, out int szam_nagyobb) && szam_nagyobb > 10)
                {
                    Console.WriteLine("Vendéglátó: Az egyetlen probléma ezzel a választással, hogy az a szoba foglalt.");
                    Thread.Sleep(1000);

                }
                //Ha kisebb számot mondasz
                else if (int.TryParse(szoba_szam, out int szam_kisebb) && szam_kisebb < 0)
                {

                    Console.WriteLine("Vendéglátó: Az egyetlen probléma ezzel a választással, hogy ez a szoba nem létezik.");
                    Thread.Sleep(1000);

                }
                //Ha bármi mást mondasz
                else
                {
                    Console.WriteLine($"Narrátor: A vendéglátó furcsán néz rád miközben te rámutatsz egy {szoba_szam} feliratra");
                    Thread.Sleep(1000);
                    Console.WriteLine("Vendéglátó: Nem teljesen értem, hogy mire gondolsz, hisz ilyen szoba nincs.");
                    Thread.Sleep(500);
                    lehetosegek++;
                }


                //Ha sokat hibázol választ neked a játék egy szobát
                if (lehetosegek == 2)
                {
                    Console.WriteLine("Vendéglátó: Na jó, úgylátszik nem értetted a feladatot ezért én választom neked a 7-es szobát");
                    Thread.Sleep(2000);
                    kulcs = 7;
                    break;
                }

                Thread.Sleep(1000);
                Console.WriteLine("Vendéglátó: Tehát, melyik szobát szeretnéd választani 1-től 10-ig? ");
                
            }


            //2-ES SZOBA

            if (kulcs == 2) 
            { 
                //Mennyit néztél ez azért kell, hogy más legyen a kimenetele a történetnek
                int megnezes = 0;

                Console.Clear();
                Console.WriteLine($"Narrátor:{nev} bement a szobájába és körbenéz");
                Thread.Sleep(1000);
                Console.WriteLine("Narrátor: Mit néznél meg először(Szekrény, Fiók)");
                Thread.Sleep(1000);

                string melyiket_nezed_meg = Console.ReadLine().ToLower();

                while (true)
                {
                    //Ha a szekrényt nézed meg először
                    if (melyiket_nezed_meg == "szekrény" && megnezes == 0)
                    {
                        Console.WriteLine("Narrátor: A szekrényben volt egy kabát aminek megnézted zsebét és találtál benne egy varázskövet ami egy irányt mutat");
                        Thread.Sleep(1000);
                        megnezes++;
                        Console.WriteLine("Narrátor: Megnézed a fiókot? (Igen/Nem)");
                        Thread.Sleep(1000);
                        string fiok_nezes_2 = Console.ReadLine().ToLower();

                        while (true)
                        {
                            if (fiok_nezes_2 == "igen" && megnezes == 1)
                            {
                                Console.WriteLine("Narrátor: A fiók üres volt.");
                                Thread.Sleep(1000);
                                break;
                            }
                            else if(fiok_nezes_2 == "nem" && megnezes == 1){

                                Console.WriteLine($"Narrátor: {nev} úgy döntött, hogy nem nézi meg a fiókot");
                                Thread.Sleep(2000);
                                Console.WriteLine("Narrátor: Milyen igaza van végülis úgyis csak kacatok vannak benne. Ugye?");
                                Thread.Sleep(4000);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Narrátor: Elnézést kérek, elfelejtettem, hogy milyen nehéz kérdést tettem fel");
                                Thread.Sleep(3000);
                                Console.WriteLine("Narrátor: Hagy ismételjem meg mégegyszer");
                                Thread.Sleep(3000);
                                Console.WriteLine("Narrátor: Megnézed a fiókot? (Igen/Nem)");
                                fiok_nezes_2 = Console.ReadLine().ToLower();

                            }
                        }
                    }

                    //Ha a fiókot nézed meg először
                    else if (melyiket_nezed_meg == "fiók" && megnezes == 0)
                    {

                        Console.WriteLine("Narrátor: A fiókban volt egy varázskő ami egy írányt mutat");
                        Thread.Sleep(1000);
                        megnezes++;
                        Console.WriteLine("Narrátor: Megnézed a szekrényt? (Igen/Nem)");
                        Thread.Sleep(1000);
                        string szekreny_nezes_2 = Console.ReadLine().ToLower();

                        while (true)
                        {
                            if (szekreny_nezes_2 == "igen" && megnezes == 1)
                            {
                                Console.WriteLine("Narrátor: A szekrényben volt egy kabát aminek zsebében csak egy megromlott cukorka volt");
                                Thread.Sleep(1000);
                                break;
                            }
                            else if (szekreny_nezes_2 == "nem" && megnezes == 1)
                            {

                                Console.WriteLine($"Narrátor: {nev} nem nézi meg a szekrényt");
                                Thread.Sleep(3000);
                                Console.WriteLine("Narrátor: Végülis mi lehet egy szekrényben véletlen sem lehetne ott Narnia");
                                Thread.Sleep(3000);
                                Console.WriteLine("Narrátor: Vagy egy kabát amiben arany van");
                                Thread.Sleep(3000);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Narrátor: Nem teljesen értettem, hogy a válasznak mi köze a kérdéshez");
                                Thread.Sleep(2000);
                                Console.WriteLine("Narrátor: Ezért megkérdezem mégegyszer");
                                Thread.Sleep(2000);
                                Console.WriteLine("Narrátor: Megnézed a szekrényt? (Igen/Nem)");
                                szekreny_nezes_2 = Console.ReadLine().ToLower();

                            }
                        }
                    }
                    //Ha meg nem jó a reakció újra kérdezi
                    else
                    {

                        if (melyiket_nezed_meg == "fiók" || melyiket_nezed_meg == "szekrény")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Narrátor: Öszintén fogalmam sincs, hogy mit olvastál félre,hogy azt írd,hogy {melyiket_nezed_meg} de nem baj");
                            Thread.Sleep(1000);
                            Console.WriteLine("Narrátor: Próbáljuk újra");
                            Thread.Sleep(1000);
                            Console.WriteLine("Narrátor: Tehát mit néznél meg először(Szekrény, Fiók)");

                            melyiket_nezed_meg = Console.ReadLine().ToLower();

                        }
                    }

                    Console.WriteLine($"Narrátor: {nev} elvette a varázskövet és lefeküdt aludni");
                    Thread.Sleep(2000);

                    Console.Clear();
                    Console.WriteLine("Narrátor: Másnap reggel lett");
                    Thread.Sleep(3000);
                    Console.WriteLine($"Narrátor: {nev} felkelt és ahogy lehetett elkezdte követni a követ");
                    Thread.Sleep(3000);
                    Console.WriteLine("Narrátor: A Kő a vendéglátóból kivezette főszereplőnket");
                    Thread.Sleep(3000);
                    Console.WriteLine("Narrátor: De még mielött kiment volna főszereplőnk megállította őt a vendéglátó");
                    Thread.Sleep(4000);
                    Console.WriteLine("Vendéglátó: Nocsak nocsak, ahogy látom megtaláltad a varázskövet");
                    Thread.Sleep(4000);
                    Console.WriteLine("Narrátor: Vajon honnan tud a vendéglátó a varázskőről");
                    Thread.Sleep(4000);
                    Console.WriteLine("Vendéglátó: Most biztos azon gondolkodsz, hogy honnan tudok a kőröl");
                    Thread.Sleep(4000);
                    Console.WriteLine("Vendéglátó: Az elötted lévő emberé volt, aki egy varázsló volt elmondása szerint");
                    Thread.Sleep(4000);
                    Console.WriteLine("Vendéglátó: A követ pedig itt hagyta mikor elment");
                    Thread.Sleep(3000);
                    Console.WriteLine("Vendéglátó: Vissza adod neki? (Igen/Nem)");
                    string vissza_adod_neki = Console.ReadLine().ToLower();

                    while (true)
                    {
                        if (vissza_adod_neki == "igen")
                        {
                            Console.WriteLine($"Narrátor: {nev} bólogatva beleegyezett");
                            Thread.Sleep(3000);
                            Console.WriteLine("Vendéglátó: Szuper!");
                            Thread.Sleep(2000);
                            Console.WriteLine("Vendéglátó: Akkor utadra is engedlek");
                            Thread.Sleep(3000);
                            break;

                        }
                        else if (vissza_adod_neki == "nem")
                        {
                            Console.WriteLine($"Narrátor: {nev} rázta a fejét de lényegtelen volt hisz így is úgyis elmegy a varázslóhoz");
                            Thread.Sleep(3000);
                            Console.WriteLine("Narrátor: A vendéglátó pedig azt hitte hogy beleegyeztél");
                            Thread.Sleep(2000);
                            Console.WriteLine("Vendéglátó: Szuper!");
                            Thread.Sleep(2000);
                            Console.WriteLine("Vendéglátó: Akkor utadra is engedlek");
                            Thread.Sleep(2000);
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Vendéglátó: Ezt nem igazán értem");
                            Thread.Sleep(2000);
                            Console.WriteLine("Narrátor: Én sem értem teljesen");
                            Thread.Sleep(2000);
                            Console.WriteLine("Vendéglátó: Tehát vissza adod neki? (Igen/Nem)");

                            vissza_adod_neki = Console.ReadLine();
                        }
                    }
                    Console.Clear();
                    Console.WriteLine($"Narrátor: {nev} megérkezett a varázsló barlangjának bejáratához");
                    Thread.Sleep(2000);
                    Console.WriteLine("Narrátor: Találtál a barlang bejárata mellett egy csengőt");
                    Thread.Sleep(2000);
                    Console.WriteLine("Narrátor: Megnyomod? (Igen/Nem)");

                    string megnyomod_e = Console.ReadLine().ToLower();

                    while (true)
                    {

                        if(megnyomod_e == "igen") 
                        {

                            Console.WriteLine($"Narrátor: {nev} illedelmesen becsengetett a barlangba");
                            Thread.Sleep(2000);
                            Console.WriteLine("Narrátor: És a varázsló kiszólt");
                            Thread.Sleep(2000);
                            Console.WriteLine("Varázsló: Gyere be utazó");
                            Thread.Sleep(2000);
                            Console.WriteLine($"Narrátor: {nev} bement a barlangba és találkozott a varázslóval");
                            Thread.Sleep(2000);
                            Console.WriteLine("Varázsló: Üdvözlet utazó");
                            break;

                        }
                        else if(megnyomod_e == "nem") 
                        {

                            Console.WriteLine("Narrátor: Nem csengettél be a barlangba");
                            Thread.Sleep(2000);
                            Console.WriteLine("Narrátor: De nem baj nem mindenkit neveltek illedelemre");
                            Thread.Sleep(2000);
                            Console.WriteLine("Narrátor: Barlangba menet közbe ráléptél egy mágikus csapdára");
                            Thread.Sleep(2000);
                            Console.WriteLine("Narrátor: A csapda pedig beteleportált a varázsló egyik ketrecébe");
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Narrátor: Nem igazán értettem");
                            Thread.Sleep(2000);
                            Console.WriteLine("Narrátor: Megnyomod a csengőt? (Igen/Nem)");
                            megnyomod_e = Console.ReadLine().ToLower();
                        } 
                    }

                    Console.WriteLine("Narrátor: Nem ismerős a varázsló ?");
                    Thread.Sleep(4000);
                    Console.WriteLine("Narrátor: Így, igaz ő volt a vendéglátó");
                    Thread.Sleep(2000);

                    if (megnyomod_e == "nem")
                    {
                        Console.WriteLine("Varázsló: Elnézést a kellemetlenségért");
                        Thread.Sleep(2000);
                        Console.WriteLine("Varázsló: kiengedlek a ketrecből");
                        Thread.Sleep(2000);
                        Console.WriteLine("Narrátor:A varázsló kiengedett téged");
                    }

                    Console.WriteLine("Varázsló: Tudom miért jöttél");
                    Thread.Sleep(2000);
                    Console.WriteLine("Narrátor: Persze, hogy tudja hisz már érdeklődött a kővel kapcsolatban a vendéglőben");
                    Thread.Sleep(5000);
                    Console.WriteLine("Varázsló: Nálad van a kövem és jöttél vissza adni nekem");
                    Thread.Sleep(3000);
                    Console.WriteLine("Varázsló: Ugye?(Igen/Nem)");
                    Thread.Sleep(2000);

                    string vissza_adod = Console.ReadLine().ToLower();

                    while (true)
                    {
                        if(vissza_adod == "igen" && vissza_adod_neki == "igen")
                        {
                            Console.WriteLine("Narrátor: Betartottad a szavadat és vissza adtad neki a követ");
                            Thread.Sleep(4000);
                            Console.WriteLine("Narrátor: Jó döntés");
                            break;
                        }
                        else if (vissza_adod == "igen" && vissza_adod_neki == "nem")
                        {
                            Console.WriteLine("Narrátor: Eredetileg azt mondtad, hogy nem adod oda");
                            Thread.Sleep(3000);
                            Console.WriteLine("Narrátor: De úgy látszik meggondoltad magad");
                            Thread.Sleep(2000);
                            Console.WriteLine("Narrátor: Helyesen cselekedtél");
                            break;
                        }
                        else if (vissza_adod == "nem" && vissza_adod_neki == "igen")
                        {
                            Console.WriteLine("Narrátor: Eredetileg azt mondtad, hogy oda adod neki");
                            Thread.Sleep(3000);
                            Console.WriteLine("Narrátor: megszegted a szavad");
                            Thread.Sleep(3000);
                            Console.WriteLine("Narrátor: Ez nem szép dolog");
                            Thread.Sleep(2000);
                            break;
                        }
                        else if (vissza_adod == "nem" && vissza_adod_neki == "nem")
                        {
                            Console.WriteLine("Narrátor: Nem gondoltad meg magad");
                            Thread.Sleep(2000);
                            Console.WriteLine("Narrátor: Úgy gondolod hogy nálad jobb kezekben van egy kő");
                            Thread.Sleep(3000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Varázsló: Nem igazán értettem");
                            Thread.Sleep(2000);
                            Console.WriteLine("Varázsló: Tudnál válaszolni arra, hogy oda adod-e a követ vagy sem");
                            Thread.Sleep(2000);
                            vissza_adod = Console.ReadLine().ToLower();
                        }
                    }

                    if(vissza_adod == "nem")
                    {

                        Console.WriteLine("Varázsló: Rendben akkor tartsd meg magadnak");
                        Thread.Sleep(3000);
                        Console.WriteLine("Varázsló: Tessék itt egy varázsseprű és menj el amíg lehet");  
                    }

                    else if (vissza_adod == "igen")
                    {
                        Console.WriteLine("Varázsló: Köszönöm szépen a követ, ennek segítségével tudok egy főzetet keverni neked");
                        Thread.Sleep(4000);
                        Console.WriteLine("Varázsló: Ami megoldja a problémád");
                        Thread.Sleep(3000);
                        Console.WriteLine("Narrátor: A varázsló csinált egy főzetet és odaadta neked");
                        Thread.Sleep(4000);
                        Console.WriteLine("Narrátor: Megiszod a főzetet ?(Igen/Nem)");
                        Thread.Sleep(2000);
                        string megiszod_a_fozetet = Console.ReadLine().ToLower();

                        while (true)
                        {
                            if(megiszod_a_fozetet == "igen")
                            {
                                Console.WriteLine($"Narrátor: {nev} megbízott a varázslóba és megitta a főzetet");
                                break;
                            }
                            else if (megiszod_a_fozetet == "nem")
                            {
                                Console.WriteLine($"Narrátor: {nev} nem bízott meg a varázslóba és nem itta meg");
                                Thread.Sleep(4000);
                                Console.WriteLine($"Narrátor: Ebben a pillanatban pedig megszomjazott {nev}");
                                Thread.Sleep(3000);
                                Console.WriteLine("Narrátor: Viszont véletlen a víz helyett a főzetett ittad meg");
                                break;


                            }

                            Console.WriteLine("Narrátor: Megismételnéd a választ");
                            megiszod_a_fozetet = Console.ReadLine();

                        }
                        Thread.Sleep(3000);
                        Console.WriteLine("Narrátor: Szerencsédre a főzettől vissza nyerted a beszéd képességedet");
                        Thread.Sleep(4000);
                        Console.WriteLine($"Narrátor: Gyerünk {nev} mondj valamit");

                        string mondas = Console.ReadLine();

                        if (mondas == "")
                        {
                            Console.WriteLine("Varázsló: Akkor ne mondj semmit");
                            Thread.Sleep(3000);
                            Console.WriteLine("Varázsló: Én tudom hogy te már tudsz beszélni");

                        }
                        else
                        {
                            Console.WriteLine($"{nev}: {mondas}");
                            Thread.Sleep(5000);
                            Console.WriteLine($"Narrátor: {nev}..");
                            Thread.Sleep(5000);
                            Console.WriteLine("Narrátor: Ez gyönyörű volt");
                            Thread.Sleep(2000);
                        }
                        Console.WriteLine("Varázsló: Na ezzel meg is lennénk");
                        Thread.Sleep(3000);
                        Console.WriteLine("Varázsló: Most pedig válaszolj nekem pár találós kérdésre");
                        Thread.Sleep(3000);
                        Console.WriteLine("Varázsló: Hogy begyakorold a beszédet, és minden helyes válaszért kapsz aranyat");
                        Thread.Sleep(4000);
                        Console.WriteLine("Narrátor: Mi ez, valami legyen ön is milliomos utánzat?");
                        Thread.Sleep(4000);
                        Console.WriteLine("Varázsló: Pontosan olyan mint egy legyen ön is milliomos utánzat");
                        Thread.Sleep(5000);
                        Console.WriteLine("Varázsló: Első Kérdés");
                        Thread.Sleep(3000);
                        Console.WriteLine("Varázsló: Mikor fekszel, ő akkor kel, egyszer egész, máskor csak fél");
                        Thread.Sleep(2000);

                        Console.WriteLine("Varázsló: Mi az ?");

                        int helyes_valasz = 2;
                        string mi_az_1 = Console.ReadLine().ToLower(); 

                        Console.WriteLine($"{nev}: {mi_az_1}");
                        //első kérdés
                        if (mi_az_1 == "a hold" && mi_az_1 == "hold")
                        {
                            Console.WriteLine("Varázsló: Így igaz a hold volt");
                            Thread.Sleep(2000);
                        }
                        else if( i > 2)
                        {
                            Console.WriteLine($"Narrátor: Mivel {nev} inteligencia szintje megfelelő");
                            Thread.Sleep(3000);
                            Console.WriteLine($"Narrátor: Megtudta állapítani, hogy a válasz biztos,hogy nem {mi_az_1} lesz");
                            Thread.Sleep(5000);
                            Console.WriteLine("Narrátor: Hanem a hold");
                            Thread.Sleep(2000);
                            Console.WriteLine($"{nev}: A hold");
                            Thread.Sleep(2000);
                            Console.WriteLine("Varázsló: Így igaz a hold volt");
                            Thread.Sleep(2000);

                        }
                        else if(se > 4)
                        {
                            Console.WriteLine("Narrátor: Nem épp erre a válaszra gondolt,de nembaj szerencséd van");
                            Thread.Sleep(3000);
                            Console.WriteLine($"Narrátor: Mivel este volt {nev} meglátta a holdat a barlang bejáratából");
                            Thread.Sleep(5000);
                            Console.WriteLine("Narrátor: Így már rájött, hogy a válasz a hold lesz");
                            Thread.Sleep(3000);
                            Console.WriteLine($"{nev}: A hold");
                            Thread.Sleep(2000);
                            Console.WriteLine("Varázsló: Így igaz a hold volt");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            helyes_valasz--;
                            Console.WriteLine("Varázsló: Nem találtad el");
                            Thread.Sleep(3000);
                            Console.WriteLine("Varázsló: A megoldás a hold volt");
                            Thread.Sleep(2000);

                        }

                        //második kérdés
                        Console.WriteLine("Varázsló: Második kérdés egyben az utolsó");
                        Thread.Sleep(2000);
                        Console.WriteLine("Varázsló: Mi az?");
                        Thread.Sleep(2000);
                        Console.WriteLine("Varázsló: Feldobom semmi leeseik semmi");

                        string mi_az_2 = Console.ReadLine().ToLower();

                        Console.WriteLine($"{nev}: {mondas}");

                        if(mi_az_2 == "semmi" && mi_az_2 == "a semmi")
                        {
                            Console.WriteLine("Varázsló: Így igaz a semmi volt");
                            Thread.Sleep(2000);
                        }
                        else if (i > 4)
                        {
                            Console.WriteLine($"Narrátor: Mivel {nev} inteligencia szintje megfelelő");
                            Thread.Sleep(3000);
                            Console.WriteLine($"Narrátor: Megtudta állapítani, hogy a válasz biztos,hogy nem {mi_az_2} lesz");
                            Thread.Sleep(5000);
                            Console.WriteLine("Narrátor: Hanem a semmi");
                            Thread.Sleep(2000);
                            Console.WriteLine($"{nev}: A semmi");
                            Thread.Sleep(2000);
                            Console.WriteLine("Varázsló: Így igaz a semmi volt");
                            Thread.Sleep(2000);
                        }
                        else if(se > 6)
                        {

                            Console.WriteLine("Narrátor: Nem épp erre a válaszra gondolt,de nembaj szerencséd van");
                            Thread.Sleep(3000);
                            Console.WriteLine($"Narrátor: {nev} meglátta az üres főzetes palackját");
                            Thread.Sleep(5000);
                            Console.WriteLine("Narrátor: Így már rájött, hogy a válasz a semmi lesz");
                            Thread.Sleep(3000);
                            Console.WriteLine($"{nev}: A semmi");
                            Thread.Sleep(2000);
                            Console.WriteLine("Varázsló: Így igaz a semmi volt");
                            Thread.Sleep(2000);

                        }
                        else
                        {

                            helyes_valasz--;
                            Console.WriteLine("Varázsló: Nem találtad el");
                            Thread.Sleep(3000);
                            Console.WriteLine("Varázsló: A megoldás a semmi volt");
                            Thread.Sleep(2000);

                        }

                        

                        if(helyes_valasz  == 2)
                        {
                            Console.WriteLine("Varázsló: Na remek");
                            Thread.Sleep(2000);
                            Console.WriteLine("Varázsló: Minden kérdésre tudtál válaszolni így megkapod a jutalmad");
                            Thread.Sleep(4000);
                            Console.WriteLine("Varázsló: Ami 12000 arany lesz");

                            penz = 12000;

                            Thread.Sleep(2000);
                            Console.WriteLine("Varázsló: A beszéd pedig hibátlanul megy");


                        }
                        else if (helyes_valasz == 1)
                        {
                            Console.WriteLine("Varázsló: Na remek");
                            Thread.Sleep(2000);
                            Console.WriteLine("Varázsló: Egy kérdésre tudtál válaszolni így a jutalmad felét megkaphatod");
                            Thread.Sleep(4000);
                            Console.WriteLine("Varázsló: Ami 6000 arany lesz");
                            Thread.Sleep(2000);

                            penz = 6000;

                            Console.WriteLine("Varázsló: A beszéd pedig ment szerencsére");




                        }
                        else
                        {
                            Console.WriteLine("Varázsló: Na...");
                            Thread.Sleep(2000);
                            Console.WriteLine("Varázsló: Egy kérdésre sem válaszoltál jól");
                            Thread.Sleep(3000);
                            Console.WriteLine("Varázsló: Így nem kapod meg a jutalmat");
                            Thread.Sleep(3000);
                            Console.WriteLine("Varázsló: De legalább már tudsz beszélni");

                        }

                        if(penz == 12000) 
                        {

                            Console.WriteLine($"Narrátor: Így végződött {nev} napja");
                            Thread.Sleep(3000);
                            Console.WriteLine($"Narrátor: Most már tudsz beszéni és még {penz} aranyad is lett");
                            Thread.Sleep(4000);
                        
                        }
                        else if (penz == 6000) 
                        {
                            Console.WriteLine($"Narrátor: Így végződött {nev} napja");
                            Thread.Sleep(3000);
                            Console.WriteLine($"Narrátor: Most már tudsz beszéni és még {penz} aranyad is lett");
                            Thread.Sleep(4000);
                        }
                        else 
                        {
                            Console.WriteLine($"Narrátor: Így végződött {nev} napja");
                            Thread.Sleep(3000);
                            Console.WriteLine($"Narrátor: Most már tudsz beszéni viszont 1 arany fityinged sincs");
                            Thread.Sleep(4000);
                        }

                        Console.WriteLine("Narrátor: Élvezd ki beszéd képességedet");
                        Thread.Sleep(3000);
                        Console.WriteLine("Narrátor:Most pedig mondj egy utolsó mondatot");

                        string utolso_mondat = Console.ReadLine();

                        Console.WriteLine($"{nev}: gorjbgivkjepofloeőlgfrekigh");
                        Thread.Sleep(5000);

                        Console.WriteLine("Narrátor: Ezen majd még gyakoronod kell");
                    } 
                }
            }
            // 2-es szoba vége
            


            // 7-ES SZOBA
            else if(kulcs == 7)
            {
                Console.WriteLine("Vendéglátó: Upsz");
                Thread.Sleep(2000);
                Console.WriteLine("Vendéglátó: Ezt elfelejtettem mondani de a 7-es szoba nem jó");
                Thread.Sleep(3000);
                Console.WriteLine("Vendéglátó: Felújítás alatt van");
                Thread.Sleep(3000);
                Console.WriteLine("Vendéglátó: A gyorsaságot és a karizmát majd itt fogod tudni felhasználni");
                Thread.Sleep(5000);
                Console.WriteLine("Vendéglátó: Addig is indítsd újra a játékot és válassz egy másik szobát");
            }
            //7-es szoba vége 







            //Minden másik szoba
            else
            {
                Console.Clear();
                //Bemész a szobádba meglátod a posztert és alszol
                Console.WriteLine($"Narrátor: {nev} bement a szobájába és meglátott egy posztert egy lovagi tornával kapcsolatban");
                Thread.Sleep(3000);
                Console.WriteLine($"Narrátor: {nev} szeme felragyogott mikor meglátta ezt a lehetőséget");
                Thread.Sleep(3000);
                Console.WriteLine($"Narrátor: Mindig is erre várt, hogy legyen lehetősége megmutatni tehetségét valahol");
                Thread.Sleep(3000);
                Console.WriteLine($"Narrátor: {nev} mihamarást lefeküdt aludni, hogy részt tudjon venni ezen a tornán");
                Thread.Sleep(3500);

                Console.Clear();

                //Reggel van
                Console.WriteLine($"Narrátor: Kireggeledett és {nev} ahogy lehetett felkelt és elindult útjára");
                Thread.Sleep(3000);
                Console.WriteLine("Vendéglátó: Jóreggelt utazó!");
                Thread.Sleep(3000);
                Console.WriteLine("Vendéglátó: Látta a posztert a lovagi tornával kap..");
                Thread.Sleep(2500);
                Console.WriteLine($"Narrátor: {nev} kinyargalt a fogadóból még a kérdésre sem válaszolt");
                Thread.Sleep(5000);
                Console.WriteLine($"Narrátor: {nev} nem érzed rosszúl magad, hogy csak úgy ignoráltad a vendéglátót? (De, Nem)");

                string rosszul_erzed_magad = Console.ReadLine().ToLower();

                while (true)
                {
                    

                    if (rosszul_erzed_magad == "de")
                    {

                        Console.WriteLine("Narrátor: Nagyon helyes");
                        Thread.Sleep(3000);
                        Console.WriteLine($"Narrátor: Tudod {nev}, nem mindenki tudja átgondolni cselekedeteinek következményét");
                        Thread.Sleep(3000);
                        Console.WriteLine($"Narrátor: De te mégis képes voltál rá");
                        Thread.Sleep(3000);
                        Console.WriteLine("Narrátor: Büszke vagyok rád");
                        Thread.Sleep(4000);
                        break;

                    }
                    else if (rosszul_erzed_magad == "nem")
                    {

                        Console.WriteLine("Narrátor: Oh mit is gondoltam");
                        Thread.Sleep(3000);
                        Console.WriteLine("Narrátor: Hisz ez úgyis csak egy játék, nem ?");
                        Thread.Sleep(3000);
                        Console.WriteLine("Narrátor: Itt nincsenek érzéseik az embereknek");
                        Thread.Sleep(3000);
                        Console.WriteLine("Narrátor: Hát képzeld el vannak");
                        Thread.Sleep(3000);
                        Console.WriteLine("Narrátor: Úgyhogy jó lenne ha átgondolnád cselekedeteidet");
                        Thread.Sleep(4000);
                        break;

                    }
                    else
                    {

                        Console.WriteLine("Narrátor: Nem teljesen értettem");
                        Thread.Sleep(1000);
                        Console.WriteLine($"Narrátor: Tehát, {nev} nem érzed rosszúl magad, hogy csak úgy ignoráltad a vendéglátót? (De, Nem)");
                        rosszul_erzed_magad = Console.ReadLine().ToLower();

                    }

                }
                Console.WriteLine($"Narrátor: Ohh, míg beszélgettünk fel sem tűnt, hogy megérkeztünk a tornára");
                Thread.Sleep(3000);
                Console.WriteLine("Narrátor: Lépj be a tornára");
                Thread.Sleep(3000);

                Console.Clear();

                //A tornán
                Console.WriteLine("Torna vezető: Üdvözlet utazó!");
                Thread.Sleep(1500);
                Console.WriteLine("Torna vezető: Miben segíthetek ?");
                Thread.Sleep(1500);
                Console.WriteLine($"Narrátor: {nev} ismerősnek tartotta a lovagi torna vezetőjét");
                Thread.Sleep(1500);
                Console.WriteLine($"Narrátor: Így igaz {nev} ő volt a vendéglátó");
                Thread.Sleep(1500);
                Console.WriteLine("Narrátor: Nem olyan nagy falu ez úgy látszik");
                Thread.Sleep(1500);

                //Ha rosszúl éreztet magad akkor segít neked a játék
                if(rosszul_erzed_magad == "de" && e >= 4 || se >= 5)
                {
                    if (e >= 8 || se >= 7)
                    {
                        Console.WriteLine("Torna vezető: A testalkatodból kiindúlva nincs ellenfeled");
                        Thread.Sleep(2000);
                        Console.WriteLine("Torna vezető: Ezért ajánlom neked a 3-as versenyzőt");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("Torna vezető: A testalkatodból kiindúlva nem lesz nagy probléma ez a csata");
                        Thread.Sleep(2000);
                        Console.WriteLine("Torna vezető: De a 3-as versenyző szerintem nagy falat");
                        Thread.Sleep(2000);
                    }
                }   

                Console.WriteLine("Torna vezető: Melyik lovag ellen szeretnél menni ? (1-3)");

                int versenyzo = 0;
                
                while (true)
                {
                    string melyik_versenyzo = Console.ReadLine();

                    if (int.TryParse(melyik_versenyzo, out int versenyzo_szam) && versenyzo_szam > 0 && versenyzo_szam <= 3)
                    {
                        versenyzo = versenyzo_szam;

                        //1-es lovag ero = 1 1 szerencse 3000 aranyat kapsz
                        //2-es lovag ero = 4 szerencsével le lehet győzni 5 kell hozzá 5000 aranyat kapsz
                        //3-as lovag ero = 8 szerencsével le lehet győzni 7 kell hozzá 12000 aranyat kapsz + hírnevet


                        if (versenyzo == 1 || versenyzo == 2)
                        {
                            Console.WriteLine($"Torna vezető: Rendben akkor megkapod a {versenyzo}-es számú versenyzőt");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Torna vezető: Rendben akkor megkapot a {versenyzo}-as számú versenyzőt");
                            Thread.Sleep(2000);
                            break;
                        }
                          
                    }

                    Console.WriteLine("Torna vezető: Látsz ilyen versenyzőt ?");
                    Thread.Sleep(1000);
                    Console.WriteLine("Torna vezető: Tehát melyik versenyzőt szeretnéd (1-3)");
                }

                Console.WriteLine($"Narrátor: {nev} kiválasztotta riválisát");
                Thread.Sleep(2000);
                Console.WriteLine("Narrátor: Lóra ülés után pedig felkészült az ütközetre");
                Thread.Sleep(2000);


                //Torna vége itt ez csak azért kell hogy mi alapján írja ki a cuccokat
                int torna_vege = 0;
                int szer_nyer = 0;
                int e_nyer = 0;

                if(versenyzo == 1)
                {
                    Console.WriteLine($"Narrátor: {nev} és riválisa egymásnak ütköztek");
                    Thread.Sleep(2000);

                    //vesztés
                    if (e < 1 && se < 1)
                    {
                        torna_vege = 1;
                    }

                    //nyerés
                    else
                    {
                        //Mivel nyertél
                        if (e > se)
                        {
                            e_nyer = 1;
                        }
                        else
                        {
                            szer_nyer = 1;
                        }
                        torna_vege = 2;
                    }
                }
                else if(versenyzo == 2)
                {
                    Console.WriteLine($"Narrátor: {nev} és riválisa egymásnak ütköztek");
                    Thread.Sleep(2000);

                    //vesztés
                    if (e < 4 && se < 5)
                    {
                        torna_vege = 1;
                    }
                    //nyerés
                    else
                    {
                        //Mivel nyertél
                        if (e > se)
                        {
                            e_nyer = 1;
                        }
                        else if (se > e)
                        {
                            szer_nyer = 1;
                        }
                        torna_vege = 2;
                    }
                }
                else
                {
                    Console.WriteLine($"Narrátor: {nev} és riválisa egymásnak ütköztek");
                    Thread.Sleep(2000);

                    //vesztés
                    if (e < 8 && se < 7)
                    {
                        torna_vege = 1;
                    }
                    //nyerés
                    else
                    {
                        //Mivel nyertél
                        if (e > se)
                        { 
                            e_nyer = 1;
                        }
                        else if (se > e)
                        {
                            szer_nyer = 1;
                        }
                        torna_vege = 2;
                    }
                }

                //Ha nem sikerül a torna 
                if(torna_vege == 1) 
                {

                    Console.WriteLine("Narrátor: És...");
                    Thread.Sleep(4000);
                    Console.WriteLine("Narrátor: Micsoda adj egy pillanatot, csak át kell újra olvassam a forgató könyvet");
                    Thread.Sleep(4000);
                    Console.WriteLine("Narrátor: Nem lehetséges, hogy vesztettél, hisz a főszereplő vagy");
                    Thread.Sleep(4000);
                    Console.WriteLine("Narrátor: Na jó, akkor új történetet találok ki, egy pillanat");
                    Thread.Sleep(10000);
                    Console.WriteLine("Narrátor: Remek megvagyok, tehát");
                    Thread.Sleep(2000);
                    Console.WriteLine($"Narrátor: {nev} az ütközés pillanatába miközben esett volna le a lóról megkapaszkodott");
                    Thread.Sleep(3000);
                    Console.WriteLine("Narrátor: és pálcájával amit a hóna alatt tartott leütötte riválisát, így ő nyert");
                    Thread.Sleep(6000);
                    Console.WriteLine("Narrátor: Ennyi, vége a történetnek");
                    Thread.Sleep(3000);
                    Console.WriteLine("Narrátor: Ez van, ezt tudtam kitalálni");
                    Thread.Sleep(3000);
                    Console.WriteLine("Narrátor: Legközelebb nyerj mint minden másik történetben amiben van egy főszereplő");
                }

                //Ha sikerül a torna
                else if( torna_vege == 2) 
                {

                    Console.WriteLine("Narrátor: És...");
                    Thread.Sleep(4000);
                    //Ha erővel nyertél
                    if(e_nyer == 1)
                    {
                        Console.WriteLine($"Narrátor: {nev} az ütközés során lerepítette ellenfelét a lóról, riválisának esélye sem volt");
                        Thread.Sleep(4000);
                    }
                    //Ha szerencsével nyertél
                    else if (szer_nyer == 1)
                    {
                        Console.WriteLine($"Narrátor: {nev} szerencséjére az elindulás pillanatába kificamodott az ellenfél lovának a bokája így felborúlt");
                        Thread.Sleep(4000);

                    }

                    Console.WriteLine($"Narrátor: Ez álltal te lettél a győztes");
                    Thread.Sleep(4000);

                    if(versenyzo == 1) 
                    {

                        Console.WriteLine($"Torna Vezető: Mivel az 1-es versenyzőt legyőzted");
                        Thread.Sleep(2000);
                        Console.WriteLine("Torna Vezető: Nyereményed 3000 arany");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Narrátor: {nev} megkapta a 3000 aranyat és elment a tornáról");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Narrátor: {nev} a 3000 aranyával bemegy egy vendéglátóba és elszórakozza pénzét");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Narrátor: Ezután pedig {nev} bement a szobájába és meglátott egy posztert egy lovagi tornával kapcsolatban");
                        Thread.Sleep(4000);
                        Console.WriteLine("Narrátor: És ezt boldogan csinálja napról napra míg meg nem hal");

                    }
                    else if (versenyzo == 2) 
                    {
                        Console.WriteLine($"Torna Vezető: Mivel az 2-es versenyzőt legyőzted");
                        Thread.Sleep(2000);
                        Console.WriteLine("Torna Vezető: Nyereményed 5000 arany");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Narrátor: {nev} megkapta a 5000 aranyat és elment a tornáról");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Narrátor: {nev} a 5000 aranyával vett egy lovat");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Narrátor: A lóval pedig tovább járja a falukat és különböző kalandokat él meg");
                        Thread.Sleep(4000);
                        Console.WriteLine("Narrátor: És boldogan él míg meg nem hal");
                    }
                    else if (versenyzo == 3) 
                    {
                        Console.WriteLine($"Torna Vezető: Mivel az 3-as versenyzőt legyőzted");
                        Thread.Sleep(2000);
                        Console.WriteLine("Torna Vezető: Nyereményed 12000 arany és hírnév a faluban");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Narrátor: {nev} megkapta a 12000 aranyat és elment a tornáról");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Narrátor: Mindenki ismert és tisztelt téged a torna után");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Narrátor: A hírneved miatt elvetted a királynőt feleségül");
                        Thread.Sleep(4000);
                        Console.WriteLine("Narrátor: És boldogan éltetek míg meg nem haltatok");
                    }
                }

            //Minden másik szoba vége
            }
        }
    }
}