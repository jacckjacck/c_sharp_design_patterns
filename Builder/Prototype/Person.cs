using System;

namespace Prototype
{
	public class Person : ICloneable
	{
		public string[] Names { get; set; }
		public Address Address { get; set; }

		public Person(string[] names, Address address)
		{
			Names = names;
			Address = address;
		}

		public override string ToString()
		{
			return $" {nameof(Names)} : { string.Join(' ', Names)}, {nameof(Address)} : {Address}";
		}

		public object Clone()
		{
			return new Person((string[]) Names.Clone(), (Address) Address.Clone());
		}
	}

	public class Address: ICloneable
	{
		public string StreetName { get; set; }
		public int HouseNumber { get; set; }

		public Address(string streetName, int houseNumber)
		{
			StreetName = streetName;
			HouseNumber = houseNumber;
		}

		public override string ToString()
		{
			return $"{nameof(StreetName) }: {StreetName}, {nameof(HouseNumber)} :{HouseNumber} ";
		}

		public object Clone()
		{
			return new Address(StreetName, HouseNumber);
		}
	}
}
