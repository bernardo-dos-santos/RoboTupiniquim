using static System.Net.Mime.MediaTypeNames;

namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            do
            {
                Console.Clear();
                int contador = 0;
                char[] direcoes = new char[] { 'N', 'L', 'S', 'O' };
                int[] armazenamentoPosicaoFinal = new int[4];
                char[] armazenamentoDireçãoFinal = new char[2];
                int[] variaveisFinais = new int[4];
                char[] direcoesFinais = new char[2];
                int tamanhoX, tamanhoY , posicaoX = 0, posicaoY = 0;

                string areastring = SolicitarArea();
                char[] areachar = StringParaCharArray(areastring);
                VerificarArrayValido(areachar, 2);
                if (!ConverterTextoInt(out tamanhoX, out tamanhoY, areachar))
                    continue;
                while (contador < 2)
                {
                    string posicoes = SolicitarPosicaoInicial();
                    char[] posicoeschar = StringParaCharArray(posicoes);
                    VerificarArrayValido(posicoeschar, 3);
                    if (!ConverterTextoInt(out posicaoX, out posicaoY, posicoeschar))
                        continue;
                    char direcaoAtual = CharArrayParaChar(posicoeschar);

                    string movimentacaoRobo = SolicitarDirecoes();
                    char[] andar = StringParaCharArray(movimentacaoRobo);
                    MovimentacaoRobo(movimentacaoRobo, direcoes, direcaoAtual, andar, out posicaoY, out posicaoX, posicaoX, posicaoY);
                    if (FimDoMapa(tamanhoX, tamanhoY, posicaoX, posicaoY))
                        continue;                   
                    variaveisFinais = ArmazenarXY(posicaoX, posicaoY, contador,variaveisFinais );                    
                    direcoesFinais = ArmazenarDirecao(contador, direcaoAtual, direcoesFinais);
                    if (contador == 1)
                        MostrarPosicoes(direcoesFinais, variaveisFinais);
                    contador += 1;
                }
                    continuar = DesejaContinuar();


            } while (continuar);
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
                string movimentacaoRobo = Console.ReadLine()!.ToUpper();
                return movimentacaoRobo;
            }
            static bool ConverterTextoInt(out int tamanhoX,out int tamanhoY, char[] areachar )
            {
                string stringnumerox, stringnumeroy; 
                stringnumerox = areachar[0].ToString();
                stringnumeroy = areachar[1].ToString();
                bool ehnumero = int.TryParse(stringnumerox, out tamanhoX);
                ehnumero = int.TryParse(stringnumeroy, out tamanhoY);

                 if(ehnumero == false)
                    Console.WriteLine("Comando Inválido, Retornando");
                    Console.ReadLine();
                return ehnumero;

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
            static void MovimentacaoRobo(string movimentacaoRobo, char[] direcoes, char direcaoAtual, char[] andar, out int posicaoY, out int posicaoX, int numeroX, int numeroY)
            {
                bool direcaocorreta = false;
                int posicaoArray = 0;
                posicaoY = numeroY;
                posicaoX = numeroX;
                for (int i = 0; i < movimentacaoRobo.Length; i++)
                {
                    
                    for (int j = 0; j < direcoes.Length; j++)
                    {
                        if (direcoes[j] == direcaoAtual)
                        {
                            direcaoAtual = direcoes[j];
                            posicaoArray = j;
                            direcaocorreta = true;
                            continue;
                        }
                    }
                    if (direcaocorreta == false)
                    {                    
                        Console.WriteLine("Direção Inicial incorreta, Retornando...");
                        break;
                    }   

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
                    {
    
                    }

                }
            }
            static int[] ArmazenarXY( int posicaoX, int posicaoY, int contador, int[] variacaofinal)
            {
            
                if (contador == 0)
                {
                    variacaofinal[0] = posicaoX;
                    variacaofinal[1] = posicaoY;
                }
                else
                {
                    variacaofinal[2] = posicaoX;
                    variacaofinal[3] = posicaoY;
                }
            return variacaofinal;
            }
            static char[] ArmazenarDirecao(int contador, char direcaoAtual, char[] armazenamento)
            {
                if (contador == 0)
                {
                    armazenamento[0] = direcaoAtual;
                }
                else
                {
                    armazenamento[1] = direcaoAtual;
                }
            return armazenamento;
        }
            static void MostrarPosicoes(char[] posicoesFinais, int[] xyfinais)
            {
            Console.WriteLine($"A posição do primeiro robô é {xyfinais[0]} {xyfinais[1]} {posicoesFinais[0]}");
            Console.WriteLine($"A posição do segundo robô é {xyfinais[2]} {xyfinais[3]} {posicoesFinais[1]}");
        }
            static bool DesejaContinuar()
            {
                Console.WriteLine("Você Deseja Continuar? (s/n)");
                string continuar = Console.ReadLine()!.ToUpper();
                if (continuar != "S")
                    return false;
                return true;
            }
            static bool FimDoMapa(int tamanhoX, int tamanhoY, int posicaoX, int posicaoY)
            {
            if (posicaoX > tamanhoX || posicaoY > tamanhoY)
            {
                Console.WriteLine("O Robô chegou ao fim do mapa, não é possível continuar, retornando...");
                return true;
            }
            else
                return false;
            }
            
            static bool VerificarArrayValido(char[] array , int numeroarray)
            {
                if(array.Length < numeroarray)
                {
                    Console.WriteLine("Comando Inválido, Retornando...");
                    Console.ReadLine();
                    return false;
                }
                return true;
            }

            
        


        

    }
}
