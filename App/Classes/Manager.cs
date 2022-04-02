using System;
namespace App.Classes
{
    class Manager : Account
    {
        public float Salary { get; private set; }

        public Manager() : base()
        {
            Salary = 1500.0f;
        }

        public Manager(string name, string lastName, string login, string password, DateTime birthday, float salary) : base(name, lastName, login, password, birthday)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} Login: {2} Birthday {3}", LastName, Name, Login, Birthday.ToShortDateString());
        }
    }
}
