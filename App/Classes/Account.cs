using System;

namespace App.Classes
{
    class Account
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public DateTime Birthday { get; private set; }

        public Account() : this("Default", "Default", "Default", "Default", new DateTime(1990, 1, 1))
        {
        }

        public Account(string name, string lastName, string login, string password, DateTime birthday)
        {
            Name = name;
            LastName = lastName;
            Login = login;
            Password = password;
            Birthday = new DateTime(birthday.Ticks);
        }

        public int GetAge()
        {
            DateTime now = DateTime.Now;
            DateTime age = new DateTime(now.Subtract(Birthday).Ticks);
            return age.Year;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} Login: {2} Age: {3}", LastName, Name, Login, GetAge());
        }
    }
}

