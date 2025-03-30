namespace RoboTupiniquim.ConsoleApp
{
    public class Armazenamento
    {
        public static int[] ArmazenarXY(int posicaoX, int posicaoY, int contador, int[] variacaofinal)
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
        public static char[] ArmazenarDirecao(int contador, char direcaoAtual, char[] armazenamento)
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
    }


}
