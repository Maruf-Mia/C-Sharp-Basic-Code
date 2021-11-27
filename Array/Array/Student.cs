using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_D_
{
    class Student
    {
        //Fields
        private string name, id;
        private float cgpa;

        //Set, Get methods
        //public void SetName(string name)
        //{
        //    this.name = name;
        //}
        //public string GetName()
        //{
        //    return this.name;
        //}

        //Property
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public float Cgpa
        {
            set{ this.cgpa = value; }
            get { return this.cgpa; }
        }

        //Auto-implemented property
        public string University
        {
            set;
            get;
        }
        public void PrintStudent()
        {
            Console.WriteLine("Name:{0}\nId:{1}\nCgpa:{2}\nUniversity:{3}",this.name,this.id,this.cgpa,this.University);
        }
    }
}
