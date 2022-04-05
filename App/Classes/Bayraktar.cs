
using System;

namespace App.Classes
{
    class Bayraktar : Product
    {
        public float MaxTimeInAir { get; set; }
        public int MaxCapacity { get; set; }
        public Bayraktar() : this("Bayraktar", 55f, 1350000, true,24,3)
        {
        }
        public Bayraktar(string name, float weight, float cost, bool isFragile, float maxTimeInAir, int maxCapacity) : base(name,weight,cost,isFragile)
        {
            MaxTimeInAir = maxTimeInAir;
            MaxCapacity = maxCapacity;
        }
        public override string ToString()
        {
            return String.Format("{0} Max time in air: {1} Max capacity: {2}", base.ToString(), MaxTimeInAir, MaxCapacity);
        }
    }
}
