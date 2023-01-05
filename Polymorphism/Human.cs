using System;
namespace Polymorphism
{
	public class Human
	{
		public string Name;

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}

