using System;

namespace LinguagemDeCelular.Entities
{
    public class Mensagem
    {
        public Mensagem(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new ArgumentException("A mensagem não pode ser vazia!");
            }

            if (texto.Length > 255)
            {
                throw new ArgumentException("A mensagem não pode ter mais de 255 caracteres!");
            }

            Texto = texto;
            Sms = Teclado.TransformarEmSms(this);
        }

        public string Texto { get; private set; }
        public string Sms { get; private set; }
    }
}