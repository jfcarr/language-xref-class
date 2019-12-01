package main

import "fmt"

func main() {
	err := arrayTest()
	if err != nil {
		fmt.Println(err)
	}

	collectionTest()
}

func arrayTest() error {
	// Arrays are of a fixed size, specified when you create them.
	arrayOfInts := [3]int{1, 2, 3}

	// You can step through the elements of the array in a for loop, using the array
	// length to keep track of where you are.  Arrays in Go are 0-based.
	for i := 0; i < len(arrayOfInts); i++ {
		fmt.Printf("Array element %d contains %d\n", i, arrayOfInts[i])
	}

	// Call a statement with a defer, and an associated handler, to catch panic
	// conditions (exceptions) on individual statements.
	defer fmt.Printf("Array element 3 contains %d\n", arrayOfInts[2])
	defer func() {
		if r := recover(); r != nil {
			fmt.Printf("Panic: %+v\n", r)
		}
	}()

	// Anything inside a function that returns an error will cause an early exit.
	// If we make it to the end of the function, we return a nil value to indicate
	// no errors occurred.
	return nil
}

func collectionTest() {
	// The simplest collection type in Go is a slice.  It provides more flexibility than an array.
	sliceOfIntegers := make([]int32, 0)

	// Slices are mutable.  You can add items to them after they're created.
	sliceOfIntegers = append(sliceOfIntegers, 1)
	sliceOfIntegers = append(sliceOfIntegers, 2)
	sliceOfIntegers = append(sliceOfIntegers, 3)

	for i := 0; i < len(sliceOfIntegers); i++ {
		fmt.Printf("Slice element %d contains %d\n", i, sliceOfIntegers[i])
	}
}
