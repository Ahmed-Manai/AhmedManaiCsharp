/*
 * C# Program to Demonstrate Culture Names
 */
using System;
using System.Globalization;
using System.Threading;
public class Info : MarshalByRefObject
{
    public void ShowCurrentCulture()
    {
        Console.WriteLine("Culture of {0} in application domain {1}: {2}",Thread.CurrentThread.Name,AppDomain.CurrentDomain.FriendlyName,CultureInfo.CurrentCulture.Name);
    }
}
public class Example
{
    public static void Main()
    {
        Info inf = new Info();
        Thread.CurrentThread.Name = "MainThread";
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("nl-NL");
        inf.ShowCurrentCulture();
        AppDomain ad = AppDomain.CreateDomain("Domain2");
        Info inf2 = (Info)ad.CreateInstanceAndUnwrap(typeof(Info).Assembly.FullName, "Info");
        inf2.ShowCurrentCulture();
        Console.ReadLine();
    }
}

/*

Culture of MainThread in application domain ConsoleApplication32.vshoot.exe : nl-NL
Culture of MainThread in application domain Domain2 : nl-NL