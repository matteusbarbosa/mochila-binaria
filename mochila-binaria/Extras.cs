using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mochila_binaria
{
    class Extras
    {
        const int MIN_PESO = 1, MAX_PESO = 100;

        /* Gera matriz com duas colunas, com peso x valor de cada item */
        public static Double[,] gerarPesoValor(int num_itens)
        {
            Double[,] pesoValor = new Double[num_itens, 2];
            //inicia o gerador de números aleatórios
            Random alt = new Random();
            for (int i = 0; i < num_itens; i++)
            {
                //1a coluna: peso
                pesoValor[i,0] = alt.Next(MIN_PESO, MAX_PESO) % 8 + 1;
                //2coluna : valor
                pesoValor[i, 1] = alt.Next(MIN_PESO, MAX_PESO) % 10 + 1;
            }

            return pesoValor;
        }
    }
}
