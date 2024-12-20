namespace OOP_Assignment1
{
    enum WeekDays
    {
        Mon, Tue, Wed, Thu, Fri, Sat, Sun
    }
    enum Seasons
    {
        Spring = 1, spring = 1, Summer = 2, summer = 2, Autumn = 3, autumn = 3, Winter = 4, winter = 4
    }
    enum Permissions
    {
        Read, Write, Delete, Execute
    }
    enum Colors
    {
        Red, Green, Blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex 1
            //WeekDays days = WeekDays.Mon;
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(days);
            //    days++;
            //}
            #endregion
            #region Ex 2
            //Person[] persons = new Person[3];
            //persons[0] = new Person("Ahmed", 25);
            //persons[1] = new Person("Amr", 23);
            //persons[2] = new Person("Mahmoud", 30);
            //foreach (Person person in persons)
            //{
            //    Console.WriteLine($"Person Name: {person.Name}, Person Age: {person.Age}");
            //}
            #endregion
            #region Ex 3
            //Seasons seasons;
            //string Input = Console.ReadLine();
            //bool Flag = Enum.TryParse(Input, out seasons);
            //if (Flag)
            //{
            //    switch (seasons)
            //    {
            //        case Seasons.Spring:
            //            Console.WriteLine("March - April - May");
            //            break;
            //            case Seasons.Summer:
            //            Console.WriteLine("June - July - August");
            //            break;
            //            case Seasons.Autumn:
            //            Console.WriteLine("September - October - November");
            //            break;
            //            case Seasons.Winter:
            //            Console.WriteLine("December - January - Febrauary");
            //                break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Enter A valid Season");
            //}
            #endregion
            #region Ex 4
            //Permissions permissions = Permissions.Read;
            #endregion
            #region Ex 5
            //string Input = Console.ReadLine();
            //Colors colors;
            //bool Flag = Enum.TryParse(Input,true, out colors);
            //if (Flag)
            //{
            //    Console.WriteLine($"{colors} is primary color");
            //}
            //else
            //{
            //    Console.WriteLine($"{Input} isnt a primary color");
            //}
            #endregion
            #region Ex 6
            //Console.WriteLine("Enter first point x:");
            //double Ax = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter first point y");
            //double Ay = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second point X");
            //double Bx = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second point Y");
            //double By = double.Parse(Console.ReadLine());
            //Point2 A = new Point2(Ax, Ay);
            //Point2 B = new Point2(Bx, By);
            //double Distance = Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
            //Console.WriteLine("The Distance between the points is: " + Distance);
            #endregion
            #region Ex 7
            //Person[] persons = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter person {i+1} Name");
            //    string Name = Console.ReadLine();
            //    Console.WriteLine($"Enter person {i+1} Age");
            //    int Age = int.Parse(Console.ReadLine());
            //    persons[i] = new Person(Name, Age);
            //}
            //Person Oldest = persons[0];
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    if (persons[i].Age > Oldest.Age)
            //    {
            //        Oldest = persons[i];
            //    }
            //}
            //Console.WriteLine($"The oldest person is {Oldest.Name} with age {Oldest.Age}");
            #endregion
        }
    }
}
