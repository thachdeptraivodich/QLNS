using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github
{
   public class Class1
    {
        public static double Power(double x, int n)
        {
            if (n == 0)
                return 1.0;
            else if (n < 0)
                return x * Power(x, n - 1);
            else
                return Power(x, n + 1) / x;
        }
    }
}
