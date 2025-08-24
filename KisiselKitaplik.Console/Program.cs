using KisiselKitaplik.Console.Models;

string kullaniciAdi = "Bora";
Console.WriteLine($"{kullaniciAdi}'nin Okuma Listesi\n");

Kitap[] okumaListem = new Kitap[64];

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

okumaListem[15] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "Tanrıların Kadehi",
    kitabinSayfaSayisi = 256,
};

okumaListem[16] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "Üçlü Tanrıça'nın Gazabı",
    kitabinSayfaSayisi = 304,
};

okumaListem[17] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "Güneş ve Yıldız",
    kitabinSayfaSayisi = 440,
};

okumaListem[18] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "Ölüler Mahkemesi",
    kitabinSayfaSayisi = 448,
};

okumaListem[19] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "Nero Kulesi",
    kitabinSayfaSayisi = 422,
};

okumaListem[20] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "Dokuz Dünya'dan 9'u",
    kitabinSayfaSayisi = 180,
};

okumaListem[21] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Golgelerin Efendisi 12 - Son Orman Muhafizi - Yeni bir baslangic",
    kitabinSayfaSayisi = 512,
};

okumaListem[23] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Gölgelerin Efendisi 13 - Kızıl Tilki Klani",
    kitabinSayfaSayisi = 368,
};

okumaListem[24] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Gölgelerin Efendisi 14 - Son Düello",
    kitabinSayfaSayisi = 320,
};

okumaListem[25] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Gölgelerin Efendisi 15 - Kayıp Prens",
    kitabinSayfaSayisi = 304,
};

okumaListem[26] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Gölgelerin Efendisi 16 - Falais' ten Kaçış",
    kitabinSayfaSayisi = 256,
};

okumaListem[27] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Gölgelerin Efendisi 17 - Arazan Kurtlari",
    kitabinSayfaSayisi = 256,
};

okumaListem[28] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Kardeşlik Savaşçıları 9 - Amansız Takip",
    kitabinSayfaSayisi = 304,
};

okumaListem[29] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The Mark of Athena",
    kitabinSayfaSayisi = 608,
};

okumaListem[30] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The House of Hades",
    kitabinSayfaSayisi = 608,
};

okumaListem[31] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The Blood of Olympus",
    kitabinSayfaSayisi = 528,
};

okumaListem[32] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The Red Pyramid",
    kitabinSayfaSayisi = 528,
};

okumaListem[33] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The Throne of Fire",
    kitabinSayfaSayisi = 464,
};

okumaListem[34] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The Serpent's Shadow",
    kitabinSayfaSayisi = 416,
};

okumaListem[35] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The Sword of Summer",
    kitabinSayfaSayisi = 512,
};

okumaListem[36] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The Hammer of Thor",
    kitabinSayfaSayisi = 480,
};

okumaListem[37] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The Ship of the Dead",
    kitabinSayfaSayisi = 432,
};

okumaListem[38] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "9 From the Nine Worlds",
    kitabinSayfaSayisi = 176,
};

okumaListem[39] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The Hidden Oracle",
    kitabinSayfaSayisi = 416,
};

okumaListem[40] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The Dark Prophecy",
    kitabinSayfaSayisi = 432,
};

okumaListem[41] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The Burning Maze",
    kitabinSayfaSayisi = 448,
};

okumaListem[42] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The Tyrant's Tomb",
    kitabinSayfaSayisi = 448,
};

okumaListem[43] = new Kitap()
{
    kitabinYazarininAdi = "Rick Roirdan",
    kitabinAdi = "The Tower of Nero",
    kitabinSayfaSayisi = 416,
};

okumaListem[44] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger’s Apprentice: The Early Years Book 1: The Tournament at Gorlan",
    kitabinSayfaSayisi = 384,
};

okumaListem[45] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger’s Apprentice: The Early Years Book 2: The Battle of Hackham Heath",
    kitabinSayfaSayisi = 346,
};

okumaListem[46] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 1: The Ruins of Gorlan",
    kitabinSayfaSayisi = 288,
};

okumaListem[47] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 2: The Burning Bridge",
    kitabinSayfaSayisi = 304,
};

okumaListem[48] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 3: The Icebound Land",
    kitabinSayfaSayisi = 288,
};

okumaListem[49] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 4: The Battle for Skandia",
    kitabinSayfaSayisi = 336,
};

okumaListem[50] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 5: The Sorcerer of the North",
    kitabinSayfaSayisi = 336,
};

okumaListem[51] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 6: The Siege of Macindaw",
    kitabinSayfaSayisi = 336,
};

okumaListem[52] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 7: Erak's Ransom",
    kitabinSayfaSayisi = 384,
};

okumaListem[53] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 8: The Kings of Clonmel",
    kitabinSayfaSayisi = 368,
};

okumaListem[54] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 9: Halt's Peril",
    kitabinSayfaSayisi = 416,
};

okumaListem[55] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 10: The Lost Stories",
    kitabinSayfaSayisi = 464,
};

okumaListem[56] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 11: The Emperor of Nihon-Ja",
    kitabinSayfaSayisi = 464,
};

okumaListem[57] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 12: The Royal Ranger: A New Beginning",
    kitabinSayfaSayisi = 464,
};

okumaListem[58] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 13: The Royal Ranger: The Red Fox Clan",
    kitabinSayfaSayisi = 352,
};

okumaListem[59] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 14: The Royal Ranger: Duel at Araluen",
    kitabinSayfaSayisi = 320,
};

okumaListem[60] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 15: The Royal Ranger: The Missing Prince",
    kitabinSayfaSayisi = 288,
};

okumaListem[61] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 16: The Royal Ranger: Escape from Falaise",
    kitabinSayfaSayisi = 256,
};

okumaListem[62] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 17: The Royal Ranger: Arazan's Wolves",
    kitabinSayfaSayisi = 256,
};

okumaListem[63] = new Kitap()
{
    kitabinYazarininAdi = "John Flanagan",
    kitabinAdi = "Ranger's Apprentice Books, book 18: The Royal Ranger: The Royal Ranger: The Ambush at Sorato",
    kitabinSayfaSayisi = 240,
};




Console.WriteLine("----- Turkce Okuyacagim Kitaplar -----\n");

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

Console.WriteLine($"16. Kitap Adı: {okumaListem[15].kitabinAdi}");
Console.WriteLine($"16. Kitap Yazarı: {okumaListem[15].kitabinYazarininAdi}");
Console.WriteLine($"16. Kitap Sayfa Sayısı: {okumaListem[15].kitabinSayfaSayisi}\n");

Console.WriteLine($"17. Kitap Adı: {okumaListem[16].kitabinAdi}");
Console.WriteLine($"17. Kitap Yazarı: {okumaListem[16].kitabinYazarininAdi}");
Console.WriteLine($"17. Kitap Sayfa Sayısı: {okumaListem[16].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"18. Kitap Adı: {okumaListem[17].kitabinAdi}");
Console.WriteLine($"18. Kitap Yazarı: {okumaListem[17].kitabinYazarininAdi}");
Console.WriteLine($"18. Kitap Sayfa Sayısı: {okumaListem[17].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"19. Kitap Adı: {okumaListem[18].kitabinAdi}");
Console.WriteLine($"19. Kitap Yazarı: {okumaListem[18].kitabinYazarininAdi}");
Console.WriteLine($"19. Kitap Sayfa Sayısı: {okumaListem[18].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"20. Kitap Adı: {okumaListem[19].kitabinAdi}");
Console.WriteLine($"20. Kitap Yazarı: {okumaListem[19].kitabinYazarininAdi}");
Console.WriteLine($"20. Kitap Sayfa Sayısı: {okumaListem[19].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"21. Kitap Adı: {okumaListem[20].kitabinAdi}");
Console.WriteLine($"21. Kitap Yazarı: {okumaListem[20].kitabinYazarininAdi}");
Console.WriteLine($"21. Kitap Sayfa Sayısı: {okumaListem[20].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"22. Kitap Adı: {okumaListem[21].kitabinAdi}");
Console.WriteLine($"22. Kitap Yazarı: {okumaListem[21].kitabinYazarininAdi}");
Console.WriteLine($"22. Kitap Sayfa Sayısı: {okumaListem[21].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"23. Kitap Adı: {okumaListem[22].kitabinAdi}");
Console.WriteLine($"23. Kitap Yazarı: {okumaListem[22].kitabinYazarininAdi}");
Console.WriteLine($"23. Kitap Sayfa Sayısı: {okumaListem[22].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"24. Kitap Adı: {okumaListem[23].kitabinAdi}");
Console.WriteLine($"24. Kitap Yazarı: {okumaListem[23].kitabinYazarininAdi}");
Console.WriteLine($"24. Kitap Sayfa Sayısı: {okumaListem[23].kitabinSayfaSayisi}\n");

Console.WriteLine($"25. Kitap Adı: {okumaListem[24].kitabinAdi}");
Console.WriteLine($"25. Kitap Yazarı: {okumaListem[24].kitabinYazarininAdi}");
Console.WriteLine($"25. Kitap Sayfa Sayısı: {okumaListem[24].kitabinSayfaSayisi}\n");

Console.WriteLine($"26. Kitap Adı: {okumaListem[25].kitabinAdi}");
Console.WriteLine($"26. Kitap Yazarı: {okumaListem[25].kitabinYazarininAdi}");
Console.WriteLine($"26. Kitap Sayfa Sayısı: {okumaListem[25].kitabinSayfaSayisi}\n");

Console.WriteLine($"27. Kitap Adı: {okumaListem[26].kitabinAdi}");
Console.WriteLine($"27. Kitap Yazarı: {okumaListem[26].kitabinYazarininAdi}");
Console.WriteLine($"27. Kitap Sayfa Sayısı: {okumaListem[26].kitabinSayfaSayisi}\n");

Console.WriteLine($"28. Kitap Adı: {okumaListem[27].kitabinAdi}");
Console.WriteLine($"28. Kitap Yazarı: {okumaListem[27].kitabinYazarininAdi}");
Console.WriteLine($"28. Kitap Sayfa Sayısı: {okumaListem[27].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"29. Kitap Adı: {okumaListem[28].kitabinAdi}");
Console.WriteLine($"29. Kitap Yazarı: {okumaListem[28].kitabinYazarininAdi}");
Console.WriteLine($"29. Kitap Sayfa Sayısı: {okumaListem[28].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"30. Kitap Adı: {okumaListem[29].kitabinAdi}");
Console.WriteLine($"30. Kitap Yazarı: {okumaListem[29].kitabinYazarininAdi}");
Console.WriteLine($"30. Kitap Sayfa Sayısı: {okumaListem[29].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"31. Kitap Adı: {okumaListem[30].kitabinAdi}");
Console.WriteLine($"31. Kitap Yazarı: {okumaListem[30].kitabinYazarininAdi}");
Console.WriteLine($"31. Kitap Sayfa Sayısı: {okumaListem[30].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"32. Kitap Adı: {okumaListem[31].kitabinAdi}");
Console.WriteLine($"32. Kitap Yazarı: {okumaListem[31].kitabinYazarininAdi}");
Console.WriteLine($"32. Kitap Sayfa Sayısı: {okumaListem[31].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"33. Kitap Adı: {okumaListem[32].kitabinAdi}");
Console.WriteLine($"33. Kitap Yazarı: {okumaListem[32].kitabinYazarininAdi}");
Console.WriteLine($"33. Kitap Sayfa Sayısı: {okumaListem[32].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"34. Kitap Adı: {okumaListem[33].kitabinAdi}");
Console.WriteLine($"34. Kitap Yazarı: {okumaListem[33].kitabinYazarininAdi}");
Console.WriteLine($"34. Kitap Sayfa Sayısı: {okumaListem[33].kitabinSayfaSayisi}\n");

Console.WriteLine($"35. Kitap Adı: {okumaListem[34].kitabinAdi}");
Console.WriteLine($"35. Kitap Yazarı: {okumaListem[34].kitabinYazarininAdi}");
Console.WriteLine($"35. Kitap Sayfa Sayısı: {okumaListem[34].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"36. Kitap Adı: {okumaListem[35].kitabinAdi}");
Console.WriteLine($"36. Kitap Yazarı: {okumaListem[35].kitabinYazarininAdi}");
Console.WriteLine($"36. Kitap Sayfa Sayısı: {okumaListem[35].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"37. Kitap Adı: {okumaListem[36].kitabinAdi}");
Console.WriteLine($"37. Kitap Yazarı: {okumaListem[36].kitabinYazarininAdi}");
Console.WriteLine($"37. Kitap Sayfa Sayısı: {okumaListem[36].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"38. Kitap Adı: {okumaListem[37].kitabinAdi}");
Console.WriteLine($"38. Kitap Yazarı: {okumaListem[37].kitabinYazarininAdi}");
Console.WriteLine($"38. Kitap Sayfa Sayısı: {okumaListem[37].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"39. Kitap Adı: {okumaListem[38].kitabinAdi}");
Console.WriteLine($"39. Kitap Yazarı: {okumaListem[38].kitabinYazarininAdi}");
Console.WriteLine($"39. Kitap Sayfa Sayısı: {okumaListem[38].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"40. Kitap Adı: {okumaListem[39].kitabinAdi}");
Console.WriteLine($"40. Kitap Yazarı: {okumaListem[39].kitabinYazarininAdi}");
Console.WriteLine($"40. Kitap Sayfa Sayısı: {okumaListem[39].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"41. Kitap Adı: {okumaListem[40].kitabinAdi}");
Console.WriteLine($"41. Kitap Yazarı: {okumaListem[40].kitabinYazarininAdi}");
Console.WriteLine($"41. Kitap Sayfa Sayısı: {okumaListem[40].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"42. Kitap Adı: {okumaListem[41].kitabinAdi}");
Console.WriteLine($"42. Kitap Yazarı: {okumaListem[41].kitabinYazarininAdi}");
Console.WriteLine($"42. Kitap Sayfa Sayısı: {okumaListem[41].kitabinSayfaSayisi}\n");

Console.WriteLine($"43. Kitap Adı: {okumaListem[42].kitabinAdi}");
Console.WriteLine($"43. Kitap Yazarı: {okumaListem[42].kitabinYazarininAdi}");
Console.WriteLine($"43. Kitap Sayfa Sayısı: {okumaListem[42].kitabinSayfaSayisi}\n");

Console.WriteLine("----- Ingilizce Okuyacagim Kitaplar -----\n");

Console.WriteLine($"44. Kitap Adı: {okumaListem[43].kitabinAdi}");
Console.WriteLine($"44. Kitap Yazarı: {okumaListem[43].kitabinYazarininAdi}");
Console.WriteLine($"44. Kitap Sayfa Sayısı: {okumaListem[43].kitabinSayfaSayisi}\n");

Console.WriteLine($"45. Kitap Adı: {okumaListem[44].kitabinAdi}");
Console.WriteLine($"45. Kitap Yazarı: {okumaListem[44].kitabinYazarininAdi}");
Console.WriteLine($"45. Kitap Sayfa Sayısı: {okumaListem[44].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"46. Kitap Adı: {okumaListem[45].kitabinAdi}");
Console.WriteLine($"46. Kitap Yazarı: {okumaListem[45].kitabinYazarininAdi}");
Console.WriteLine($"46. Kitap Sayfa Sayısı: {okumaListem[45].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"47. Kitap Adı: {okumaListem[46].kitabinAdi}");
Console.WriteLine($"47. Kitap Yazarı: {okumaListem[46].kitabinYazarininAdi}");
Console.WriteLine($"47. Kitap Sayfa Sayısı: {okumaListem[46].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"48. Kitap Adı: {okumaListem[47].kitabinAdi}");
Console.WriteLine($"48. Kitap Yazarı: {okumaListem[47].kitabinYazarininAdi}");
Console.WriteLine($"48. Kitap Sayfa Sayısı: {okumaListem[47].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"49. Kitap Adı: {okumaListem[48].kitabinAdi}");
Console.WriteLine($"49. Kitap Yazarı: {okumaListem[48].kitabinYazarininAdi}");
Console.WriteLine($"49. Kitap Sayfa Sayısı: {okumaListem[48].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"50. Kitap Adı: {okumaListem[49].kitabinAdi}");
Console.WriteLine($"50. Kitap Yazarı: {okumaListem[49].kitabinYazarininAdi}");
Console.WriteLine($"50. Kitap Sayfa Sayısı: {okumaListem[49].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"51. Kitap Adı: {okumaListem[50].kitabinAdi}");
Console.WriteLine($"51. Kitap Yazarı: {okumaListem[50].kitabinYazarininAdi}");
Console.WriteLine($"51. Kitap Sayfa Sayısı: {okumaListem[50].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"52. Kitap Adı: {okumaListem[51].kitabinAdi}");
Console.WriteLine($"52. Kitap Yazarı: {okumaListem[51].kitabinYazarininAdi}");
Console.WriteLine($"52. Kitap Sayfa Sayısı: {okumaListem[51].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"53. Kitap Adı: {okumaListem[52].kitabinAdi}");
Console.WriteLine($"53. Kitap Yazarı: {okumaListem[52].kitabinYazarininAdi}");
Console.WriteLine($"53. Kitap Sayfa Sayısı: {okumaListem[52].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"54. Kitap Adı: {okumaListem[53].kitabinAdi}");
Console.WriteLine($"54. Kitap Yazarı: {okumaListem[53].kitabinYazarininAdi}");
Console.WriteLine($"54. Kitap Sayfa Sayısı: {okumaListem[53].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"55. Kitap Adı: {okumaListem[54].kitabinAdi}");
Console.WriteLine($"55. Kitap Yazarı: {okumaListem[54].kitabinYazarininAdi}");
Console.WriteLine($"55. Kitap Sayfa Sayısı: {okumaListem[54].kitabinSayfaSayisi}\n");
                    
Console.WriteLine($"56. Kitap Adı: {okumaListem[55].kitabinAdi}");
Console.WriteLine($"56. Kitap Yazarı: {okumaListem[55].kitabinYazarininAdi}");
Console.WriteLine($"56. Kitap Sayfa Sayısı: {okumaListem[55].kitabinSayfaSayisi}\n");

Console.WriteLine($"57. Kitap Adı: {okumaListem[56].kitabinAdi}");
Console.WriteLine($"57. Kitap Yazarı: {okumaListem[56].kitabinYazarininAdi}");
Console.WriteLine($"57. Kitap Sayfa Sayısı: {okumaListem[56].kitabinSayfaSayisi}\n");

Console.WriteLine($"58. Kitap Adı: {okumaListem[57].kitabinAdi}");
Console.WriteLine($"58. Kitap Yazarı: {okumaListem[57].kitabinYazarininAdi}");
Console.WriteLine($"58. Kitap Sayfa Sayısı: {okumaListem[57].kitabinSayfaSayisi}\n");

Console.WriteLine($"59. Kitap Adı: {okumaListem[58].kitabinAdi}");
Console.WriteLine($"59. Kitap Yazarı: {okumaListem[58].kitabinYazarininAdi}");
Console.WriteLine($"59. Kitap Sayfa Sayısı: {okumaListem[58].kitabinSayfaSayisi}\n");

Console.WriteLine($"60. Kitap Adı: {okumaListem[59].kitabinAdi}");
Console.WriteLine($"60. Kitap Yazarı: {okumaListem[59].kitabinYazarininAdi}");
Console.WriteLine($"60. Kitap Sayfa Sayısı: {okumaListem[59].kitabinSayfaSayisi}\n");

Console.WriteLine($"61. Kitap Adı: {okumaListem[60].kitabinAdi}");
Console.WriteLine($"61. Kitap Yazarı: {okumaListem[60].kitabinYazarininAdi}");
Console.WriteLine($"61. Kitap Sayfa Sayısı: {okumaListem[60].kitabinSayfaSayisi}\n");

Console.WriteLine($"62. Kitap Adı: {okumaListem[61].kitabinAdi}");
Console.WriteLine($"62. Kitap Yazarı: {okumaListem[61].kitabinYazarininAdi}");
Console.WriteLine($"62. Kitap Sayfa Sayısı: {okumaListem[61].kitabinSayfaSayisi}\n");

Console.WriteLine($"63. Kitap Adı: {okumaListem[62].kitabinAdi}");
Console.WriteLine($"63. Kitap Yazarı: {okumaListem[62].kitabinYazarininAdi}");
Console.WriteLine($"63. Kitap Sayfa Sayısı: {okumaListem[62].kitabinSayfaSayisi}\n");

Console.WriteLine($"64. Kitap Adı: {okumaListem[63].kitabinAdi}");
Console.WriteLine($"64. Kitap Yazarı: {okumaListem[63].kitabinYazarininAdi}");
Console.WriteLine($"64. Kitap Sayfa Sayısı: {okumaListem[63].kitabinSayfaSayisi}\n");













