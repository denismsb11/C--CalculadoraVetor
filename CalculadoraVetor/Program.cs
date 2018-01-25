using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraVetor
{
    class Program
    {
        private static int sairPrograma;
        private static int saidaFunção;
   

        static void Main(string[] args)
        {
            void somaVetor()
            {
                int sairPrograma = 0;
                int saidaFunção = 0;

                Console.WriteLine("SOMA DE VETORES");
                Console.WriteLine("Digite o tamanho do vetor:");
                int tamanho = int.Parse(Console.ReadLine());

                int[] vetorA = new int[tamanho];
                int[] vetorB = new int[tamanho];

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorA[" + i + "]");
                    vetorA[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorB[" + i + "]");
                    vetorB[i] = int.Parse(Console.ReadLine());
                }

                int[] vetorResultado = new int[tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    vetorResultado[i] = vetorA[i] + vetorB[i];
                }

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorA[" + i + "] = " + vetorResultado[i]);
                }

            }

            void subVetor()
            {
                int sairPrograma = 0;
                int saidaFunção = 0;

                Console.WriteLine("SOMA DE VETORES");
                Console.WriteLine("Digite o tamanho do vetor:");
                int tamanho = int.Parse(Console.ReadLine());

                int[] vetorA = new int[tamanho];
                int[] vetorB = new int[tamanho];

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorA[" + i + "]");
                    vetorA[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorB[" + i + "]");
                    vetorB[i] = int.Parse(Console.ReadLine());
                }

                int[] vetorResultado = new int[tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    vetorResultado[i] = vetorA[i] - vetorB[i];
                }

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorA[" + i + "] = " + vetorResultado[i]);
                }

            }

            void mulVetor()
            {
                int sairPrograma = 0;
                int saidaFunção = 0;

                Console.WriteLine("SOMA DE VETORES");
                Console.WriteLine("Digite o tamanho do vetor:");
                int tamanho = int.Parse(Console.ReadLine());

                int[] vetorA = new int[tamanho];
                int[] vetorB = new int[tamanho];

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorA[" + i + "]");
                    vetorA[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorB[" + i + "]");
                    vetorB[i] = int.Parse(Console.ReadLine());
                }

                int[] vetorResultado = new int[tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    vetorResultado[i] = vetorA[i] * vetorB[i];
                }

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorA[" + i + "] = " + vetorResultado[i]);
                }

            }

            void mulConsVetor()
            {
                int sairPrograma = 0;
                int saidaFunção = 0;

                Console.WriteLine("SOMA DE VETORES");
                Console.WriteLine("Digite o tamanho do vetor:");
                int tamanho = int.Parse(Console.ReadLine());

                int[] vetorA = new int[tamanho];
                int[] vetorB = new int[tamanho];

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorA[" + i + "]");
                    vetorA[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Digite o valor da constante:");
                int constante = int.Parse(Console.ReadLine());


                int[] vetorResultado = new int[tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    vetorResultado[i] = vetorA[i] * constante;
                }

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorA[" + i + "] = " + vetorResultado[i]);
                }
            }

            void divVetor()
            {
                int sairPrograma = 0;
                int saidaFunção = 0;

                Console.WriteLine("SOMA DE VETORES");
                Console.WriteLine("Digite o tamanho do vetor:");
                int tamanho = int.Parse(Console.ReadLine());

                int[] vetorA = new int[tamanho];
                int[] vetorB = new int[tamanho];

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorA[" + i + "]");
                    vetorA[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorB[" + i + "]");
                    vetorB[i] = int.Parse(Console.ReadLine());
                }

                int[] vetorResultado = new int[tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    vetorResultado[i] = vetorA[i] / vetorB[i];
                }

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("vetorA[" + i + "] = " + vetorResultado[i]);
                }

            } 

            int menu()
            {
                Console.WriteLine("\n\n===== CALCULADORA DE VETORES =====\n");
                Console.WriteLine("Escolha uma das operações abaixo:");
                Console.WriteLine("(1) SOMA");
                Console.WriteLine("(2) SUBTRAÇÃO");
                Console.WriteLine("(3) MULTIPLICAÇÃO COM CONSTANTE");
                Console.WriteLine("(4) MULTIPLICAÇÃO");
                Console.WriteLine("(5) DIVISAO");
                Console.WriteLine("(0) SAIR DO PROGRAMA");
                Console.WriteLine("\n===================================\n");
                return int.Parse(Console.ReadLine());
            }

            void decisoes(int decisao)
            {
                switch (decisao)
                {
                    case 1:
                        somaVetor();
                        break;
                    case 2:
                        subVetor();
                        break;
                    case 3:
                        mulVetor();
                        break;
                    case 4:
                        mulConsVetor();
                        break;
                    case 5:
                        divVetor();
                        break;
                    case 0:
                        sairPrograma = 1;
                        break;
                }
            }

 
            while (sairPrograma == 0)
            {
                int escolha = menu();
                decisoes(escolha);
            }

        }
    }
}
