using System;

namespace rltpMVC.Models
{
    public class Evento
    {
        public string tipoEvento {get;set;}
        public DateTime dataEvento {get;set;}
        public string inicioEvento {get;set;}
        public string terminoEvento {get;set;}
        public string numPessoas {get;set;}
        public string descricaoEvento {get;set;}

        public Evento()
        {

        }

        public Evento(string tipoEvento, DateTime dataEvento, string inicioEvento, string terminoEvento, string numPessoas, string descricaoEvento)
        {
            this.tipoEvento = tipoEvento;
            this.dataEvento = dataEvento;
            this.inicioEvento = inicioEvento;
            this.terminoEvento = terminoEvento;
            this.numPessoas = numPessoas;
            this.descricaoEvento = descricaoEvento;
        }
        
    }

    
}