namespace Byte_Bank
{
    public class ContaCorrente
    {
        public string Titular {get;set;}
        public int Agencia {get;set;}
        public int Numero {get;set;}
        public double Saldo {get;set;} 
        

        public ContaCorrente (int Agencia, int Numero, string Titular) {
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0.0;
            
            
        }

        public double Deposito(double Valor) {
            return this.Saldo += Valor;
        }
        public bool Saque(double Valor) {
            if(Saldo >= Valor) {
                Saldo -=  Valor;
                return true;
            } else {
                return false;
            }
        }
        public bool Transferencia(ContaCorrente contaDestino, double Valor) {
            if(this.Saque(Valor)) {
                contaDestino.Deposito(Valor);
                return true;
            } else {
                return false;
            }
        } 


        
    }
}