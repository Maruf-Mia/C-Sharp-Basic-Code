using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_D_
{
    public class Person
    {
        //public string name = "Shakib";
        //private int voterId = 100;
        //protected string email = "shakib@gmail.com";
        //internal string address = "Kuratoli,Dhaka";
        //protected internal string bloodGroup = "O-";
        //public Person()
        //{
        //    this.name = "";
        //    this.voterId = 0;
        //    this.email = "";
        //    this.address = "";
        //    this.bloodGroup = "";
        //}
        public string name = "Maruf";
        private int voterId = 100;
        protected string email = "Shakib@gmail.com";
        internal string adress = "Kuratoli,Dhaka";
        protected internal String bloodGroup = "O-";
        public Person()
        {
            this.name = "";
            this.voterId = 0;
            this.email = "";
            this.adress = "";
            this.bloodGroup = "";
        }
    }
}
