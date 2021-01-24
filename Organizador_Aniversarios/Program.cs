using System;
using System.Globalization;

namespace Organizador_Aniversarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = null;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Data de Aniversário: (dia/mês/ano) ");
            string dataUsuario = Console.ReadLine();

            DateTime data = DateTime.ParseExact(dataUsuario, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Aniversariante pessoa = new Aniversariante(nome, data);

            Console.WriteLine("\n" + pessoa);
        }
    }
}
