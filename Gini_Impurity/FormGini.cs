using Gini_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gini_Impurity
{
    public partial class FormGini : Form
    {
        List<Person> list = new List<Person>();
        
        List<GiniT> listGiniF3 = new List<GiniT>();
        int c0 = 0;
        int c1 = 0;

        string result = "";
        public FormGini()
        {
            InitializeComponent();
        }

        private void FormGini_Load(object sender, EventArgs e)
        {
            FormUtama form = (FormUtama)this.Owner;
            list = form.listOfPerson;
           
            
            

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            GiniYN();

            /*GiniT yesF1 = Feat1("YES");
            listGiniF1.Add(yesF1);
            GiniT noF1 = Feat1("NO");
            listGiniF1.Add(noF1);

            GiniT yesF2 = Feat2("YES");
            listGiniF2.Add(yesF2);
            GiniT noF2 = Feat2("NO");
            listGiniF2.Add(noF2);

            List<GiniT> listOfC0F3 = Feat3("<=");
            List<GiniT> listOfC1F3 = Feat3(">");

            GiniT giniC0 = listOfC0F3[0];
            GiniT giniC1 = listOfC1F3[0];
            listGiniF3.Add(giniC0);
            listOfC1F3.Add(giniC1);

            double giniBestSplit = GiniChild.CalcGiniChild(listGiniF3, total);


            for (int i = 1; i < listOfC0F3.Count; i++)
            {
                giniC0 = listOfC0F3[i];
                giniC1 = listOfC1F3[i];
                listGiniF3.Add(giniC0);
                listOfC1F3.Add(giniC1);

                double giniIndexI = GiniChild.CalcGiniChild(listGiniF3, total);

                if (giniBestSplit > giniIndexI)
                {
                    giniBestSplit = giniIndexI;
                }
            }

            yesF1.CalcGini();
            noF1.CalcGini();

            yesF2.CalcGini();
            noF2.CalcGini();



            textBoxOutput.Text = yesF1.Gini.ToString("F4");



            textBox1.Text = GiniChild.CalcGiniChild(listGiniF2, total).ToString("F4");
            textBoxFeat3.Text = giniBestSplit.ToString("F4");*/
        }

        private void GiniYN()
        {
            GiniYesNo giniF1 = Sorter.Feat1Sort(list);
            GiniYesNo giniF2 = Sorter.Feat2Sort(list);
            GiniNumeric giniF3 = Sorter.Feat3Sort(list);

            double giniYF1 = giniF1.CalcGiniY();
            double giniNF1 = giniF1.CalcGiniN();

            double giniYF2 = giniF2.CalcGiniY();
            double giniNF2 = giniF2.CalcGiniN();

            double giniChildF1 = giniF1.CalcGiniChild(giniYF1, giniNF1);
            double giniChildF2 = giniF2.CalcGiniChild(giniYF2, giniNF2);
            double giniChildF3 = giniF3.Gini;

            result = $" Hasil perhitungan \n gini F1 {giniChildF1}\n gini F2 {giniChildF2} \n gini F3 {giniChildF3} \n Best Split adalah F1 {giniChildF1}"; ;

            textBoxF1.Text = giniChildF1.ToString("F4");
            textBoxF2.Text = giniChildF2.ToString("F4");
            textBoxFeat3.Text = giniChildF3.ToString("F4");
        }

       

       

        private List<GiniT> Feat3(string node)
        {
            List<GiniT> listOfGini = new List<GiniT>();

            list.Sort(delegate (Person x, Person y)
            {
                if (x.Feat3 == 0 && y.Feat3 == 0) return 0;
                else if (x.Feat3 == 0) return -1;
                else if (y.Feat3 == 0) return 1;
                else return x.Feat3.CompareTo(y.Feat3);
            });

            int split = (list[0].Feat3 + list[1].Feat3) / 2;

            for(int i = 2; i < list.Count; i++)
            {
                int sameSplit = (list[i - 1].Feat3 + list[i].Feat3) / 2;

                if (split != sameSplit)
                {
                    foreach (Person person in list)
                    {
                        if (node == "<=")
                        {
                            if (person.Feat3 <= split && person.Classif == "C0")
                            {
                                c0++;
                            }
                            else if (person.Feat3 <= split && person.Classif == "C1")
                            {
                                c1++;
                            }
                        }
                        else
                        {
                            if (person.Feat3 > split && person.Classif == "C0")
                            {
                                c0++;
                            }
                            else if (person.Feat3 > split && person.Classif == "C1")
                            {
                                c1++;
                            }
                        }
                    }

                    GiniT gini = new GiniT(node + " " + split.ToString(), c0, c1);
                    gini.CalcGini();
                    listOfGini.Add(gini);
                    c0 = 0;
                    c1 = 0;
                    split = sameSplit;
                }               
            }

            return listOfGini;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Gini List";
            save.FileName = "Result.txt";
            save.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.CheckPathExists = true;
            save.DefaultExt = ".txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(save.FileName))
                {
                    sw.Write(result);
                    sw.Flush();
                    sw.Close();
                }

            }
        }
    }
}
