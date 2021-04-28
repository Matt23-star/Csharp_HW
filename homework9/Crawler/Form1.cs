using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crawler
{
    public partial class Form1 : Form
    {
        public SimpleCrawler SimpleCrawler { get; set; } = new SimpleCrawler();

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            urlTextBox.DataBindings.Add("Text", this.SimpleCrawler, "startURL");
        }

        private void sendURL_Click(object sender, EventArgs e)
        {
            SimpleCrawler.c
        }
    }
}
