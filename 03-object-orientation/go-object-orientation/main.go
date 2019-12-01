package main

import "fmt"

// Go does not support classes, but it allows you to implement functions on structures.

type member struct {
	firstName, lastName string
	age                 int
}

// Determine if the member is a legal adult.
func (m *member) isLegalAdult() bool {
	if m.age >= 18 {
		return true
	}

	return false
}

func main() {
	memberInstance := member{firstName: "John", lastName: "Doe", age: 37}

	fmt.Printf("The new member record is for %s %s, who is %d years old.\n",
		memberInstance.firstName, memberInstance.lastName, memberInstance.age)

	if memberInstance.isLegalAdult() == true {
		fmt.Printf("%s is a legal adult.\n", memberInstance.firstName)
	} else {
		fmt.Printf("%s is not a legal adult.\n", memberInstance.firstName)
	}
}
