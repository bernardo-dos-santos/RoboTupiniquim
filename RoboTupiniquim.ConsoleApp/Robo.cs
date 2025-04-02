namespace RoboTupiniquim.ConsoleApp
{
    public class Robo
    {
        public int posicaoX, posicaoY;
        public char direcaoAtual;

        public int ArrayCircular(int j, int tamanhoArray)
        {
            int teste = ((j % tamanhoArray) + tamanhoArray) % tamanhoArray;
            return teste;
        }
        public bool MovimentacaoRobo(string movimentacaoRobo, char[] direcoes, char direcaoAtual, char[] andar, out int posicaoY, out int posicaoX, int numeroX, int numeroY)
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
                    return false;
                }

            }
            return true;
        }


    }


}
