using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_D_
{
    class Sample
    {
        public void MyMethod(int x)
        {
            Console.WriteLine("MyMethod: "+x);
        }
        public void AnotherMethod(int x)
        {
            Console.WriteLine("AnotherMethod: " + x);
        }
        public void Method1(int x)
        {
            Console.WriteLine("Method1: " + x);
        }
        public void Method2(int x)
        {
            Console.WriteLine("Method2: " + x);
        }
    }

    //Delegate declaration
    public delegate void MyDelegate(int a);
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            //MyDelegate myDelegate = new MyDelegate(s.MyMethod);//method subscription
            //myDelegate.Invoke(100);
            //myDelegate(200);
            //myDelegate += s.AnotherMethod;
            //myDelegate += s.Method1;
            //myDelegate += s.Method2;
            //myDelegate -= s.MyMethod;
            //myDelegate -= s.MyMethod;
            //myDelegate += s.MyMethod;
            //myDelegate(500);

            MyDelegate m1 = s.MyMethod;
            MyDelegate m2 = s.AnotherMethod;
            MyDelegate m3 = s.Method1;
            MyDelegate m4 = s.Method2;
            MyDelegate myDelegate = m1 + m2 + m3 + m4;
            myDelegate(2000);
        }
    }
}
