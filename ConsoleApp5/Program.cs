using System;
using ConsoleApp5;
public class Program
{
    #region Q1

    //public static void Main()
    //{
    //    person[] people = new person[3];
    //    people[0] = new person("George", 21);
    //    people[1] = new person("Ronaldinho", 25);
    //    people[2] = new person("sky", 20);
    //    foreach (person person in people)
    //    {
    //        Console.WriteLine(person.name + " " + person.age);
    //    }
    //}
    #endregion

    #region Q2

    //public static void Main()
    //{
    //    Console.WriteLine("enter x1 in point 1");
    //    double x1 = Convert.ToDouble(Console.ReadLine());
    //    Console.WriteLine("enter y1 in point 1");
    //    double y1 = Convert.ToDouble(Console.ReadLine());
    //    Console.WriteLine("enter x2 in point 2");
    //    double x2 = Convert.ToDouble(Console.ReadLine());
    //    Console.WriteLine("enter y2 in point 2");
    //    double y2 = Convert.ToDouble(Console.ReadLine());

    //    Point point1 = new Point(x1, y1);
    //    Point point2 = new Point(x2, y2);
    //    double distance = Point.calculatemethod(point1, point2);
    //    Console.WriteLine(distance);

    //}
    #endregion

    #region Q3

    public static void Main()
    {
        person[] persons = new person[3];
        for (int i = 0; i < 3; i++)
        {   Console.Write("Name ");
            persons[i].name = Console.ReadLine();
            Console.Write("Age ");
            persons[i].age = int.Parse(Console.ReadLine()); 
        }
        person oldestPerson = persons[0]; 
        for (int i = 1; i < 3; i++) 
        { if (persons[i].age > oldestPerson.age)
            { oldestPerson = persons[i];
            }
        }
        Console.WriteLine($"The oldest person is {oldestPerson.name} with age {oldestPerson.age}.");
    }
    #endregion


}