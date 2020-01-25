using System;

namespace DateModifier
{
    public class DateModifier
    {
        private DateTime firstDate;
        private DateTime secondDate;

        public DateModifier()
        {

        }

        public DateTime FirstDate { get; set; }

        public DateTime SecondDate { get; set; }

        public double DifferenceInDays(DateTime firstDate,DateTime secondDate)
        {
            var result = Math.Abs((firstDate - secondDate).TotalDays);
            return result;
        }
    }
}
