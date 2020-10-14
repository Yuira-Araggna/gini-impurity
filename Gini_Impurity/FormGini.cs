using Gini_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gini_Impurity
{
    public partial class FormGini : Form
    {
        List<Person> list = new List<Person>();
        List<GiniT> listGiniF1 = new List<GiniT>();
        List<GiniT> listGiniF2 = new List<GiniT>();
        int c0, c1, total;
        public FormGini()
        {
            InitializeComponent();
        }

        private void FormGini_Load(object sender, EventArgs e)
        {
            FormUtama form = (FormUtama)this.Owner;
            list = form.listOfPerson;
            Total();
            
            GiniT yesF1 = Feat1("YES");
            listGiniF1.Add(yesF1);
            GiniT noF1 = Feat1("NO");
            listGiniF1.Add(noF1);

            GiniT yesF2 = Feat2("YES");
            listGiniF2.Add(yesF2);
            GiniT noF2  = Feat2("YES");
            listGiniF2.Add(noF2);

            yesF1.CalcGini();
            noF1.CalcGini();

            yesF2.CalcGini();
            noF2.CalcGini();

            textBoxOutput.Text = yesF1.Gini.ToString();
            textBox1.Text = GiniChild.CalcGiniChild(listGiniF2, total).ToString();

            //GiniChild.CalcGiniChild(listGiniF1, total).ToString();
            //
        }

        private GiniT Feat1(string feat)
        {
            foreach (Person person in list)
            {
                if (person.Feat1 == feat && person.Classif == "C0")
                {
                    c0++;
                }
                else if (person.Feat1 == feat && person.Classif == "C1")
                {
                    c1++;
                }
            }

            GiniT gini = new GiniT(feat, c0, c1);
            c0 = 0;
            c1 = 0;

            return gini;
        }
        private GiniT Feat2(string feat)
        {
            foreach (Person person in list)
            {
                if (person.Feat2 == feat && person.Classif == "C0")
                {
                    c0++;
                }
                else if (person.Feat2 == feat && person.Classif == "C1")
                {
                    c1++;
                }
            }

            GiniT gini = new GiniT(feat, c0, c1);
            c0 = 0;
            c1 = 0;
            return gini;
        }

        private int Total()
        {
            foreach(Person person in list)
            {
                total++;
            }
            return total;
        }

    }
}
