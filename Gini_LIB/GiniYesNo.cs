using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gini_LIB
{
    public class GiniYesNo
    {
        private int yc0;
        private int yc1;
        private int nc0;
        private int nc1;
        private int totalY;
        private int totalN;
        private int total;
        private double gini;

        public int Yc0 { get => yc0; set => yc0 = value; }
        public int Yc1 { get => yc1; set => yc1 = value; }
        public int Nc0 { get => nc0; set => nc0 = value; }
        public int Nc1 { get => nc1; set => nc1 = value; }
        public int Total { get => total; set => total = value; }
        public double Gini { get => gini; set => gini = value; }
        public int TotalY { get => totalY; set => totalY = value; }
        public int TotalN { get => totalN; set => totalN = value; }

        public GiniYesNo(int yc0, int yc1, int nc0, int nc1)
        {
            Yc0 = yc0;
            Yc1 = yc1;
            Nc0 = nc0;
            Nc1 = nc1;
            Total = yc0 + yc1 + nc0 + nc1;
            TotalY = yc0 + yc1;
            TotalN = nc0 + nc1;
            Gini = CalcGiniChild(CalcGiniY(), CalcGiniN());
        }

        public double CalcGiniY()
        {
            int totalY = Yc0 + Yc1;
            double gini;

            if(Yc0 > 0 && Yc1 > 0)
            {
                gini = 1 - Math.Pow((double)Yc0 / totalY, 2) - Math.Pow((double)Yc1 / totalY, 2);
            }
            else if(Yc0 > 0)
            {
                gini = 1 - Math.Pow((double)Yc0 / totalY, 2);
            }
            else
            {
                gini = 1 - Math.Pow((double)Yc1 / totalY, 2);
            }

            return gini;
        }

        public double CalcGiniN()
        {
            int totalN = Nc0 + Nc1;
            double gini;

            if (Nc0 > 0 && Nc1 > 0)
            {
                gini = 1 - Math.Pow((double)Nc0 / totalN, 2) - Math.Pow((double)Nc1 / totalN, 2);
            }
            else if (Nc0 > 0)
            {
                gini = 1 - Math.Pow((double)Nc0 / totalN, 2);
            }
            else
            {
                gini = 1 - Math.Pow((double)Nc1 / totalN, 2);
            }

            return gini;
        }

        public double CalcGiniChild(double gini1, double gini2)
        {
            double gini = ((double)TotalY / (double)Total * gini1) + ((double)TotalN / (double)Total * gini2);
            return gini;
        }
    }
}
