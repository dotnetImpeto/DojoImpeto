using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dojoTelefone.Test
{
    [TestClass]
    public class TelefoneTest
    {
        [TestMethod]
        public void Passsando_um_numero_retorna_um_numero()
        {
            string entrada = "1";
            string resultado = "";
            string esperado = "1";

            resultado = Telefone.GetNumber(entrada);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Passsando_letra_A_retorna_numero_2()
        {
            string entrada = "A";
            string resultado = "";
            string esperado = "2";

            resultado = Telefone.GetNumber(entrada);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Passsando_letra_B_retorna_numero_2()
        {
            string entrada = "B";
            string resultado = "";
            string esperado = "2";

            resultado = Telefone.GetNumber(entrada);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Passsando_letra_C_retorna_numero_2()
        {
            string entrada = "C";
            string resultado = "";
            string esperado = "2";

            resultado = Telefone.GetNumber(entrada);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Passsando_letra_D_retorna_numero_3()
        {
            string entrada = "D";
            string resultado = "";
            string esperado = "3";

            resultado = Telefone.GetNumber(entrada);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Passsando_letra_E_retorna_numero_3()
        {
            string entrada = "E";
            string resultado = "";
            string esperado = "3";

            resultado = Telefone.GetNumber(entrada);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Passsando_letra_F_retorna_numero_3()
        {
            string entrada = "F";
            string resultado = "";
            string esperado = "3";

            resultado = Telefone.GetNumber(entrada);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Passsando_letras_11_retorna_numero_11()
        {
            string entrada = "11";
            string resultado = "";
            string esperado = "11";

            resultado = Telefone.GetNumber(entrada);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Passsando_letras_1A_retorna_numero_12()
        {
            string entrada = "1A";
            string resultado = "";
            string esperado = "12";

            resultado = Telefone.GetNumber(entrada);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Passsando_letras_AA_retorna_numero_22()
        {
            string entrada = "AA";
            string resultado = "";
            string esperado = "22";

            resultado = Telefone.GetNumber(entrada);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Passsando_letras_AAAA_retorna_numero_2222()
        {
            string entrada = "AAAA";
            string resultado = "";
            string esperado = "2222";

            resultado = Telefone.GetNumber(entrada);

            Assert.AreEqual(esperado, resultado);
        }
    }
}
