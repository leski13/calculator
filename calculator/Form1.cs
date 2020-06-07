using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double first = Convert.ToDouble(textBox1.Text);
                double second = Convert.ToDouble(textBox2.Text);
                switch (comboBox1.Text)
                {
                    case "+":
                        textBox3.Text = Convert.ToString(first + second);
                        break;
                    case "-":
                        textBox3.Text = Convert.ToString(first - second);
                        break;
                    case "/":
                        if (second == 0)
                            MessageBox.Show("Divide by zero exception.");
                        textBox3.Text = Convert.ToString(first / second);
                        break;
                    case "*":
                        textBox3.Text = Convert.ToString(first * second);
                        break;
                    default:
                        textBox3.Text = "Incorrect input data.";
                        break;
                }
            }
            
            catch (DivideByZeroException q)
            {
                MessageBox.Show(q.Message);
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void buttonDegree_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect input data.");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }
    }
}
