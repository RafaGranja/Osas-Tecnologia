using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static  class Util { 

    ///IMPRIME A LISTA EM ORDEM REVERSA PARA FICAR EM ORDEM DE MENOR PARA MAIOR
    public static void ImprimeLista(List<int> list)
    {


        for (int i = list.Count-1; i >=0; i--)
        {

            if (i == list.Count - 1)
            {

                Console.Write(list[i]);

            }
            else
            {
                Console.Write(", ");
                Console.Write(list[i]);

            }

        }

    }

    ///RETORNA TRUE CASO O NUMERO SEJA PRIMO E FALSE CASO O NUMERO NÃO SEJA PRIMO
    public static bool Primo(int x)
    {
        List<int> ret_primos = new List<int>();

        for (int i = x; i > 0; i--)
        {

            if (x % i == 0)
            {

                ret_primos.Add(i);


            }

        }

        if (ret_primos.Count == 2)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    ///RETORNA UM MAP COM DOIS VETORES, UM VETOR "Divisores" QUE POSSUI TODOS OS DIVISORES DO NUMERO PASSO COMO PARÂMETRO
    /// E OUTRO VETOR "Primos" CONTENDO TODOS OS PRIMOS QUE SÃO DIVISORES DO NUMERO PASSADO COMO PARAMETRO
    public static Dictionary<string, List<int>> Divisores(int x)
    {
        Dictionary<string, List<int>> ret = new Dictionary<string, List<int>>();
        List<int> ret_divisores = new List<int>();
        List<int> ret_primos = new List<int>();

        for (int i = x; i > 0; i--)
        {

            if (x % i == 0)
            {

                ret_divisores.Add(i);

                if (Primo(i))
                {

                    ret_primos.Add(i);

                }

            }

        }

        ret.Add("Divisores", ret_divisores);
        ret.Add("Primos", ret_primos);

        return ret;

    }
    
}


namespace Divisor
{
    public class Program
    {
        static void Main(string[] args)
        {

            int number = 0;
            String line="";

            if (args.Length == 0)
            {
                Console.WriteLine("Insira um numero para calcularmos seus divisores e primos: ");
                line = Console.ReadLine();
            }
            else
            {
                line = args[0];
            }

            try
            {
                number = int.Parse(line);

                if (number <= 0)
                {

                    throw new Exception("Valor inválido, número deve ser maior que 0");

                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"Erro ao realizar leitura de dados :{e.Message}");

            }

            Dictionary<string, List<int>> resultado = Util.Divisores(number);

            Console.Write("Divisores: ");

            Util.ImprimeLista(resultado["Divisores"]);

            Console.Write("\nDivisores Primos: ");

            Util.ImprimeLista(resultado["Primos"]);

            Console.Write("\n");

        }
    }
}
