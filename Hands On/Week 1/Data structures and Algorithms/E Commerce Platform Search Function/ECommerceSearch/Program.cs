using System;

class Program
{
    static void Main(string[] args)
    {
        Product[] products = new Product[]
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(205, "Shoes", "Fashion"),
            new Product(150, "Keyboard", "Electronics"),
            new Product(301, "Book", "Stationery")
        };

        Array.Sort(products, (p1, p2) => p1.ProductId.CompareTo(p2.ProductId));

        int searchId = 150;

        Console.WriteLine("Running Linear Search:");
        var linearResult = SearchService.LinearSearch(products, searchId);
        Console.WriteLine(linearResult != null ? linearResult.ToString() : "Product not found");

        Console.WriteLine("\nRunning Binary Search:");
        var binaryResult = SearchService.BinarySearch(products, searchId);
        Console.WriteLine(binaryResult != null ? binaryResult.ToString() : "Product not found");

        //Console.ReadLine();
    }
}