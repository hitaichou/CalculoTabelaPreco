using System;

namespace CalculoTabelaPreco
{
    class Program
    {
        static void Main(string[] args)
        {
            double vTotal;

            CalculoPreco cp = new CalculoPreco();

            Console.WriteLine("Entre com o código do lanche e quantidade:");
            string[] vet = Console.ReadLine().Split();
            int vCodigo = int.Parse(vet[0]);
            int vQtd = int.Parse(vet[1]);

            if (vCodigo == 1)
            {
                vTotal = cp.CalculoCachorroQuente(vQtd);
                Console.WriteLine("Total: " + vTotal.ToString("F2"));
            }
            else if (vCodigo == 2)
            {
                vTotal = cp.CalculoXsalada(vQtd);
                Console.WriteLine("Total: " + vTotal.ToString("F2"));
            }
            else if (vCodigo == 3)
            {
                vTotal = cp.CalculoXBacon(vQtd);
                Console.WriteLine("Total: " + vTotal.ToString("F2"));
            }
            else if (vCodigo == 4)
            {
                vTotal = cp.CalculoTorradaSimples(vQtd);
                Console.WriteLine("Total: " + vTotal.ToString("F2"));
            }
            else if (vCodigo == 5)
            {
                vTotal = cp.CalculoRefrigerante(vQtd);
                Console.WriteLine("Total: " + vTotal.ToString("F2"));
            }
            else
                Console.WriteLine("Codigo não existente");



        }
    }
}
