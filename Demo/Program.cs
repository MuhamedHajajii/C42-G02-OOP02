using Demo.Encasoulation;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            // Session Two OOP
            // 1- What is OOP
            // 2- Encapsulation
            // 3- Property
            // 4- Indexer
            // 5- Class
            // 6- Inheritance
            // 7- Access Modifiers
            // 8- Association [Composition,Agregation]

            #region 1- What Is OOP

            /** What Is OOP ?
             * Object Orianted Programing
             * Programming Paradigm
             * We Have 3 Programming paradigm to work with
             * 1- Leaner [The Maintenance is do difficult]
             * 2- Function [Block of code declared as function and make the code reusable and still have global variable plus it can not implement business]
             * 3- OOP [Can Implement Business But still include some issues] 
             * 
             * The OOP include 4 pillars
             * 1- Encasuplation [Separate data difination from data use] Data Difenition we mean Attributes and we have two ways to implement it
             * 2- Inheritance [reduce the repetitions for the code and avoid the maintenance proplems] 
             * 3- Polymorphism [override on a function to make a differnect behavior and it 
             * works with inheritance and overloading to make on function with the same name make different action same function in sameclass
             * with the same name] 
             * 4- Abstraction [Guide line, steps you will implement to hide a part from your business to hide some information its not important right now]
             * it may be important information but not in the current time , to hide part from the system in the current time
             * It the best paradigm to simulate the real life so i can implement any buisness with it the function or structure programming paradigm 
             * only focus on behaviors like C Language
             * deal with every part on the program as an object and make a class for every part of this business 
             * and create every part of it and descript it within the class like Employee project department 
             * and create it from the init class
             * 
             * The disadvantage for the oop 
             * because the huge parts of the oop we will face a problems with maintanence and performance but we will handle it using another things 
             * so its not a big deal
             * 
             */

            #endregion

            #region 2-Encapsulation

            // What is The Encasulation ??
            /** 
             * Means to separate the data difination from data use , and the data definition means the Attributes of the class
             * I was face some problems when i was deal with attributes direct [Data definition]
             * The Encasulation is supported in both (Class & Struct)
             */

            #region 1- Before Encapsulation
            // Declare For A Variable form type employee
            // This Variable is only can assign a employee not any other data
            // struct has not object
            //Employee employee;
            //// This new keyword is only resposible to choose which constructor u will use
            //// and in the struct even if you don't decalre the parameter less constructor the compiler will generate it by defult
            //employee = new Employee();
            //Console.WriteLine(employee.ToString());

            //employee = new Employee(10, "Hajajii", 2000);
            //Console.WriteLine(employee.ToString());

            //employee = new Employee(name: "Aliaa", id: 20, salary: 4000);
            //Console.WriteLine(employee.ToString());

            //// if i want to change any value of the struct like id i will get it and change it 
            //// set the id directly through attribute
            //employee.id = 30;
            //// get the id directly through my attribute
            //Console.WriteLine(employee.id);

            /** If i have a class library 
             * and i have a class in it caled employee 
             * and i will change any thing in the employee in the class library like the id will change to empId
             * so i should change it all over the clints
             */

            /** If i want to write any constraints i will not add this constraints 
             * i can not denay and validate the values which will be assign to the attributes
             */

            /** If i want to denay any changes in the id or on any attribute 
             * using private will lead to block the set and the get
             * so i want to keep it public as it is 
             */


            #endregion

            #region 2- After Encabsulation

            /** We Have Two types to apply the encasulation [old way setter and getter methods] [new way property ] full or automatic or indexer
             * the encasulation must help to solve three main issues in the oop
             * 1- The Data definition [Attributes] when you change any of them in the base class it must be renamed all over the solution
             * 2- can n't denay any changes on the attributes only with the private access modifier and this will lead to denay the get and the set
             * 3- cann't made any condations or constraints on the attributes like make the maximum or minimum salary is 5000$
             */

            /**
             * to solve this problems we have to ways we mentioned them before
             * properties ==>> New Way
             * Setter and getter Properties ==>> Old Way
             */

            Employee employee;
            employee = new Employee(10,"Hajajii",2000,20,20);

            Console.WriteLine(employee.GetName()); ;
            employee.SetName("Haji bs");
            Console.WriteLine(employee.GetName()); ;

            // This is the first way to apply the encapsulation 
            // separate the data definition [Attributes] from the data use [clint]
            // now i can deal with my attricutes with indirect way
            // i can change the name of the attributes only in my struct
            // i can validate the data
            // i can denay and grant the set or the get
            // this was with the first approach

            /** Second Approach with the property
             * 1- Full Property
             * 2- Automatic Property
             * 3- Indexer
             */

            Employee employee02;
            employee02 = new Employee(50,"Salma",1000,20,20);

            Console.WriteLine(employee02.Salary); ;
            employee02.Salary = 1500;
            Console.WriteLine(employee02.Salary); ;
            Console.WriteLine("================================");
            Console.WriteLine(employee02.ToString());
            Console.WriteLine($"Deductions = : {employee02.Deduction}"); ;
            Console.WriteLine("================================");
            Employee emp03 = new Employee(60,"Esmail",5000,10,10);

            Console.WriteLine(emp03.ToString());
            Console.WriteLine($"Deductions = : {emp03.Deduction}"); ;

            #endregion

            #endregion

        }
    }
}
