package main

import "fmt"
import "reflect"

func main() {
	simpleConsoleOutput("Jim")
	// ^ Go advises camel casing for most situations.

	typingRules()

	codeBlocks()

	loops()
}

func simpleConsoleOutput(nameValue string) {
	fmt.Println("Hello World!")

	// You can format strings with concatenation
	fmt.Println("Hello " + nameValue + "!")

	// Go doesn't have inline string interpolation, but you can format and print a string with Printf.
	// (You have to add a carriage return)
	fmt.Printf("Hello %s!\n", nameValue)

	// If you need to build the string before printing it, you can use Sprintf.
	var formattedLine string = fmt.Sprintf("Hello %s!", nameValue)
	fmt.Println(formattedLine)
}

func typingRules() {
	// Go is statically typed

	// This means that variable types must be known at compile time.
	var stringValue string = "A String"
	var anInteger int = 10
	var aFloat float32 = 3.14159

	fmt.Printf("The string value is '%s', the integer value is %d, and the float value is %f\n", stringValue, anInteger, aFloat)

	// If you use the := assignment operator, Go will attempt to infer the type.
	inferredStringValue := "A String"
	inferredInteger := 10
	inferredFloat := 3.14159

	fmt.Printf("The inferred %s value is '%s', the inferred %s value is %d, and the inferred %s value is %f\n", reflect.TypeOf(inferredStringValue).String(), inferredStringValue, reflect.TypeOf(inferredInteger).String(), inferredInteger, reflect.TypeOf(inferredFloat).String(), inferredFloat)

	// I used reflect.TypeOf to determine the variable types above,
	// but there's a much more concise way to print it: %T
	fmt.Printf("The value of inferredFloat is %f, and the type is %T\n", inferredFloat, inferredFloat)
}

func codeBlocks() {
	// Grouping of code ("scoping") is controlled by curly brackets/braces, and individual
	// statements are terminated with a newline.

	methodScopedVariable := 100

	fmt.Printf("methodScopedVariable is initialized to %d\n", methodScopedVariable)

	if 1 == 1 {
		// LocalScopedVariable will only be available inside the (1==1) block
		localScopedVariable := 10

		fmt.Printf("The value of localScopedVariable is %d\n", localScopedVariable)

		// MethodScopedVariable is part of the outer scope, so it's available here, and
		// can be modified.
		methodScopedVariable = 200
	}

	fmt.Printf("Value of methodScopedVariable is now %d\n", methodScopedVariable)
}

func loops() {
	// A for loop has an establishing condition, a condition to check before executing the block,
	// and a statement to execute for each iteration of the loop.
	for i1 := 1; i1 < 5; i1++ {
		fmt.Printf("For loop, iteration %d\n", i1)
	}

	// A while loop executes as long as the condition of the while is true.  In Go, a while loop
	// is implemented as an alternate syntax of for.
	i2 := 1
	for i2 < 5 {
		fmt.Printf("While loop, iteration %d\n", i2)
		i2++
	}
}
