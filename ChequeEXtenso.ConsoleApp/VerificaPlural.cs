using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequeEXtenso.ConsoleApp
{
    public class VerificaPlural
    {
        public string VerificaCentavos(string strValor, string valor_por_extenso, int i)
        {
            if (i == 15)
                if (Convert.ToInt32(strValor.Substring(16, 2)) == 1)
                    valor_por_extenso += " centavo";
                else if (Convert.ToInt32(strValor.Substring(16, 2)) > 1)
                    valor_por_extenso += " centavos";
            return valor_por_extenso;
        }

        public string VerificaPluralDeReais(string strValor, string valor_por_extenso)
        {
            if (Convert.ToInt64(strValor.Substring(0, 15)) == 1)
                valor_por_extenso += " real";
            else if (Convert.ToInt64(strValor.Substring(0, 15)) > 1)
                valor_por_extenso += " reais";
            return valor_por_extenso;
        }

        public string VerficaMil(string strValor, string valor_por_extenso)
        {
            if (Convert.ToInt32(strValor.Substring(9, 3)) > 0)
                valor_por_extenso += " mil" + ((Convert.ToDecimal(strValor.Substring(12, 3)) > 0) ? " e " : string.Empty);
            return valor_por_extenso;
        }

        public string VerficaMilhao(string strValor, string valor_por_extenso)
        {
            if (Convert.ToInt32(strValor.Substring(6, 3)) == 1)
                valor_por_extenso += " milhão" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " e " : string.Empty);
            else if (Convert.ToInt32(strValor.Substring(6, 3)) > 1)
                valor_por_extenso += " milhões" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " e " : string.Empty);
            return valor_por_extenso;
        }

        public string VerificaBilhao(string strValor, string valor_por_extenso)
        {
            if (Convert.ToInt32(strValor.Substring(3, 3)) == 1)
                valor_por_extenso += " bilhão" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " e " : string.Empty);
            else if (Convert.ToInt32(strValor.Substring(3, 3)) > 1)
                valor_por_extenso += " bilhões" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " e " : string.Empty);
            return valor_por_extenso;
        }

    }
}
