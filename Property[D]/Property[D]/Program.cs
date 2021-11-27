using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_D_
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetName("Shakib");
            Console.WriteLine(student.GetName());
            student.Name = "Shakib";
            student.Id = "18-yyyyy-1";
            student.Cgpa = 3.5f;
            student.University = "AIUB";
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Id);
            student.PrintStudent();
        }
    }
}
