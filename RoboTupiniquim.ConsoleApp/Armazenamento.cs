namespace RoboTupiniquim.ConsoleApp
{
    public class Armazenamento
    {
        public static string[] ArmazenamentoPosicoes(Robo[] robos)
        {
            string[] resultados = new string[robos.Length];
            for(int contador = 0; contador < robos.Length; contador++)
            {
                resultados[contador] = (contador + 1) + "° robô: " + robos[contador].posicaoX.ToString()+ " " + robos[contador].posicaoY.ToString() + " " + robos[contador].direcaoAtual.ToString();
            }
            return resultados;              
        }
    }


}
