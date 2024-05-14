

using System.ComponentModel.DataAnnotations;

namespace CalculoFrete
{
    public class Frete
    {
        //double valorFrete;

        public static double CalcularFrete(int distancia, int peso)
        {
            double valorFrete = 0.1 * distancia;

            valorFrete += Calc200km(distancia);
            valorFrete += Calc1000km(distancia);
            valorFrete = CalcPeso(peso, valorFrete);

            return valorFrete;
        }

        private static double CalcPeso(int peso, double valorFrete)
        {
            if (peso >= 5 && peso <= 25)
            {
                return valorFrete *= 5;
            }
            else if (peso >= 25 && peso <= 75)
            {
                return valorFrete *= 3;
            }

            return valorFrete;
        }

        private static double Calc1000km(int distancia)
        {
            return (distancia / 1000) * 10;
        }

        private static double Calc200km(int distancia)
        {
            return (distancia / 200) * 1;
        }
    }
}


