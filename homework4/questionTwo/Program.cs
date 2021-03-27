using System;

namespace questionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock();
            //设置响铃时间 第10秒响铃
            ClockEventArgs ringTime = new ClockEventArgs(5);
            clock.RingTime = ringTime;
            //注册事件
            clock.Timing += AlarmEvent;
            clock.TimePass();
        }

        public static void AlarmEvent(Clock sender, ClockEventArgs clockEventArgs)
        {
            clockEventArgs.PrintTime();
            if (sender.IsRing(clockEventArgs))
            {
                Console.WriteLine("闹钟：响铃了！！！");
                System.Threading.Thread.Sleep(6000);
                for (int i = 0; i < 5; i++) { clockEventArgs.TimeIncrease(); }
            }
            else
            {
                Console.WriteLine("闹钟：嘀嗒...");
            }
        }
    }
}
