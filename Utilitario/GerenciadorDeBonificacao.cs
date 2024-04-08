using bytebank.Funcionarios;


namespace bytebank.Utilitario{

    public class GerenciadorDeBonificacao {

        public double TotalDeBonificacao {get;private set;}
        
        
        public void Registrar(Funcionario funcionario){

            this.TotalDeBonificacao += funcionario.GetNotification();

        }

         public void Registrar(Diretor diretor){

            this.TotalDeBonificacao += diretor.GetNotification();

        }

        }

        

}
    