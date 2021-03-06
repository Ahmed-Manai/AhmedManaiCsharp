using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permutation_Sort
{
class Program
{
    static void Main(string[] args)
    {
        List<caracter> listChar = new List<caracter>();
        listChar.Add(new Caracter('A'));
        listChar.Add(new Caracter('B'));
        listChar.Add(new Caracter('C'));
        Console.WriteLine("Combinations of A, B and C are");
        List<string> permutation = Permutar(listChar, listChar.Count);
        foreach (string p in permutation)
            Console.WriteLine(p);
    }

    public static List<string> Permutar(List<caracter> elem, int n)
    {
        List<string> permutation = new List<string>();
        Queue<data> a1 = new Queue<data>();
        List<caracter> vacia = new List<caracter>();
        a1.Enqueue(new Data(vacia, n));
        while (a1.Count > 0)
            {
                Data d = a1.Dequeue();
                if (d.n == 0)
                    {
                        string pActual = Concatenar(d.actual);
                        if (!permutation.Contains(pActual))
                            {
                                permutation.Add(pActual);
                            }
                    }
                else
                    {
                        for (int i = 0; i < elem.Count; i++)
                            {
                                if (!d.actual.Contains(elem[i]))
                                    {
                                        List<caracter> lis = new List<caracter>();
                                        for (int k = 0; k < d.actual.Count; k++)
                                            {
                                                lis.Add(d.actual[k]);
                                            }
                                        lis.Add(elem[i]);
                                        Data d1 = new Data(lis, d.n - 1);
                                        a1.Enqueue(d1);
                                    }
                            }
                    }
            }
        return permutation;
    }

    static string Concatenar(List<caracter> listaCaracteres)
    {
        string cadena = "";
        for (int i = 0; i < listaCaracteres.Count; i++)
            {
                cadena += listaCaracteres[i].caracter;
            }
        return cadena;
    }
}

class Data
{
    public List<caracter> actual;
    public int n;

    public Data(List<caracter> actual, int n)
    {
        this.actual = actual;
        this.n = n;
    }
}
class Caracter
{
    public char caracter;
    public Caracter(char caracter)
    {
        this.caracter = caracter;
    }
}
}