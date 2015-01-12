using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOS.Common.Ext;
namespace Linq
{
    class Program
    {
        public delegate int deleGate(int num);
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            #region Ling使用
            //var newNumbers = from num in numbers
            //                 select num + 1;
            //foreach (var item in newNumbers)
            //{
            //    Console.WriteLine(item);
            //}   
            //var result = numbers.Where(num=>num>3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}         
            #endregion

            
            //string str = string.Empty;
            //str.StrExten();
            //deleGate dele = new deleGate(Test);
            //int result =  dele.Invoke(3);
            //deleGate dele = delegate(int num) { return num + 1; };
            //deleGate dele = n => n + 1;
            List<string> user = new List<string>();
            user.Add("dudongdong");
            user.Add("wangwu");
            user.Add("zhaoliu");
            user.Add("ayun");
            user.Add("adu");
            var result = user.OrderBy(name => name);
            var result2 = user.GroupBy((name) => name);
            result.Select(a=>a).Print();
                //result
            //result.Print();
            Console.ReadKey();
        }

        public static int Test(int num)
        {
            num = num + 2;
            return num + 1;
        }
    }

    public static class StringExten
    {
        public static void StrExt(this string s)
        { 
            
        }
        public static void Print(this IEnumerable<string> ie)
        {
            IEnumerator<string> result = ie.GetEnumerator();
            while (result.MoveNext())
            {
                Console.WriteLine(result.Current);
            }
        }
    
    }

    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public List<Order> Orders { get; set; }
    }

    class Order
    {
        public int OrderID { get; set; }
        public string Maker { get; set; }
    }
}
