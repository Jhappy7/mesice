bool cont = true;

while (cont == true)
{
    DateTime cas = DateTime.Now;
    int cisloMesice = cas.Month;
    string[] poleMesicu = { "Leden", "Unor", "Brezen", "Duben", "Kveten", "Cerven", "Cervenec", "Srpen", "Zari", "Rijen", "Listopad", "Prosinec" };

    Console.WriteLine("nyní je " + poleMesicu[cisloMesice - 1]);
    Console.WriteLine("předchozí měsíc byl " + poleMesicu[cisloMesice - 2]);
    Console.WriteLine("následující měsíc bude " + poleMesicu[cisloMesice]);


    Console.WriteLine("Zadejte cislo od 1 do 12(cislomesice): ");
    int cislomesice = int.Parse(Console.ReadLine());

    if (cislomesice < 1)
    {
        Console.WriteLine("tento měsíc neexsituje");
    }
    else if (cislomesice > 12)
    {
        Console.WriteLine("tento měsíc neexistuje");
    }

    Console.WriteLine("nyní je " + poleMesicu[cislomesice - 1] + ", predochozi mesic byl " + poleMesicu[cislomesice - 2] + ", nasledujici mesic bude " + poleMesicu[cislomesice]);

    Console.WriteLine("chceš pokračovat?");
    string odpoved = Console.ReadLine().ToLower();

    if (odpoved == "ano") cont = true; else cont = false;
}

