using System;

namespace csharp_simple_things
{
	class Program
	{
		static void Main(string[] args)
		{
			// Note casing on the method name.  Microsoft recommends PascalCase for most things.
			SimpleConsoleOutput("Jim");

			TypingRules();

			CodeBlocks();

			Loops();
		}

		static void SimpleConsoleOutput(string nameValue)
		{
			// ^ Note the use of camelCase on the method parameter.  This is one of the exceptions to
			// Microsoft's PascalCase rules.

			// Starting with the simplest of examples, here's how to print a string to the console.
			Console.WriteLine("Hello World!");

			// Then, we can use the variable in our message.
			Console.WriteLine("Hello " + nameValue + "!");

			// We used string concatenation above, but string interpolation is cleaner.
			Console.WriteLine($"Hello {nameValue}!");
		}

		static void TypingRules()
		{
			// C# is statically typed.

			// This means that variable types must be known at compile time.
			string StringValue = "A String";
			Int32 AnInteger = 10;
			double ADouble = 3.14159;

			Console.WriteLine($"The string value is '{StringValue}', the integer value is {AnInteger}, and the double value is {ADouble}");

			// C# does allow a 'shortcut' of sorts, via the 'var' keyword.  You can use var as long as the type can be
			// inferred through its usage at compile time.
			var InferredStringValue = "A String";
			var InferredInteger = 10;
			var InferredDouble = 3.14159;

			Console.WriteLine($"The inferred {InferredStringValue.GetType()} value is '{InferredStringValue}', the inferred {InferredInteger.GetType()} value is {InferredInteger}, and the inferred {InferredDouble.GetType()} value is {InferredDouble}");
		}

		static void CodeBlocks()
		{
			// Grouping of code ("scoping") is controlled by curly brackets/braces, and individual
			// statements are terminated with a semicolon.

			var MethodScopedVariable = 100;

			Console.WriteLine($"MethodScopedVariable is initialized to {MethodScopedVariable}");

			if (1 == 1)
			{
				// LocalScopedVariable will only be available inside the (1==1) block
				var LocalScopedVariable = 10;

				Console.WriteLine($"The value of LocalScopedVariable is {LocalScopedVariable}");

				// MethodScopedVariable is part of the outer scope, so it's available here, and
				// can be modified.
				MethodScopedVariable = 200;
			}

			Console.WriteLine($"Value of MethodScopedVariable is now {MethodScopedVariable}");
		}

		static void Loops()
		{
			// A for loop has an establishing condition, a condition to check before executing the block,
			// and a statement to execute for each iteration of the loop.
			for (int i1 = 1; i1 < 5; i1++)
			{
				Console.WriteLine($"For loop, iteration {i1}");
			}

			// A while loop executes as long as the condition of the while is true.
			var i2 = 1;
			while (i2 < 5)
			{
				Console.WriteLine($"While loop, iteration {i2}");
				i2++;
			}
		}
	}
}
