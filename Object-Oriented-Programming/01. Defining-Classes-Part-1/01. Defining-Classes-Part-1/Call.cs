using System;

namespace _01.Defining_Classes_Part_1
{
    public class Call
    {
        private DateTime date;
        private string phoneNumber;
        private int duration; //in secounds

        public Call(DateTime date, string phoneNumber, int duration)
        {
            this.date = date;
			this.phoneNumber = phoneNumber;
            this.duration = duration;
        }

        public DateTime Date { get { return this.date; } set { this.date = value; } }
        public string PhoneNumber { get { return this.phoneNumber; } set { this.phoneNumber = value; } }
        public int Duration { get { return this.duration; } set { this.duration = value; } }
    }
}
