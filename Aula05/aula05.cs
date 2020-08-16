using System;

namespace aula05{
    class aula05{
        static void Main(string[] args){
            //vetor
            int[] n = new int[3]{11,22,33};

            for(int i=0;i<n.Length;i++){
                Console.WriteLine(n[i]);
            }

            Console.WriteLine("\n=========================\n");

            foreach(int num in n){
                Console.WriteLine(num);
            }

        }
    }
}
