using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenSink.Core
{

    public class Calculator
    {
        //public static Dictionary<string, Func<decimal, decimal, decimal>> operatorList = new Dictionary<string, Func<decimal, decimal, decimal>>()
        //{
        //    { "Add"         , (a,b) => { return a + b; } },
        //    { "Substract"   , (a,b) => { return a - b; } },
        //    { "Multiply"    , (a,b) => { return a * b; } },
        //    { "Divide"      , (a,b) => { return a / b; } },
        //};
        //public static decimal calculate( decimal a, decimal b, Func<decimal,decimal,decimal> @operator)
        public static decimal calculate(decimal a, decimal b, OperationEnum @operator)
        {
            decimal result = 0;
            //result = @operator(a,b);
            result = @operator.getValue().func(a, b);
            return result;
        }

    }

}
