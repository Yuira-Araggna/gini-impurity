using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gini_LIB
{
    public class GiniNumeric
    {
        private int lessEqualC0;
        private int lessEqualC1;
        private int greaterThanC0;
        private int greaterThanC1;
        private int totalLessEqual;
        private int totalGreaterThan;
        private int total;
        private double gini;

        public int LessEqualC0 { get => lessEqualC0; set => lessEqualC0 = value; }
        public int LessEqualC1 { get => lessEqualC1; set => lessEqualC1 = value; }
        public int GreaterThanC0 { get => greaterThanC0; set => greaterThanC0 = value; }
        public int GreaterThanC1 { get => greaterThanC1; set => greaterThanC1 = value; }
        public int TotalLessEqual { get => totalLessEqual; set => totalLessEqual = value; }
        public int TotalGreaterThan { get => totalGreaterThan; set => totalGreaterThan = value; }
        public int Total { get => total; set => total = value; }
        public double Gini { get => gini; set => gini = value; }

        public GiniNumeric(int lessEqualC0Input, int lessEqualC1Input, int greaterThanC0Input, int greaterThanC1Input)
        {
            LessEqualC0 = lessEqualC0Input;
            LessEqualC1 = lessEqualC1Input;
            GreaterThanC0 = greaterThanC0Input;
            GreaterThanC1 = greaterThanC1Input;
            TotalLessEqual = lessEqualC0Input + lessEqualC1Input;
            TotalGreaterThan = greaterThanC0Input + greaterThanC1Input;
            Total = totalLessEqual + totalGreaterThan;
            Gini = CalcGiniChild(CalcGiniLessEqual(), CalcGiniGreaterThan());
        }

        public double CalcGiniLessEqual()
        {
            double giniLessEqual = 0;

            if (lessEqualC0 > 0 && lessEqualC1 > 0)
            {
                giniLessEqual = 1 - Math.Pow(((double)lessEqualC0 / totalLessEqual), 2.0) - Math.Pow(((double)lessEqualC1 / totalLessEqual), 2.0);
            }
            else if (lessEqualC0 > 0)
            {
                giniLessEqual = 1 - Math.Pow(((double)lessEqualC0 / totalLessEqual), 2.0);
            }
            else if (lessEqualC1 > 0)
            {
                giniLessEqual = 1 - Math.Pow(((double)lessEqualC1 / totalLessEqual), 2.0);
            }

            return giniLessEqual;
        }

        public double CalcGiniGreaterThan()
        {
            double giniGreaterThan = 0;

            if (greaterThanC0 > 0 && greaterThanC1 > 0)
            {
                giniGreaterThan = 1 - Math.Pow(((double)greaterThanC0 / totalGreaterThan), 2.0) - Math.Pow(((double)greaterThanC1 / totalGreaterThan), 2.0);
            }
            else if (greaterThanC0 > 0)
            {
                giniGreaterThan = 1 - Math.Pow(((double)greaterThanC0 / totalGreaterThan), 2.0);
            }
            else if (greaterThanC1 > 0)
            {
                giniGreaterThan = 1 - Math.Pow(((double)greaterThanC1 / totalGreaterThan), 2.0);
            }

            return giniGreaterThan;
        }

        public double CalcGiniChild(double giniLessEqual, double giniGreaterThan)
        {
            double giniChild = (double)totalLessEqual / total * giniLessEqual + (double)totalGreaterThan / total * giniGreaterThan;

            return giniChild;
        }
    }
}
