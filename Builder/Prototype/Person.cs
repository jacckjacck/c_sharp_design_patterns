using System;

namespace Prototype
{
	public class Person : IPrototype<Person>
	{
		public string[] Names { get; set; }
		public Address Address { get; set; }

		public Person(string[] names, Address address)
		{
			Names = names;
			Address = address;
		}

		public Person(Person other)
		{
			Names = other.Names;
			Address = new Address(other.Address);
		}

		public override string ToString()
		{
			return $" {nameof(Names)} : { string.Join(' ', Names)}, {nameof(Address)} : {Address}";
		}

		public Person DeepCopy()
		{
			return new Person(Names, Address.DeepCopy());
		}
	}

	public class Address: IPrototype<Address>
	{
		public string StreetName { get; set; }
		public int HouseNumber { get; set; }

		public Address(string streetName, int houseNumber)
		{
			StreetName = streetName;
			HouseNumber = houseNumber;
		}

		public Address(Address other)
		{
			StreetName = other.StreetName;
			HouseNumber = other.HouseNumber;
		}

		public override string ToString()
		{
			return $"{nameof(StreetName) }: {StreetName}, {nameof(HouseNumber)} :{HouseNumber} ";
		}

		public Address DeepCopy()
		{
			return new Address(StreetName, HouseNumber);
		}
	}
}
