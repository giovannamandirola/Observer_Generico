using System;

namespace Observer
{
    public class Temperature
    {
        private decimal degrees;

        private DateTime date;

        public Temperature(decimal temperature, DateTime dateAndTime)
        {
            this.degrees = temperature;
            this.date = dateAndTime;
        }

        public decimal Degrees
        {
            get
            {
                return this.degrees;
            }
            set
            {
                this.degrees = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
    }
}