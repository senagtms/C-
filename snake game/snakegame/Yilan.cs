using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1Yilan
{
    class Yilan
    {
        public int X=1;
        public int Y=1;
        public int skor = 0;

        public void ciz()
        {
            //daha onceki yilan silinip yenisi cizilecek
            //ekran tamamen silindigi icin yemi ve skoru yeniden yazdirmak gerek
            Console.Clear();
            Console.SetCursorPosition(X, Y);
            Console.Write("S");
        }

        public void hareketEt(ConsoleKeyInfo tus)
        {
            //tus sag ok ise x++
            //tus sol ok ise x--
            //tus asagi ok ise y++
            //tus ust ok ise y--
            if (tus.Key == ConsoleKey.RightArrow)
                X++;
            else if (tus.Key == ConsoleKey.LeftArrow)
                X--;
            else if (tus.Key == ConsoleKey.DownArrow)
                Y++;
            else if (tus.Key == ConsoleKey.UpArrow)
                Y--;
            //hareket alani icinde kalma kontrolu yapilmali
            if (X == 31)
                X = 1;
            if (X == 0)
                X = 30;
            if (Y == 21)
                Y = 1;
            if (Y == 0)
                Y = 20;
        }//hareket et

        public bool yemiYedimi(Yem oankiYem)
        {
            bool sonuc = false;
            if ((X == oankiYem.X) && (Y == oankiYem.Y))
            {
                skor++;
                sonuc = true;
            }
            return sonuc;
        }

        public void skorYaz()
        {
            Console.SetCursorPosition(1, 22);
            Console.WriteLine("Skor: " + skor);
        }
    }//class
}//namespace
