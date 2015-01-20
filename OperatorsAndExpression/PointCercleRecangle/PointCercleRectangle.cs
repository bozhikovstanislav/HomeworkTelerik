using System;


namespace PointCercleRecangle
{
    class PointCercleRectangle
    {


        public struct Point
        {
            public int x,y;
            public Point(int x1,int y1)
            {
                this.x=x1;
                this.y=y1;
            }
        }
        static void Main()
        {

            /*Problem 10 Point Inside a Circle & Outside of a Rectangle
             * 
                            Write an expression that checks for given point (x, y) if 
                            it is within the circle K({1, 1}, 1.5) and out of 
                            the rectangle R(top=1, left=-1, width=6, height=2).
             * 
            */


            





            //Console.WriteLine("Welcom to the program that checks if a given point is in the circle and out of \n recanle");

            //Console.WriteLine("*************************************************************************");
            //Drowing a circle and a recangle in one center point.

            Point p = new Point(4, 2);
            //for (int  i = 0; i < 6 ; i++)
            //{
            //    Console.Write("*");
            //}
            
            for (int i = 0; i < 6; i++)
			{ 
                for (int k = 0; k < 3; k++)
                {
                  
                    Console.CursorTop = k;
                }
                Console.CursorLeft = i;
                Console.Write("*");
			}
            

            //Console.WriteLine("Enter the point coordinat");

            //Console.WriteLine("Enter a value for X1 ");
            //string x1Entered = Console.ReadLine();
            //Console.WriteLine("Enter a value for Y1 ");
            //string y1Entered = Console.ReadLine();

            ////Entering the radius of the circle
            //Console.WriteLine("Enter a radius of the circle");
            //string radius = Console.ReadLine();
            ////Validation of the the input data
            //double x1;
            //double y1;
            //double r;
            //bool isNumberX1 = double.TryParse(x1Entered, out x1);
            //bool isNumberY1 = double.TryParse(y1Entered, out y1);
            //bool isRadius = double.TryParse(radius, out r);
            //if (isNumberX1 && isNumberY1 && isRadius)
            //{
            //    //enterCordinat.x = x1;
            //    //enterCordinat.y = y1;

            //    //Temporary R radius
            //    double rTemp = Math.Sqrt((Math.Pow(x1, 2)) + Math.Pow(y1, 2));

            //    //Condition when the point is in the circle
            //    if (rTemp <= r)
            //    {
            //        Console.WriteLine("The point with cordinats ({0},{1}) is IN the Circle with Radius r={2}", x1, y1, r);
            //    }
            //    else
            //    {
            //        Console.WriteLine("The point with cordinats ({0},{1}) is NOT IN  the Circle with Radius r={2}", x1, y1, r);
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("You did not put coordinat - Please put an integr value for x and y");
            //}

            Console.ReadLine();
            
        }
    }
}
