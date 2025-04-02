using static System.Net.Mime.MediaTypeNames;
using static RoboTupiniquim.ConsoleApp.Armazenamento;
using static RoboTupiniquim.ConsoleApp.ConversaoDeDados;
using static RoboTupiniquim.ConsoleApp.ResultadosEContinuar;
using static RoboTupiniquim.ConsoleApp.SolicitacaoDeDados;
using static RoboTupiniquim.ConsoleApp.ConversaoDeDados;
using static RoboTupiniquim.ConsoleApp.VerificacaoDeDados;
using static RoboTupiniquim.ConsoleApp.Robo;
using System.Xml;
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
                char[] direcoes = new char[] { 'N', 'L', 'S', 'O' };
                int quantosRobos;
                int tamanhoX, tamanhoY;

                string areastring = SolicitarArea();
                char[] areachar = StringParaCharArray(areastring);
                if (!VerificarArrayValido(areachar, 2))
                    continue;
                else if (!ConverterTextoInt(out tamanhoX, out tamanhoY, areachar))
                    continue;
                string quantosRobo = SolicitarQuantosRobos();
                if(!int.TryParse(quantosRobo, out  quantosRobos))
                {
                    Console.WriteLine("Número inválido, Retornando...");
                    Console.ReadLine();
                    continue;
                }
                Robo[] robos = new Robo[quantosRobos];
                    
                for (int contador = 0; contador < robos.Length; contador++)
                {
                    Robo robo = new Robo();
                    robos[contador] = robo;
                    QualRobo(contador + 1);
                    string posicoes = SolicitarPosicaoInicial();
                    char[] posicoeschar = StringParaCharArray(posicoes);
                    if (!VerificarArrayValido(posicoeschar, 3))
                    {
                        contador -= 1;
                        continue;
                    }

                    else if (!ConverterTextoInt(out robo.posicaoX, out robo.posicaoY, posicoeschar))
                    {
                        contador -= 1;
                        continue;
                    }
                    robo.direcaoAtual = CharArrayParaChar(posicoeschar);
                        
                    string movimentacaoRobo = SolicitarDirecoes();
                    char[] andar = StringParaCharArray(movimentacaoRobo);
                    if (!VerificarDirecoes(andar))
                    {
                        contador -= 1;
                        continue;
                    }
                    if (!robo.MovimentacaoRobo(movimentacaoRobo, direcoes, robo.direcaoAtual, andar, out robo.posicaoY, out robo.posicaoX, robo.posicaoX, robo.posicaoY))
                    {
                        Console.WriteLine("Comando Inválido, Retornando...");
                        {
                            contador -= 1;
                            continue;
                        }
                    }

                    if (FimDoMapa(tamanhoX, tamanhoY, robo.posicaoX, robo.posicaoY))
                    {
                        contador -= 1;
                        continue;
                    }

                }
                string[] resultado = ArmazenamentoPosicoes(robos);
                MostrarPosicoes(resultado);
                continuar = DesejaContinuar();
            } while (continuar);
        }

        public static void QualRobo(int i)
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"{i}° Robô");
            Console.WriteLine("--------------------------------------------");
        }
    }

}
