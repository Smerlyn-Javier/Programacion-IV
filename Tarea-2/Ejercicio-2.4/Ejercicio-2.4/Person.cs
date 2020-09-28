using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._4
{
    class Person
    {
        string name;
        string lastName;
        string sex;
        int age;

        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected string Sex { get; set; }
        protected string Age { get; set; }

        public Person(string name, string lastName, string sex, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.sex = sex;
            this.age = age;
           
        }
    }
}
