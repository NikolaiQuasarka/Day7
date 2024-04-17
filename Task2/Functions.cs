using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal static class Functions
    {
        public static double midvalue(List<double> list)
        {
            return list.Where(x=>x<0).Sum()/list.Count;
        }
    }
}
