using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Value1, Value2, Value3, Value4, Value5, RT;

                Value1 = Convert.ToDouble(textBox1.Text);
                Value2 = Convert.ToDouble(textBox2.Text);
                Value3 = Convert.ToDouble(textBox5.Text);
                Value4 = Convert.ToDouble(textBox4.Text);
                Value5 = Convert.ToDouble(textBox6.Text);

                RT = Value1 + Value2 + Value3 + Value4 + Value5;

                SeriesOUT.Text = "Resistance in Series =" + RT;
            }
            catch
            {
                MessageBox.Show("please input all values.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double Value1, Value2, Value3, Value4, Value5, RT;

                Value1 = Convert.ToDouble(textBox19.Text);
                Value2 = Convert.ToDouble(textBox20.Text);
                Value3 = Convert.ToDouble(textBox21.Text);
                Value4 = Convert.ToDouble(textBox22.Text);
                Value5 = Convert.ToDouble(textBox23.Text);

                RT = 1 / (1 / Value1 + 1 / Value2 + 1 / Value3 + 1 / Value4 + 1 / Value5);

                ParallelOUT.Text = "Resistance in series =" + RT;
            }
            catch
            {
                MessageBox.Show("Please input all values");
            }
        }
    }
}
