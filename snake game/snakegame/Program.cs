using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1Yilan
{
    class Program
    {
        static void Main(string[] args)
        {
            //oyunda bir yilan bulunmaktadir
            //klavyeden escape basilana kadar
            //{
            //basilan tusu al
            //yilani buna gore hareket ettit
            //yilani ciz
            //yemi ciz
            //yemi yedimi kontrol et yemisse yeniden uret
            //skoru yaz
            //}

            Yilan snake = new Yilan();
            Yem y = new Yem();
            y.uret();
            ConsoleKeyInfo basilantus;
            do
            {
                basilantus = Console.ReadKey();
                snake.hareketEt(basilantus);
                snake.ciz();
                y.ciz();
                if (snake.yemiYedimi(y) == true)
                {
                    //yeni yem uret
                    y.uret();
                    snake.ciz();
                }
                snake.skorYaz();

            } while (basilantus.Key != ConsoleKey.Escape);

          
        }
    }

 
}
