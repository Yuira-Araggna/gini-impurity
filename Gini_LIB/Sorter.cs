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

        public static GiniNumeric Feat3Sort(List<Person> list)
        {
            List<GiniNumeric> listGiniNumeric = new List<GiniNumeric>();

            list.Sort(delegate (Person x, Person y)
            {
                if (x.Feat3 == 0 && y.Feat3 == 0) return 0;
                else if (x.Feat3 == 0) return -1;
                else if (y.Feat3 == 0) return 1;
                else return x.Feat3.CompareTo(y.Feat3);
            });

            int split = (list[0].Feat3 + list[1].Feat3) / 2;

            for (int i = 2; i < list.Count; i++)
            {
                int lec0 = 0, lec1 = 0, gtc0 = 0, gtc1 = 0;
                int sameSplit = (list[i - 1].Feat3 + list[i].Feat3) / 2;

                if (split != sameSplit)
                {
                    foreach (Person person in list)
                    {
                        if (person.Feat3 <= split && person.Classif == "C0")
                        {
                            lec0++;
                        }
                        else if (person.Feat3 <= split && person.Classif == "C1")
                        {
                            lec1++;
                        }
                        else if (person.Feat3 > split && person.Classif == "C0")
                        {
                            gtc0++;
                        }
                        else
                        {
                            gtc1++;
                        }
                    }

                    GiniNumeric numeric = new GiniNumeric(lec0, lec1, gtc0, gtc1);
                    listGiniNumeric.Add(numeric);
                    split = sameSplit;
                }
            }

            GiniNumeric giniChildren = listGiniNumeric[0];

            for (int i = 1; i < listGiniNumeric.Count; i++)
            {
                if (giniChildren.Gini > listGiniNumeric[i].Gini)
                {
                    giniChildren = listGiniNumeric[i];
                }
            }

            return giniChildren;
        }
    }
}
