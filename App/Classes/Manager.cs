using System;
using System.IO;
using System.Text;

namespace App.Classes
{
    class Manager : Account
    {
        public float Salary { get; set; }
        public string Path { get; set; }

        public Manager() :this("","","","", new DateTime(1990, 1, 1),1500.0f)
        {
        }

        public Manager(string name, string lastName, string login, string password, DateTime birthday, float salary) : base(name, lastName, login, password, birthday)
        {
            Salary = salary;
            SetPath();
        }

        public void AddClient(Client client)
        {
            if (File.Exists("Client_Base.txt"))
            {
                try
                {
                    string dataBaseStr = File.ReadAllText("Client_Base.txt");
                    string[] dataBase = dataBaseStr.Split('\n');
                    for (int i = 0; i < dataBase.Length; i++)
                    {
                        if (String.Compare(dataBase[i], client.ToString()) == 0)
                            return;
                    }
                    File.AppendAllText("Client_Base.txt", client.ToString() + "\n");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                try
                {
                    File.WriteAllText("Client_Base.txt", client.ToString() + "\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }     
        }

        public void SellProduct(Client client, Product product)
        {
            AddClient(client);

            DateTime now = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            sb.Append("Sold: ");
            sb.Append(client.ShortToString() + " ");
            sb.Append("Product: ");
            sb.Append(product.ToString() + " ");
            sb.Append("At: ");
            sb.Append(now.ToString());

            if (File.Exists(Path))
            {
                try
                {
                    File.AppendAllText(Path, sb.ToString() + "\n");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                try
                {
                    File.WriteAllText(Path, sb.ToString() + "\n");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string GetSellsHistory()
        {
            string history = "";
            if (File.Exists(Path))
            {
                try
                {
                    history = File.ReadAllText(Path);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            return history;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} Login: {2} Password: {3} Birthday: {4} Salary: {5}", LastName, Name, Login, Password, Birthday.ToShortDateString(), Salary);
        }

        private void SetPath()
        {
            Path = "Manager_";
            Path += Login += ".txt";
        }
    }
}
