using System;
using System.Globalization;

namespace Organizador_Aniversarios
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c = true;

            while (c)
            {
                string nome = null;

                Console.Write("\nNome: ");
                nome = Console.ReadLine();

                Console.Write("Data de Aniversário: (dia/mês/ano) ");
                string dataUsuario = Console.ReadLine();

                DateTime data = DateTime.ParseExact(dataUsuario, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Aniversariante pessoa = new Aniversariante(nome, data);

                Console.WriteLine("\n" + pessoa);


                // .......................... Repetir? ............................

                Console.Write("\n......................... \n\nMais uma?(sim/não) ");

                if (Console.ReadLine() == "sim")
                {
                    c = true;
                }
                else
                {
                    c = false;
                }
            }
        }
    }
}
