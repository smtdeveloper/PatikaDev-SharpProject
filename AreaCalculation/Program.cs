Console.WriteLine("SMTcoder Calculation");

double radius, height, edge1, edge2, edge3, baseLength, width;
double pi = 3.14;
double result;
string? input = "";
string exit = "to log out : Write exit  ; ENTER to continue.  SMTcoder Calculation";
string codeError = "You have selected the wrong transaction code!";

Console.WriteLine("Choose Geometric Shape : circle = 0 , triangle = 3 , square  = 4");
int geoType = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Select the size you want to calculate : Environment = 1 , Area = 2 , Volume = 3   ");
int areaType = Convert.ToInt32(Console.ReadLine());



while (input.ToLower() != "exit")
{
    if (geoType == 0) // Daire 
    {
        switch (areaType)
        {
            case 1:
                Console.WriteLine("Please Enter the Radius to calculate the Circumference of the Circle  : ");
                Console.Write("Radius : "); radius = Convert.ToInt32(Console.ReadLine());
                result = 2 * pi * radius;
                Console.WriteLine("Circumference of circle " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            case 2:
                Console.WriteLine("Please Enter the Radius to calculate the Area of the Circle  : ");
                Console.Write("Radius : "); radius = Convert.ToInt32(Console.ReadLine());
                result = pi * (radius * radius);
                Console.WriteLine("Circumference of area " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            case 3:
                Console.WriteLine("Please Enter the Radius and Height of the Circle to calculate its Volume : ");
                Console.Write("Radius : "); radius = Convert.ToInt32(Console.ReadLine());
                Console.Write("Height : "); height = Convert.ToInt32(Console.ReadLine());
                result = pi * (radius * radius) * height;
                Console.WriteLine("Circumference of volume " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            default:
                Console.WriteLine(codeError);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;
        }
    }
    else if (geoType == 3) // üçgen
    {
        switch (areaType)
        {
            case 1:
                Console.WriteLine("Please enter the 3 side lengths to calculate the perimeter of the triangle : ");
                Console.Write("1.Edge : "); edge1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Edge : "); edge2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("3.Edge : "); edge3 = Convert.ToInt32(Console.ReadLine());
                result = edge1 + edge2 + edge3;
                Console.WriteLine("Perimeter of triangle " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            case 2:
                Console.WriteLine("Please enter the base length and height to calculate the area of the triangle : ");
                Console.Write("Base Length : "); baseLength = Convert.ToInt32(Console.ReadLine());
                Console.Write("Height : "); height = Convert.ToInt32(Console.ReadLine());
                result = (baseLength * height) / 2;
                Console.WriteLine("Area of triangle " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            case 3:
                Console.WriteLine("Please enter the base length and height to calculate the volume of the triangle : ");
                Console.Write("Base Length : "); baseLength = Convert.ToInt32(Console.ReadLine());
                Console.Write("Height : "); height = Convert.ToInt32(Console.ReadLine());
                result = ((baseLength * height) / 2) * height;
                Console.WriteLine("Volume of triangle " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            default:
                Console.WriteLine(codeError);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;
        }
    }
    else if (geoType == 4) // kare
    {
        switch (areaType)
        {
            case 1:
                Console.WriteLine("Please enter a side length to calculate the perimeter of the square : ");
                Console.Write("Edge length : "); edge1 = Convert.ToInt32(Console.ReadLine());
                result = edge1 * 4;
                Console.WriteLine(" Perimeter of the square  " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("Please enter a side length to calculate the area of the square : ");
                Console.Write("Edge length : "); edge1 = Convert.ToInt32(Console.ReadLine());
                result = edge1 * edge1;
                Console.WriteLine("Area of the square  " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;
            case 3:
                Console.WriteLine("Lütfen karenin Hacmini hesaplamak için, bir kenar uzunluğunu , genişliğini ve yüksekliğini   giriniz ! ");
                Console.Write("Edge length : "); edge1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Width : "); width = Convert.ToInt32(Console.ReadLine());
                Console.Write("Height : "); height = Convert.ToInt32(Console.ReadLine());
                result = edge1 * width + height;
                Console.WriteLine("Volume of the square : " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            default:
                Console.WriteLine(codeError);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

        }
    }
    else
    {
        Console.WriteLine(codeError);
        Console.WriteLine(exit);
        input = Console.ReadLine();
    }
}