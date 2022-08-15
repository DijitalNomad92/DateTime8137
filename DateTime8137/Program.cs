using System.Globalization;

DateTime tarih = new DateTime(2022, 8, 11);
tarih = new DateTime(2022, 8, 11, 14, 15, 55, 123);

Console.WriteLine(tarih);

Console.WriteLine(tarih.ToShortDateString()); // 11.08.2022
Console.WriteLine(tarih.ToLongDateString()); // 11 agustos 2022 Perşembe
Console.WriteLine(tarih.ToLongTimeString()); // 14:15:55
Console.WriteLine(tarih.ToShortTimeString()); // 14:15

Console.WriteLine(tarih.ToString("yyyy-MM-dd HH:mm:ss"));

Console.WriteLine(tarih.Month + "/" + tarih.Day + "/" + tarih.Year + " " + tarih.Hour + ":" + tarih.Minute + ":" + tarih.Second + ":" + ":" + tarih.Millisecond);

DateTime tarih1 = DateTime.Parse("15.08.2022");
Console.WriteLine(tarih1);

tarih1 = DateTime.Parse("08/15/2022", new CultureInfo("en-US"));
// burda mutlaka system globalization' u kullanmamız gerek
Console.WriteLine(tarih1);

double sayi = 1.2;

string sayistr = sayi.ToString(new CultureInfo("en-US"));
Console.WriteLine(sayistr); // sonuc 1.2 olur, burda tarihi belirttigimiz bolgeye gore yazdırır 

DateTime simdi = DateTime.Now;  // su anki tarihe ulasırız
DateTime yarin = simdi.AddDays(1);  // bir gun sonraki tarihe ulasırız
DateTime birHaftaOncesi = simdi.AddDays(-7); // bir hafta onceki tarihe ulasırız
Console.WriteLine(yarin);

if (yarin.CompareTo(simdi) > 0)
    Console.WriteLine("yarın > simdi");
else if (yarin.CompareTo(simdi) < 0)
    Console.WriteLine("yarın < simdi");
else  // (yarin.compareTo(simdi) == 0)
    Console.WriteLine("yarın = simdi");  // onceden CompareTo kullanıyordu, artık kullanmaya gerek yok (aşagıda)

if (yarin > simdi)
    Console.WriteLine("yatın > şimdi");
else if (yarin < simdi)
    Console.WriteLine("yarın < şimdi");
else
    Console.WriteLine("yarın = şimdi"); // artık böyle kıyaslama yapabiliriz

Console.WriteLine(simdi.DayOfWeek + " - " + simdi.DayOfYear + " - " + simdi.Ticks); // bu yılın gunu , gun sayısı sıraya gore(365) ve tıcks


Console.WriteLine(simdi.Date + " - " + DateTime.Today);  // sadece tarih kısmı 

DateTime dt1 = DateTime.Parse("15.08.2022 13:00:00");
DateTime dt2 = DateTime.Parse("15.08.2022 14:35:15");

TimeSpan sure = dt2.Subtract(dt1);
// 1:35:15 fark var
int days = sure.Days; // 0 aynı gun oldugu için
int seconds = sure.Seconds;  // 15
double totalSeconds = sure.TotalSeconds; // sure
double totalMunites = sure.TotalMinutes;
Console.WriteLine(totalMunites);

Console.Write("Dogum Tarihi Giriniz (gg.aa.yyyy: ) ");

DateTime yas = DateTime.Parse(Console.ReadLine(), new CultureInfo("tr-TR"));
//DateTime yas = Convert.ToDateTime(Console.ReadLine()); yukarıdakının aynısı
DateTime simdi2 = DateTime.Now;
//TimeSpan farkYas = simdi2.Subtract(yas); aşagınız aynısı
TimeSpan farkYas = simdi2 - yas;
//double yasi = farkYas.TotalDays / 365;
double yasi = farkYas.TotalHours / (365 * 24 + 6); // daha dogru sonuca ulasmak için 6 saatı da ekliyoruz
Console.WriteLine("Yaşı: " + (int)yasi);  // burda ınt'e çevirmezsek ,kusurler ile gelir

double pi = Math.PI; // math methodunu kullanmak
int sayi1 = 10;
int sayi2 = 20;
Console.WriteLine(Math.Abs(sayi1 - sayi2));  // Math.abs negatif sayiyi pozitife çevirir

double sayi3 = 2.4;
Console.WriteLine(Math.Floor(sayi3) + " - " + Math.Ceiling(sayi3)); // Burda Floor sayıyı aşagı dorgu yuvarlar,ceiling de yukarı.

double sayi4 = 12.345;
double sayi5 = 98.765;
Console.WriteLine(Math.Round(sayi4) + " - " + Math.Round(sayi5)); // burda round otomatik .5 buyukse yukarı kucukse aşagı yuvarlar

Console.WriteLine(Math.Round(sayi4,1) + " - " + Math.Round(sayi5,1)); // ondalıktan sonraki 1 sayıyı yuvarlar 12.4 - 98.8

double no1 = 4 * 4 * 4;  // 4'ün 3 kuvvetini alır
no1 = Math.Pow(4, 3); // 4'ün 3 kuvvetini alır

int s1 = Math.Min(2, 3); // 2 yazar minimum sayısı gosterir
int s2 = Math.Max(2, 3); // 3 yazar, maksimum sayıyı 








