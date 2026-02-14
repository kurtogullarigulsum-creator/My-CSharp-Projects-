Console.WriteLine("LÜTFEN SEÇİM YAPINIZ (1-4): ");
string sayi = Console.ReadLine();

Console.WriteLine("BAKİYE GİRİNİZ:");
int bakiye = Convert.ToInt32(Console.ReadLine());

switch (sayi)
{
    case "1":
        Console.WriteLine("BAKİYENİZ: " + bakiye);
        break;

    case "2":
        Console.WriteLine("ÇEKMEK İSTEDİĞİNİZ TUTARI GİRİNİZ: ");
        int cekilenTutar = Convert.ToInt32(Console.ReadLine());

        if (cekilenTutar <= bakiye)
        {
            // Mantık düzeltildi: Bakiyeden çekilen tutar çıkarıldı
            bakiye -= cekilenTutar;
            Console.WriteLine("İŞLEM BAŞARILI. KALAN BAKİYE: " + bakiye);
        }
        else
        {
            Console.WriteLine("BAKİYENİZ YETERSİZDİR! Mevcut bakiye: " + bakiye);
        }
        break;

    case "3":
        Console.WriteLine("YATIRMAK İSTEDİĞİNİZ TUTARI GİRİNİZ: ");
        int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());
        bakiye += yatirilacakTutar; // Bakiye güncellendi
        Console.WriteLine("TOPLAM BAKİYENİZ: " + bakiye);
        break;

    case "4":
        Console.WriteLine("ATM'DEN ÇIKIŞ YAPTINIZ!! İYİ GÜNLER DİLERİZ...");
        break;

    default:
        Console.WriteLine("HATA: LÜTFEN GEÇERLİ BİR SEÇİM YAPINIZ (1, 2, 3 veya 4)!");
        break;
}







