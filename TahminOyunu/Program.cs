using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi = new Random().Next(0, 100);
            int tahmin=0;
            char devamMi;

            Console.WriteLine("Tahmin Oyununa Hoşgeldin!\nAklımdan tuttuğum 1-100 arasındaki sayıyı tahmin edebilir misin?\n" +
                 "Hadi ilk tahmininle başlayalım çömez!");
                do
                {
                    tahmin = int.Parse(Console.ReadLine());
                    if (tahmin > sayi)
                    {
                        Console.WriteLine("Aşağı in!");
                    }
                    else if (tahmin < sayi)
                    {
                        Console.WriteLine("Yukarı çık!");
                    }

                } while (tahmin != sayi);
                Console.WriteLine("Tahminin doğru, tebrikler çömez!");
            
            Console.ReadKey();

        }


    }
}
