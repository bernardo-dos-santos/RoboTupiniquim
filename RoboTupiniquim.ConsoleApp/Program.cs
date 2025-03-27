namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite dois numeros, representando a área de pesquisa (Ex: 5 6) ");
                string areastring = Console.ReadLine()!;
                char[] areachar = new char[10];
                int tamanhoX = 0, tamanhoY = 0;
                string stringnumerox, stringnumeroy;
                bool ehnumero = true;
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
                stringnumerox = areachar[0].ToString();
                stringnumeroy = areachar[1].ToString();
                ehnumero = int.TryParse(stringnumerox, out tamanhoX);
                ehnumero = int.TryParse(stringnumeroy, out tamanhoY);

                if (ehnumero == false)
                {
                    Console.WriteLine("Comando Inválido, retornando ao início");
                    continue;
                }
                
               
                char[] direcoes = new char[] {'N', 'L', 'S', 'O' };

                Console.WriteLine("Digite dois numeros e uma letra, representando a posicao X, Y e Direção incial, respectivamente");
                Console.WriteLine("Ex: (1 2 L)");
                string posicoes = Console.ReadLine()!.ToUpper();
                char[] posicoeschar = new char[10];
                int posicaoX = 0, posicaoY = 0;
                string stringPosicaoX, stringPosicaoY;
                char direcaoInicial;
                bool saoNumeros = true;
                int numerobase2 = 0;
                for (int n = 0; n < posicoes.Length; n++)
                {
                    char atual = posicoes[n];
                    if(atual != ' ')
                    {
                        posicoeschar[numerobase2] = atual;
                        numerobase2++;
                    }
                }
                stringPosicaoX = posicoeschar[0].ToString();
                stringPosicaoY = posicoeschar[1].ToString();
                saoNumeros = int.TryParse(stringPosicaoX, out posicaoX);
                saoNumeros = int.TryParse(stringPosicaoY, out posicaoY);
                if (saoNumeros == false)
                {
                    Console.WriteLine("Comando(s) Inválido(s), retornando ao início");
                    continue;
                }
                direcaoInicial = posicoeschar[2];

                Console.WriteLine("Digite Comando para mexer o robô, as letras aceitas são: ");
                Console.WriteLine("E (Virar 90° a esquerda");
                Console.WriteLine("D (Virar 90° a direita");
                Console.WriteLine("M (andar para frente na direção colocada)");
                string movimentacaoRobo = Console.ReadLine()!;

                char[] andar = new char[movimentacaoRobo.Length];
                char letraAtual;
                for (int caracter = 0; caracter < andar.Length; caracter++)
                {
                    letraAtual = movimentacaoRobo[caracter];
                    andar[caracter] = letraAtual;
                }
                char direcaoAtual = direcaoInicial;
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
                        if(direcaocorreta == false)
                        Console.WriteLine("Direção Inicial incorreta, Retornando...");
                        
                        if (andar[i] == 'E')
                        {
                        posicaoArray = ArrayCircular(posicaoArray - 1, direcoes.Length );
                            direcaoAtual = direcoes[posicaoArray];
                        } else if (andar[i] == 'D')
                        {
                            posicaoArray = ArrayCircular(posicaoArray + 1, direcoes.Length);
                            direcaoAtual = direcoes[posicaoArray];

                        } else if (andar[i] == 'M')
                        {
                            if (direcaoAtual == 'N')
                            posicaoY += 1;
                            else if (direcaoAtual == 'S')
                            posicaoY -= 1;
                            else if (direcaoAtual == 'L')
                            posicaoX += 1;
                            else
                            posicaoX -= 1;
                                  
                        }else
                        Console.WriteLine("Comando Inválido, Digite apenas as letras E, D e M");
                    
                }

                Console.ReadLine();

            }

            static int ArrayCircular(int j, int tamanhoArray)
            {
                int teste = ((j % tamanhoArray) + tamanhoArray) % tamanhoArray;
                return teste;
            }
        }
    }
}
