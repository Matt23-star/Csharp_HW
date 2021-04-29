using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
    public class State
    {
        public State(string state)
        {
            this.state = state;
        }

        public string state { get; set; }
    }
}
