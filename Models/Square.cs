using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPAreaFinder.Models
{
    public class Square
    {
        public double SLength { get; set; }

        public double CalculateSquareArea()
        {
            return SLength * SLength;
        }
    }
}
