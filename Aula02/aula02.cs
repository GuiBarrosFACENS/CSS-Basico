using System;

namespace Aula02{
    class Principal{
        static void Main(string[] args){

            string x;
            float idade;

            Console.WriteLine("digite seu nome: ");
            x = Console.ReadLine();
            Console.WriteLine("Seu nome é: "+ x);

            Console.WriteLine("digite sua idade: ");
            idade = float.Parse(Console.ReadLine());
            Console.WriteLine("Sua idade é: "+ idade);



        }
    }
}
