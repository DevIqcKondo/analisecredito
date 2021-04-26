using System;

namespace analisecredito
{
    class Program
    {
        static void Main(string[] args)
        {
            double emprestimo=0;
            int parc=0;
            double renMen=0;
            double y=0;
            double x=0;

            Console.WriteLine("Para solicitar o seu empréstimo, tecle ENTER!");
            Console.ReadKey();

            Console.Write("Informe sua renda mensal: ");
            renMen=Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do empréstimo: ");
            emprestimo=Convert.ToDouble(Console.ReadLine());

            Console.Write("Deseja parcelar o valor em quantas vezes? ");
            parc=Convert.ToInt32(Console.ReadLine());


            y=emprestimo/parc;
            x=(renMen*30)/100;
            x= renMen-x;

            if(emprestimo<=x){
                Console.ForegroundColor=ConsoleColor.DarkGreen;
                Console.WriteLine("Seu empréstimo foi aprovado.");
                Console.Write("O valor do empréstimo é de R$"+emprestimo);
                Console.Write(" parcelado em "+parc);
                Console.Write(" vezes de "+y);
                Console.WriteLine();
                Console.ResetColor();
            } else {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("Infelizmente seu empréstimo não foi aprovado");
                Console.ResetColor();
            }
            
            
            

        }
    }
}
