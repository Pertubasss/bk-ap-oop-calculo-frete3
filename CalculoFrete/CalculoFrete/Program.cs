namespace CalculoFrete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a distância entre o distribuidor e o local de entrega (em km):");
            int distancia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso da encomenda (em kg):");
            int peso = int.Parse(Console.ReadLine());

            var frete = new Frete();
            double valorFrete = frete.CalcularFrete(distancia, peso);

            Console.WriteLine($"O valor do frete é: R${valorFrete:F2}");
        }
    }
}
