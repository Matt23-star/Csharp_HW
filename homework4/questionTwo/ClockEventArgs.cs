using System;
using System.Collections.Generic;
using System.Text;

namespace questionTwo
{
    public class ClockEventArgs : EventArgs
    {
        public int Second { get; set; }
        public int Minute { get; set; }
        public int Hour { get; set; }
        public int Day { get; set; }

        public ClockEventArgs()
        {
            Second = 0;
            Minute = 0;
            Hour = 0;
            Day = 0;
        }

        public ClockEventArgs(int second) : this()
        {
            Second = second;
        }

        public ClockEventArgs(int minute, int second) : this(second)
        {
            Minute = minute;
        }
        public ClockEventArgs(int hour, int minute, int second) : this(minute, second)
        {
            Hour = hour;
        }

        public ClockEventArgs(int day,int hour, int minute, int second) : this(hour, minute, second)
        {
            Day = day;
        }

        public bool IsLegal()
        {
            if(Second>=0&&Second<60
                &&Minute>=0&&Minute<60
                && Hour >= 0 && Hour < 24)
            {
                return true;
            }
            return false;
        }

        public bool IsEqual(ClockEventArgs clockEventArgs)
        {
            if(this.Second == clockEventArgs.Second
                &&this.Minute == clockEventArgs.Minute
                &&this.Hour == clockEventArgs.Hour
                &&this.Day == clockEventArgs.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TimeIncrease()
        {
            Second++;
            if (Second >= 60)
            {
                Second -= 60;
                Minute++;
            }
            if (Minute >= 60)
            {
                Minute -= 60;
                Hour++;
            }
            if (Hour >= 24)
            {
                Hour -= 24;
                Day++;
            }
        }

        public void PrintTime()
        {
            Console.WriteLine($"现在是{this.Day}天{this.Hour}时{this.Minute}分{this.Second}秒");
        }
    }
}
