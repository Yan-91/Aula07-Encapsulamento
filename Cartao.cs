using System;

namespace Aula07encapsulamento
{
    public class Cartao
    {
        public string numero {get; set;}
        public string titular{get;set;}
        public string bandeira{get;set;}
        private string token="askdaair878akfjamfm";
        protected string cvv {get; set;}
        public void AprovarCompra(){
    
            Console.WriteLine("Compra aprovada!");
        }
        private bool ValidarToken(){
            if(token != null){
            return true;
        }
        return false;
        }
        protected bool ValidarCompra(){
            return true;
        }
    }
}