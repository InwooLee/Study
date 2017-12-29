using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TK
{
    public class Util
    {
        public static double ToRadians(double degrees)
        {
            return (Math.PI / 180.0d) * degrees; 
        }

        public static double ToDegrees(double radians)
        {
            return (180.0d / Math.PI) * radians;
        }

        //public static 
    }
}
