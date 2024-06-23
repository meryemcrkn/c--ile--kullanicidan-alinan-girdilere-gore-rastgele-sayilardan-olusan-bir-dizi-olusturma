using System;

namespace sınavlıksoru
{
    //Elemanları rastgele değerlerden oluşan bir dizi oluşturulacak ve bu dizi küçükten büyüğe sıralanacaktır. 
    //Bunun için program çalıştığında Main metodunda dizinin eleman sayısı, elemanların alt ve üst sınırları klavyeden girilecektir.
    //Bu değerler sırala metoduna gönderilecek sirala metodu içinde gelen değerlere uygun olarak rastgele bir dizi oluşturulacak , orijinal dizi ve sıralı hali ekranda gösterilecektir.
    //Main metodunda dizi için gereken değerlerin sürekli girilmesi sağlanacaktır.Klavyeden negatif bir veri girilirse program sonlanacaktır.
    //Değer döndürmeyen yapida olcaktir. SINAV SORUSU 
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Dizi kaç elemanlı olsun?");
                int boyut = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dizi hangi sayılar arasında olsun?");
                int alt_sinir = Convert.ToInt32(Console.ReadLine());
                int ust_sinir = Convert.ToInt32(Console.ReadLine());
                if (boyut > 0 && alt_sinir > 0 && ust_sinir > 0)
                {
                    Console.WriteLine();
                    Sirala(boyut, alt_sinir, ust_sinir);
                    Console.WriteLine();

                }
                else
                {
                    break;
                }
                Console.ReadKey();
            }

        }
        static void Sirala(int boyut, int alt_sinir, int ust_sinir)
        {
            int[] dizi = new int[boyut];
            Random rnd = new Random();
            for (int i = 0; i < boyut; i++)
            {
                dizi[i] = rnd.Next(alt_sinir, ust_sinir);
            }
            Console.WriteLine("Dizinin ilk hali");
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Dizinin sıralanmış hali");
            Array.Sort(dizi);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
