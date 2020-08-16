using System;

namespace Aula08{
    class aula08{
        static void Main(string[] args){

            int dendo,dsor,quoc,rest; // dividendo, divisor,quociente, resto
            dendo=10;
            dsor=5;
            quoc=divide(dendo,dsor,out rest);

            Console.WriteLine("{0} / {1} = quociente = {2} e resto = {3}",dendo,dsor,quoc,rest);

            // outro codígo, PARANS, deixa voce inicializar vetor com ou sem numeros, n tem que passar qnts tem!!!

            soma(10,5,2,4);


            
        }
        //retorna 2 coisas, OUT INT RESTO
        static int divide(int dividendo, int divisor,out int resto){  // resto retorna sem return
            int quociente;
            quociente=dividendo/divisor;
            resto = dividendo%divisor;
            return quociente;
        }

        //PARANS FUNCIONANDO!!!
        static void soma(params int[]n){
            int res=0;
            if(n.Length < 1){ // se o tamanho da vetor for menor do que 1...
                Console.WriteLine("Não existem valoresa serem somado");
            }else if(n.Length < 2 ){
                Console.WriteLine("Valores insufientes para soma!"); 
            }else{
                for(int i=0;i<n.Length;i++){
                    res+=n[i];
                }
            }

            Console.WriteLine("Soma Total:{0}",res);
        


        }


    }
}
