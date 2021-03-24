using System;
using System.Collections.Generic;

/* You are given the following information, but you may prefer to do some research for yourself.

1 Jan 1900 was a Monday.
Thirty days has September,
April, June and November.
All the rest have thirty-one,
Saving February alone,
Which has twenty-eight, rain or shine.
And on leap years, twenty-nine.
A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.

How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)? */

namespace ProjectEuler
{
    public class Problem19
    {
        List<Day> days = new List<Day>();

        public void Solve()
        {
            int dayCount = 1;

            for (int year = 1900; year <= 2000; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    int daysInMonth;

                    daysInMonth = GetDaysInMonth(month, year);

                    for(int date = 1; date <= daysInMonth; date++, dayCount++)
                    {
                        days.Add(new Day(dayCount, month, year, date));
                        if(dayCount == 7)
                        {
                            dayCount = 0;
                        }
                    }
                }
            }

            int count = 0;
            foreach(Day day in days)
            {
                if(day.year != 1900)
                {
                    if (day.day == 7 && day.dateOfMonth == 1)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        int GetDaysInMonth(int month, int year)
        {
            if (month == 2)
            {
                if(year % 4 != 0 || year % 100 == 0)
                {
                    return 28;
                }
                else
                {
                    return 29;
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else
            {
                return 31;
            }
        }
    }

    class Day
    {
        //1 for Monday, 2 for Tuesday... 7 for Sunday
        public int day;

        public int month;

        public int year;

        public int dateOfMonth;

        public Day(int setDay, int setMonth, int setYear, int setDateOfMonth)
        {
            day = setDay;
            month = setMonth;
            year = setYear;
            dateOfMonth = setDateOfMonth;
        }
    }
}
