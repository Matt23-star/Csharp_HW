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
        private SimpleCrawler simpleCrawler = new SimpleCrawler();
        private Url url;
        private State state;
        public string startURL { get; set; }
        public SimpleCrawler SimpleCrawler { get; set; } = new SimpleCrawler();

        public Form1()
        {
            InitializeComponent();
            urlTextBox.DataBindings.Add("Text", this, "startURL");
            messages.DataSource = simpleCrawler.stateList;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendURL_Click(object sender, EventArgs e)
        {

            simpleCrawler.urls.Add(startURL, false);
            while (true)
            {
                string current = null;
                foreach (string url in simpleCrawler.urls.Keys)
                {
                    if ((bool)simpleCrawler.urls[url]) continue;
                    current = url;
                }

                if (current == null || simpleCrawler.count > 10) break;
                url = new Url(current);
                simpleCrawler.urlList.Add(url);
                webBindingSource1.DataSource = simpleCrawler.urlList;
                string html = simpleCrawler.DownLoad(current);
                stateBindingSource.DataSource = simpleCrawler.stateList;
                simpleCrawler.urls[current] = true;
                simpleCrawler.count++;
                simpleCrawler.Parse(html, startURL);
            }
        }
    }
}
