using System;
using System.IO;

namespace App.Classes
{
    class Admin : Account
    {
        public string Path { get; private set; }

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

        /*public Manager[] GetManagersFromDataBase()
        {
            Manager[] managers = new Manager[0];
            if (File.Exists(Path))
            {
                while (File.)
            }
        }*/

    }
}
