namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                char[] direcoes = new char[] { 'N', 'L', 'S', 'O' };
                string areastring = SolicitarArea();
                int tamanhoX, tamanhoY;
                char[] areachar = StringParaCharArray(areastring);
                ConverterTextoInt(out tamanhoX, out tamanhoX, areachar);

                //if (ehnumero == false)
                //{
                //Console.WriteLine("Comando Inválido, retornando ao início");
                //continue;
                //}



                string posicoes = SolicitarPosicaoInicial();
                int posicaoX = 0, posicaoY = 0;
                char[] posicoeschar = StringParaCharArray(posicoes);
                ConverterTextoInt(out posicaoX, out posicaoY, posicoeschar);
                char direcaoAtual = CharArrayParaUmChar(posicoeschar);


                string movimentacaoRobo = SolicitarDirecoes();
                char[] andar = StringParaCharArray(movimentacaoRobo);
                MovimentacaoRobo(movimentacaoRobo, direcoes, direcaoAtual, andar, posicaoY, posicaoX);



                Console.ReadLine();

            }
        }

            public static int ArrayCircular(int j, int tamanhoArray)
            {
                int teste = ((j % tamanhoArray) + tamanhoArray) % tamanhoArray;
                return teste;
            }

            static string SolicitarArea()
            {
                Console.Write("Digite dois numeros, representando a área de pesquisa (Ex: 5 6) ");
                string areastring = Console.ReadLine()!;
                return areastring;
            }
            static string SolicitarPosicaoInicial()
            {
                Console.WriteLine();
                Console.WriteLine("Digite dois numeros e uma letra, representando a posicao X, Y e Direção incial, respectivamente");
                Console.WriteLine("Ex: (1 2 L)");
                string posicoes = Console.ReadLine()!.ToUpper();
                return posicoes;
            }
            static string SolicitarDirecoes()
            {
                Console.WriteLine("Digite Comando para mexer o robô, as letras aceitas são: ");
                Console.WriteLine("E (Virar 90° a esquerda");
                Console.WriteLine("D (Virar 90° a direita");
                Console.WriteLine("M (andar para frente na direção colocada)");
                string movimentacaoRobo = Console.ReadLine()!;
                return movimentacaoRobo;
            }
            static void ConverterTextoInt(out int tamanhoX,out int tamanhoY, char[] areachar )
            {
                string stringnumerox, stringnumeroy;
                stringnumerox = areachar[0].ToString();
                stringnumeroy = areachar[1].ToString();
                int.TryParse(stringnumerox, out tamanhoX);
                int.TryParse(stringnumeroy, out tamanhoY);
            }
            static char[] StringParaCharArray(string areastring)
            {
                char[] areachar = new char[areastring.Length];
                int numerobase = 0;
                for (int z = 0; z < areastring.Length; z++)
                {

                    char atual = areastring[z];
                    if (atual != ' ')
                    {
                        areachar[numerobase] = atual;
                        numerobase++;
                    }
                }
                return areachar;
            }
            static char CharArrayParaChar(char[] posicoeschar)
            {
                char direcaoInicial;
                direcaoInicial = posicoeschar[2];
                return direcaoInicial;
            }
            static void MovimentacaoRobo(string movimentacaoRobo, char[] direcoes, char direcaoAtual, char[] andar, int posicaoY, int posicaoX)
            {
                bool direcaocorreta = false;
                int posicaoArray = 0;
                for (int i = 0; i < movimentacaoRobo.Length; i++)
                {
                    for (int j = 0; j < direcoes.Length; j++)
                    {
                        if (direcoes[j] == direcaoAtual)
                        {
                            direcaoAtual = direcoes[j];
                            posicaoArray = j;
                            direcaocorreta = true;
                        }
                    }
                    if (direcaocorreta == false)
                        Console.WriteLine("Direção Inicial incorreta, Retornando...");

                    if (andar[i] == 'E')
                    {
                        posicaoArray = ArrayCircular(posicaoArray - 1, direcoes.Length);
                        direcaoAtual = direcoes[posicaoArray];
                    }
                    else if (andar[i] == 'D')
                    {
                        posicaoArray = ArrayCircular(posicaoArray + 1, direcoes.Length);
                        direcaoAtual = direcoes[posicaoArray];

                    }
                    else if (andar[i] == 'M')
                    {
                        if (direcaoAtual == 'N')
                            posicaoY += 1;
                        else if (direcaoAtual == 'S')
                            posicaoY -= 1;
                        else if (direcaoAtual == 'L')
                            posicaoX += 1;
                        else
                            posicaoX -= 1;

                    }
                    else
                        Console.WriteLine("Comando Inválido, Digite apenas as letras E, D e M");

                }
            }
        }
    }
}
