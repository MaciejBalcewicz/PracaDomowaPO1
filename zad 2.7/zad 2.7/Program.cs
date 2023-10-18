using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        int x, y = 5;
        x = ++y * 2;
        x = y++;
        x = y--;
        Console.WriteLine(++y);
        Console.ReadKey();
    }
}