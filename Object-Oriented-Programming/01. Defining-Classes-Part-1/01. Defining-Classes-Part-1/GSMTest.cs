namespace _01.Defining_Classes_Part_1
{
    using System;
    using System.Collections.Generic;
    class GSMTest
    {
        public static void RunTest()
        {
            List<GSM> phones = new List<GSM>();

            phones.Add(new GSM("Galaxy S3", "Samsung", 321.99, "Gosho", new Battery(BatteryType.LiIon, 123, 12), new Display(5, 413425125)));
            phones.Add(new GSM("Galaxy S6", "Samsung", 800.99, "Tosho", new Battery(BatteryType.NiCd, 136, 16), new Display(6, 155346363)));
            phones.Add(new GSM("Galaxy S8", "Samsung"));

            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }

            Console.WriteLine("___STATIC CLASS___\n");
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
