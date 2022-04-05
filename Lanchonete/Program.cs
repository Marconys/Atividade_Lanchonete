using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Lanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Produtos = { "Cachorro Quente", "X-Salada", "X-Bacon", "Refrigerante"};
            int[] Codigo = new int[] { 10, 13, 15, 17 };
            double[] Preco = new double[] { 10.00, 15.00, 20.00, 12.00 };
          

            Console.WriteLine("-----------------------------------\nFaça o Seu pedido\n-----------------------------------");

            for (int i = 0; i < Codigo.Length; i++)
            {
                Console.WriteLine("{0} {1} R$ {2}", Codigo[i], Produtos[i], Preco[i].ToString("F2", CultureInfo.InvariantCulture));
            }

            int Pedido = Convert.ToInt32(Console.ReadLine());
            




            Console.ReadKey();
        }
    }
}
