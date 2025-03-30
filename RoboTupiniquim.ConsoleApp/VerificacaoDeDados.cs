namespace RoboTupiniquim.ConsoleApp
{
    public class VerificacaoDeDados
    {
        public static bool FimDoMapa(int tamanhoX, int tamanhoY, int posicaoX, int posicaoY)
        {
            if (posicaoX > tamanhoX || posicaoY > tamanhoY || posicaoX < 0 || posicaoY < 0)
            { 
                Console.WriteLine("O Robô chegou ao fim do mapa, não é possível continuar, retornando...");
                return true;
            }
            else
                return false;
        }
        public static bool VerificarArrayValido(char[] array, int numeroarray)
        {
            if (array.Length < numeroarray)
            {
                Console.WriteLine("Comando Inválido, Retornando...");
                Console.ReadLine();
                return false;
            }
            return true;
        }
        public static bool VerificarDirecoes(char[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] != 'E' && c[i] != 'D' && c[i] != 'M')
                {
                    Console.WriteLine("Direções Inválidas, Digite Novamente");
                    Console.ReadLine();
                    return false;
                }

            }
            return true;
        }
    }


}
