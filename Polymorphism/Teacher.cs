using System;
namespace Polymorphism
{
	public class Teacher:Human
	{
        public string Subject;

        public override string ToString()
        {
            return $"Name:{Name}-Subject:{Subject}";
        }
    }
}

