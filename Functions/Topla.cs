using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Topla
    {

        // 2. fonksiyon oluşturma 

        // erişim_belirleyici geri_dönüş_tipi fonksiyonun_adı( parametreler )
        // {
        //fonksiyonun kodu
        // return geri_dönüş_tipi
        // }

        public int Toplama(int sayi1, int sayi2)
        {
            var sonuc = sayi1 + sayi2;

            Console.WriteLine(sayi1  + " + " + sayi2 + " = " + sonuc);

            return sonuc;
        }

        // Fonksiyon türleri


    }
}
