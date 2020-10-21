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

            double[] listGini = new double[3]
           {
                giniChildF1,
                giniChildF2,
                giniChildF3
           };

            result = $" Hasil perhitungan \n gini F1 {giniChildF1:F4}\n gini F2 {giniChildF2:F4} \n gini F3 {giniChildF3:F4} \n Best Split adalah F1 {SmallestGini(listGini):F4}"; ;

            textBoxF1.Text = giniChildF1.ToString("F4");
            textBoxF2.Text = giniChildF2.ToString("F4");
            textBoxFeat3.Text = giniChildF3.ToString("F4");
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

        private double SmallestGini(double[] listGini)
        {
            double smallest = listGini[0];

            for (int i = 0; i < listGini.Count(); i++)
            {
                if (smallest > listGini[i])
                {
                    smallest = listGini[i];
                }
            }

            return smallest;
        }
    }
}
