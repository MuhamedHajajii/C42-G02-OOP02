namespace C42_G02_OOP02
{
    internal class Program
    {

        static void Main()
        {
            #region Part 01

            /*
             1.	Try all what we have learned in the lecture.
             */

            /* Applied All of them 
             * indexer and phonebook in the demo 
             */

            #endregion

            #region Part 02

            #region Q1
            /*
             1- Define a struct "Person" with properties "Name" and "Age". Create an array of three 
            "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
             */

            //Person[] person = new Person[3];

            //person[0] = new Person("Haji", 25);
            //person[1] = new Person("Aliaa", 30);
            //person[2] = new Person("Marwan", 24);


            //for (int i = 0; i < person.Length; i++)
            //    Console.WriteLine(person[i].ToString());

            #endregion

            #region Q2

            /*
            2- Create a struct called "Person" with properties "Name" and "Age". 
            Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
             */

            //Console.WriteLine("Please Write The Count Of People you Will Add: ");
            //int ArraySize = GetValidNumber();

            //Person02[] P = new Person02[ArraySize];

            //for (int i = 0; i < ArraySize; i++)
            //{
            //    Console.Write($"Please Enter The Person Number {i + 1} Is Name:  ");
            //    string PersonName = Console.ReadLine()!;
            //    Console.Write($"Please Enter The Person Number { i + 1 } Is Age: ");
            //    int Age = GetValidNumber();

            //    P[i] = new Person02(PersonName, Age);
            //}

            //foreach (var Person in P)
            //{
            //    Console.WriteLine(Person.ToString());
            //}

            #endregion

            #endregion

            #region Part 03

            int EmployeeArrSize = 5;

            Employee[] EmpArr = new Employee[EmployeeArrSize];

            EmpArr[0] = new Employee(1, "Muhamed Hajajii", SecurityLevel.DBA, 10000, new HiringDate(22, 8, 1999), Gender.M);
            EmpArr[1] = new Employee(2, "Marwan AbuBakr", SecurityLevel.Guest, 12000, new HiringDate(1, 9, 2001), Gender.M);
            EmpArr[2] = new Employee(2, "Marwan AbuBakr", SecurityLevel.Guest, 12000, new HiringDate(1, 9, 2000), Gender.M);
            EmpArr[3] = new Employee(3, "Aliaa Tarek", (SecurityLevel)15, 20000, new HiringDate(1, 10, 1995), Gender.F);
            EmpArr[4] = new Employee(4, "Aliaa Tarek 02", (SecurityLevel)15, 20000, new HiringDate(1, 5, 1995), Gender.F);

            ;

            foreach (var item in Employee.SortEmployees(EmpArr))
            {
                Console.WriteLine("===================================");
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("===================================");

            #endregion

        }

        /* Handle Get Valid Number Fo All Assignment */
        public static int GetValidNumber()
        {
            bool IsNumber;
            bool IsValid;
            do
            {
                IsNumber = int.TryParse(Console.ReadLine(), out int Num);
                IsValid = Num >= 0;
                if (IsNumber && IsValid)
                {
                    return Num;
                }
            } while (!IsNumber || !IsValid);
            return 0;
        }


    }
}
