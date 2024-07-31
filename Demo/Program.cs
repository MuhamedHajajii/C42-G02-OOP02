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

            ///**
            // * to solve this problems we have to ways we mentioned them before
            // * properties ==>> New Way
            // * Setter and getter Properties ==>> Old Way
            // */

            //Employee employee;
            //employee = new Employee(10,"Hajajii",2000,20,20);

            //Console.WriteLine(employee.GetName()); ;
            //employee.SetName("Haji bs");
            //Console.WriteLine(employee.GetName()); ;

            //// This is the first way to apply the encapsulation 
            //// separate the data definition [Attributes] from the data use [clint]
            //// now i can deal with my attricutes with indirect way
            //// i can change the name of the attributes only in my struct
            //// i can validate the data
            //// i can denay and grant the set or the get
            //// this was with the first approach

            ///** Second Approach with the property
            // * 1- Full Property
            // * 2- Automatic Property
            // * 3- Indexer
            // */

            //Employee employee02;
            //employee02 = new Employee(50,"Salma",1000,20,20);

            //Console.WriteLine(employee02.Salary); ;
            //employee02.Salary = 1500;
            //Console.WriteLine(employee02.Salary); ;
            //Console.WriteLine("================================");
            //Console.WriteLine(employee02.ToString());
            //Console.WriteLine($"Deductions = : {employee02.Deduction}"); ;
            //Console.WriteLine("================================");
            //Employee emp03 = new Employee(60,"Esmail",5000,10,10);

            //Console.WriteLine(emp03.ToString());
            //Console.WriteLine($"Deductions = : {emp03.Deduction}"); ;

            #endregion

            #endregion

            #region 3- PhoneBook
            // Need to make a data type which will represent a phonebook
            // implement it on the class or the struct will never matter in this step but the preferred implementation is the struct if you can 
            // because it allocated in the stack

            // the Defult Constructor the compiler generate with the struct
            //PhoneBook Note = new PhoneBook();
            // The User Defind Constructor

            //PhoneBook Note = new PhoneBook(3);

            //Note.AddPerson(0, "Aliaa", 123);
            //Note.AddPerson(1, "Mona", 465);
            //Note.AddPerson(2, "Ali", 789);

            //int PhoneNumber = Note.GetPersonNumber("Mona");
            //int PhoneNumber01 = Note.GetPersonNumber("Shimaa");

            //// Deal with the write line which takes the integer because it will only take integer
            //Console.WriteLine(PhoneNumber);
            //// Now it deals with the write line which take the object because it may take a string or number
            //Console.WriteLine(PhoneNumber == -1 ? "Not Found" : PhoneNumber);
            //Console.WriteLine(PhoneNumber01 == -1 ? "Not Found" : PhoneNumber01);

            //Note.SetPersonNumber("Mona", 999);
            //Console.WriteLine(Note.GetPersonNumber("Mona"));

            //// in the previous case we use the property in the old way
            //// in this way we will deal with the note as an array
            //// indexer always named with this and its only a property with parameters 

            //// Set the number using indexer
            //Note["Ali"] = 666;
            //// get Number using the indexer
            //Console.WriteLine(Note["Ali"]);

            //// always use the indexr when you want to deal with your object as an array or variable
            //// like the string it deal with the string as array

            //string Name = "aliaa";
            //Console.WriteLine(Name[0]);
            ////Name[0] = 'A'; //invalid 
            //// so the string allowed only the get not the set

            //Console.WriteLine(Note); // print the namespace and the datatype name

            //for(int i = 0; i < Note.Size; i++)
            //{
            //    Console.WriteLine(Note[i]);
            //}

            // the indexer is more easy to deal with and more complex to write 
            // so in the external code it more easy

            #endregion

            #region 4- Class
            // now we finished the strund and enum both value types 
            // now will take the class and after that we will start with the interface

            /** What i can type inside the class ?
             * 1- Attributes [Fields] Member Variables
             * 2- Functions [constructor functions, Getter Setter, Methods]
             * 3- Properties [Full Property, Automatic Property, Indexer]
             * 4- Events
             * 
             * inside access modifiers
             * 1- Private
             * 2- Protected Private
             * 3- Protected
             * 4- Internal 
             * 5- Internal Protected
             * 6- Public
             * 
             * with access modifiers
             * 1- Internal 
             * 2- public
             * 
             */

            /** Why to use the class ?
             * If i have a car ? so should i declare every car as an object ? 
             * i will init a user defind data type for the car and init it with the defult or the common attributes between all the cars
             * create object from the main class which will include another car 
             * so if you will not have any necessary to inherit anything 
             * don't use class and go use struct 
             * 
             */

            //Car C1;
            /**
             * Declare for a reference from type Car
             * This Can Refer for an object from tyep car
             * and an object which will inherit from the type car
             * allocate 4 bytes in the stack
             * zero bytes in the heap
             */

            //C1 = new Car();
            /**
             * The Combiler will generate the parameter less constructor by defult 
             * this parameterless constructor now does not do any thing 
             * and the new here deal with the object not just like the new in the struct
             * Allocate the requierd bytes in the heap for the object 16 bytes
             * Assign the Allocated bytes with the defult value of the data type
             * call the user defind constructor function [if exists] in this case i use the defult one which the object made
             * assign the refernece C1 with the allocated object at the heap
             * so the new in the struct only to choose which constructor will be called 
             * but here to 
             */
            //Console.WriteLine(C1);

            //Car C1 = new();
            //Car C2 = new(10,"BMW",290);
            //Car C3 = new(10, "BMW");
            Car C4 = new(10);

            //Console.WriteLine("C1 =====================");
            //Console.WriteLine(C1);
            //Console.WriteLine("C2 =====================");
            //Console.WriteLine(C2);
            //Console.WriteLine("C3 =====================");
            //Console.WriteLine(C3);
            //Console.WriteLine("C4 =====================");
            //Console.WriteLine(C4);

            // So i can make a constructor chaining with the other constructor 
            // first avoid the repetation inside the code
            // second i can implement the code inside every constructor
            // constructor chaning 
            // using the property to implement the concept of encapsulation and the indexer to make the 
            // property cotolr the set and the get from the attributes 
            // and using the indexer to deal with them but deal with the object as a array

            // car c1 ==> reference in the stack
            // c1 - new car so in this step i create the object an allocate it in the stack
            // id 10 speed 290 model reference for the string and the string will store in another place in the heap
            // heap and stack is a reagion in the memory and this has a behavior differenct from the other 

            #endregion

        }
    }
}
