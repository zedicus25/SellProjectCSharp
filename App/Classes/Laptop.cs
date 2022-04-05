
using System;

namespace App.Classes
{
    class Laptop : Product
    {
        public string Model { get; set; }
        public int Ram { get; set; }
        public string Cpu { get; set; }
        public Laptop() : this("BaseLaptop",2.5f,15000,true,"BaseModel",8, "Ryzen 5 1500X")
        {
        }

        public Laptop(string name, float weight, float cost, bool isFragile, string model, int ram, string cpu) : base(name,weight,cost,isFragile)
        {
            Model = model; 
            Ram = ram;
            Cpu = cpu;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} RAM: {2} CPU: {3} Weight: {4} Cost: {5}", Name,Model,Ram,Cpu, Weight, Cost);
        }
    }
}
