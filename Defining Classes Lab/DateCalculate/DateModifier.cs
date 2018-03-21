using System;

namespace DateCalculate
{
    class DateModifier
    {
        private DateTime firstDate;
        private DateTime secondDate;
        public DateTime FirstDate { get; private set; }
        public DateTime SeconDate { get; private set; }

        public DateModifier(string firstDate,string seconDate)
        {
            this.FirstDate=DateTime.Parse(firstDate);
            this.SeconDate=DateTime.Parse(seconDate);
        }

        public int Days()
        {
            return  Math.Abs((this.FirstDate - this.SeconDate).Days);
        }
    }
}

