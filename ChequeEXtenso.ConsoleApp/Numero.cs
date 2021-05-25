using System;


namespace ChequeEXtenso.ConsoleApp
{
    public class Numero 
    { //receber o número
        public string numero_extenso;
        public string numero;


        public bool VerificaValor(decimal valor)
        {
            return valor <= 0 | valor >= 1000000000000000;
        }

        public string MensagemErroMaiorTrilhao()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new ArgumentOutOfRangeException("valor", "Valor não suportado pelo sistema, maior que 999.999.999.999,99.");
        }

        public string MensagemErroLetra()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new ArgumentOutOfRangeException("valor", "Sistema não suporta letras");
        }
    }

    
}
