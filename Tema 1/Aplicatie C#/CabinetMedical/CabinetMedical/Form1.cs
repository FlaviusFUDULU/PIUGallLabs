using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetMedical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Consultatie cons = new Consultatie();
            cons.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AnalizeLaborator anLab = new AnalizeLaborator();
            anLab.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Radiografii rad = new Radiografii();
            rad.Show();
        }
    }
}
