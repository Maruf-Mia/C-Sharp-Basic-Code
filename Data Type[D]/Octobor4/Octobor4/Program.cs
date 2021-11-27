using System;
using Csharpfundamentalsam.Math;
namespace Octobor4
{
    class ProgrCsharpfundamentalsam
    {
        public class Person
        {
            public string firstName;
            public string lastname;
        }

        public void Introduce()
        {
            Console.WriteLine("My Name is " + firstName + " " + lastname);
        }
    }
        static void Main(string[] args)
        {
            /////Console.WriteLine("Hello World!");
            //string firstname = "Maruf";
            //String secondname = "Hasan";
            //String myfullname = firstname + secondname;
            //Console.WriteLine(myfullname);
            //Console.WriteLine(firstname.IndexOf("X"));
            //Console.WriteLine(firstname[3]);

            var male = new Person();
            male.Introduce();

            male.firstName = "John";
            male.lastname = "Doe";

          var result =  Maruf.Add(13,27);
        Console.WriteLine(result);
          
        }
    }
}
