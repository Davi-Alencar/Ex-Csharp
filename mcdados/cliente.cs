using System;

namespace mcdados
{
    public class cliente
    {
        //Propriedades
        public string nome;
        public string endereco;
        public string telefone;
        public string senha;
        public string email;
        public DateTime datanascimento;

        //Construtores
        public cliente(string nome, string telefone, string email) {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }


    }
}