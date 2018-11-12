using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Program
    {
        private static int tamanho { get; set; }
        static void Main(string[] args)
        {
            tamanho = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[tamanho, tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                int j = 0;
                string input = Console.ReadLine();
                string[] outputs = input.Split(' ');
                foreach(string output in outputs)
                {
                    if (validation(Convert.ToInt32(output)))
                    {
                        arr[i, j] = int.Parse(output);
                        j++;
                    } else
                    {
                        Console.WriteLine("Numero invalido, inisira um numero entre -100 e 100 ");
                        fecharPrograma();
                    }
                }
            }
            Console.WriteLine(diagonalDifference(arr));
            fecharPrograma();
        }

        public static int diagonalDifference (int[,] arr)
        {
            int principal = 0;
            int secundaria = 0;
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    if (i == j) principal += arr[i, j];
                }
            }
            int n = tamanho - 1;
            for (int i = 0; i < tamanho; i++)
            {
                secundaria += arr[i, n];
                --n;
            }
            if ((principal - secundaria) >= 0)
            {
                return (principal - secundaria);
            }
            else return (principal - secundaria) * (-1);
        }
        public static bool validation (int number)
        {
            if (number >= -100 && number <= 100) return true;
            else return false;
        }

        public static void fecharPrograma()
        {
            Console.WriteLine("Fim do programa, tecle enter para sair...");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
