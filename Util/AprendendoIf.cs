using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Util
{
    class AprendendoIf
    {
        public static void Main(string[] args)
        {
            bool expressao = 1 < 2;
            if (!expressao)
            {
                Console.WriteLine("Expressão verdadeira");
            }
            else
            {
                Console.WriteLine("Expressão falsa");
            }
        }
    }
}
