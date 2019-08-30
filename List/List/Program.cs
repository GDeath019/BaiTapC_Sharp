using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ds = new List<int>(5);           
            Random rd = new Random();
            
            for (int i = 0;i<ds.Capacity;i++)
            {
                int x = rd.Next(1, 101);
                ds.Add(x);
            }
            for(int i=0;i<ds.Count;i++)
            {
                Console.WriteLine(ds[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
