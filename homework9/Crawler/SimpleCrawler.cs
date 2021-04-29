using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Crawler {
    public class SimpleCrawler
    {
        public Hashtable urls { get; set; } = new Hashtable();
        public int count { get; set; } = 0;
        public List<Url> urlList { get; set; } = new List<Url>();
        public List<State> stateList { get; set; } = new List<State>();
        private State state;

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                state = new State("爬取成功");
                stateList.Add(state);
                return html;
            }
            catch (Exception ex)
            {
                stateList.Add(new State(ex.Message));
                return "";
            }
        }

        public void Parse(string html, string startUrl)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+(html|htm|aspx|jsp)[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (!Regex.IsMatch(strRef, @"http"))
                {
                    strRef = startUrl + strRef.Substring(1, strRef.Length - 1);
                }
                else if (!Regex.IsMatch(strRef, startUrl))
                {
                    continue;
                }
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
