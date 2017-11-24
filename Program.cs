using lambda;
using System;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Func<int,int,double> total = Atividade.subtrair; 
            System.Console.WriteLine(total(10,45));
            Func<int,int,string> sdg = Atividade.Multiplicar;
            System.Console.WriteLine(sdg(23,4));
           
            Data dt = delegate(string msg){return msg+" batata ~ "+DateTime.Now;};
            System.Console.WriteLine(dt("lksa")); */

            int[] valores = {34,34,54,1,46,76,34,65,23};
            


            /* Func<int,bool> rs = delegate(int x){return x % 2 == 0;};
            

            foreach(var i in valores)
                if(rs(i))
                    System.Console.WriteLine(i); */
        



            /* Func<int,bool> rs = x => x % 2 == 0;
            

            foreach(var i in valores)
                if(rs(i))
                    System.Console.WriteLine(i); */

            Func<double,double,double> calculo = (x,y) => x/y;
            Console.WriteLine(calculo(31,43));
        }
        
        static bool par(int v){
            return v%2==0;
        }

        delegate string Data(string mensagem);

    }
}
