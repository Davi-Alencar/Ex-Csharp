namespace Byte_Bank {
    public class Cliente {
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Cpf {get;set;}
        public string Senha {get;set;}

        public Cliente (string Nome, string Email, string Cpf) {
            this.Nome = Nome;
            this.Email = Email;
            this.Cpf = Cpf;
            
        }

        public bool TrocaSenha(string Senha) {
            if ((Senha.Length > 6) && (Senha.Length < 16)) {
                this.Senha = Senha;
                return true;
            } else {
                return false;
            }
        }
    }

}