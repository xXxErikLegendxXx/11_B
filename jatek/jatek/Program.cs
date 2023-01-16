using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
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

            
            while (true)
            {
                string szoba_szam = Console.ReadLine();

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
                                Console.WriteLine("Milyen igaza van végülis úgyis csak kacatok vannak benne. Ugye?");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Narrátor: Elnézést kérek, elfelejtettem, hogy milyen nehéz kérdést tettem fel");
                                Thread.Sleep(1000);
                                Console.WriteLine("Narrátor: Hagy ismételjem meg mégegyszer");
                                Thread.Sleep(1000);
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
                                Thread.Sleep(1000);
                                Console.WriteLine("Narrátor: Végülis mi lehet egy szekrényben véletlen sem lehetne ott Narnia");
                                Thread.Sleep(1000);
                                Console.WriteLine("Narrátor: Vagy egy kabát amiben arany van");
                                Thread.Sleep(1000);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Narrátor: Nem teljesen értettem, hogy a válasznak mi köze a kérdéshez");
                                Thread.Sleep(1000);
                                Console.WriteLine("Narrátor: Ezért megkérdezem mégegyszer");
                                Thread.Sleep(1000);
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
                }
            }
            // 2-es szoba vége
            


            // 7-ES SZOBA
            else if(kulcs == 7)
            {
                Console.Clear();
                Console.WriteLine($"Narrátor: {nev} bement a szobájába és talált az asztalán egy lapot amiben egy sárkányról volt szó");
                Thread.Sleep(2000);
                Console.WriteLine("Narrátor: És ezt természetesen neked kell legyőznöd");
                Thread.Sleep(2000);
                Console.WriteLine($"Narrátor: Találtál a lap mellett egy pénzeszsákot amiben így ránézésre 1500 arany van segítek");
                Thread.Sleep(2000);
                Console.WriteLine($"Elveszed a pénz?(Igen/Nem)");
                string elveszed_a_p = Console.ReadLine().ToLower();

                while (true)

                    if (elveszed_a_p == "igen")
                    {
                        penz = 1500;
                        Console.WriteLine($"Narrátor: {nev} remekül döntött és elvette a pénzt,nem tudta kié,nem tudta honnan van, de az biztos, hogy már a tiéd");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Jelenlegi aranyad {penz}");
                        break;

                    }
                    else if (elveszed_a_p == "nem")
                    {
                        Console.WriteLine($"Narrátor: {nev} annyira becsületes,hogy nem veszi el a pénzt,vagy csak nem tudja hogy egy arany fillére sincs");
                        Thread.Sleep(2000);
                        Console.WriteLine("Narrátor: Az egyetlen dolga ami arany az a szíve");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Narrátor: Jelenlegi aranyad {penz}");
                        break;


                    }
                    else
                    {
                        Console.WriteLine($"Narrátor: {nev} ennyi pénzt életébe nem látott ezért sokkolt állapota miatt nem is tudott rendesen válaszolni");
                        Thread.Sleep(2000);
                        Console.WriteLine("Narrátor: Probáljuk meg mégegyszer");
                        Thread.Sleep(2000);
                        Console.WriteLine($"Elveszed a pénz?(Igen/Nem)");
                        elveszed_a_p = Console.ReadLine().ToLower();
                    }
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

                //Ha rosszúl érezdet magad akkor segít neked a játék
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