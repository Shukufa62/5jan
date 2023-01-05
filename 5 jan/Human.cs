using System;
namespace _5_jan
{
	public class Human
	{
		public string Name;

		public virtual void ShowInfo()
		{
			Console.WriteLine(Name);
		}


        public override string ToString()
        {
            return $"{Name}";
        }
		//demek olarki eyni funksiyani yerine yetiriler

		
    }
}

