using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_delegates
{
    internal class StringOperations
    {
        

        // Методы

        public string UppercaseStr(string str)
        {
            Console.Write("Замена регистра букв строки на верхний регистр: ");
            
            return str.ToUpper();
        }

        public string Lowercasestr(string str)
        {
            Console.Write("Замена регистра букв в строке на нижний регистр: ");
            return str.ToLower();
            
        }
        public string ReplaceSpacers(string str)
        {
            Console.Write("Замена пробелов звездочками: ");
            return str.Replace(' ', '*');
           
        }
        public string DeleteSpacers(string str)
        {
            Console.Write("Удаление пробелов: ");
            string temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    temp += str[i];
            }
            return temp;
            
        }
        
    }
}
