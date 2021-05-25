using System;


namespace ChequeEXtenso.ConsoleApp
{
    public class Unidade 
    {
        

        public string VerificaUnidade(string montagem, int c)
        {
            if (c == 1) montagem += "um";
            else if (c == 2) montagem += "dois";
            else if (c == 3) montagem += "três";
            else if (c == 4) montagem += "quatro";
            else if (c == 5) montagem += "cinco";
            else if (c == 6) montagem += "seis";
            else if (c == 7) montagem += "sete";
            else if (c == 8) montagem += "oito";
            else if (c == 9) montagem += "nove";
            return montagem;
        }
    }
}
