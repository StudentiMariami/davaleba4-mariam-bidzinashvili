using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davaleba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            int ricxvi1=int.Parse(textBox1.Text);
            int ricxvi2 = 4;
            int ricxvi3 = 5;

            memkvidre obieqti = new memkvidre(ricxvi2, ricxvi3);

            obieqti.gverdi1 = ricxvi1;

            int perimetri = obieqti.metodi_1();
            int fartobi=obieqti.metodi_2();

            label1.Text="PERIMETRIA  "+perimetri.ToString()+"   FARTOBIA  "+fartobi.ToString();
        }
    }
}
