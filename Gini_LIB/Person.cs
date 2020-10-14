using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gini_LIB
{
    public class Person
    {
        private string feat1;
        private string feat2;
        private int feat3;
        private string classif;

        public string Feat1 { get => feat1; set => feat1 = value; }
        public string Feat2 { get => feat2; set => feat2 = value; }
        public int Feat3 { get => feat3; set => feat3 = value; }
        public string Classif { get => classif; set => classif = value; }

        public Person(string feat1, string feat2, int feat3, string classif="")
        {
            Feat1 = feat1;
            Feat2 = feat2;
            Feat3 = feat3;
            Classif = classif;
        }



    }
}
