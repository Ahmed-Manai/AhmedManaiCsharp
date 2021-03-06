/*
 * C# Program to Prefix Game
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Project
{
class Program
{
    static void Main(string[] args)
    {
        string[,] seq = new string[4, 3];
        int row = 0;
        seq[row, 0] = "substring";
        seq[row, 1] = "sub";
        seq[row, 2] = "incorrect";
        row++;
        seq[row, 0] = "input";
        seq[row, 1] = "in";
        seq[row, 2] = "incorrect";
        row++;
        int numrows = 0;
        play(seq, numrows);
        Console.Write("Continue : Press 'y'");
        string next = Console.ReadLine();
        if (next.CompareTo("y") == 0)
            {
                Console.Clear();
                numrows += 2;
                play(seq, numrows);
            }
        Console.ReadLine();
    }
    static void play(string[,] seq, int rows)
    {
        Console.WriteLine("ENGLISH WORD PREFIX GAME");
        for (int i = rows; i <rows+2 ; i++)
            {
                Console.Write("What is the correct prefix of '{0}':", seq[i, 0]);
                string ans = Console.ReadLine();
                if (seq[i, 1].ToLower().CompareTo(ans.ToString().ToLower()) == 0)
                    seq[i, 2] = "correct";
                Console.WriteLine();
            }
        Console.WriteLine("CHECK YOUR ANSWERS!!!");
        Console.WriteLine("Word\t\t\tPrefix\t\tDescription");
        for (int i = rows; i < rows+2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}\t\t", seq[i, j]);
                Console.WriteLine();
            }
        Console.Read();
    }
}
}
/*

ENGLISH WORD PREFIX GAME
What is the correct prefix of 'substring' : sub
What is the correct prefix of 'input' : in

CHECK YOUR ANSWERS!!!!
Word       Prefix      Description
substring  sub         correct
input      in          correct