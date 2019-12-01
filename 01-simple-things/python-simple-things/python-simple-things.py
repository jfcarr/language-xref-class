#!/usr/bin/python3

def simple_console_output(name_value):
	print("Hello World!")

	# Use variable with string concatenation
	print("Hello " + name_value + "!")

	# Use variable with string interpolation
	print(f"Hello {name_value}!")

def typing_rules():
	# Python is dynamically typed, so types don't need to be specified in declarations -> they're
	# determined at runtime.
	
	# You can use the type() function to determine a variable's type.
	string_value = "A String"
	print(f"string_value is of type {type(string_value)}")

def code_blocks():
	# Grouping of code ("scoping") is controlled by indentation, and individual
	# statements are terminated with a newline.

	method_scoped_variable = 100

	print("method_scoped_variable is initialized to " + str(method_scoped_variable))

	if 1 == 1:
		local_scoped_variable = 10

		print("The value of local_scoped_variable is " + str(local_scoped_variable))

	# Python does NOT enforce local scoping.  Once the variable is declared, it can
	# remain available longer than you expect.
	print("The value of local_scoped_variable outside the declaring scope is still " + str(local_scoped_variable))

def loops():
	# A for loop using a 3-part range has the following parts: a starting value,
	# an ending value (exclusive), and an increment value.
	for i1 in range(1, 5, 1):
		print("For loop, iteration " + str(i1))

	# A while loop executes as long as a condition is true
	i2 = 1
	while i2 < 5:
		print("While loop, iteration " + str(i2))
		i2 += 1
	

# snake casing is recommended for Python.  (appropriate, eh?)
simple_console_output("Jim")

typing_rules()

code_blocks()

loops()