using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csis265proj08.models
{
   public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double P { get; set; }
        public double A { get ; set; }

        public Rectangle(double Length, double Width)
        {
           this.Length = Length;
            this.Width = Width;
        }

        public double RectanglePerimeter()
        {
             P = 2 * (Length + Width);
            return P;
            
        }

        public double RectangleArea()
        {
             A = Length * Width;
            return A;
            
        }

    }
}
