using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace OPPconcepts.Backend
{
    public class Date
        //publico= modificableen el main
    {
        //fields
        //atributos (campos de clase (privados))
        private int _year;
        private int _month;
        private int _day;

        //constructor
        public Date()
        {
            _year = 1900;
            _month = 1;
            _day = 1;
        }
        public Date(int year, int month, int day)

        {
            Year = year;
            Month = month;
            Day = day;
        }
        //propiedades
        public int Year
        {
            get => _year;
            set => _year = validateYear(value);
        }
        public int Month
        {
            get => _month;
            set => _month = ValidateMonth(value);
        }
        public int Day
        {
            get => _day;
            set => _day = ValidateDay(value);
        }
        //Methods
        public override string ToString()
        {
            return $"{Year:0000}/{Month:00}/{Day:00}";
        }
        private int validateYear(int year)
        {
            if (year < 0 )
            {
                throw new ArgumentOutOfRangeException(nameof(year), "Year must be greathesth 0. ");
            }
            return year;
        }
        private int ValidateMonth(int month)
        {
            if (month < 1 || month >12)
            {
                throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12.");
            }
            return month;
        }
        private int ValidateDay(int day)
        {
            if (day < 1 )
            {
                throw new ArgumentOutOfRangeException(nameof(day), "Day must be greathest than 0.");
            }
            if (day == 29 && Month ==2 && IsLeapYear(Year))
            {
                return day;
            }
            int[] daysIntMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if ( day> daysIntMonth[Month-1])
            {
                throw new ArgumentOutOfRangeException(nameof(day),$"Day must be between 1 and {daysIntMonth[Month-1]} for month {Month}.");
            }
            return day;
        
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);      
        }
    }
}

