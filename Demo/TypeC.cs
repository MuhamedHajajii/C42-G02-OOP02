using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Demo
{
    internal class TypeC : TypeA
    {
        public TypeC()
        {
            //M = 10; // Invalid  
            //X = 10; // Invalid private Protected only can inherit within the project
            Y = 10; // i can inherit it because it was protected as Private
            Z = 10; // internal protected can inherit it in a class in another project but it will be private too
        }
    }
}
