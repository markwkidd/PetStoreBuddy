using System;

namespace PetStore
{
    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material {  get; set; }
        
        public DogLeash()
        {
            LengthInches = 0;
            Material = String.Empty;
        }
    }
}
