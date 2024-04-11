using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 130;
            double n2 = 8;
            Calculadora calc = new Calculadora("Casio", "fx-50");
            MostrarTipo(calc);
            Console.Write("La suma es: "); double total = calc.Sumar(n1, n2);
            Console.WriteLine(total);
            Console.Write("La resta es: "); double diferencia = calc.Restar(n1, n2);
            Console.WriteLine(diferencia);
            Console.Write("La multiplicación es: ");  double multiplicar = calc.Multiplicar(n1, n2);
            Console.WriteLine(multiplicar);
            Console.Write("La división es: ");  double division = calc.Dividir (n1, n2);
            Console.WriteLine(division);


            CalculadoraCientifica cientifica = new CalculadoraCientifica("X", "fx-89");
            MostrarTipo(cientifica);
            Console.Write("La potencia es: ");  double potencia = cientifica.Potencia(n1, n2);
            Console.WriteLine(potencia);
            Console.Write("La raíz es: ");  double raiz= cientifica.Raiz(n1);
            Console.WriteLine(raiz);
            Console.Write("El residuo de la división es: ");  double modulo = cientifica.Modulo(n1, n2);
            Console.WriteLine(modulo);
            Console.Write("El resultado del logaritmo es: "); double logaritmo = cientifica.Logaritmo (n1, n2);
            Console.WriteLine(logaritmo);

            Console.ReadLine();

        }

        public static void MostrarTipo(Calculadora calculadora)
        {
            Console.WriteLine(calculadora.Tipo());
        }

    }

    internal class CalculadoraCientifica : Calculadora 
    {

        public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
        {
        }

        public double Potencia(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }

        public double Raiz(double n1)
        {
            return Math.Sqrt(n1);
        }

        public double Modulo(double n1, double n2)
        {
            return n1 % n2;
        }

        public double Logaritmo(double n1, double n2)
        {
            return Math.Log(n1, n2);   
        }

        public override string Tipo()
        {
            return "Calculadora Científica";
        }
    }

    public class Calculadora
    {
        public string Marca { get; set; }

        public string Serie { get; set; }   

        public Calculadora(string marca, string serie)
        {
            Marca = marca;
            Serie = Serie;

        }

        public double Sumar (double n1, double n2)
        {
            return n1 + n2;
        }

        public double Restar (double n1, double n2) 
        {
            return n1 - n2;
        }

        public double Multiplicar(double n1, double n2) {  return n1 * n2; }

        public double Dividir(double n1, double n2)
        {
            return n1 / n2;      
        }

        public virtual string Tipo()
        {
            return "Calculadora básica";
        }
    }
}
