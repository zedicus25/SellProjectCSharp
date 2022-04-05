using App.Classes;
using System;


namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("Alexander", "Tsyganok", "Zedicus", "123456", new DateTime(2003, 8, 30));

            //admin.AddManager(new Manager("Ivan", "Ivanov", "fsafds", "qwerty", new DateTime(1999, 5, 12), 1400.0f));
            //admin.AddManager(new Manager("Petr", "Petrov", "PP99", "qwerty1", new DateTime(1982, 7, 12), 2500.0f));
            //admin.AddManager(new Manager("Sidr", "Sidorov", "Sidr99", "qwerty2", new DateTime(1974, 5, 22), 2411.0f));

            Manager[] managers = admin.GetManagersFromDataBase();

            /*admin.ChangeManagerData(managers[0]);

            for (int i = 0; i < managers.Length; i++)
            {
                Console.WriteLine(managers[i]);
            }*/

            /*Client client1 = new Client("Vasyli","Bobko","vs_Bob25","hardPass", new DateTime(1984,11,8),"+380508551463");
            client1.BuyProduct(new Bayraktar("Bayraktar",50,1530000,true,24,4), managers[0]);

            Client client2 = new Client("Bob", "Brush", "brush884", "veryhardPass", new DateTime(1972, 5, 27), "+380983691720");
            client2.BuyProduct(new Sugar(), managers[0]);
            client2.BuyProduct(new Laptop("Lenovo",2.5f,14500,true,"Tab10",16,"Ryzen 3"), managers[1]);

            Client client3 = new Client("Tomas", "Forman", "foram95", "newPass", new DateTime(1995, 11, 14), "+380987851074");
            client3.BuyProduct(new Bed("Love",43,5700,false,145,200,200), managers[2]);*/

            for (int i = 0; i < managers.Length; i++)
            {
                Console.WriteLine(managers[i].GetSellsHistory());
            }

        }
    }
}
