using System.Security.Cryptography.X509Certificates;
using static Assignment02.Employee;

namespace Assignment02
{
    internal class Program
    {
        public enum SecurityLevel
        {
            Guest, Developer, Secretary, DBA
        }

        [Flags]
        public enum Gender
        {
            M , F
        }

        static void Main(string[] args)
        {
            #region Part01

            #region Question01
            //Console.WriteLine("Enter two points: ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Convert.ToDouble(Console.ReadLine());
            //Point p1 = new Point(x, y);
            //Console.WriteLine("Enter two points: ");
            //x = Convert.ToDouble(Console.ReadLine());
            //y = Convert.ToDouble(Console.ReadLine());
            //Point p2 = new Point(x, y);
            //Console.WriteLine($"Distance between two points is: {Point.Distance(p1, p2)}");
            #endregion

            #region Question02
            //Console.WriteLine("Enter the details of first person: ");
            //string name01 = Console.ReadLine();
            //int age01 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the details of second person: ");
            //string name02 = Console.ReadLine();
            //int age02 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the details of third person: ");
            //string name03 = Console.ReadLine();
            //int age03 = Convert.ToInt32(Console.ReadLine());

            //Person p1 = new Person(name01, age01);
            //Person p2 = new Person(name02, age02);
            //Person p3 = new Person(name03, age03);

            //if(age01 > age02 && age01 > age03)
            //{
            //    Console.WriteLine($"The oldest person is: {p1.Name} {p1.Age}");
            //}
            //else if (age02 > age01 && age02 > age03)
            //{
            //    Console.WriteLine($"The oldest person is: {p2.Name} {p2.Age}");
            //}
            //else
            //{
            //    Console.WriteLine($"The oldest person is: {p3.Name} {p3.Age}");
            //}
            #endregion

            #endregion

            #region Part02

            #region Question01
            Employee emp = new Employee(1, "Ahmed", "Developer", 50000, new DateTime(2024, 12, 30));
            Console.WriteLine(emp.ToString());
            #endregion

            #region Question02
            HiringDate hiringDate = new HiringDate(30, 12, 2024);
            Console.WriteLine(hiringDate.ToString());
            #endregion

            #region Question03

            #endregion

            #region Question04

            #endregion

            #endregion
        }
    }
}
