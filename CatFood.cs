using System;

namespace PetStore
{
    public class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }

        public CatFood()
        {
            WeightPounds = 0;
            KittenFood = false;
        }
    }
}
