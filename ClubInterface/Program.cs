using System;
namespace Employees
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        string Fullname();
        double Pay();
    }
    class Program
    {
        class Member : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Cost { get; set; }
            public int Type { get; set; }

            public Member()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Cost = 10;
                Type = 0;
            }
            public Member(int id, string firstName, string lastName, double cost, int type)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Cost = cost;
                Type = type;
            }

            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public double Pay()
            {
                if (Type > 1)
                    return 2 * Cost;
                else
                    return Cost;
            }
        }
        static void Main(string[] args)
        {
            // Worker object created using parameterized constructor
            Member fred = new Member(10, "Freddy", "Fazbear", 10, 2);
            Console.WriteLine(fred.Fullname());
            Console.WriteLine(fred.Pay() + "$ each month");

            //Worker object created using the default constructor
            Member Geoff = new Member();
            Geoff.Id = 20;
            Geoff.FirstName = "Geoff";
            Geoff.LastName = "Fog";
            Geoff.Cost = 10;
            Geoff.Type = 1;
            Console.WriteLine(Geoff.Fullname());
            Console.WriteLine(Geoff.Pay() + "$ each month");

        }
    }
}