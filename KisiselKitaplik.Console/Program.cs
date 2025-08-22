using KisiselKitaplik.Console.Models;

string kullaniciAdi = "Bora"; // kendi adını yaz
Console.WriteLine($"{kullaniciAdi}'nin Okuma Listesi");

Kitap[] okumaListem = new Kitap[1];

okumaListem[0] = new Kitap() 
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Dikenler ve Guller Sarayi",
    kitabinSayfaSayisi = 540
};

okumaListem[1] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Sis ve Ofke Sarayi",
    kitabinSayfaSayisi = 552
};

okumaListem[2] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Kanatlar ve Kuller Sarayi",
    kitabinSayfaSayisi = 764
};

okumaListem[3] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Buz ve YildizIsigi Sarayi",
    kitabinSayfaSayisi = 288
};

okumaListem[4] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Gumus ve Alevler Sarayi",
    kitabinSayfaSayisi = 728,
};

okumaListem[5] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Cam Sato",
    kitabinSayfaSayisi = 500
};

okumaListem[6] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Karanlik Tac",
    kitabinSayfaSayisi = 500
};

okumaListem[7] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Atesin Varisi",
    kitabinSayfaSayisi = 600
};

okumaListem[8] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Golgeler Kralicesi",
    kitabinSayfaSayisi = 632
};

okumaListem[9] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Firtinalar Imparatorlugu",
    kitabinSayfaSayisi = 700
};

okumaListem[10] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Safak Kulesi",
    kitabinSayfaSayisi = 692
};

okumaListem[11] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Kul Kralligi",
    kitabinSayfaSayisi = 960,
};

okumaListem[12] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Hilal Sehir 1 (Toprak ve Kan Hanesi)",
    kitabinSayfaSayisi = 856
};

okumaListem[13] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Hilal Sehir 2 (Gokyuzu ve Nefes Hanesi)",
    kitabinSayfaSayisi = 840
};

okumaListem[14] = new Kitap()
{
    kitabinYazarininAdi = "Sarah J. Maas",
    kitabinAdi = "Hilal Sehir 3 (Alev ve Golge Hanesi)",
    kitabinSayfaSayisi = 928,
};

Console.WriteLine($"1. Kitap Adı: {okumaListem[0].kitabinAdi}");
Console.WriteLine($"1. Kitap Yazarı: {okumaListem[0].kitabinYazarininAdi}");
Console.WriteLine($"1. Kitap Sayfa Sayısı: {okumaListem[0].kitabinSayfaSayisi}\n");

Console.WriteLine($"2. Kitap Adı: {okumaListem[1].kitabinAdi}");
Console.WriteLine($"2. Kitap Yazarı: {okumaListem[1].kitabinYazarininAdi}");
Console.WriteLine($"2. Kitap Sayfa Sayısı: {okumaListem[1].kitabinSayfaSayisi}\n");

Console.WriteLine($"3. Kitap Adı: {okumaListem[2].kitabinAdi}");
Console.WriteLine($"3. Kitap Yazarı: {okumaListem[2].kitabinYazarininAdi}");
Console.WriteLine($"3. Kitap Sayfa Sayısı: {okumaListem[2].kitabinSayfaSayisi}\n");

Console.WriteLine($"4. Kitap Adı: {okumaListem[3].kitabinAdi}");
Console.WriteLine($"4. Kitap Yazarı: {okumaListem[3].kitabinYazarininAdi}");
Console.WriteLine($"4. Kitap Sayfa Sayısı: {okumaListem[3].kitabinSayfaSayisi}\n");

Console.WriteLine($"5. Kitap Adı: {okumaListem[4].kitabinAdi}");
Console.WriteLine($"5. Kitap Yazarı: {okumaListem[4].kitabinYazarininAdi}");
Console.WriteLine($"5. Kitap Sayfa Sayısı: {okumaListem[4].kitabinSayfaSayisi}\n");

Console.WriteLine($"6. Kitap Adı: {okumaListem[5].kitabinAdi}");
Console.WriteLine($"6. Kitap Yazarı: {okumaListem[5].kitabinYazarininAdi}");
Console.WriteLine($"6. Kitap Sayfa Sayısı: {okumaListem[5].kitabinSayfaSayisi}\n");

Console.WriteLine($"7. Kitap Adı: {okumaListem[6].kitabinAdi}");
Console.WriteLine($"7. Kitap Yazarı: {okumaListem[6].kitabinYazarininAdi}");
Console.WriteLine($"7. Kitap Sayfa Sayısı: {okumaListem[6].kitabinSayfaSayisi}\n");

Console.WriteLine($"8. Kitap Adı: {okumaListem[7].kitabinAdi}");
Console.WriteLine($"8. Kitap Yazarı: {okumaListem[7].kitabinYazarininAdi}");
Console.WriteLine($"8. Kitap Sayfa Sayısı: {okumaListem[7].kitabinSayfaSayisi}\n");

Console.WriteLine($"9. Kitap Adı: {okumaListem[8].kitabinAdi}");
Console.WriteLine($"9. Kitap Yazarı: {okumaListem[8].kitabinYazarininAdi}");
Console.WriteLine($"9. Kitap Sayfa Sayısı: {okumaListem[8].kitabinSayfaSayisi}\n");

Console.WriteLine($"10. Kitap Adı: {okumaListem[9].kitabinAdi}");
Console.WriteLine($"10. Kitap Yazarı: {okumaListem[9].kitabinYazarininAdi}");
Console.WriteLine($"10. Kitap Sayfa Sayısı: {okumaListem[9].kitabinSayfaSayisi}\n");

Console.WriteLine($"11. Kitap Adı: {okumaListem[10].kitabinAdi}");
Console.WriteLine($"11. Kitap Yazarı: {okumaListem[10].kitabinYazarininAdi}");
Console.WriteLine($"11. Kitap Sayfa Sayısı: {okumaListem[10].kitabinSayfaSayisi}\n");

Console.WriteLine($"12. Kitap Adı: {okumaListem[11].kitabinAdi}");
Console.WriteLine($"12. Kitap Yazarı: {okumaListem[11].kitabinYazarininAdi}");
Console.WriteLine($"12. Kitap Sayfa Sayısı: {okumaListem[11].kitabinSayfaSayisi}\n");

Console.WriteLine($"13. Kitap Adı: {okumaListem[12].kitabinAdi}");
Console.WriteLine($"13. Kitap Yazarı: {okumaListem[12].kitabinYazarininAdi}");
Console.WriteLine($"13. Kitap Sayfa Sayısı: {okumaListem[12].kitabinSayfaSayisi}\n");

Console.WriteLine($"14. Kitap Adı: {okumaListem[13].kitabinAdi}");
Console.WriteLine($"14. Kitap Yazarı: {okumaListem[13].kitabinYazarininAdi}");
Console.WriteLine($"14. Kitap Sayfa Sayısı: {okumaListem[13].kitabinSayfaSayisi}\n");

Console.WriteLine($"15. Kitap Adı: {okumaListem[14].kitabinAdi}");
Console.WriteLine($"15. Kitap Yazarı: {okumaListem[14].kitabinYazarininAdi}");
Console.WriteLine($"15. Kitap Sayfa Sayısı: {okumaListem[14].kitabinSayfaSayisi}\n");








