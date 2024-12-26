using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler

            double number;
            
            number = 4.85;
            Console.WriteLine(number);

            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 44.95;
            potatoPrice = 32.15;
            tomatoPrice = 60.15;


            Console.WriteLine("Elmanın birim fiyatı: " + applePrice + " TL");
            Console.WriteLine("Portakal birim fiyatı: " + orangePrice + " TL");
            Console.WriteLine("Çilek birim fiyatı: " + strawberryPrice + " TL");
            Console.WriteLine("Patates birim fiyatı: " + potatoPrice + " TL");
            Console.WriteLine("Domates birim fiyatı: " + tomatoPrice + "TL");

            Console.WriteLine();
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 1.320;
            strawberryGram = 0.400;
            potatoGram = 4.024;
            tomatoGram = 5.3212;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Toplam Elma Tutarı" + " " + appleTotalPrice);
            Console.WriteLine("Toplam Portakal Tutarı" + " " + orangeTotalPrice);
            Console.WriteLine("Toplam Çilek Tutarı" + " " + strawberryTotalPrice);
            Console.WriteLine("Toplam Patates Tutarı" + " " + potatoTotalPrice);
            Console.WriteLine("Toplam Domates Tutarı" + " " + tomatoTotalPrice);

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine("Toplam Tutar: " + " " + shoppingTotalPrice + " TL");




            #endregion


            #region Char Degiskenler

            char symbol;
            symbol = 'a';

            Console.WriteLine(symbol);


            #endregion

            #region Klavyeden veri girisleri

            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: "); 
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("Yolcu İlçe: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Yolcu Şehir ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu Tc Kimlik ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();


            Console.WriteLine("****** Yolcu Bilgisi ******");

            Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);
            Console.WriteLine("Yolcu İkametgah: " + passengerDistrict + " / " + passengerCity);
            Console.WriteLine("Yolcu Yaşı: " + passengerAge);
            Console.WriteLine("Yolcu Kimlik " + passengerIdentityNumber);





            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız Bilgisayar Sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye Sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız Tv sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());


            Console.WriteLine();

            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            Console.WriteLine(totalPrice);




            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1. sınav notunu giriniz ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. sınav notunu giriniz ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3. sınav notunu giriniz ");
            exam3 = double.Parse(Console.ReadLine());


            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion


            #region Klavyeden Karakter Girişleri

            char gender;
            Console.WriteLine("Lütfen cinsiyet seçiniz:");

            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            #endregion






            Console.Read();
        }
    }
}
