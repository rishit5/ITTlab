using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            input = Console.ReadLine();
            string[] splitIntput = input.Split(':');
            long[] dateTime = { 0, 0, 0, 0, 0, 0 };
            long.TryParse(splitIntput[0], out dateTime[0]);
            long.TryParse(splitIntput[1], out dateTime[1]);
            long.TryParse(splitIntput[2], out dateTime[2]);
            long.TryParse(splitIntput[3], out dateTime[3]);
            long.TryParse(splitIntput[4], out dateTime[4]);
            long.TryParse(splitIntput[5], out dateTime[5]);
            Console.WriteLine("Enter the ticks: ");
            string ticksStr;
            ticksStr = Console.ReadLine();
            long ticks;
            long.TryParse(ticksStr, out ticks);
            ticks = ticks / 10000000;
            // 86400s = 1 day
            dateTime[0] = dateTime[0] + (ticks / 86400);
            if(dateTime[0] >= 31)
            {
                dateTime[0] = 1;
                dateTime[1] = dateTime[1] + 1;
                if(dateTime[1] > 12)
                {
                    dateTime[1] = 1;
                    dateTime[2] = dateTime[2] + 1;
                }
             }
            ticks = ticks % 86400;
            dateTime[3] = dateTime[3] + (ticks / 3600);
            ticks = ticks % 3600;
            if(dateTime[3] >= 23)
            {
                dateTime[3] = 0;
                dateTime[0] = dateTime[0] + 1;
                if (dateTime[0] >= 31)
                {
                    dateTime[0] = 1;
                    dateTime[1] = dateTime[1] + 1;
                    if (dateTime[1] > 12)
                    {
                        dateTime[1] = 1;
                        dateTime[2] = dateTime[2] + 1;
                    }
                }
            }
            dateTime[4] = dateTime[4] + (ticks / 60);
            ticks = ticks % 60;
            if(dateTime[4] > 59)
            {
                dateTime[4] = 0;
                dateTime[3] = dateTime[3] + 1;
                if (dateTime[3] >= 23)
                {
                    dateTime[3] = 0;
                    dateTime[0] = dateTime[0] + 1;
                    if (dateTime[0] >= 31)
                    {
                        dateTime[0] = 1;
                        dateTime[1] = dateTime[1] + 1;
                        if (dateTime[1] > 12)
                        {
                            dateTime[1] = 1;
                            dateTime[2] = dateTime[2] + 1;
                        }
                    }
                }
            }
            dateTime[5] = dateTime[5] + ticks;
            if(dateTime[5] >= 60)
            {
                dateTime[5] = 0;
                dateTime[4] = dateTime[4] + 1;
                if (dateTime[4] > 59)
                {
                    dateTime[4] = 0;
                    dateTime[3] = dateTime[3] + 1;
                    if (dateTime[3] >= 23)
                    {
                        dateTime[3] = 0;
                        dateTime[0] = dateTime[0] + 1;
                        if (dateTime[0] >= 31)
                        {
                            dateTime[0] = 1;
                            dateTime[1] = dateTime[1] + 1;
                            if (dateTime[1] > 12)
                            {
                                dateTime[1] = 1;
                                dateTime[2] = dateTime[2] + 1;
                            }
                        }
                    }
                }
            }
            string s = string.Join(":", dateTime);
            Console.WriteLine(s);
            Console.Read();
        }
    }
}
