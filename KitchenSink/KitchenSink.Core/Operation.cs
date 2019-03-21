using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenSink.Core
{
    //Change it to template ?
    public class Operation : IFunc //: Func<decimal,decimal,decimal> // Cannot derive from sealed function
    {
        // Sugested convention for sealed classes.
        //public Func<decimal, decimal, decimal> parentClass { get; set; }
        public Func<decimal, decimal, decimal> func { get; set; }
        public Operation(Func<decimal, decimal, decimal> func)
        {
            this.func = func;
        }
    }
}
