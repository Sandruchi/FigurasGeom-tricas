using System;

namespace FigurasGeometricas
{
    // Clase para representar un Círculo
    public class Circulo
    {
        // Propiedad privada para almacenar el radio
        private double radio;

        // Constructor para inicializar el radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área de un círculo
        // Devuelve el resultado como double
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método para calcular el perímetro (circunferencia) del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase para representar un Rectángulo
    public class Rectangulo
    {
        // Propiedades privadas para la base y la altura
        private double baseRect;
        private double altura;

        // Constructor para inicializar la base y la altura
        public Rectangulo(double baseRect, double altura)
        {
            this.baseRect = baseRect;
            this.altura = altura;
        }

        // Método para calcular el área del rectángulo
        public double CalcularArea()
        {
            return baseRect * altura;
        }

        // Método para calcular el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }
    }

    // Clase principal para probar las figuras
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un círculo con radio 5
            Circulo c = new Circulo(5);
            Console.WriteLine("Área del círculo: " + c.CalcularArea());
            Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

            // Crear un rectángulo con base 4 y altura 6
            Rectangulo r = new Rectangulo(4, 6);
            Console.WriteLine("Área del rectángulo: " + r.CalcularArea());
            Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro());
        }
    }
}
