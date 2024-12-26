using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            Console.WriteLine("Hello World");
            Console.Write("Selam");
            Console.Read();

            #endregion

            #region String Degiskenler

            //StringDegiskenler
            //Degisken_türü degisken_adi;

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine("--------------------------------");

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;


            customerName = "Hasan";
            customerSurname = "Özbey";
            customerPhone = "555 444 33 22";
            customerEmail = "deneme@gmail.com";
            district = "Mamak";
            city = "Ankara";


            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim " + customerPhone + "/" + customerEmail);
            Console.WriteLine("Adres " + district + " " + city);
            Console.WriteLine("-------------------------------------------------");














            #endregion


            #region intDegiskenler



            #endregion



            Console.Read();
        }
    }
}
