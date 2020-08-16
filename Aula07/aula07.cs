using System;

namespace Aula07{
    class aula07{
        static void Main(string[] args){
            
            int v1,v2,r;
            Console.WriteLine("Digite os 2 numeros");
            v1=Convert.ToInt32(Console.ReadLine());
            v2=Convert.ToInt32(Console.ReadLine());

            r=soma(v1,v2);
            Console.WriteLine("A soma de {0}+{1} é: {2}",v1,v2,r);

        }
        static int soma(int n1,int n2){
            int res=n1+n2;
            return res;
            
        }

    }
}
