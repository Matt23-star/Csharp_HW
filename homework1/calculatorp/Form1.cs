using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorp
{
    public partial class Form1 : Form
    {
        double firstNum, secondNum, result;
        char c;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox1.Text);
            secondNum = double.Parse(textBox3.Text);
            c = char.Parse(textBox2.Text);
            switch (c)
            {
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
                case '*':
                    result = firstNum * secondNum;
                    break;
                case '/':
                    result = firstNum / secondNum;
                    break;
                default:
                    MessageBox.Show("数据错误，请重新输入！");
                    break;
            }
            label1.Text = result.ToString();
        }
    }
}
