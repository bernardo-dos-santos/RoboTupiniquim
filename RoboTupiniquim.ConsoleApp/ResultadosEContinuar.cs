namespace RoboTupiniquim.ConsoleApp
{
    public class ResultadosEContinuar
    {
        public static void MostrarPosicoes(char[] posicoesFinais, int[] xyfinais)
        {
            Console.WriteLine($"A posição do primeiro robô é {xyfinais[0]} {xyfinais[1]} {posicoesFinais[0]}");
            Console.WriteLine($"A posição do segundo robô é {xyfinais[2]} {xyfinais[3]} {posicoesFinais[1]}");
        }
        public static bool DesejaContinuar()
        {
            Console.WriteLine("Você Deseja Continuar? (s/n)");
            string continuar = Console.ReadLine()!.ToUpper();
            if (continuar != "S")
                return false;
            return true;
        }
    }


}
