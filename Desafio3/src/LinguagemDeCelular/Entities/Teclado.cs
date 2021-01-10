using System;
using System.Collections.Generic;
using System.Linq;

namespace LinguagemDeCelular.Entities
{
    public static class Teclado
    {
        public static readonly List<Conjunto> CONJUNTO_LETRAS = new List<Conjunto>()
        {
            new Conjunto(new List<char>{'A','B','C'}, numeroCorrespondente: 2),
            new Conjunto(new List<char>{'D','E','F'}, numeroCorrespondente: 3),
            new Conjunto(new List<char>{'G','H','I'}, numeroCorrespondente: 4),
            new Conjunto(new List<char>{'J','K','L'}, numeroCorrespondente: 5),
            new Conjunto(new List<char>{'M','N','O'}, numeroCorrespondente: 6),
            new Conjunto(new List<char>{'P','Q','R','S'}, numeroCorrespondente: 7),
            new Conjunto(new List<char>{'T','U','V'}, numeroCorrespondente: 8),
            new Conjunto(new List<char>{'W','X','Y','Z'}, numeroCorrespondente: 9),
            new Conjunto(new List<char>{' '}, numeroCorrespondente: 0),
        };

        public static string TransformarEmSms(Mensagem mensagem)
        {
            var sms = "";
            char[] caracteres = mensagem.Texto.ToCharArray();

            foreach (char caracter in caracteres)
            {
                if (Char.IsLetter(caracter) || Char.IsWhiteSpace(caracter))
                {
                    var caracterMaiusculo = char.ToUpper(caracter);
                    sms += IncrementarSms(caracterMaiusculo, sms);
                }
                else
                {
                    sms += caracter;
                }
            }

            return sms;
        }

        private static string IncrementarSms(char caracter, string sms)
        {
            var incremento = "";

            Conjunto conjunto = CONJUNTO_LETRAS.Find(c =>
                c.Letras.Contains(caracter)
            );

            bool precisaDeUmaPausa = Convert.ToString(sms.LastOrDefault()) == conjunto.Numero.ToString();

            if (precisaDeUmaPausa) incremento += "_";

            var numerosPraAdicionar = conjunto.Letras.IndexOf(caracter);

            for (int i = 0; i <= numerosPraAdicionar; i++)
            {
                incremento += conjunto.Numero.ToString();
            }

            return incremento;

        }
    }
}