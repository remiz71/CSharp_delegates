using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_delegates
{
    public delegate string strFormat(string str);
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Это новая строка которую надо отформатировать";
            Console.WriteLine($"Исходная строка: {str}");
            StringOperations strOp = new StringOperations();
            strFormat str1 = strOp.Lowercasestr;
            strFormat str2 = strOp.DeleteSpacers;
            strFormat str3 = strOp.UppercaseStr;
            str3 += strOp.ReplaceSpacers;
            str3 += strOp.Lowercasestr;
            str2 += strOp.Lowercasestr;
            str2 += strOp.UppercaseStr;
            str1 += strOp.UppercaseStr;
            str1 += strOp.DeleteSpacers;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Отработка первого делегата: ");
            foreach (strFormat format in str1.GetInvocationList())
            {
                Console.WriteLine(format(str));
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Отработка второго делегата: ");
            foreach (strFormat format in str2.GetInvocationList())
            {
                Console.WriteLine(format(str));
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Отработка третьего делегата: ");
            foreach (strFormat format in str3.GetInvocationList())
            {
                Console.WriteLine(format(str));
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------");
            
            
        }
    }
}
