using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer5
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = "";
            int aux;

            Console.Write("Digite uma palavra: ");

            palavra = Console.ReadLine();

            char[] letras = palavra.ToCharArray();
            char[] letrasInv = palavra.ToCharArray();

            aux = letras.Length - 1;

            for (int i = 0; i < letras.Length; i++)
            {
                letrasInv[aux - i] = letras[i];
            }

            for (int i = 0; i < letras.Length; i++)
            {
                Console.Write(letrasInv[i]);
            }

            Console.ReadLine();
        }
    }
}
