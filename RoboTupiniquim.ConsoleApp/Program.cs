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
                int N, S, L, O;
                 N = 10;
                 S = 10;
                 L = 8;
                 O = 8;
                int posicaoRoboInicialX = 1;
                int posicaoRoboInicialY = 2;
                char direcaoInicial = 'N';

                string teste = "EDMEDMEDMEDM";

                char[] direcoes = new char[teste.Length];

                for (int i = 0; i < teste.Length; i++)
                {
                    if (direcoes[i] == 'E')
                    {

                    } else if (direcoes[i] == 'D')
                    {

                    } else if (direcoes[i] == 'M')
                    {

                    } else
                        Console.WriteLine("Comando Inválido, Digite apenas as letras E, D e M");
                        
                }



            }
        }
    }
}
