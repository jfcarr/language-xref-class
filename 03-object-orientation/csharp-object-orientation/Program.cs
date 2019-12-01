using System;

namespace csharp_object_orientation
{
	class Member
	{
		// Private property values.
		private string firstName;
		private string lastName;
		private int age;

		// The class constructor, which initializes the First Name, Last Name, and Age properties.
		public Member(string firstName, string lastName, int age)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.age = age;

		}

		/// <summary>
		/// Member's first name
		/// </summary>
		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		/// <summary>
		/// Member's last name
		/// </summary>
		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		/// <summary>
		/// Member's age, in years.
		/// </summary>
		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		/// <summary>
		/// Determine if the member is a legal adult.
		/// </summary>
		/// <returns>bool</returns>
		public bool IsLegalAdult()
		{
			if (age >= 18)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Determine if the member is a legal adult.
		/// </summary>
		/// <remarks>
		/// This version uses a ternary operator to assign the return value.
		/// </remarks>
		/// <returns>bool</returns>
		public bool IsLegalAdultTernary()
		{
			return (age >= 18) ? true : false;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			// Declare a new Member object.
			var MemberRecord = new Member("John", "Doe", 37);

			Console.WriteLine($"The new member record is for {MemberRecord.FirstName} {MemberRecord.LastName}, who is {MemberRecord.Age} years old.");

			// Determine if the new Member is a legal adult, and display an appropriate message.
			if (MemberRecord.IsLegalAdult() == true)
			{
				Console.WriteLine($"{MemberRecord.FirstName} is a legal adult.");
			}
			else
			{
				Console.WriteLine($"{MemberRecord.FirstName} is NOT a legal adult.");
			}
		}
	}
}
