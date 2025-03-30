namespace RoboTupiniquim.ConsoleApp
{
    public class ConversaoDeDados
    {
        public static bool ConverterTextoInt(out int tamanhoX, out int tamanhoY, char[] areachar)
        {
            string stringnumerox, stringnumeroy;
            stringnumerox = areachar[0].ToString();
            stringnumeroy = areachar[1].ToString();
            bool ehnumero = int.TryParse(stringnumerox, out tamanhoX);
            ehnumero = int.TryParse(stringnumeroy, out tamanhoY);
            if (ehnumero == false)
            {
                Console.WriteLine("Comando Inválido, Retornando...");
                Console.ReadLine();
            }
            return ehnumero;
        }
        public static char[] StringParaCharArray(string areastring)
        {
            char[] areachar = new char[areastring.Length];
            int numerobase = 0;
            for (int z = 0; z < areastring.Length; z++)
            {
                char atual = areastring[z];
                if (atual != ' ')
                {
                    areachar[numerobase] = atual;
                    numerobase++;
                }
            }
            return areachar;
        }
        public static char CharArrayParaChar(char[] posicoeschar)
        {
            char direcaoInicial;
            direcaoInicial = posicoeschar[2];
            return direcaoInicial;
        }
    }


}
