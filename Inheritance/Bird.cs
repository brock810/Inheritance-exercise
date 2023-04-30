using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
        }
        public bool Flies { get; set; }
        public string FeatherColor { get; set; }
        public bool NoseBeak { get; set; }
        public int NumberOfLegs { get; set; }
    

    }
}
