using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPAreaFinder.Models
{
    public class Rectangle
    {
        public double RectWidth { get; set; }
        public double RectHeight { get; set; }

        public double calculateRectangleArea()
        {
            return RectWidth * RectHeight;
        }
    }
}
