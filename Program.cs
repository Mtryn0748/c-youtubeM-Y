using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_döngü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOREACH DÖNGÜSÜ
            //foreach(1;2;3;4)
            //1-değişken türü
            //2-değişken adı
            //3-In
            //4-liste, koleksiyon, dizi

            /*string[] cities = {"varsava", "Roma", "MİLANO", "london", "atina"};
            foreach (string n in cities)
            {
                Console.WriteLine(n);
            }*/

            /*
             int[] number = {1,2,45,541,852,1026,965,2,0,65,31};
            foreach (int i in number)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            //int[] numberSum = {1,3,5,7,9,11,13,15,17,19};
            //int total = 0;
            //foreach (int sum in numberSum)
            //{
            //    total += sum;
            //}Console.WriteLine(total);


            #endregion
            #region BURADAKİ SORUYU KENDİN ÇÖZCEKSİN
            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan al
            Console.WriteLine("----------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());// dönüşüm
            Console.WriteLine("----------------------------------");

            //Öğrenci isimleri ve not ortalamaları diziai
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                // sonra bir bak buraya şiraze kaydı
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // 3 sınav girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; 
                }
                Console.WriteLine();

                studentExamAvg[i] = totalExamResult / 3;
            }

            
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("----------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");// ortalaama

                // burayı şekillendir sonra 
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
            }
            #endregion


            Console.Read();
        }
    }
}
