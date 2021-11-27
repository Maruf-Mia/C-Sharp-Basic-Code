using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Property_D_;
namespace Array
{
    //Array
    class Program
    {
        static void Main(string[] args)
        {
            //Single dimensional array
            //int[] numbers = new int[5];
            //numbers[0] = 10;
            //numbers[1] = 7;
            //numbers[2] = 15;
            //numbers[3] = 5;
            //numbers[4] = 9;
            //numbers[5] = 90;//exception

            //array declaration and initialization
            //int[] numbers = new int[5] { 10, 7, 15, 5, 9 };
            //int[] numbers = new int[] { 10, 7, 15, 5, 9 };
            //int[] numbers =  { 10, 7, 15, 5, 9 };

            //Console.WriteLine(numbers.Rank);
            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers[2]);

            //for(int i=0;i<numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //foreach loop
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Multi-dimensional array
            //int[,] numbers = new int[2, 3];
            //numbers[0, 0] = 10;
            //numbers[0, 1] = 20;
            //numbers[0, 2] = 30;

            //numbers[1, 0] = 40;
            //numbers[1, 1] = 50;
            //numbers[1, 2] = 60;

            //int[,] numbers = new int[2, 3] { 
            //                                    { 10,20,30},
            //                                    { 40,50,60}
            //                               };

            //int[,] numbers = new int[,] {
            //                                { 10,20,30},
            //                                { 40,50,60}
            //                            };

            //int[,] numbers = {
            //                    { 10,20,30},
            //                    { 40,50,60}
            //                 };

            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers[1,1]);

            //for (int i=0;i<numbers.GetLength(0);i++)
            //{
            //    for(int j=0;j<numbers.GetLength(1);j++)
            //    {
            //        Console.Write(numbers[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}

            //Jagged array
            //int[][] numbers = new int[2][];
            //numbers[0] = new int[3] { 10, 20, 30 };
            //numbers[1] = new int[2] { 40, 50 };

            //int[][] numbers = new int[2][] {
            //                                    new int[3] { 10, 20, 30 },
            //                                    new int[2] { 40, 50 }
            //                               };

            //int[][] numbers = new int[][] {
            //                                    new int[3] { 10, 20, 30 },
            //                                    new int[2] { 40, 50 }
            //                               };

            //int[][] numbers = {
            //                        new int[3] { 10, 20, 30 },
            //                        new int[2] { 40, 50 }
            //                  };

            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers[0][1]);

            //for (int i=0;i<numbers.Length;i++)
            //{
            //    for(int j=0;j<numbers[i].Length;j++)
            //    {
            //        Console.Write(numbers[i][j]+" ");
            //    }
            //    Console.Write("| ");
            //}
            //Console.WriteLine();

            //Array of objects

            //Student[] students = new Student[2];
            //Student student1 = new Student() { Name = "Shakib", Id = "18-yyyyy-1", Cgpa = 3.5f, University = "AIUB" };
            //Student student2 = new Student() { Name = "Tamim", Id = "20-yyyyy-1", Cgpa = 3.7f, University = "AIUB" };
            //students[0] = student1;
            //students[1] = student2;

            Student[] students = new Student[2] {
                                                    new Student() { Name = "Shakib", Id = "18-yyyyy-1", Cgpa = 3.5f, University = "AIUB" },
                                                    new Student() { Name = "Tamim", Id = "20-yyyyy-1", Cgpa = 3.7f, University = "AIUB" }
                                                };
            
            for (int i=0;i<students.Length;i++)
            {
                students[i].PrintStudent();
            }
            for (int i =0; i<10)
        }
    }
}
