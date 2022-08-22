using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class GenericDemo
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            list.Add(34);
            list.Add(3555);
            list.Add(21);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Hitendra");
            dic.Add(2, "Mohan");
            dic.Add(3, "Simran");
            
            foreach (KeyValuePair<int,string> item in dic)
            {
                Console.WriteLine(item.Key +" " + item.Value);
                
            }
            Console.ReadKey();
        }
    }
}
