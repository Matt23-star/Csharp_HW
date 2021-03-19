using System;

namespace questionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock();
            //设置响铃时间 第10秒响铃
            ClockEventArgs ringTime = new ClockEventArgs(10);
            clock.RingTime = ringTime;
            //注册事件
            clock.Timing += AlarmEvent;
            clock.TimePass();
        }

        public static void AlarmEvent(object sender, ClockEventArgs clockEventArgs, ClockEventArgs ringTime)
        {
            clockEventArgs.PrintTime();
            if (clockEventArgs.IsEqual(ringTime))
            {
                Console.WriteLine("闹钟：响铃了！！！");
            }
            else
            {
                Console.WriteLine("闹钟：嘀嗒...");
            }
        }
    }
}
