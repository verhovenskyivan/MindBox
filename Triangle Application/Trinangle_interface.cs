using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Application
{
   public  interface Trinangle_interface
    {
        double A { get; }
        double B { get; }
        double C { get; }

        bool IsTriangleRectangular { get; }
    }
}
