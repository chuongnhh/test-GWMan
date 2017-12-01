using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class MODE
    {
        public int SignStart { get; set; }
        public int SignLength { get; set; }

        public int WeightStart { get; set; }
        public int WeightLength { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // khởi tạo kiểu loại cân
            MODE mode = new MODE
            {
                SignStart = 7,
                SignLength = 1,
                WeightStart = 0,
                WeightLength = 6
            };
            // test case
            Console.WriteLine(TestFunc(".567890", mode));
            Console.WriteLine(TestFunc("5.67890-", mode));
            Console.WriteLine(TestFunc("5.567800", mode));
            Console.WriteLine(TestFunc("5.56780", mode));
            Console.WriteLine(TestFunc("5.56780-", mode));
        }

        // hàm chính
        static double TestFunc(string test, MODE mode)
        {
            string digit = Reverse(test.Substring(mode.WeightStart, mode.WeightLength).ToString());

            string sign = "";
            if (test.Length > 7)
            {
                sign = test.Substring(mode.SignStart, mode.SignLength);
            }

            return Double.Parse(sign + digit);
        }

        // đảo chuổi
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
