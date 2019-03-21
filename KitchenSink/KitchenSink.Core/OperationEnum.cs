using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenSink.Core
{
    //Type-safe enum pattern ( aka old java enum )
    //public enum OperationEnum
    public class OperationEnum :IEnum<Operation>
    {
        //Add = new Operation( ),
        public static readonly OperationEnum Add        = new OperationEnum( new Operation( (a, b) => { return a + b; } ) );
        public static readonly OperationEnum Substract  = new OperationEnum( new Operation( (a, b) => { return a - b; } ) );
        public static readonly OperationEnum Multiply   = new OperationEnum( new Operation( (a, b) => { return a * b; } ) );
        public static readonly OperationEnum Divide     = new OperationEnum( new Operation( (a, b) => { return a / b; } ) );

        private Operation operation;
        //https://stackoverflow.com/questions/7747948/why-can-a-enum-have-a-package-private-constructor
        //static OperationEnum
        //{
        //    //Add = new Operation((a, b) => { return a + b; } );
        //}
        //https://stackoverflow.com/questions/7747948/why-can-a-enum-have-a-package-private-constructor
        private OperationEnum( Operation operation )
        {
            //Add = new Operation((a, b) => { return a + b; } );
            this.operation = operation;
        }
        public Operation getValue()
        {
            return operation;
        }
    }
    //Todo:check if there could be a problem with serialization like in java
}
