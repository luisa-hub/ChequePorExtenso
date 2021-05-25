

namespace ChequeEXtenso.ConsoleApp
{
    public class Centena
    {
        public string VerificaCentena(string montagem, int a, int b, int c)
        {
            if (a == 1) montagem += (b + c == 0) ? "cem" : "cento";
            else if (a == 2) montagem += "duzentos";
            else if (a == 3) montagem += "trezentos";
            else if (a == 4) montagem += "quatrocentos";
            else if (a == 5) montagem += "quinhentos";
            else if (a == 6) montagem += "seiscentos";
            else if (a == 7) montagem += "setecentos";
            else if (a == 8) montagem += "oitocentos";
            else if (a == 9) montagem += "novecentos";
            return montagem;
        }
    }
}
