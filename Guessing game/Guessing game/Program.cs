using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bulundu = false;
            Random sayiGen = new Random();
            int bilgisayarinUrettigiSayi = sayiGen.Next(1, 100);
            int tahminSayisi = 1;
            Console.WriteLine("1-100 arasında tahminde bulun");
            while (bulundu == false)//for(;bulundu==false;)
            {
                int tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin == bilgisayarinUrettigiSayi)
                {
                    Console.WriteLine("tebrikler {0} tahminde buldun", tahminSayisi);
                    bulundu = true;
                }
                else
                {
                    tahminSayisi++;
                    //ipucu ver
                    if (tahmin > bilgisayarinUrettigiSayi)
                        Console.WriteLine("tahmini kucult");
                    else
                        Console.WriteLine("tahmini buyut");
                }
            
            }
        }
    }
}
