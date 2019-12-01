using System;
using System.Collections.Generic;

namespace csharp_data_items
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayTest();

			CollectionTest();
		}

		static void ArrayTest()
		{
			// Arrays are of a fixed size, specified when you create them.
			int[] ArrayOfInts = new int[3] { 1, 2, 3 };

			// You can step through the elements of the array in a for loop, using the array
			// length to keep track of where you are.  Arrays in C# are 0-based.
			for (int i = 0; i < ArrayOfInts.Length; i++)
			{
				Console.WriteLine($"Array element {i} contains {ArrayOfInts[i]}");
			}

			// A foreach provides a simple way of walking an array.
			var foreachIteration = 0;
			foreach (int ArrayElement in ArrayOfInts)
			{
				Console.WriteLine($"foreach: [item {foreachIteration}] is {ArrayElement}");
				foreachIteration++;
			}

			// Using an exception handler will allow you to handle out-of-bounds conditions.
			try
			{
				Console.WriteLine($"Array element 10 contains {ArrayOfInts[9]}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"[ERROR] {ex.Message}");
			}
		}

		static void CollectionTest()
		{
			// A collection (in this example, a generic List) provides a more flexible way of holding data.
			var listOfIntegers = new List<Int32>();

			// Collections are mutable, so you can add items after the collection is created.
			listOfIntegers.Add(1);
			listOfIntegers.Add(2);
			listOfIntegers.Add(3);
			listOfIntegers.Add(4);

			// You can remove items by key as well.
			listOfIntegers.Remove(4);

			// A foreach provides a simple way of walking a collection.
			var itemIteration = 0;
			foreach (var integerItem in listOfIntegers)
			{
				Console.WriteLine($"Item {itemIteration} is {integerItem}");
				itemIteration++;
			}

			// You can combine declaring and populating a collection with an object initializer.
			var listOfStrings = new List<String> {
				"One",
				"Two",
				"Three"
			};
			itemIteration = 0;
			foreach (var stringItem in listOfStrings)
			{
				Console.WriteLine($"Item {itemIteration} is {stringItem}");
				itemIteration++;
			}
		}
	}
}
