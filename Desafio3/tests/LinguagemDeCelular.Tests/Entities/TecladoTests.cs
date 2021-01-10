using System;
using LinguagemDeCelular.Entities;
using Xunit;

namespace LinguagemDeCelular.Tests.Entities
{
    public class TecladoTests
    {
        [Theory]
        [InlineData("abc", "2_22_222")]
        [InlineData("ag i w", "24044409")]
        [InlineData("SEMPRE ACESSO O DOJOPUZZLES", "77773367_7773302_222337777_777766606660366656667889999_9999555337777")]
        public void TransformarEmSms__deve_retornar_sms_valido__quando_texto_estiver_valido(string texto, string smsValido)
        {
            var sms = Teclado.TransformarEmSms(new Mensagem(texto));
            Assert.Equal(expected: smsValido, actual: sms);
        }

        [Theory]
        [InlineData("-", "-")]
        [InlineData("?-*&", "?-*&")]
        public void TransformarEmSms__deve_retornar_sms_com_caracter_especial(string caracterEspecial, string smsValido)
        {
            var sms = Teclado.TransformarEmSms(new Mensagem(caracterEspecial));
            Assert.Equal(expected: smsValido, actual: sms);
        }

        [Fact]
        public void TransformarEmSms__deve_retornar_sms_valido__quando_estiver_com_espaco()
        {
            var sms = Teclado.TransformarEmSms(new Mensagem(" "));
            Assert.Equal(expected: "0", actual: sms);
        }
    }
}