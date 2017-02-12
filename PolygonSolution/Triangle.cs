using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonSolution
{
    //ShapeType is used so no misnaming can occur on the triangle type
    public enum ShapeType
    {
        Scalene,
        Isosceles,
        Equilateral,
        Error
    }

    public class Triangle
    {
        
        public int[] Sides { get; set; }
      
        public Triangle()
        {
            //constructor sets up sides with an intial value of -1 so we can
            //do error testing later
            Sides = new int [3];
            Sides[0] = -1;
            Sides[1] = -1;
            Sides[2] = -1;
        }
      
        public ShapeType  GetTriangleType()
        {
            //if any side has 0 or less we have a bad triangle
            if (Sides[0] <= 0 || Sides[1] <= 0 || Sides[2] <= 0)
            {
                return ShapeType.Error;
            }

            else if (Sides.Distinct().Count() == 1) //There is only one distinct value in the set, therefore all sides are of equal length
            {
                
                return ShapeType.Equilateral;
            }
            else if (Sides.Distinct().Count() == 2) //There are only two distinct values in the set, therefore two sides are equal and one is not
            {
                return ShapeType.Isosceles;
            }
            else if (Sides.Distinct().Count() == 3) // There are three distinct values in the set, therefore no sides are equal
            {
                return ShapeType.Scalene;
            }
            // if we have any other condition then above we have an error
            else
            {
                return ShapeType.Error;
            }
          
        }
    }
}
