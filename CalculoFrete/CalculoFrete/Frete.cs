namespace CalculoFrete
{
    public class Frete
    {
        public static double CalcularFrete(int distancia, int peso)
        {
            double valorFrete = 0.1 * distancia;

            valorFrete += (distancia / 200) * 1;

            valorFrete += (distancia / 1000) * 10;

            if (peso > 5 && peso <= 25)
            {
                valorFrete *= 5;
            }
            else if (peso > 25 && peso <= 75)
            {
                valorFrete *= 3;
            }

            return valorFrete;
        }
    }
}
