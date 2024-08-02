using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP02
{
    internal class Person
    {
        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }

        #endregion

        #region Constructors
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }

        #endregion
    }
}
