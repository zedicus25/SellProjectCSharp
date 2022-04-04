using System;
using System.IO;
using System.Text;

namespace App.Classes
{
    class Manager : Account
    {
        public float Salary { get; set; }
        public string Path { get; set; }

        public Manager() : base()
        {
            SetPath();
            Salary = 1500.0f;
        }

        public Manager(string name, string lastName, string login, string password, DateTime birthday, float salary) : base(name, lastName, login, password, birthday)
        {
            SetPath();
            Salary = salary;
        }

        public void AddClient(Client client)
        {
            if (File.Exists("Client_Base.txt"))
                File.AppendAllText("Client_Base.txt", client.ToString() + "\n");
            else
                File.WriteAllText("Client_Base.txt", client.ToString() + "\n");
        }

        public void SellProduct(Client client, Product product)
        {
            //if client has in base, just sell else add client to base and sell 
            StringBuilder sb = new StringBuilder();
            sb.Append("Sold: ");
            sb.Append(client.ShortToString() + " ");
            sb.Append("Product: ");
            sb.Append(product.ToString());

            if (File.Exists(Path)) 
                File.AppendAllText(Path, sb.ToString() + "\n");
            else
                File.WriteAllText(Path, sb.ToString() + "\n");
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
