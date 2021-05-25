using System;

namespace ChequeEXtenso.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Numero numeroClasse = new Numero();
            Unidade unidadeClasse = new Unidade();
            Dezena dezenaClasse = new Dezena();
            Centena centenaClasse = new Centena();
            VerificaPlural plural = new VerificaPlural();
            Base base1 = new Base(numeroClasse, unidadeClasse, centenaClasse, dezenaClasse, plural);

            while (true)
            {
                try
                {
                    Console.Write("Digite um número para ser escrito por extenso: ");
                    decimal valor = Convert.ToDecimal(Console.ReadLine());

                    base1.ToExtenso(valor);
                    Console.WriteLine(base1.ToExtenso(valor));
                    Console.ResetColor();
                    Console.ReadLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
                Console.Clear();  
            }
        }
    }
}
