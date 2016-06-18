using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Defining_Classes_Part_1
{
    public class GSMCallHistoryTest
    {
        public static void RunTest()
        {
            GSM peshoPhone = new GSM("Galaxy S3", "Samsung", 321.99, "Gosho", new Battery(BatteryType.LiIon, 123, 12), new Display(5, 413425125));

            peshoPhone.AddCall(new Call(DateTime.Now.AddMinutes(1), "+359888888888", 125));
            peshoPhone.AddCall(new Call(DateTime.Now.AddMinutes(2), "+359888888123", 26));
            peshoPhone.AddCall(new Call(DateTime.Now.AddMinutes(3), "+359888888124", 256));
            peshoPhone.AddCall(new Call(DateTime.Now.AddMinutes(3).AddSeconds(30), "+359888888666", 59));
            peshoPhone.AddCall(new Call(DateTime.Now.AddMinutes(12), "+359888888666", 3));

            Console.WriteLine("__Call History__\n");
            foreach (var call in peshoPhone.CallHistory)
            {
                Console.WriteLine(string.Format("From number : {0}\nOn date: {1}\nDuration: {2} seconds\n", call.PhoneNumber, call.Date, call.Duration));
            }

            double calculateBill = peshoPhone.CalculateCallPrice(peshoPhone.CallHistory);
            Console.WriteLine("Total : " + calculateBill + " BGN");

            List<Call> sortedCalls = peshoPhone.CallHistory.OrderBy(m => m.Duration).ToList();
            peshoPhone.RemoveCall(sortedCalls[sortedCalls.Count - 1]);

            calculateBill = peshoPhone.CalculateCallPrice(peshoPhone.CallHistory);
            Console.WriteLine("Total after calculation: " + calculateBill + " BGN");

            peshoPhone.ClearCallHistory();

            Console.WriteLine("\n__Call History Cleaned__\n");
            foreach (var call in peshoPhone.CallHistory)
            {
                Console.WriteLine(string.Format("From number : {0}\nOn date: {1}\nDuration: {2} seconds\n", call.PhoneNumber, call.Date, call.Duration));
            }
        }
    }
}
