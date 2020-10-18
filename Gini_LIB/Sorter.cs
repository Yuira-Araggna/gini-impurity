using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gini_LIB
{
    public class Sorter
    {

        public static GiniYesNo Feat1Sort(List<Person> list)
        {
            int yc0 = 0, yc1 = 0, nc0 = 0, nc1 = 0;
            foreach (Person person in list)
            {
                if (person.Feat1 == "YES" && person.Classif == "C0")
                {
                    yc0++;
                }
                else if (person.Feat1 == "YES" && person.Classif == "C1")
                {
                    yc1++;
                }
                else if (person.Feat1 == "NO" && person.Classif == "C0")
                {
                    nc0++;
                }
                else
                {
                    nc1++;
                }
            }
            GiniYesNo gini = new GiniYesNo(yc0, yc1, nc0, nc1);

            return gini;
        }

        public static GiniYesNo Feat2Sort(List<Person> list)
        {
            int yc0 = 0, yc1 = 0, nc0 = 0, nc1 = 0;
            foreach (Person person in list)
            {
                if (person.Feat2 == "YES" && person.Classif == "C0")
                {
                    yc0++;
                }
                else if (person.Feat2 == "YES" && person.Classif == "C1")
                {
                    yc1++;
                }
                else if (person.Feat2 == "NO" && person.Classif == "C0")
                {
                    nc0++;
                }
                else
                {
                    nc1++;
                }
            }
            GiniYesNo gini = new GiniYesNo(yc0, yc1, nc0, nc1);

            return gini;
        }

        public static List<int> Feat3Sort(List<Person> list)
        {
            List<int> listInt = new List<int>();

            foreach(Person person in list)
            {
                listInt.Add(person.Feat3);
            }

            return list.Sort();
        }
    }
}
