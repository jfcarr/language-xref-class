#!/usr/bin/python3

def array_test():
	# Python does not have a built-in array type, but it does have a type that closely
	# mirrors the behavior of an array: the Tuple

	# Tuples are immutable.  Once initialized, they cannot be changed.
	tuple_of_ints = (1, 2, 3)

	for_iteration = 0
	print("Tuple:\n")
	for tuple_element in tuple_of_ints:
		print("Element " + str(for_iteration) + " contains " + str(tuple_element))
		for_iteration = for_iteration + 1

	# You can use an exception handler to catch out-of-bound errors.
	try:
		print("Element 10 contains " + tuple_of_ints[9])
	except IndexError:
		print("Not a valid index of the tuple")
	except:
		print("Something bad happened. I'm not sure what it was.")

def collection_test():
	# The simplest mutable collection in Python is a List
	list_of_ints = [1, 2, 3]

	# You can append elements to them.
	list_of_ints.append(4)

	# You can remove elements by key, as well.
	list_of_ints.remove(4)

	# You can use a for loop to access each element of an array.
	for_iteration = 0
	print("\nList:\n")
	for list_element in list_of_ints:
		print("Element " + str(for_iteration) + " contains " + str(list_element))
		for_iteration = for_iteration + 1

array_test()

collection_test()