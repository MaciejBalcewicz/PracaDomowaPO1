using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;

class Program
{
    const int _max = 100000;

    static void Main()
    {
        var list = new List<string>();
        var link = new LinkedList<string>();
        var queue = new Queue<string>();
        var hashSet = new HashSet<string>();

  
        for (int i = 0; i < 1000; i++)
        {
            list.Add("OK");
            link.AddLast("OK");
            queue.Enqueue("OK");
            hashSet.Add("OK");
        }

        TestCollection(list, "List");
        TestCollection(link, "LinkedList");
        TestCollection(queue, "Queue");
        TestCollection(hashSet, "HashSet");

        Console.Read();
    }

    static void TestCollection(IEnumerable collection, string collectionName)
    {
        var sw = Stopwatch.StartNew();
        for (int i = 0; i < _max; i++)
        {
            foreach (string v in collection)
            {
                if (v.Length != 2)
                {
                    throw new Exception();
                }
            }
        }
        sw.Stop();
        Console.WriteLine($"{collectionName}: {((double)(sw.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns")}");
    }
}
