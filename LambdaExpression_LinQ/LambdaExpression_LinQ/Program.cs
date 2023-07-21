using System;
using System.Collections.Generic;

namespace LambdaExpression_LinQ
{
    public class Program
    {
        static void Main(string[] args)
        {

            Management management = new Management();
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ ProductID=1,UserID=11, Rating=5, Review="Very Good",Islike=true },
                new ProductReview(){ ProductID=2,UserID=12, Rating=4, Review="Good",Islike=true },
                new ProductReview(){ ProductID=3,UserID=13, Rating=4, Review="Good",Islike=true },
                new ProductReview(){ ProductID=4,UserID=14, Rating=5, Review="Very Good",Islike=true },
                new ProductReview(){ ProductID=5,UserID=15, Rating=2, Review="Poor",Islike=false },
                new ProductReview(){ ProductID=6,UserID=16, Rating=3, Review="Average",Islike=false },
                new ProductReview(){ ProductID=7,UserID=17, Rating=4, Review="Good",Islike=true },
                new ProductReview(){ProductID=8,UserID=18, Rating =5, Review = "Very Good", Islike = true},
                new ProductReview(){ProductID=9,UserID=19, Rating = 5, Review = "Very Good", Islike = true},
                new ProductReview(){ProductID=10,UserID=20,Rating = 4, Review = "Good", Islike = true},
                new ProductReview(){ProductID=11,UserID=21, Rating = 3, Review = "Average", Islike = false},
                new ProductReview(){ProductID=12,UserID=22, Rating = 2, Review = "Poor", Islike = false},
                new ProductReview(){ProductID=13,UserID=23, Rating = 1, Review = " Bad", Islike = false},
                new ProductReview(){ProductID=14,UserID=24, Rating = 1, Review = " Bad", Islike = false},
                new ProductReview(){ProductID=15,UserID=25, Rating = 2, Review = "Poor", Islike = false},
                new ProductReview(){ProductID=16,UserID=26, Rating = 3, Review = "Average", Islike = false},
                new ProductReview(){ProductID=17,UserID=27, Rating = 3, Review = "Average", Islike = false},
                new ProductReview(){ ProductID=15,UserID=28,Rating=2, Review="Poor",Islike=false },
                new ProductReview(){ ProductID=5,UserID=29, Rating=5, Review="Very Good",Islike=true },
                new ProductReview(){ ProductID=18,UserID=30, Rating=4, Review="Good",Islike=true },
                new ProductReview(){ ProductID=19,UserID=31, Rating=4, Review="Good",Islike=true },
                new ProductReview(){ ProductID=20,UserID=32, Rating=5, Review="Very Good",Islike=true },
                new ProductReview(){ ProductID=10,UserID=33, Rating=5, Review="Very Good",Islike=true },
                new ProductReview(){ ProductID=25,UserID=34, Rating=5, Review="Very Good",Islike=true },
                new ProductReview(){ ProductID=5,UserID=35, Rating=4, Review="Good",Islike=true },

            };
            while (true)
            {

                Console.WriteLine("1-Top three ratings");
                Console.WriteLine("Choose any option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        management.TopThreeRecord(list);
                        break;
                }
            }


        }
    }
}

