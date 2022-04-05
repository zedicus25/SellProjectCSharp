
using System;

namespace App.Classes
{
    class Bed : Product
    {
        public float MaxLoad { get; set; }
        public float Width { get; set; }
        public float Lenght { get; set; }
        public Bed() : this("BaseBed", 43, 11500, false, 130, 90, 190)
        {
        }

        public Bed(string name, float weight,float cost, bool isFragile, float maxLoad, float width, float lenght) : base(name,weight,cost,isFragile)
        {
            MaxLoad = maxLoad;
            Width = width;
            Lenght = lenght;
        }

        public override string ToString()
        {
            return String.Format("{0} Max load: {1} Width: {2} Lenght{3}", base.ToString(),MaxLoad,Width,Lenght); 
        }
    }
}
