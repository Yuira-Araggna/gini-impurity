using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gini_LIB
{
    public class GiniT
    {
        private string namaFeat;  //ADA     Tidak Ada
        private int c0;           //12      13
        private int c1;           //13      12
        private int total;        //25      25
        private double gini;      //0.48    0.48

        public string NamaFeat { get => namaFeat; set => namaFeat = value; }
        public int C0 { get => c0; set => c0 = value; }
        public int C1 { get => c1; set => c1 = value; }
        public double Gini { get => gini; set => gini = value; }
        public int Total { get => total; private set => total = value; }

        public GiniT(string namaFeat, int c0, int c1)
        {
            NamaFeat = namaFeat;
            C0 = c0;
            C1 = c1;
            Gini = 0;
            Total = c0 + c1;
        }

        public void CalcGini()
        {
            double gini = 1 - ((double)C0 / Total) - ((double)C1 / Total);
            Gini = gini;
        }
    }
}
