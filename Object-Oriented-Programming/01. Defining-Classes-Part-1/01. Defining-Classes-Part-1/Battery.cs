using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Defining_Classes_Part_1
{
    public class Battery
    {
        private BatteryType type;
        private int idleHour;
        private int talkHour;

        public Battery() { }

        public Battery(BatteryType type, int idleHour, int talkHour)
        {
            this.type = type;
            this.idleHour = idleHour;
            this.talkHour = talkHour;
        }

        public BatteryType Type { get { return this.type; } set { this.type = value; } }
        public int IdleHour { get { return this.idleHour; } set { this.idleHour = value; } }
        public int TalkHour { get { return this.talkHour; } set { this.talkHour = value; } }

        public override string ToString()
        {
            return string.Format("\n    Model: {0}\n    Talk time (h): {1}\n    Stand-by time (h): {2}",
                this.type.ToString() ?? "unknown", 
                this.talkHour, 
                this.idleHour);
        }
    }
}
