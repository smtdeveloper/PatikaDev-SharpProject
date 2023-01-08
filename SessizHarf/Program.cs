//Algoritma
//Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulamasını yazınız.

//Örnek: Input: Merhaba Umut Arya

//Output: True False True


using System;

while (true)
{
    Console.WriteLine("\n\n Boşluk bırakıp kelimelerİ girin");

    foreach (var item in Console.ReadLine().Split())
    {
        bool def = false;
        for (int i = 1; i < item.Length; i++)
        {
            if (sessizMi(item[i]) == sessizMi(item[i - 1]))
                def = true;
        }
        Console.Write(def + " ");
    }

    bool sessizMi(char c)
    {
        return !"aeıioöuüAEIİOÖUÜ".ToCharArray().Contains(c);
    }
}