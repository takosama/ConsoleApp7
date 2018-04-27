using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            Random r = new Random();
            for (int i = 0; i < 100000000; i++)
            {
                int no = r.Next(0, 3);
                int select = r.Next(0, 3);
                List<int> noms = new List<int>();
                noms.Add(0);
                noms.Add(1);
                noms.Add(2);
                noms.Remove(select);

                if (no == select)
                    noms.Remove(r.Next(0, 2));
                else
                    if (noms[0] == no)
                    noms.Remove(noms[1]);
                else
                    noms.Remove(noms[0]);
                select = noms[0];
                if (no == select)
                    cnt++;
                Console.WriteLine(1.0 * cnt / 100000000);
            }

        }
    }
}
