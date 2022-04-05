
namespace App.Classes
{
    class Sugar : Product
    {
        public Sugar() : base("Sugar", 1.0f, 30, false)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}