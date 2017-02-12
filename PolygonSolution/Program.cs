using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonSolution
{
    class Program
    {
        static void Main(string[] args)

        {
            //tell the user what data they are going to enter and setup variables
            Console.WriteLine("Enter Triangle Data: ");
            int count = 0;
            int side;
            Triangle myTriangle = new Triangle();
            
            // run the loop until all 3 sides are set
            while (count < 3)
            {
                Console.Write("Enter Side {0}: ", count + 1);
                string line = Console.ReadLine();
                //ensure side is an integer, if not then display error
                if (int.TryParse(line, out side))
                {
                    //ensure integer is positive
                    if (side <= 0)
                    {
                        Console.WriteLine("Side must be > 0");
                    }
                    //otherwise store the side and increment the counter
                    else {
                        myTriangle.Sides[count] = side;
                        count += 1;
                    }
                   
                }
                else
                {
                    Console.WriteLine("Value must be an Integer");
                }
            }
            //output data then use readline to wait while user reviews data
            Console.WriteLine("Triangle is of type: {0}", myTriangle.GetTriangleType());
            Console.WriteLine("Press <ENTER> to end");
            Console.ReadLine();
           
        }
    }
}
