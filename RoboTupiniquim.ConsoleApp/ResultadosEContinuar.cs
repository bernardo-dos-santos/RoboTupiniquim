namespace RoboTupiniquim.ConsoleApp
{
    public class ResultadosEContinuar
    {
        public static void MostrarPosicoes(string[] resultados)
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            foreach (var item in resultados)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------");
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
