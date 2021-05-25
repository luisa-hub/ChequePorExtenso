using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChequeEXtenso.ConsoleApp;

namespace ChequeExtenso.Tests
{
    [TestClass]
    public class ChequeExtensoTests

    {
        public static Numero numeroClasse = new Numero();
        public static Unidade unidadeClasse = new Unidade();
        public static Dezena dezenaClasse = new Dezena();
        public static Centena centenaClasse = new Centena();
        public static VerificaPlural plural = new VerificaPlural();
        public static Base base1 = new Base(numeroClasse, unidadeClasse, centenaClasse, dezenaClasse, plural);

        [TestMethod]
       

        public void TesteApenasCentavo()
        {
            decimal valor = 0.05m;
            Assert.AreEqual("cinco centavos", base1.ToExtenso(valor));
        }

        [TestMethod]
        public void TesteUnidadeCentavo()
        { 
            decimal valor = 2.25m;
            Assert.AreEqual("dois reais e vinte e cinco centavos", base1.ToExtenso(valor));
        }

        [TestMethod]
        public void TesteUnidade() {
            decimal valor = 7.00m;
            Assert.AreEqual("sete reais", base1.ToExtenso(valor));
        }

        [TestMethod]
        public void TesteDezena() {
            decimal valor = 37m;
            Assert.AreEqual("trinta e sete reais", base1.ToExtenso(valor));
        }

        [TestMethod]
        public void TesteCentena() {

            decimal valor = 637m;
            Assert.AreEqual("seiscentos e trinta e sete reais", base1.ToExtenso(valor));        
        }

        [TestMethod]
        public void TesteMilhar() {
            decimal valor = 1637m;
            Assert.AreEqual("um mil e seiscentos e trinta e sete reais", base1.ToExtenso(valor));
        }


        [TestMethod]
        public void TesteMilharcomCentavos()
        {
            decimal valor = 15415.16m;
            Assert.AreEqual("quinze mil e quatrocentos e quinze reais e dezesseis centavos", base1.ToExtenso(valor));
        }

        [TestMethod]
        public void TesteMilharDuasCasas() {

            decimal valor = 61637m;
            Assert.AreEqual("sessenta e um mil e seiscentos e trinta e sete reais", base1.ToExtenso(valor));
        }

        [TestMethod]
        public void TesteMilharTresCasas() {

            decimal valor = 961637m;
            Assert.AreEqual("novecentos e sessenta e um mil e seiscentos e trinta e sete reais", base1.ToExtenso(valor));
        }

        [TestMethod]
        public void TesteUmMilhao() { 
            decimal valor = 1852700.00m;
            Assert.AreEqual("um milhão e oitocentos e cinquenta e dois mil e setecentos reais", base1.ToExtenso(valor));
        }

        [TestMethod]
        public void TesteMilhoes() { 
            decimal valor = 5961637.00m;
            Assert.AreEqual("cinco milhões e novecentos e sessenta e um mil e seiscentos e trinta e sete reais", base1.ToExtenso(valor));
        }

        [TestMethod]
        public void TesteMilhoesDuasCasas() { 
            decimal valor = 25961637.00m;
            Assert.AreEqual("vinte e cinco milhões e novecentos e sessenta e um mil e seiscentos e trinta e sete reais", base1.ToExtenso(valor));


        }


        [TestMethod]
        public void TesteMilhoesTresCasas() {
            decimal valor = 425961637.00m;
            Assert.AreEqual("quatrocentos e vinte e cinco milhões e novecentos e sessenta e um mil e seiscentos e trinta e sete reais", base1.ToExtenso(valor));
        }

        [TestMethod]
        public void TesteUmBilhao() {
            decimal valor = 1000000000.00m;
            Assert.AreEqual("um bilhão de reais", base1.ToExtenso(valor));
        }

        [TestMethod]
        public void TesteBilhoes() {
            decimal valor = 8425961637.00m;
            Assert.AreEqual("oito bilhões e quatrocentos e vinte e cinco milhões e novecentos e sessenta e um mil e seiscentos e trinta e sete reais", base1.ToExtenso(valor));
        }
    }

}
