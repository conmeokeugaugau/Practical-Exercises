using System;

namespace Practical-Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool choice = true;

            do {
                Console.WriteLine("\n");
                Console.Write("The number of products: ");
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];  // a = code of product
                int[] b = new int[n];  // b = quantity
                string[] product = new string[n];
                double[] quantity = new double[n];
                double total = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Code of product {i + 1}: ");
                    a[i] = int.Parse(Console.ReadLine());
                    Console.Write($"Quantity: ");
                    b[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < n; i++)
                {
                    if (a[i] == 1)
                    {
                        product[i] = "Cochorro Quente";
                        quantity[i] = 4;
                    }
                    else if (a[i] == 2)
                    {
                        product[i] = "X-Salada";
                        quantity[i] = 4.5;
                    }
                    else if (a[i] == 3)
                    {
                        product[i] = "X-Bacon";
                        quantity[i] = 5;
                    }
                    else if (a[i] == 4)
                    {
                        product[i] = "Torrada simples";
                        quantity[i] = 2;
                    }
                    else if (a[i] == 5)
                    {
                        product[i] = "Refrigerante";
                        quantity[i] = 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid code!");
                    }
                }

                Console.WriteLine("_________________________________________________________________________________________");
                Console.WriteLine($"{"NO",-10} | {"PRODUCTION NAME",-20} | {"PRICE",12} | {"QUANTITY",12} | {"TOTAL (R$)",12}");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"{i + 1,-10} | {product[i],-20} | {quantity[i],12:0.00} | {b[i],12} | {quantity[i] * b[i],12:0.00}");
                }
                Console.WriteLine("-----------------------------------------------------------------------------------------");

                for (int i = 0; i < n; i++)
                {
                    total += (quantity[i] * b[i]);
                }
                Console.WriteLine($"TOTAL: {total,71:0.00}");

                Console.Write("Enter your choice (1 - continue / 0 - exit): ");
                int z = int.Parse(Console.ReadLine());
                if (z == 0)
                {
                    choice = false;
                    Console.WriteLine("Thank you & Good bye!");
                }
            }
            while (choice == true);
        }
    }
}
