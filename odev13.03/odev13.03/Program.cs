// See https://aka.ms/new-console-template for more information
using odev13._03;
using System;
        
Yas yas = new Yas();   
Console.WriteLine(yas.YasKategorisi(13));
        Console.WriteLine(yas.YasKategorisi(54));
        Console.WriteLine(yas.YasKategorisi(100));

Console.WriteLine(arabayasi(2));
Console.WriteLine(arabayasi(11));



List<araba> arabalar = new List<araba>();
araba araba1 = new araba { model = "Ford Focus", yakittüketimi = 6.5m, yolmesafesi = 300 };
araba araba2 = new araba { model = "BMW 320i", yakittüketimi = 8.2m, yolmesafesi = 450 };



decimal toplambenzintüketimi = 0;
foreach (var araba in arabalar)
{
    Console.WriteLine(araba.model + " - Benzin Tüketimi: " + araba.benzintüketimi() + " L");
    toplambenzintüketimi += araba.benzintüketimi();

}
Console.WriteLine("toplam benzin tüketimi : " + toplambenzintüketimi + "l");

static String arabayasi(int yas)
    {
        if (yas < 0 || yas > 30)
            return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
        else if (yas < 10)
            return "Arabanız yeni";
        else if (yas < 20)
            return "Servise götürmeniz gerekebilir";
        else
            return "Arabanız hurdaya çıkabilir";

    }
       


int sayi = 0;
while ( sayi <5)
{
    sayi++;
}
Console.WriteLine("sayı:" + sayi);

int sayi2 = 0;

do
{
    sayi2++;
}

while (sayi2< 5);
Console.WriteLine("sayı:" + sayi2);


public class araba
{
    public string model;
    public decimal yakittüketimi;
    public decimal yolmesafesi;

    public decimal benzintüketimi ()
    {
        return (yakittüketimi / 100) * yolmesafesi;
    }

} 
