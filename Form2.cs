using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangingHealthWithTimer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            int j = Util.GetRandom();
            label1.Text = "Enemy attacks you! -"+j+"  HP";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
