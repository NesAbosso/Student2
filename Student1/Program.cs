using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Student1
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
               // context.Database.EnsureCreated();

                var student = new Student() { Name = "Bobby" };
                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }


        }
    }
}
