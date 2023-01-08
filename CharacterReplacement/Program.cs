using System;

string s = "Merhaba";
char ilk = s[0];
char son = s[s.Length - 1];
s = son + s.Substring(1, s.Length - 2) + ilk;
Console.WriteLine(s);

Console.WriteLine("-------------------------------------------------");

Console.Write("Karakter Değiştirme : ");
string input = Console.ReadLine();

char first = input[0];
char last = input[input.Length - 1];
input= last + input.Substring(1, input.Length - 2) + first;
Console.WriteLine(input);


// Tüm kelimeyi cevirme
string x = "Samet Akca";
string reversed = "";
for (int i = x.Length - 1; i >= 0; i--)
{
    reversed += (char)(x[i]);
}
Console.WriteLine(reversed);
