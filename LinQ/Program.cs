using System;
using System.Net.WebSockets;

namespace LinQ
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Category>  categories = new List<Category>
			{
				new Category{ CategoryID =1 , CategortyName = "Bilgisayar" },
				new Category{ CategoryID =1 , CategortyName = "Telefon" }
			};

			List<Product> products = new List<Product>
			{
				new Product{ ProductID=1, CategoryID =1 , ProductName = "Acar Laptop" , QuantityPerUnit = "32 GB RAM" , UnitPrice = 10000 , UnitInStock = 5 },
				new Product{ ProductID=1, CategoryID =1 , ProductName = "Asus Laptop" , QuantityPerUnit = "8 GB RAM" , UnitPrice = 8000 , UnitInStock = 4 },
				new Product{ ProductID=1, CategoryID =1 , ProductName = "HP Laptop" , QuantityPerUnit = "16 GB RAM" , UnitPrice = 6000 , UnitInStock = 3 },
				new Product{ ProductID=1, CategoryID =2 , ProductName = "Apple Telefon" , QuantityPerUnit = "4 GB RAM" , UnitPrice = 5000 , UnitInStock = 2 },
				new Product{ ProductID=1, CategoryID =2 , ProductName = "Samsung Telefon " , QuantityPerUnit = "6 GB RAM" , UnitPrice = 4000 , UnitInStock = 1 }
			};

			// Algoritmik
			Console.WriteLine(" \n Algoritmik ile \n  ");

			foreach (var item in products)
			{
				if (item.UnitPrice > 5000 && item.UnitInStock > 3)
				{
                    Console.WriteLine(item.ProductName );
                }

				
			}


            // Linq
            Console.WriteLine(" \n Linq ile \n  ");

			var result = products.Where(x => x.UnitPrice > 5000 && x.UnitInStock > 3).Select( n => n.ProductName);
			foreach (var item in result)
			{
				Console.WriteLine(item );
			}

        }

	

    }

	class Product
	{
		public int ProductID { get; set; }
		public int CategoryID { get; set; }
		public string ProductName { get; set; }
		public string QuantityPerUnit { get; set; }
		public decimal UnitPrice { get; set; }
		public int UnitInStock { get; set; }
	}

	class Category
	{
		public int CategoryID { get; set; }
		public string CategortyName { get; set; }
	}

}



