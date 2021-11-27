using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265proj08.models
{
   public class RectangleManager 
    {
        public List<Rectangle> rectangles;
        public RectangleManager()
        {
            rectangles = new List<Rectangle>();
            
        }
        public void AddRectangle(double Length, double Width)
        {
            rectangles.Add(new Rectangle(Length, Width));
        }

        public double TotalRectanglePerimeter()
        {
            
           double SumP = rectangles.Sum(s => s.RectanglePerimeter());
            return SumP;
        }
        public double TotalRectangleArea()
        {
            double SumA = rectangles.Sum(s => s.RectangleArea());
            return SumA;

        }
        public double AverageRectanglePerimeter()
        {
            return rectangles.Average(x => x.RectanglePerimeter());

        }


        public double AverageRectangleArea()
        {
            return rectangles.Average(x => x.RectangleArea());

        }
    }
}
