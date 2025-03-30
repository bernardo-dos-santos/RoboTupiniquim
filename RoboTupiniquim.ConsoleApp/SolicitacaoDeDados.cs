namespace RoboTupiniquim.ConsoleApp
{
    public class SolicitacaoDeDados
    {
        public static string SolicitarArea()
        {
            Console.Write("Digite dois numeros, representando a área de pesquisa (Ex: 5 6) ");
            string areastring = Console.ReadLine()!;
            return areastring;
        }
        public static string SolicitarPosicaoInicial()
        {
            Console.WriteLine();
            Console.WriteLine("Digite dois numeros e uma letra, representando a posicao X, Y e Direção incial, respectivamente");
            Console.WriteLine("Ex: (1 2 L)");
            string posicoes = Console.ReadLine()!.ToUpper();
            return posicoes;
        }
        public static string SolicitarDirecoes()
        {
            Console.WriteLine("Digite Comando para mexer o robô, as letras aceitas são: ");
            Console.WriteLine("E (Virar 90° a esquerda");
            Console.WriteLine("D (Virar 90° a direita");
            Console.WriteLine("M (andar para frente na direção colocada)");
            string movimentacaoRobo = Console.ReadLine()!.ToUpper();
            return movimentacaoRobo;
        }
    }


}
