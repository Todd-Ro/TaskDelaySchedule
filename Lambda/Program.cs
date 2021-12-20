using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> FirstTen = LINQ.GetFirstTen();
            LINQ.printInts(FirstTen);

            IEnumerable<int> FirstTenSquares = LINQ.squareEnum(FirstTen);
            LINQ.printInts(FirstTenSquares);
            // LINQ.printInts(FirstTen); //Original enumerable unchanged

            List<int> scores = LINQ.GetScores();
            IEnumerable<int> goodScores = LINQ.queryScores(scores);
            LINQ.printInts(goodScores);

            Person John = new Person()
            {
                Forename = "John",
                Surname = "Smith",
                DateOfBirth = new DateTime(1980, 6, 14)
            };

            Person Bob = new Person()
            {
                Forename = "Bob",
                Surname = "Williams",
                DateOfBirth = new DateTime(1974, 2, 21)
            };

            Person Chris = new Person()
            {
                Forename = "Chris",
                Surname = "Jones",
                DateOfBirth = new DateTime(1990, 10, 4)
            };

            List<Person> people = new List<Person>()
            {
                John, Bob, Chris
            };

            IEnumerable<string> surnames = people.Select(x => x.Surname);
            foreach(string name in surnames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            IEnumerable<int> squaresToFortyNine = LINQ.squareEnum(LINQ.GetFirstSeven());
            LINQ.printInts(squaresToFortyNine);




            List<Student> studList = new List<Student>()
            {
                new Student{rollNo = 1, name="Liza"},
                new Student{rollNo= 2, name="Tina"},
                new Student{rollNo = 3, name="Stewart"},
                new Student {rollNo = 4, name="Stefani"},
                new Student{rollNo = 5, name = "Trish"}
            };

            IEnumerable<Student> sortedStuds = studList.OrderBy(x => x.name);
            foreach(Student s in studList)
            {
                Console.WriteLine(s.rollNo.ToString() +" " + s.name); //Original Order Unchanged
            }
            Console.WriteLine();
            foreach(Student stu in sortedStuds)
            {
                Console.WriteLine(stu.rollNo.ToString() + " " + stu.name);
            }
        }
    }
}
