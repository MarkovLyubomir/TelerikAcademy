using System;

[VersionAttribute("1.0")]
class Program
{
    static void Main()
    {
        object[] versionAttributes = typeof(Program).GetCustomAttributes(typeof(VersionAttribute), false);

        Console.WriteLine("Version: {0}", versionAttributes[0]);
    }
}