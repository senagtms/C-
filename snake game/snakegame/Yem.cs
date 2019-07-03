using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1Yilan
{
    class Yem
    {
        public int X;
        public int Y;

        public void uret()
        {
            //X ve Y icin oyun alani sinirlarinda rastgele degerler uretecek
            Random sayiGen = new Random();
            X = sayiGen.Next(1, 31);
            Y = sayiGen.Next(1, 21);
        }

        public void ciz()
        {
            //o anki X ve Y degerine kursorun konumlanmasi
            //ve belli bir karakterin o noktaya yazilmasi
            Console.SetCursorPosition(X, Y);
            Console.Write("*");
        }
    }
}
