using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_D_
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Dhaka");
            cities.Add("Jedda");
            cities.Add("New York");
            cities.Add("Mumbai");

            //cities.Add("Dhaka");
            //cities.Add("Jedda");
            //cities.Add("New York");
            //cities.Add("Mumbai");

            cities.Add("Tokiyo");

            cities.TrimExcess();
            //Console.WriteLine("Count:" +cities.Count);
            //Console.WriteLine("Capacity:" + cities.Capacity);
            //Console.WriteLine(cities[2]);

            //cities.Reverse();
            //cities.Sort();
            //cities.RemoveAt(3);
            //cities.Remove("New York");
            //cities.Clear();
            //foreach(string item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(cities.Contains("Dhaka"));
            //Console.WriteLine(cities.IndexOf("New York"));

            //List of object
            List<Student> students = new List<Student>();
            Student student1 = new Student() { Id=1,Name="Shakib"};
            students.Add(student1);
            students.Add(new Student() { Id=2,Name="Tamim"});

            foreach(Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
