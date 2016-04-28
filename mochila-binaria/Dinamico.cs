using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mochila_binaria
{
    public class Dinamico
    {
        private double valor_total;
        private double tempo_execucao;
        private Double[,] itens;
        private int qtd_capacidade_mochila;
        private int qtd_produtos_loja;

        public void solucionar(int num_itens)
        {
            Itens = Extras.gerarPesoValor(num_itens);

            int[] a = new int[60000];
            int[] inserir = new int[60000];
            int aux = 0;

            if (qtd_capacidade_mochila >= 10 && qtd_capacidade_mochila <= 20)
            {
                for (int i = 0; i <= qtd_capacidade_mochila; ++i)
                {
                    a[i] = 0;
                    inserir[i] = -1;
                }
                a[0] = 0;
                //começa a calcular a quantidade de itens na loja
                for (int i = 1; i <= qtd_capacidade_mochila; ++i)
                {
                    for (int j = 0; j < Itens.GetLength(0); ++j)
                    {
                        if ((peso[j] <= i) && (a[i] < a[i - peso[j]] + valor[j]))
                        {
                            a[i] = a[i - peso[j]] + valor[j];
                            inserir[i] = j;
                        }
                    }
                }
                aux = capMochila;
                while ((aux > 0) && (inserir[aux] != -1))
                    aux -= peso[inserir[aux]];
                MessageBox.Show("Valor total carregado na Mochila R$ " + a[capMochila] + ".", "Algoritmo Dinâmico - Solução Dinâmica",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A capacidade da Mochila é imcompatível!\nA capacidade deve ser entre 10 a 20.",
                    "Capacidade Incompatível", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Dinamico()
        {

        }

        public Dinamico(int qtd_capacidade_mochila, int qtd_produtos_loja)
        {

        }
        
        public double Valor_total
        {
            get
            {
                return valor_total;
            }

            set
            {
                valor_total = value;
            }
        }

        public double Tempo_execucao
        {
            get
            {
                return tempo_execucao;
            }

            set
            {
                tempo_execucao = value;
            }
        }

        public int Qtd_capacidade_mochila
        {
            get
            {
                return qtd_capacidade_mochila;
            }

            set
            {
                qtd_capacidade_mochila = value;
            }
        }

        public int Qtd_produtos_loja
        {
            get
            {
                return qtd_produtos_loja;
            }

            set
            {
                qtd_produtos_loja = value;
            }
        }

        public double[,] Itens
        {
            get
            {
                return itens;
            }

            set
            {
                itens = value;
            }
        }
    }
}
