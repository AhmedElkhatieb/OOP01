using System.Security.AccessControl;
using Common;

namespace OOP_Session01_Demo
{
    enum Grades
    {
        A, B, C, D, F
    }
    enum Gender
    {
        Male = 1, m = 1, Female = 2, f = 2
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region What is access modifiers
            //TypeA obj = new Common.TypeA();
            ////obj.X = 10; // invalid
            ////obj.Y = 20; // invalid
            //obj.Z = 30; // valid
            #endregion
            #region Enum
            //Grades grade = Grades.A;
            //if (grade == Grades.A)
            //{
            //    Console.WriteLine("Congratulations A+");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry :(");
            //}
            #endregion
            #region Struct
            //Point P1 = new Point(4,2); // Declare object from type Point
            //// (new is used to choose constructor)
            //// CLR will allocate 8 bytes uninitialised at stack
            //Console.WriteLine(P1.X);
            //Console.WriteLine(P1);
            #endregion
            #region Encapsulation
            Employee Emp = new Employee(10, "Rana", 20000);
            Emp.Salary = 30000;
            Console.WriteLine(Emp.Salary);
            //Emp.SetName("Abdelrahman");
            //Console.WriteLine(Emp.GetName()); 

            //Emp.Id = 20;           
            //Console.WriteLine(Emp);
            #endregion
        }
    }
}
