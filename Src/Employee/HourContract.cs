using System;

namespace Store.src.Employee
{
    public class HourContract
    {
        private DateTime _dateTime;
        private double _valuePerHour;
        private int _hours;

        public DateTime DateTime { get => _dateTime; set => _dateTime = value; }
        public double ValuePerHour { get => _valuePerHour; set => _valuePerHour = value; }
        public int Hours { get => _hours; set => _hours = value; }

        public HourContract()
        {
        }

        public HourContract(DateTime dateTime , double valuePerHour, int hours)
        {
            DateTime = dateTime;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }



        public override string ToString()
        {
           
            return base.ToString() + "(dateTime: " + DateTime + ",valuePerHour:" + ValuePerHour + ",hours:" + Hours + ")";
        }

    }
}