using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPAreaFinder.Views
{
    public interface IFinder
    {
        string rectangleWidthText { get; set; }
        string rectangleHeightText { get; set; }
        string squareLengthText { get; set; }
        string AreaResultText { set; }
    }
}
