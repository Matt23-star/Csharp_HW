﻿using System;
using System.Collections.Generic;
using System.Text;

namespace questionTwo
{

    public delegate void ClockEventHandler(Object sender, ClockEventArgs clockEventArgs , ClockEventArgs ringTime);

    class Clock
    {
        public ClockEventArgs RingTime { get; set; }

        public Clock()
        {

        }

        public Clock(ClockEventArgs ringTime)
        {
            this.RingTime = ringTime;
        }

        public event ClockEventHandler Timing;

        public void TimePass()
        {
            int ticktocks = 10000;
            int i = 0;
            ClockEventArgs args = new ClockEventArgs();
            while (i < ticktocks)
            {
                //每一秒 i 增加 1
                System.Threading.Thread.Sleep(1000);
                i++;

                //每经过一秒钟发生一个事件
                if (Timing != null)
                {
                    args.TimeIncrease();
                    Timing(this, args, RingTime);
                }
            }
        }
    }
}
