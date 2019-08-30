using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Vũ Quang Minh");
            foreach(KeyValuePair<int,string> item in dic)
            {
                Console.WriteLine("Mã=: " +item.Key + " Tên:= " + item.Value);
            }
            Console.ReadLine();
        }
    }
}
