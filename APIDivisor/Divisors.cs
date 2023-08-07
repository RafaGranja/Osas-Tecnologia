using APIDivisor;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace APIDivisor
{

    public static class Util
    {

        ///IMPRIME A LISTA EM ORDEM REVERSA PARA FICAR EM ORDEM DE MENOR PARA MAIOR
        public static void ImprimeLista(List<int> list)
        {


            for (int i = list.Count - 1; i >= 0; i--)
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

    public class Divisores
    {

        public Divisores(int number)
        {

            Dictionary<string, List<int>> resultado = Util.Divisores(number);

            this.divisors = resultado["Divisores"];
            this.prime_divisors = resultado["Primos"];

            this.number = number;


        }

        public List<int>? divisors { get; set; }

        public List<int>? prime_divisors { get; set; }

        public int number { get; set; }
    }

}