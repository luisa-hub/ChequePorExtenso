using System;

namespace ChequeEXtenso.ConsoleApp
{
    public class Base
    {
        Numero numeroClasse;
        Unidade unidadeClasse;
        Dezena dezenaClasse;
        Centena centenaClasse;
        VerificaPlural plural;
        public Base(Numero numeroC, Unidade unidadeC, Centena centenaC, Dezena dezenaC, VerificaPlural verificaPlural)
        {
            numeroClasse = numeroC;
            unidadeClasse = unidadeC;
            centenaClasse = centenaC;
            dezenaClasse = dezenaC;
            plural = verificaPlural;
        }
        public string ToExtenso(decimal valor)
        {
            try
            {
                if (numeroClasse.VerificaValor(valor))
                    return numeroClasse.MensagemErroMaiorTrilhao();

                else
                {
                    string strValor = valor.ToString("000000000000000.00");
                    string valor_por_extenso = string.Empty;

                    for (int i = 0; i <= 15; i += 3)
                    {
                        valor_por_extenso += MontagemDaEscritaCentenas(Convert.ToDecimal(strValor.Substring(i, 3)));

                        valor_por_extenso = VerificaSePassaDeCentena(strValor, valor_por_extenso, i);

                        valor_por_extenso = VerificaInteiro(strValor, valor_por_extenso, i);

                        valor_por_extenso = plural.VerificaCentavos(strValor, valor_por_extenso, i);
                    }
                    return valor_por_extenso;
                }
            }
            catch(Exception e)
            {
               return e.Message;   
            }
        }
        
        #region VERIFICADORES PÓS CENTENA

        private string VerificaSePassaDeCentena(string strValor, string valor_por_extenso, int i)
        {
            if (i == 3 & valor_por_extenso != string.Empty)
            {
                valor_por_extenso = plural.VerificaBilhao(strValor, valor_por_extenso);
            }
            else if (i == 6 & valor_por_extenso != string.Empty)
            {
                valor_por_extenso = plural.VerficaMilhao(strValor, valor_por_extenso);
            }
            else if (i == 9 & valor_por_extenso != string.Empty)
                valor_por_extenso = plural.VerficaMil(strValor, valor_por_extenso);
            return valor_por_extenso;
        }

        private string VerificaInteiro(string strValor, string valor_por_extenso, int i)
        {
            if (i == 12)
            {
                if (valor_por_extenso.Length > 8)
                    valor_por_extenso = VerificaValorArredondado(valor_por_extenso);

                valor_por_extenso = plural.VerificaPluralDeReais(strValor, valor_por_extenso);

                if (Convert.ToInt32(strValor.Substring(16, 2)) > 0 && valor_por_extenso != string.Empty)
                    valor_por_extenso += " e ";
            }

            return valor_por_extenso;
        }

        private static string VerificaValorArredondado(string valor_por_extenso)
        {
            if (valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "bilhão" | valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "milhão")
                valor_por_extenso += " de";
            else
                                            if (valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "blilhões" | valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "milhões" | valor_por_extenso.Substring(valor_por_extenso.Length - 8, 7) == "trilhões")//apagar
                valor_por_extenso += " de";
            return valor_por_extenso;
        }

        #endregion

        public string MontagemDaEscritaCentenas(decimal valor)
        {
            if (valor <= 0)
                return string.Empty;
            else
            {
                string montagem = string.Empty;
                if (valor > 0 & valor < 1)
                {
                    valor *= 100;
                }
                string strValor = valor.ToString("000");
                int a = Convert.ToInt32(strValor.Substring(0, 1));
                int b = Convert.ToInt32(strValor.Substring(1, 1));
                int c = Convert.ToInt32(strValor.Substring(2, 1));

                montagem = centenaClasse.VerificaCentena(montagem, a, b, c);

                montagem = VerificaDezena(montagem, a, b, c);
                montagem = VerificaNecessidadeDoENaDezena(montagem, strValor, c);

                return montagem;
            }
        }

        #region MÉTODOS PRIVADOS

        private string VerificaNecessidadeDoENaDezena(string montagem, string strValor, int c)
        {
            if (strValor.Substring(1, 1) != "1" & c != 0 & montagem != string.Empty) montagem += " e ";
            

            if (strValor.Substring(1, 1) != "1")
                montagem = unidadeClasse.VerificaUnidade(montagem, c);

            return montagem;
        }

        


        private string VerificaDezena(string montagem, int a, int b, int c)
        {
            montagem = dezenaClasse.VerificaDe20a90(montagem, a, b, c);
            return montagem;
        }

       


       
        #endregion
    }
}
