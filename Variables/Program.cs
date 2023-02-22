Console.WriteLine("Değisken Tipleri");

Console.WriteLine("Top 4 :)");
// int ramde 4 bayt alan kaplar	
// değer aralığı -2147483648, ..., 2147483647
// (tam sayı için kullanılır)
int number1 = 2;
Console.WriteLine("int : " + number1);

// string	Sınırsız	
// Metin tutar. çift tırnak içinde olan herşey string'dir.
string name = "Çiğdem";
Console.WriteLine("string : " + name);

// Koşullu yapılarda kullanılır.
// Bool türünden değerlere true, false veya
// 2<1 gibi ifadeler örnek verilebilir. Örnekler:
bool Isdelete = true;
bool check = 2 < 1;
Console.WriteLine("Bool : "+Isdelete);

// Tarihler için kullanılır
DateTime birthday = new DateTime(20/09/2000);
Console.WriteLine("DateTime : " + birthday);

Console.WriteLine(" ------------------  ");

// Tam Sayılar için  : byte = sbyte < short = ushort < int = uint < long - ulong 

// byte	ramde 1 bayt
// değer aralığı 0, ..., 255
// tam sayı için kullanılır
byte number2 = 255;

// sbyte 1 bayt	
// değer aralığı  -128, ..., 127
// tam sayı için kullanılır
sbyte number3 = 127;

//short 2 bayt
//- 32768, ..., 32767 
// tam sayı için kullanılır
short number4 = 32767;

//ushort 2 bayt	
//0, ..., 65535
// tam sayı için kullanılır
ushort number5 = 65535;

//int 4 bayt
//- 2147483648, ..., 2147483647
// tam sayı için kullanılır
int number6 = 2147483647;

//uint 4 bayt
//0, ..., 4294967295
//(tam sayı)
uint number7 = 4294967295;

//long 8 bayt
// -9223372036854775808, ..., 9223372036854775807
// tam sayı için kullanılır
long number8 = 9223372036854775807;

// ulong	8 bayt	
// 0, ..., 18446744073709551615
// tam sayı için kullanılır
ulong number9 = 18446744073709551615;

// Ondalık sayılar : float < double < decimal

//float ramde  4 bayt	
//±1.5 * 10 - 45, ..., ±3.4 * 1038
//reel sayılar için
float number10 = 50.2f;

//double ramde 8 bayt
//±5.0 * 10 - 324, ..., ±1.7 * 10308
//reel sayılar için
double number11 = 80.80;

//decimal ramde 16 bayt	
//±1.5 * 10 - 28, ..., ±7.9 * 1028(
//reel sayılar için
decimal number12 = 800.9m;

//char	ramde 2 bayt
//Tek bir karakteri tutar.	
char harf = 'Ç';

