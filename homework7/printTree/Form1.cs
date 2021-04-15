using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace printTree
{
    public partial class Form1 : Form
    {
        Tree tree = new Tree();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            tree.Length = double.Parse(textBox1.Text);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string color = comboBox1.SelectedItem.ToString();
            switch (color)
            {
                case "红色": tree.Pen = Pens.Red; break;
                case "蓝色": tree.Pen = Pens.Blue; break;
                case "黄色": tree.Pen = Pens.Yellow; break;
                default: tree.Pen = Pens.Black; break;
            }
            tree.Graphics = panel4.CreateGraphics();
            tree.DrawCayleyTree(tree.Depth, panel4.ClientRectangle.X + panel4.ClientRectangle.Width / 2,
                panel4.ClientRectangle.Y + panel4.Height, tree.Length, -Math.PI / 2);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            tree.Depth = int.Parse(textBox6.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            tree.Th1 = double.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            tree.Th2 = double.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            tree.Per1 = double.Parse(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            tree.Per2 = double.Parse(textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.CreateGraphics().Clear(panel4.BackColor);
        }
    }
}
