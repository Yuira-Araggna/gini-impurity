using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gini_LIB
{
    public class GiniChild
    {

        public static double CalcGiniChild(List<GiniT> listOfGini, int totalData)
        {
            double giniChild = 0;
            foreach(GiniT gini in listOfGini)
            {
                giniChild += (double)gini.Total / totalData * gini.Gini;
            }
            return giniChild;
        }
    }
}
