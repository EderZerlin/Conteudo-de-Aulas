using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            calcular c = new calcular();

            Console.WriteLine("Digite o valor inicial: ");
            c.valorInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de parcelas: ");
            c.qtdParcelas = int.Parse(Console.ReadLine());

            Console.WriteLine("O valor das parcelas é: " + c.calcularParcelas());

            Console.ReadKey();
        }
    }

    public class Calcular
    {
        public double valorInicial, resultado;
        public int qtdParcelas;

        public double calcularParcelas()
        {
            resultado = valorInicial / qtdParcelas;

            if (qtdParcelas > 5)
            {
                resultado = resultado + resultado * (1 / 100);
            }

            return resultado;
        }
    }
}
