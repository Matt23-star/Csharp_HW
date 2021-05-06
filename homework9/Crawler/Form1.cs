using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections;

namespace Crawler
{
    public partial class Form1 : Form
    {
        private SimpleCrawler simpleCrawler = new SimpleCrawler();
        private bool flag = false;
        public string startURL { get; set; }
        public SimpleCrawler SimpleCrawler { get; set; } = new SimpleCrawler();

        public Form1()
        {
            InitializeComponent();
            urlTextBox.DataBindings.Add("Text", this, "startURL");
            stateBindingSource.DataSource = simpleCrawler.stateList;
            urlBindingSource.DataSource = simpleCrawler.urlList;
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
            simpleCrawler.urls = new Hashtable();
            if (startURL == null)
            {
                MessageBox.Show("请输入需要爬取的URL");
                return;
            }
            if (!flag)
            {
                simpleCrawler.urls.Add(startURL, false);
                flag = true;
            }
            urlListBox.DataSource = simpleCrawler.urlList;
            stateListBox.DataSource = simpleCrawler.stateList;
            while (true)
            {
                //if (this.stopButton.DialogResult.ToString() == "OK")
                //    break;
                string current = null;
                foreach (string url in simpleCrawler.urls.Keys)
                {
                    if ((bool)simpleCrawler.urls[url]) continue;
                    current = url;
                }

                if (current == null || simpleCrawler.count > 10) break;
                simpleCrawler.urlList.Add(new Url(current));
                string html = simpleCrawler.DownLoad(current);
                simpleCrawler.urls[current] = true;
                simpleCrawler.count++;
                simpleCrawler.Parse(html, startURL);

                messagesSource.ResetBindings(false);
                urlBindingSource.ResetBindings(false);
                stateBindingSource.ResetBindings(false);
            }
        }

        private void stateListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {

        }
    }
}
