namespace GenericList
{
    using System;
    using System.Linq;

    public class GenericMain
    {
        static void Main()
        {

            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.AddElement(i);
            }

            Console.WriteLine(list.ToString());
            Console.WriteLine(list.Max<int>());
            Console.WriteLine(list.Min<int>());
        }
    }
}
