namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int areaX, areaY;
                areaX = 5;
                areaY = 5;
                char[] direcoes = new char[] {'N', 'L', 'S', 'O' };
        
                int posicaoRoboX = 3;
                int posicaoRoboY = 3;
                char direcaoInicial = 'L';

                string teste = "MMDMMDMDDM";

                char[] andar = new char[teste.Length];
                char letraAtual;
                for (int caracter = 0; caracter < andar.Length; caracter++)
                {
                    letraAtual = teste[caracter];
                    andar[caracter] = letraAtual;
                }
                char direcaoAtual = direcaoInicial;
                bool direcaocorreta = false;
                int posicaoArray = 0;
                for (int i = 0; i < teste.Length; i++)
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
                            posicaoRoboY += 1;
                            else if (direcaoAtual == 'S')
                            posicaoRoboY -= 1;
                            else if (direcaoAtual == 'L')
                            posicaoRoboX += 1;
                            else
                            posicaoRoboX -= 1;
                                  
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
