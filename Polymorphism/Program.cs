using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Human hmn1 = new Human {Name= "Hikmet" };
            object objHmn = hmn1;

            Student std1 = new Student { Name = "Abbas", GroupNo = "P123" };
          

            Teacher tch1 = new Teacher { Name = "Tofiq", Subject = "Design" };

            //upcasting
            Human hmn2 = new Student { Name = "Gunay", GroupNo = "P123" };


            //downsting
            Student std2 = hmn2 as Student;


            hmn2 = new Human { Name = "Akif" };

            if(hmn2 is Student)
            {
                var std = (Student)hmn2;
                Console.WriteLine(std.GroupNo);

            }
            else if(hmn2 is Teacher)
            {
                var tc = (Teacher)hmn2;
                Console.WriteLine(tc.Subject);
            }
            else
            {
                Console.WriteLine($"{ hmn2.Name } ne telebe ne de muellim deyil");
            }

            Human human3 = new Student { Name = "Rafiq", GroupNo = "P555" };
            human3 = new Teacher { Name = "Eli", Subject = "Design" };


           
            Console.WriteLine("\n====================== Human list =========================\n");
            Human[] humans = { hmn1, hmn2, human3, std1, std2, tch1 };

            for (int i = 0; i < humans.Length; i++)
            {
                Console.WriteLine(humans[i]);
            }
        }
    }
}

