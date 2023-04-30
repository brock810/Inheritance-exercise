using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal()
        { 
        }
        public string Lives { get; set; }
        public bool NeedsSleep { get; set; }
        public bool NeedsFood { get; set; }

        public int NumberOfEyes { get; set; }
    }
}
