using System;

namespace FunçãoSRSA
{
    class Program
    {
        static void Main(string[] args)
        {
           minhaData();
        }

        /// <summary>
        /// Essa função exibe na tela do terminal a data e a hora do sistema
        /// </summary>
        static void minhaData(){
            Console.WriteLine(DateTime.Now);//Mostra a data e a hora
        }
    }
}
