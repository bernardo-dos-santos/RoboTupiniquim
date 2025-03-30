namespace RoboTupiniquim.ConsoleApp
{
    public class RoboTupiniquim
    {
        public static int ArrayCircular(int j, int tamanhoArray)
        {
            int teste = ((j % tamanhoArray) + tamanhoArray) % tamanhoArray;
            return teste;
        }
        public static bool MovimentacaoRobo(string movimentacaoRobo, char[] direcoes, char direcaoAtual, char[] andar, out int posicaoY, out int posicaoX, int numeroX, int numeroY)
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
                    return false;
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
                    Console.WriteLine("Direção solicitada incorreta, Retornando...");
                    return false;
                }

            }
            return true;
        }
        public static void QualRobo(int contador)
        {
            Console.WriteLine();
            if (contador == 0)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Primeiro Robô");
                Console.WriteLine("--------------------------------------------");
            }
            else
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Segundo Robô");
                Console.WriteLine("--------------------------------------------");
            }

        }

    }


}
