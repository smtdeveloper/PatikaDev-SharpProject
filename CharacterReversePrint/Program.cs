Console.WriteLine("Character Reverse Print");

string input = Console.ReadLine();


    string[] strings = input.Split(" ");

    foreach (var word in strings)
    {
        char[] chars = word.ToCharArray();
        Array.Reverse(chars);
        string reverseWord = new string(chars);
        Console.Write(reverseWord + " ");
        break;
    }



//for (int i = input.Length - 1; i >= 0; i--)
//{
//    Console.Write(input[i]);
//}


