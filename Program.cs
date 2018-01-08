using System;
using System.Text.RegularExpressions;

namespace CsharpDome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mobile="17317832jhh559";
            Regex red=new Regex(@"^[0-9]$");
            var flag=red.IsMatch(mobile);
            if(!flag)
            {
                Console.WriteLine("这个电话号码不正确");
            }
            for(var i=0;i<5;i++)
            {
                Console.WriteLine("he"+i);
            }
            Console.ReadKey();
        }
        private static void Voide()
        {

        }
    }
}
