using System;

namespace Organizador_Aniversarios
{
    class Aniversariante
    {
        // ========== Atributos Privados e Auto Properties =============
        private string _nome;
        public DateTime Aniversario { get; private set; }

        // ======================= Construtores ========================
        public Aniversariante(string nome, DateTime aniversario)
        {
            _nome = nome;
            Aniversario = aniversario;
        }

        // ================== Properties Customizadas ==================
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        // ========================== Métodos ==========================
        public string MudarAniversario (DateTime novaData)
        {
            Aniversario = novaData;
            return "Aniversário alterado com sucesso!";
        }

        // ======================== To String ==========================
        public override string ToString()
        {
            return Aniversario.ToString("dd-MM") + " -> " + Nome;
        }
    }
}
