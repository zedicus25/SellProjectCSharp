using System;

namespace App.Classes
{
    class Client : Account
    {
        public string PhoneNumber { get; set; }

        public Client() : base()
        {
            PhoneNumber = "";
        }

        public Client(string name, string lastName, string login, string password, DateTime birthday, string number) : base(name, lastName, login, password, birthday)
        {
            PhoneNumber = number;
        }

        public void BuyProduct(Product product, Manager manager)
        {
            manager.SellProduct(this, product);
        }

        public override string ToString()
        {
            return String.Format("{0} {1} Login: {2} Password: {3} Birthday: {4} Phone: {5}", LastName, Name, Login, Password, Birthday.ToShortDateString(), PhoneNumber);
        }

        public string ShortToString()
        {
            return String.Format("{0} {1} Login: {2} Birthday: {3} Phone: {4}", LastName, Name, Login, Birthday.ToShortDateString(), PhoneNumber);
        }
    }
}
