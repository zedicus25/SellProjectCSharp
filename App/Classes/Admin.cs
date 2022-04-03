using System;
using System.IO;

namespace App.Classes
{
    class Admin : Account
    {
        public string Path { get; set; }

        public Admin(string name, string lastName, string login, string password, DateTime birthday) : base(name, lastName, login, password, birthday)
        {
            Path = login += ".txt";
        }

        public override string ToString()
        {
            return String.Format("{0} Path {1}", base.ToString(), Path);
        }

        public void AddManager(Manager manager)
        {
            if (File.Exists(Path))
                File.AppendAllText(Path, manager.ToString() + "\n");
            else
                File.WriteAllText(Path, manager.ToString() + "\n");
        }

        public Manager[] GetManagersFromDataBase()
        {
            Manager[] managers = new Manager[0];
            if (File.Exists(Path))
            {
                string allStr = File.ReadAllText(Path);
                string[] allLines = allStr.Split("\n");

                managers = new Manager[allLines.Length - 1];

                for (int i = 0; i < allLines.Length-1; i++)
                {
                    string[] str = allLines[i].Split(' ');
                    for (int j = 0; j < str.Length; j++)
                    {
                        str[j] = str[j].Replace("Password:", "");
                        str[j] = str[j].Replace("Login:", "");
                        str[j] = str[j].Replace("Birthday:", "");
                        str[j] = str[j].Replace("Salary:", "");
                    }
                    string[] birthday = str[7].Split('.');

                    managers[i] = new Manager(str[1], str[0], str[3], str[5], 
                        new DateTime(int.Parse(birthday[2]), int.Parse(birthday[1]), int.Parse(birthday[0])),
                        float.Parse(str[9]));
                }
            }
            return managers;
        }

        public void ChangeManagerData(Manager manager)
        {
            Console.WriteLine("Enter new login (Press Enter if you dont want change login)");
            string login = Console.ReadLine();
            Console.WriteLine("Enter new password (Press Enter if you dont want change password)");
            string password = Console.ReadLine();
            manager.Login = login != "" ? login : manager.Login;
            manager.Password = password != "" ? password : manager.Password;
        }

    }
}
