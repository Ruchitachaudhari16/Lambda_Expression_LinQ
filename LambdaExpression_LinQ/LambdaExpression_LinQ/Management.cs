﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_LinQ
{
public class Management
    {
        public void TopThreeRecord(List<ProductReview> products)
        {
            var result = products.OrderByDescending(x => x.Rating).Take(3);
            foreach (var item in result)
            {

                Console.WriteLine(item.ProductID + " " + item.UserID + " " + item.Rating + " " + item.Review + " " + item.Islike);
            }
            var record = (from product in products orderby product.Review descending select product).Take(3);
            //firstly sort data in descending order and then print top 3 records.
            foreach (var item in record)
            {

                Console.WriteLine(item.ProductID + " " + item.UserID + " " + item.Rating + " " + item.Review + " " + item.Islike);
            }
        }
    }
}
    
