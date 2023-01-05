using System;
namespace Polymorphism
{
	public class Student:Human
	{
		public string GroupNo;
        public override string ToString()
        {
            return $"Nmae:{Name}-GroupNo:{GroupNo}";
        }
    }
}

