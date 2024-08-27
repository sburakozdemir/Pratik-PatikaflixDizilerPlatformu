using Pratik_PatikaflixDizilerPlatformu;

List<Diziler> diziListe = new List<Diziler>();

while (true)
{
    Diziler dizi = new Diziler();
    Console.Write("Dizinin ismini girin: ");
    dizi.Ad = Console.ReadLine();
    Console.Write("Dizinin yapım yılını girin: ");
    dizi.YapımYılı = Convert.ToInt32(Console.ReadLine());
    Console.Write("Dizinin türü: ");
    dizi.Tur = Console.ReadLine();
    Console.Write("Yayın yılı: ");
    dizi.YayınYılı = Convert.ToInt32(Console.ReadLine());
    Console.Write("Yönetmenler: ");
    dizi.Yönetmenler = Console.ReadLine();
    Console.Write("Platform: ");
    dizi.Platform = Console.ReadLine();

    diziListe.Add(dizi);
    Console.WriteLine("Dizi başarıyla eklendi...");

    Console.WriteLine("Yeni bir dizi eklemek ister misiniz? (E/H)");
    string devam = Console.ReadLine().ToLower();
    if (devam == "h")
        break;
}

// Komedi dizilerini filtreleme ve yeni liste oluşturma
var komediDiziListesi = diziListe
    .Where(d => d.Tur.ToLower() == "komedi")
    .Select(d => new KomediDizileri
    {
        Ad = d.Ad,
        Tur = d.Tur,
        Yönetmenler = d.Yönetmenler
    })
    .OrderBy(d => d.Ad)
    .ThenBy(d => d.Yönetmenler)
    .ToList();

// Komedi dizilerini ekrana yazdırma
Console.WriteLine("\nKomedi Dizileri Listesi:");
foreach (var komediDizi in komediDiziListesi)
{
    Console.WriteLine($"Adı: {komediDizi.Ad}, Tür: {komediDizi.Tur}, Yönetmen: {komediDizi.Yönetmenler}");
}