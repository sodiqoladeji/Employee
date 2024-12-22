using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class Employee
    {
        public int EmployeeId;
        private string EmployeeCat;
        public int PayRate;
        public double BasicPay;
        public double Deductions;
        public int Wage;
        public int NumberOfHours;
        public int NumberOfContracts;
        public Employee(int employeeId, string employeeCat, double basicPay, double deductions)
        { 
            EmployeeId = employeeId;
            EmployeeCat = employeeCat;
            BasicPay = basicPay;
            Deductions = deductions;
        }
        public Employee(int employeeId, string employeeCat, int wage,int numberofhours, double deductions) 
        {
            this.EmployeeId = employeeId;
            this.EmployeeCat = employeeCat;
            this.Wage = wage;
            this.NumberOfHours = numberofhours;
            this.Deductions = deductions;
        }
        public Employee(int employeeId, string employeeCat, double basicPay, int numberofcontracts, double deductions)
        {
            EmployeeId = employeeId;
            EmployeeCat = employeeCat;
            BasicPay = basicPay;
            NumberOfContracts = numberofcontracts;
            Deductions = deductions;
        }
        public string EmployeeCategory
        {
            get { return EmployeeCat; }
            set
            {
                if(value == "FullTimeEmployee" ||  value == "PartTimeEmployee" || value == "Contractor")
                    EmployeeCat = value;
            }

        }
        public double Pay() 
        {
            if (EmployeeCat == "FullTimeEmployee") 
            {
              Console.WriteLine((BasicPay * 1) - Deductions);
                
            }
            
            else if (EmployeeCat == "PartTimeEmployee")
            { 
                Console.WriteLine((Wage * NumberOfHours) - Deductions);
            }

            else
            {
                Console.WriteLine((BasicPay * NumberOfContracts) - Deductions);
            }

            return Pay();
        }
    }
}
