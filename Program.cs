using System;

namespace Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite aqui o seu salário: ");
            int salario = int.Parse(Console.ReadLine());

            if(salario <500){
                double reajuste = salario*1.30;
                Console.WriteLine("O seu salário sofreu um reajuste de 30%, o valor a ser sacado é de: " +reajuste);
            }

            if(salario >500){
                double reajuste = salario*1.30;
                Console.WriteLine("O seu salário não pode ser reajustado, pois ecede o valor tolerado!");
            }
        }
    }
}
