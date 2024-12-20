using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session01_Demo
{
    internal class Employee
    {
        #region Attributes
        public int Id;
        public string Name;
        public decimal salary;
        #endregion
        #region Constructor
        public Employee(int _Id, string _Name, decimal _Salary)
        {
            Id = _Id;
            Name = _Name;
            salary = _Salary;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary}";
        }
        #endregion
        #region Encapsulation
        // Seperate data definiton [Attributes] from its use (getter/setter - property - indexer)

        //Getter
        public string GetName()
        {
            return Name;
        }
        //Setter
        public void SetName(string Value)
        {
            Name = Value.Length <= 5 ? Value : Value.Substring(0,5);
            //Data validation
        }
        // Applying property (Full Property - Automatic Property)
        //Full Property
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value >= 4000 ? value : 4000;
            }
        }
        //public int age;
        //Automatic Property
        public int Age { get; set; }
        // full property used if you want to validate
        // In Automatic Property we dont write the attribute 
        //propfull => build full property
        //prop => build automatic property

        
        #endregion
    }
}
