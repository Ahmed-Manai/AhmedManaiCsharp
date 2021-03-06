/*
 * C# Program to Split a String Collections into Groups
 */
using System;
using System.IO;
using System.Collections;
using System.Linq;
class program
{
    static void SendEmail(string email)
    {
        Console.WriteLine(email);
    }
    static void Main(string[] args)
    {
        string[] email = {"One@aaa.com", "Two@aaa.com",
                          "Three@aaa.com", "Four@aaa.com",
                          "Five@aaa.com", "Six@aaa.com",
                          "Seven@aaa.com", "Eight@aaa.com"
                         };
        var Grp = from i in Enumerable.Range(0, email.Length)
                  group email[i] by i / 3;
        foreach (var mail in Grp)
            SendEmail(string.Join(";", mail.ToArray()));
        Console.ReadLine();
    }
}

/*
One@aaa.com;Two@aaa.com;
Three@aaa.com;Four@aaa.com;
Five@aaa.com;Six@aaa.com;
Seven@aaa.com;Eight@aaa.com