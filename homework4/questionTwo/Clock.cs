using System;
using System.Collections.Generic;
using System.Text;

namespace questionTwo
{
    public class ClockEventArgs : EventArgs
    {
        public int ticktocks = 0;
    }

    public delegate void ClockEventHandler(Object sender, ClockEventArgs clockEventArgs , int ringTime);

    class Clock
    {
        public int RingTime { get; set; }

        public Clock()
        {

        }

        public Clock(int ringTime)
        {
            this.RingTime = ringTime;
        }

        public event ClockEventHandler Timing;

        public void TimePass()
        {
            int ticktocks = 10000;
            int i = 0;
            while (i < ticktocks)
            {
                //每一秒 i 增加 1
                System.Threading.Thread.Sleep(1000);
                i++;

                //每经过一秒钟发生一个事件
                if (Timing != null)
                {
                    ClockEventArgs args = new ClockEventArgs();
                    args.ticktocks = i;
                    Timing(this, args, RingTime);
                }
            }
        }
    }
}
