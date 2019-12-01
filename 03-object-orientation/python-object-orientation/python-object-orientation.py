#!/usr/bin/python3

class Member:
	# Python class constructors are named __init__
	def __init__(self, first_name, last_name, age):
		self.first_name = first_name
		self.last_name = last_name
		self.age = age

	# Python does not have explicit property setters and getters.

	# Every method in a Python class must define at least one parameter named 'self', which is
	# a reference to the current instance of the class.
	def is_legal_adult(self):
		if self.age >= 18:
			return True
		else:
			return False

new_member = Member("John", "Doe", 37)

print("The new member record is for " + new_member.first_name + " " + new_member.last_name + ", who is " + str(new_member.age) + " years old.")

# You do not have to pass the 'self' parameter.  It's automatic.
if new_member.is_legal_adult() == True:
	print(new_member.first_name + " is a legal adult.")
else:
	print(new_member.first_name + " is NOT a legal adult.")