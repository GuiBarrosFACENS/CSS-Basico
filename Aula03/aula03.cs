using System;
namespace Aula03{
    class aula03{
        static void Main(string[] args){
            /*
            int n1,n2,n3;
            n1=10; n2 =20; n3=30;
            Console.WriteLine("\nn1={0}\nn2={1}\nn3={2}",n1,n2,n3);
            */
            double ValorCompra=5.50;
            double ValorVenda;
            double lucro = 0.1;
            string produto = "Pastel";

            ValorVenda=ValorCompra+(ValorCompra*lucro);

            Console.WriteLine("Produto........: {0,15}", produto);
            Console.WriteLine("Val.Compra.....: {0,15:c}", ValorCompra);
            Console.WriteLine("Lucro..........: {0,15:p}", lucro);
            Console.WriteLine("Val.Venda......: {0,15:c}", ValorVenda);

        
        }
        
    }
}
