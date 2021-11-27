//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//public class Student
//{
//    Field declaration
//    string name, id;
//    float cgpa;

//    Constructor declaration
//    public Student(string name, string id, float cgpa)
//    {
//        this.name = name;
//        this.id = id;
//        this.cgpa = cgpa;
//    }

//    Method declaration
//    public void PrintStudent()
//    {
//        Console.WriteLine("Name:{0}\nId:{1}\nCgpa:{2}", this.name, this.id, this.cgpa);
//    }
//}

//public class Student
//{
//    Field declaration
//    string name, id;
//    float cgpa;
//    Constructor declaration
//    public Student(string name, string id, float cgpa)
//    {
//        this.name = name;
//        this.id = id;
//        this.cgpa = cgpa;
//    }
//    Method declaration
//    public void PrintStudent()
//    {
//        Console.WriteLine("Name:{0}\nId:{1}\nCgpa:{2}", this.name, this.id, this.cgpa);
//    }
//}

//class Program
//{
//static void MyMethod(string country = "Norway")
//{
//    Console.WriteLine(country);
//}

//static void Main(string[] args)
//{
//    MyMethod("Sweden");
//    MyMethod("India");
//    MyMethod();
//    MyMethod("USA");
//}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{

        class Program
        {

            static void Main(String[] args)
            {
                int value;
                Console.WriteLine("......Calculator....");
                Console.Write("Enter First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter 2nd Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Symbol (/ * + -): ");
                String Symbol = Console.ReadLine();

            switch (Symbol)
            {
                case "+":
                    value = num1 + num2;
                    Console.WriteLine("Addition:" + value);
                    break;

                case "-":
                    value = num1 - num2;
                    Console.WriteLine("Subtraction" + value);
                    break;
                case "*":
                    value = num1 * num2;
                    Console.WriteLine("Multiplication" + value);
                    break;

                case "/":
                    value = num1 / num2;
                    Console.WriteLine("Divison" + value);
                    break;

                default:
                    {
                       Console.WriteLine("Wrong Input!!!!");
                        break;
                    }

            }
            }
        }
}
