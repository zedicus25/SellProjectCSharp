using App.Classes;
using System;


namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("Alexander", "Tsyganok", "Zedicus", "123456", new DateTime(2003, 8, 30));
           // admin.AddManager(new Manager("Ivan", "Ivanov", "fsafds", "qwerty", new DateTime(1999, 5, 12), 1400.0f));
           // admin.AddManager(new Manager("Ivan1", "Ivanov1", "fsafds1", "qwerty1", new DateTime(1999, 1, 1), 14001.0f));
            //admin.AddManager(new Manager("Ivan2", "Ivanov2", "fsafds2", "qwerty2", new DateTime(1999, 2, 2), 14002.0f));
            Manager[] managers = admin.GetManagersFromDataBase();
            admin.ChangeManagerData(managers[0]);
            for (int i = 0; i < managers.Length; i++)
            {
                Console.WriteLine(managers[i]);
            }
        }
    }
}
