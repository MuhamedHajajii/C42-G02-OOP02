using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encasoulation
{
    internal struct Employee
    {
        #region Attributes
        // The defult access modifer in the struct is private
        private int id; // Attribute
        private string name; // Attribute
        private decimal salary; // Attribute
        private int age; // Attribute
        //public int empid; // Attribute
        //public string empname; // Attribute
        //public decimal empsalary; // Attribute
        #endregion


        #region Constructors
        // to avoid the problem to skip the defult validation you can deal direct with the property and let the property deal with the member vairable
        // if you inside the struct or the class you will deal with the attribute direct 
        // if you will deal external the struct or the class or using a validation deal with the property
        // it doesn't necessry to use it if there are no validation
        public Employee(int id, string name, decimal salary, int age, int age2)
        {
            this.id = id;
            this.name = name;
            this.Salary = salary;
            this.age = age;
            this.Age2 = age2;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id = {id}\nName = {name}\nSalary = {salary:c}\nAge = {Age2}";
        }

        // Separate the data definition form its use [Attributes == Data Definition] use == Clint

        // 1- Apply encapsulation getter setter
        // a. all your attributes must be private
        // b. the functions always must be public
        // can denay the set using private or delete this function so i will only allowed to get it with the getter method
        public void SetName(string value)
        {
            // Can Validate the name now
            this.name = value.Length > 3 ? value[0..3] : value;
        }


        public string GetName()
        {
            return this.name;
        }

        // first step to apply the encapsulation with the property make the attribute private
        // second step to make the attribute small
        // value is a keyword inside the property reserved keyword
        // now if i will change the name of the attribute i don't need to change it in the external code for the clint
        // i can make a validation on the code
        // i can denay the set or the get
        // but in the first add u will not can add the validation yet
        // plus the recomended way is to apply the property not the methods of the getter and setter because it mostly like the defult way butr with constranits
        public decimal Salary
        {
            get { return this.salary; }
            // if you make it private you can use it inside the struct but in the external code you will not 
            set { this.salary = value < 2000 ? 2000 : value; }
        }

        // full property only used when u applay a validation else using a automatic property
        public int Age
        {
            get { return this.age; }    
            set { this.age = value; }
        }

        /**
         * This is now a Property not an attribute and called automatic property
         * The compiler will generate the attribute with the defult value for it 
         * hidden private attribute backing field 
         * Hidden to deal with but you can see it in the ilspy from the dll file intermediate language
         * and you don't have any access for it 
         */
        public int Age2 { get; set; }

        // the snippet for the full prop is prop propfull and for the automatic property
        // Drivied Property or attribute calculate
        // i didn't use it ever derived attribute
        //private decimal deduction;

        public decimal Deduction
        {
            get { return this.Salary * 0.2M; }
        }
        /**
         * The Clr will allocate in the stack the required bytes for the attributes id = 4 , name = 4 , salary decimal = 16 Total us 24 bytes
         * and the string will be allocated in the head with the array of charachter for the name
         */

        #endregion

    }
}
