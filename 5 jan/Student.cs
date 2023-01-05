using System;
namespace _5_jan
{
	public class Student:Human
	{
		public string GroupNo;

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} {GroupNo}" );
        }
        public override string ToString()
        {
            return $"{Name} {GroupNo}";
        }
    }
}

