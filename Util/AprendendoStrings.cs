using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Util
{
    class AprendendoStrings
    {
        public static void Main(string[] args)
        {
            string texto = "  Precisamos de um plano de ataque ! Eu tenho um plano. Ataque.  ";
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.Replace("plano", "Super Plano"));
            Console.WriteLine(texto.Trim());
            Console.WriteLine(texto.TrimStart());
            Console.WriteLine(texto.TrimEnd());
            Console.WriteLine(texto.Substring(texto.Length / 2));
            Console.WriteLine("Texto contém a palavra plano? {0}", texto.Contains("plano"));
            Console.WriteLine("Posição palavra um {0}", texto.IndexOf("um"));
            Console.WriteLine("Quantidade de caracteres: {0}", texto.Length);
            foreach (string txt in texto.Split("ataque"))
            {
                Console.WriteLine(txt);
            }

        }

    }
}
