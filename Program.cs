using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_maainsubjectc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YAZDIRMA KOMUTLARI
            //Console.Write("merhaba dünya");

            //Console.WriteLine("******Yemek Kategorileri*****");
            //Console.WriteLine();
            //Console.WriteLine("1-çorba");
            //Console.WriteLine("2-ana yemek");
            //Console.WriteLine("3-içecek");
            //Console.WriteLine("4-ara sıcak");
            //Console.WriteLine("5-tatlı");
            //Console.WriteLine();

            #endregion
            #region string DEĞİŞKENLER
            //string
            // değişkentürü+ + ;

            //string name;
            //name = "muharrem";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "ali";
            //customerSurname = "veli";
            //customerPhone = "0530123452785";
            //customerEmail = "deneme@gmail.com";
            //district = "korkuteli";
            //city = "antalya";
            //Console.WriteLine("**Rezervasyon kartı***");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişşim:"+customerPhone);
            //Console.WriteLine("Email:" + customerEmail);
            //Console.WriteLine("il:"+city+"/ ilçe: "+ district);

            //Console.WriteLine();
            //customerName = "murat";
            //customerSurname = "turat";
            //customerPhone = "0530123452785";
            //customerEmail = "31bağımııs@gmail.com";
            //district = "menteşe";
            //city = "kapı";
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişşim:" + customerPhone);
            //Console.WriteLine("Email:" + customerEmail);
            //Console.WriteLine("il:" + city + "/ ilçe: " + district);


            #endregion
            #region İNT DEĞİŞKENLER
            // int 
            int hamburgerPrice = 300;
            int cokePrice = 40;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*-* Restoran Menü Fiyatları*-*");
            Console.WriteLine();
            Console.WriteLine("--- Hamburger:" + hamburgerPrice + "TL");
            Console.WriteLine("--- Kola:" + cokePrice + "TL");
            Console.WriteLine("--- Su:" + waterPrice + "TL");
            Console.WriteLine("--- Patates Kızartması:" + friesPrice + "TL");
            Console.WriteLine("--- Pizza:" + pizzaPrice + "TL");
            Console.WriteLine("--- Limonata:" + lemonadePrice + "TL");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalhamburgerPrice = 0;
            int totalcokePrice = 0;
            int totalwaterPrice = 0;
            int totalfriesPrice = 0;
            int totalpizzaPrice = 0;
            int totallemonadePrice = 0;



            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 4;
            friesCount = 6;
            pizzaCount = 2;
            lemonadeCount = 2;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalcokePrice = cokeCount * cokePrice;
            totalwaterPrice = waterCount * waterPrice;
            totalfriesPrice = friesCount * friesPrice;
            totalpizzaPrice = pizzaCount * pizzaPrice;
            totallemonadePrice = lemonadeCount * totalhamburgerPrice;
            int totalinPrice = totalhamburgerPrice + totalwaterPrice + totalpizzaPrice + totalfriesPrice + totalcokePrice + totallemonadePrice;


            Console.WriteLine("-------------------------");
            Console.WriteLine("Hamburger fiyatı:" + totalhamburgerPrice + "TL");
            Console.WriteLine("Kola fiyatı:" + totalcokePrice + "TL");
            Console.WriteLine("Su fiyatı:" + totalwaterPrice + "TL");
            Console.WriteLine("Kızartma fiyatı:" + totalfriesPrice + "TL");
            Console.WriteLine("Pizza fiyatı:" + totalpizzaPrice + "TL");
            Console.WriteLine("Limonata fiyatı:" + totallemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("Toplam Tutar:" + totalinPrice + "TL");

            #endregion
            Console.Read();

        }
    }
}
