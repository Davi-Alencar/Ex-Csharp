using System;

namespace aluno
{

   public class Aluno
    {
        //Propriedades
        public string nome{get;set;};
        public string curso{get;set;};
        public string cpf{get;set;};
        public int[] notas;

        //construtor
        public Aluno(string nome, string cpf){
            this.nome = nome;
            this.cpf = cpf;

        }

        public Aluno(string nome, string cpf, string curso){
            this.nome = nome;
            this.cpf = cpf;
            this.curso = curso;
        } 
    }
}