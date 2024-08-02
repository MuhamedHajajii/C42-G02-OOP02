using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB : TypeA
    {
        public void Print()
        {
            TypeA obj = new TypeA();

            //obj.X = 10; // Protected Private so  Private
            //obj.Y = 10; // Protected so Protected Private
            //obj.Z = 10; // Internal so Protected Internal - Valid
            //obj.M = 10; // private so Protected Private
            // So without any inheritance you can igonre the protected keyword

            

        }

        public TypeB()
        {
            // With The Inheritance
            X = 10; // valid Inherit it as private 
            Y = 20; // valid inherit it As Private
            Z = 30; // valid inherit as Internal
            //M = 40; // invalid

        }
    }
}
