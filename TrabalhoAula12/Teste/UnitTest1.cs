using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhoAula12;

namespace Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IdadePositivo()
        {
            Aluno P1 = new Aluno();

            P1.Codigo = 1;
            P1.Nome = "Felipe";
            P1.Sobrenome = "Vozgeral Çanca";
            P1.DataNasc = new DateTime(1990, 04, 01);

            Aluno P2 = new Aluno();

            P2.Codigo = 2;
            P2.Nome = "Aline";
            P2.Sobrenome = "Branca";
            P2.DataNasc = new DateTime(2020, 01, 01);

            Aluno P3 = new Aluno();

            P3.Codigo = 3;
            P3.Nome = "Alfredo";
            P3.Sobrenome = "Sella III";
            P3.DataNasc = new DateTime(1986, 03, 12);

            Assert.Equals()
        }

        [TestMethod]
        public void IdadeNegativo()
        {
            Aluno P1 = new Aluno();

            P1.Codigo = 1;
            P1.Nome = "Felipe";
            P1.Sobrenome = "Vozgeral Çanca";
            P1.DataNasc = new DateTime(1990, 04, 01);

            Aluno P2 = new Aluno();

            P2.Codigo = 2;
            P2.Nome = "Alin@";
            P2.Sobrenome = "Branca";
            P2.DataNasc = new DateTime(2020, 01, 01);

            Aluno P3 = new Aluno();

            P3.Codigo = 3;
            P3.Nome = "Alfredo";
            P3.Sobrenome = "Sella III";
            P3.DataNasc = new DateTime(1986, 03, 12);

        }

        [TestMethod]
        public void NomePositivo()
        {
            Aluno P1 = new Aluno();

            P1.Codigo = 1;
            P1.Nome = "Felipe";
            P1.Sobrenome = "Vozgeral Çanca";
            P1.DataNasc = new DateTime(1990, 04, 01);

            Aluno P2 = new Aluno();

            P2.Codigo = 2;
            P2.Nome = "Alin@";
            P2.Sobrenome = "Branca";
            P2.DataNasc = new DateTime(2020, 01, 01);

            Aluno P3 = new Aluno();

            P3.Codigo = 3;
            P3.Nome = "Alfredo";
            P3.Sobrenome = "Sella III";
            P3.DataNasc = new DateTime(1986, 03, 12);

        }

        [TestMethod]
        public void NomeNegativo()
        {
            Aluno P1 = new Aluno();

            P1.Codigo = 1;
            P1.Nome = "Felipe";
            P1.Sobrenome = "Vozgeral Çanca";
            P1.DataNasc = new DateTime(1990, 04, 01);

            Aluno P2 = new Aluno();

            P2.Codigo = 2;
            P2.Nome = "Alin@";
            P2.Sobrenome = "Branca";
            P2.DataNasc = new DateTime(2020, 01, 01);

            Aluno P3 = new Aluno();

            P3.Codigo = 3;
            P3.Nome = "Alfredo";
            P3.Sobrenome = "Sella III";
            P3.DataNasc = new DateTime(1986, 03, 12);

        }

        [TestMethod]
        public void ValidaNomePositivo()
        {
            Aluno P1 = new Aluno();

            P1.Codigo = 1;
            P1.Nome = "Felipe";
            P1.Sobrenome = "Vozgeral Çanca";
            P1.DataNasc = new DateTime(1990, 04, 01);

            Aluno P2 = new Aluno();

            P2.Codigo = 2;
            P2.Nome = "Alin@";
            P2.Sobrenome = "Branca";
            P2.DataNasc = new DateTime(2020, 01, 01);

            Aluno P3 = new Aluno();

            P3.Codigo = 3;
            P3.Nome = "Alfredo";
            P3.Sobrenome = "Sella III";
            P3.DataNasc = new DateTime(1986, 03, 12);

        }

        [TestMethod]
        public void ValidaNomeNegativo()
        {
            Aluno P1 = new Aluno();

            P1.Codigo = 1;
            P1.Nome = "Felipe";
            P1.Sobrenome = "Vozgeral Çanca";
            P1.DataNasc = new DateTime(1990, 04, 01);

            Aluno P2 = new Aluno();

            P2.Codigo = 2;
            P2.Nome = "Alin@";
            P2.Sobrenome = "Branca";
            P2.DataNasc = new DateTime(2020, 01, 01);

            Aluno P3 = new Aluno();

            P3.Codigo = 3;
            P3.Nome = "Alfredo";
            P3.Sobrenome = "Sella III";
            P3.DataNasc = new DateTime(1986, 03, 12);

        }

        [TestMethod]
        public void ErroValidacaoPositivo()
        {
            Aluno P1 = new Aluno();

            P1.Codigo = 1;
            P1.Nome = "Felipe";
            P1.Sobrenome = "Vozgeral Çanca";
            P1.DataNasc = new DateTime(1990, 04, 01);

            Aluno P2 = new Aluno();

            P2.Codigo = 2;
            P2.Nome = "Alin@";
            P2.Sobrenome = "Branca";
            P2.DataNasc = new DateTime(2020, 01, 01);

            Aluno P3 = new Aluno();

            P3.Codigo = 3;
            P3.Nome = "Alfredo";
            P3.Sobrenome = "Sella III";
            P3.DataNasc = new DateTime(1986, 03, 12);

        }

        [TestMethod]
        public void ErroValidacaoNegativo()
        {
            Aluno P1 = new Aluno();

            P1.Codigo = 1;
            P1.Nome = "Felipe";
            P1.Sobrenome = "Vozgeral Çanca";
            P1.DataNasc = new DateTime(1990, 04, 01);

            Aluno P2 = new Aluno();

            P2.Codigo = 2;
            P2.Nome = "Alin@";
            P2.Sobrenome = "Branca";
            P2.DataNasc = new DateTime(2020, 01, 01);

            Aluno P3 = new Aluno();

            P3.Codigo = 3;
            P3.Nome = "Alfredo";
            P3.Sobrenome = "Sella III";
            P3.DataNasc = new DateTime(1986, 03, 12);

        }

    }
}