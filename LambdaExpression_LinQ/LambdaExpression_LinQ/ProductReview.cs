using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_LinQ
{
    //Lambda expression is used to create anonymous function ,expression and body member.
    //Its a short block of code that accepts parameter and return a value 
    //Use=> - is a lambda operator which is used for all the lambda expressions
    public class ProductReview
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public int Rating { get;set; }
        public string Review { get; set; }
        public bool Islike { get;set; }

    }

    
}
