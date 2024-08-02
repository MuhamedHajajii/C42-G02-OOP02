using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x,y)
        {
            Z = z;
        }

        public override string ToString()
        {
            return $"{base.ToString()},({Z})";
        }

        public new int Product() // Masking new version from the method called product
        {
            return base.Product() * Z;
        }

    }
}
