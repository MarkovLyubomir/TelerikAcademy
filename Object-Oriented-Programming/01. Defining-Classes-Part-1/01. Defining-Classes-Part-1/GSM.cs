namespace _01.Defining_Classes_Part_1
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private static readonly GSM iPhone4S = new GSM("iPhone 4S", "Apple", 89.99, "Pesho", new Battery(BatteryType.LiIon, 140, 14), new Display(4.5, 62000000));

        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> history = new List<Call>();
        private double callPricePerMinute = 0.37;

        public static GSM IPhone4S { get { return iPhone4S; } }

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public string Model
        {
            get {
                return this.model;
            }
            set {
                if (value.Length < 2 && value.Length >= 20)
                {
                    throw new AccessViolationException("Invalid model. (model < 2 && model >= 20)");
                }
                this.model = value;
            }
        }

        public string Manufacturer { get { return this.manufacturer; } set { this.manufacturer = value; } }
        public double Price { get { return this.price; } set { this.price = value; } }
        public string Owner { get { return this.owner; } set { this.owner = value; } }
        public Battery Battery { get { return this.battery; } set { this.battery = value; } }
        public Display Display { get { return this.display; } set { this.display = value; } }

        public List<Call> CallHistory {
            get
            {
                return this.history;
            }
            set
            {
                this.history = value;
            }
        }

        public double CalculateCallPrice (List<Call> calls)
        {
            // Because they charge you minute after minute after 2012 (even if you talk 61 secound you will pay for 2 minutes)
            int roundedMinutes = 0;
            foreach (var phoneCall in calls)
            {
                if (phoneCall.Duration < 60)
                {
                    roundedMinutes++;
                }
                roundedMinutes += phoneCall.Duration / 60;
            }

            return roundedMinutes * callPricePerMinute;
        }

        public void AddCall (Call call)
        {
            this.history.Add(call);
        }

        public void RemoveCall (Call call)
        {
            this.history.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.history.Clear();
        }

        public override string ToString()
        {
            string batteryStr = (this.battery != null) ? this.battery.ToString() : "[unknown]";
            string displatStr = (this.display != null) ? this.display.ToString() : "[unknown]";
            string priceStr = (this.price != 0) ? "$" + this.price.ToString() : "[unknown]";

            return "GSM Details \nOwner: "
                + (this.owner ?? "unknown") + "\nManufacturer: "
                + (this.manufacturer ?? "unknown") + "\nModel: "
                + (this.model ?? "unknown") + "\nPrice: "
                + priceStr + "\nBattery: "
                + batteryStr + "\nDisplay: "
                + displatStr + "\n\n";
        }
    }
}
