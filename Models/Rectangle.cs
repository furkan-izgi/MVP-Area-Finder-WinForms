using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPAreaFinder.Models
{
    public class Rectangle
    {
        public double Rwidth { get; set; }
        public double Rheight { get; set; }

        public double calculateRectangleArea()
        {
            return Rwidth * Rheight;
        }
    }
}
