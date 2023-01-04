//Algoritma
//Ekrandan bir string bir de sayı alan (aralarında virgül ile),
//ilgili string ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulasını yazınız.

//Örnek: Input: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0

//Output: Algritma Algortma Algoritma lgoritma

// Get input from the user
Console.Write("Enter a string and an index, separated by a comma (enter 'exit' to quit): ");
string input = Console.ReadLine();

while (input.ToLower() != "exit")
{
    // Split the input string into the string and the index
    string[] inputParts = input.Split(',');
    string stringInput = inputParts[0];
    int indexInput = int.Parse(inputParts[1]);

    // Print the character at the given index
    string output = stringInput.Remove(indexInput, 1);
    Console.WriteLine(output);

    // Get the next input
    Console.Write("Enter a string and an index, separated by a comma (enter 'exit' to quit): ");
    input = Console.ReadLine();
}