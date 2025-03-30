using static System.Net.Mime.MediaTypeNames;
using static RoboTupiniquim.ConsoleApp.Armazenamento;
using static RoboTupiniquim.ConsoleApp.ConversaoDeDados;
using static RoboTupiniquim.ConsoleApp.ResultadosEContinuar;
using static RoboTupiniquim.ConsoleApp.SolicitacaoDeDados;
using static RoboTupiniquim.ConsoleApp.ConversaoDeDados;
using static RoboTupiniquim.ConsoleApp.VerificacaoDeDados;
using static RoboTupiniquim.ConsoleApp.RoboTupiniquim;
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
                if (!VerificarArrayValido(areachar, 2))
                    continue;
                else if (!ConverterTextoInt(out tamanhoX, out tamanhoY, areachar))
                    continue;
                    while (contador < 2)
                    {
                        QualRobo(contador);
                        string posicoes = SolicitarPosicaoInicial();
                        char[] posicoeschar = StringParaCharArray(posicoes);
                        if (!VerificarArrayValido(posicoeschar, 3))
                            continue;
                        else if (!ConverterTextoInt(out posicaoX, out posicaoY, posicoeschar))
                            continue;
                        char direcaoAtual = CharArrayParaChar(posicoeschar);
                        
                        string movimentacaoRobo = SolicitarDirecoes();
                        char[] andar = StringParaCharArray(movimentacaoRobo);
                        if (!VerificarDirecoes(andar))
                        continue;
                        if (!MovimentacaoRobo(movimentacaoRobo, direcoes, direcaoAtual, andar, out posicaoY, out posicaoX, posicaoX, posicaoY))
                        continue;
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
    }

}
