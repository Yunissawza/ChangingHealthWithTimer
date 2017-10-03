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
    public static class Util
    {
        private static Random rnd = new Random();
        public static int GetRandom()
        {
            return rnd.Next(1, 6);
        }
    }
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        
        public Form1()
        {
            InitializeComponent();

            timer.Tick += new EventHandler(timer1_Tick);

            timer.Interval = (1000) * (3);
            timer.Enabled = true;
            timer.Start();         
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            int a = int.Parse(label2.Text);
            int i = Util.GetRandom();

            a -= i;

            label2.Text = a.ToString();

            Form2 Form = new Form2();
            Form.Show();
        }
    }
}
