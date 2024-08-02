using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP02
{
    internal struct Person02
    {

        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region Constructions
        public Person02(string _PersonName, int _PersonAge)
        {
            Name = _PersonName;
            Age = _PersonAge;
        }
        #endregion

        #region Methods
        public void AddPerson(string _PersonName, int _PersonAge)
        {
            this.Name = _PersonName;
            this.Age = _PersonAge;
        }

        public override string ToString()
        {
            return $"Name = ({this.Name}), Age = ({this.Age})";
        }

        #endregion

    }
}
