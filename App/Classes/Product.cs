using System;

namespace App.Classes
{
    class Product
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public float Cost { get; set; }
        public bool IsFragile { get; set; }
        public Product() : this("Base", 1, 1, false)
        {
        }
        public Product(string name, float weight, float cost, bool isFragile)
        {
            Name = name;
            Weight = weight;
            Cost = cost;
            IsFragile = isFragile;
        }

        public override string ToString()
        {
            return String.Format("{0} Weight: {1} Cost: {2}", Name, Weight, Cost);
        }
    }
}
