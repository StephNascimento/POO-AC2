using System;
using System.Collections.Generic;
using System.Globalization;

namespace ATV_EXER2_16._11._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();
            Console.WriteLine("Entre com o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            //for para entrada de dados
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nFuncionário #{i}: ");
                Console.Write("Tercerizado (S/N)? ");
                char ch = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor das horas: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'S')
                {
                    Console.Write("Adicional: ");
                    double adicional = double.Parse(Console.ReadLine());
                    //Adicionando funcionário tercerizado na lista
                    list.Add(new Tercerizado(nome, horas, valor, adicional));
                }
                //Adicionando funcionário na lista
                list.Add(new Funcionario(nome, horas, valor));
            }

            //Imprime os pagamentos de cada funcionário
            Console.WriteLine("\nPagamentos: ");
            foreach(Funcionario func in list)
            {
                Console.WriteLine("Funcionário: " + func.Nome + " - R$" + 
                    func.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
