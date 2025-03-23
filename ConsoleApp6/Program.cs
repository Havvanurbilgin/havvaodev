// See https://aka.ms/new-console-template for more information
using ConsoleApp6.Classes.cs;

Console.WriteLine("Hello, World!");


Program p = new Program();

for (int i = 0; i < 5; i++)
{

    Console.WriteLine("Lütfen " + (i + 1) + ". sayıyı girin: ");
    object sayilar = null;
    sayilar[i] = Convert.ToDouble(Console.ReadLine());
}

foreach (double sayi in sayilar)
{
    toplam += sayi;
}


double ortalama = toplam / 5;
Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);


Sayitahminoyunu s= new Sayitahminoyunu();


Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Tahmin etmeye çalış!");

while (tahmin != rastgeleSayi)
{
    Console.Write("Tahmininizi girin: ");
    tahmin = Convert.ToInt32(Console.ReadLine());
    tahminSayisi++;

  
    if (tahmin < rastgeleSayi)
    {
        Console.WriteLine("Tahmininiz düşük. Daha büyük bir sayı söyleyin.");
    }
    else if (tahmin > rastgeleSayi)
    {
        Console.WriteLine("Tahmininiz yüksek. Daha küçük bir sayı söyleyin.");
    }
    else
    {
        Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
    }
}


Console.WriteLine("Tahmin sayınız: " + tahminSayisi);


HesapMakinesi h = new HesapMakinesi();

{

    Console.Write("Birinci sayıyı girin: ");
    int sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("İkinci sayıyı girin: ");
    int sayi2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
    Console.WriteLine("1 - Toplama");
    Console.WriteLine("2 - Çıkarma");
    Console.WriteLine("3 - Çarpma");
    Console.WriteLine("4 - Bölme");
    Console.Write("Seçiminizi yapın (1/2/3/4): ");
    int secim = Convert.ToInt32(Console.ReadLine());

    
    double sonuc = 0; 
    bool islemYapildi = true; 

    switch (secim)
    {
        case 1:
            sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
            break;
        case 2:
            sonuc = sayi1 - sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
            break;
        case 3:
            sonuc = sayi1 * sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
            break;
        case 4:
           
            if (sayi2 != 0)
            {
                sonuc = (double)sayi1 / sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else
            {
                Console.WriteLine("Hata! Bir sayıyı sıfıra bölemezsiniz.");
            }
            break;
        default:
            islemYapildi = false;
            Console.WriteLine("Geçersiz işlem seçimi!");
            break;
    }

   
    if (islemYapildi)
    {
        Console.WriteLine("İşlem başarıyla gerçekleştirildi.");
    }
    else
    {
        Console.WriteLine("Lütfen geçerli bir işlem seçin.");
    }
}

MerhabaDünya mh = new MerhabaDünya();
{
    Console.WriteLine("Merhaba, Dünya!");
}