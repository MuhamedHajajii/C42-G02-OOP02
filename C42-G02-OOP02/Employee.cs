using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP02
{
    internal class Employee
    {

        #region PROPERTIES

        public int ID { get; set; }
        public string? EmpName { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public double Salary { get; set; }
        public HiringDate HireDate { get; set; }

        public Gender Gender { get; set; }

        #endregion

        #region CONSTRUCTORS

        public Employee()
        {
            
        }

        public Employee(int iD, string empName, SecurityLevel securityLevel, double salary, HiringDate hireDate, Gender gender)
        {
            ID = iD;
            EmpName = empName;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        #endregion

        #region METHODS

        public override string ToString()
        {
            
            return string.Format("Employee ID: {0}\nEmployee Name: {1}\nEmployee Security Level: {2}\nEmployee Salary: {3 :c}\nEmployee HireDate: {4}\nEmployee Gender: {5}",
                this.ID,
                this.EmpName!,
                this.SecurityLevel!, 
                this.Salary!, 
                this.HireDate!,
                this.Gender!);
        }
        
        public static Employee[] SortEmployees(Employee[] employees)
        {
            Employee Swap;
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = 0; j < employees.Length - 1; j++)
                {
                    bool Flag = HiringDate.CompareTwoHiringDates(employees[j].HireDate, employees[j + 1].HireDate);
                    if (Flag)
                    {
                        Swap = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = Swap;
                    }
                }
            }
            
            return employees;
        }

        #endregion

    }
}
