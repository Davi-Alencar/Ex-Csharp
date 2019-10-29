using System;

namespace Senaizinho
{
    public class Sala
    {
            public int capacidadeAtual;
            public int capacidadeTotal = 10;
            public int numSala;
            public string[] Alunos;
            
        public Sala(int capacidadeTotal, int numSala) {
            this.capacidadeTotal = capacidadeTotal;
            this.numSala = numSala;
            this.capacidadeAtual = this.capacidadeTotal;
            this.Alunos = new string[capacidadeTotal];
            
        }

        public string AlocarAlunos (string NomeAluno) {

            int index = 0;

            if (this.capacidadeAtual > 0) 
            {
                foreach (string aluno in this.Alunos) 
                {
                    if (aluno == "") 
                    {
                        this.Alunos[index] = NomeAluno;
                        break;
                    }
                    index++;
                }
                this.capacidadeAtual--;
                return "Ok";
            } else {
                return "Lotado!";
            }
    
            
        }

        public string RemoverAlunos (string nomeAluno) {
            int index = 0;

            if(this.capacidadeAtual == this.capacidadeTotal)
            {
                return "Vida vazia...";
            }
            foreach(string aluno in this.Alunos)
            {
                if(nomeAluno == aluno) 
                {
                    this.Alunos[index] = "";
                    return "Ok";
                }
                index++;
            }
            return "Não encontrado...";
        }

        public string MostrarAlunos() {

            string listaAlunos="";
            foreach(string aluno in this.Alunos)
            {
                if(aluno != "")
                {
                    listaAlunos = listaAlunos + aluno + " ";
                }
            }
            listaAlunos.TrimEnd();
            return listaAlunos;
        } 
    }
}