using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_D_
{
    abstract class Parent
    {
        abstract public void MyMethod();
        public void NonAbstractMethod()
        {
            Console.WriteLine("Parent->NonAbstractMethod");
        }
    }
    class Child:Parent
    {
        override public void MyMethod()
        {
            Console.WriteLine("Child->MyMethod");
        }
    }

    class GrandChild:Child
    {
        override public void MyMethod()
        {
            Console.WriteLine("GrandChild->MyMethod");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //new Parent();//error
            //Parent parent;
            Parent parent = new Child();
            parent.MyMethod();
            parent = new GrandChild();
            parent.MyMethod();
            parent.NonAbstractMethod();
        }
    }
}
