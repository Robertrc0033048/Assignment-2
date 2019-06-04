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
            //allows the code to be tested
            try
            {
                // this code will calculate the resistance of the values inputed in a series circuit
                double Value1, Value2, Value3, Value4, Value5, RT;

                Value1 = Convert.ToDouble(textBox1.Text);
                Value2 = Convert.ToDouble(textBox2.Text);
                Value3 = Convert.ToDouble(textBox5.Text);
                Value4 = Convert.ToDouble(textBox4.Text);
                Value5 = Convert.ToDouble(textBox6.Text);

                //Adds together all the values

                RT = Value1 + Value2 + Value3 + Value4 + Value5;

                SeriesOUT.Text = "Resistance in Series =" + RT;
            }
            // if the code has errors will display this message
            catch
            {
                MessageBox.Show("please input all values.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // this code will calculate the resistance of the values inputed in a series circuit
                double Value1, Value2, Value3, Value4, Value5, RT;

                Value1 = Convert.ToDouble(textBox19.Text);
                Value2 = Convert.ToDouble(textBox20.Text);
                Value3 = Convert.ToDouble(textBox21.Text);
                Value4 = Convert.ToDouble(textBox22.Text);
                Value5 = Convert.ToDouble(textBox23.Text);

                if (Value1 == 0)
                {
                    Value1 = Double.PositiveInfinity;
                }

                if (Value2 == 0)
                {
                    Value2 = Double.PositiveInfinity;
                }

                if (Value3 ==0 )
                {
                    Value3 = Double.PositiveInfinity;
                }

                if (Value4 == 0)
                {
                    Value4 = Double.PositiveInfinity;
                }

                 if (Value5 == 0)
                {
                    Value5 = Double.PositiveInfinity;
                }

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
