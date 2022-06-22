using Cadastro_Pessoa_FS1.Interfaces;

namespace Cadastro_Pessoa_FS1.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {
        public PessoaFisica(string nome, Endereco endereco, float rendimento) : base(nome, endereco, rendimento)
        {
            
        }

        public string ?cpf { get; set; }

        public string ?dataNascimento { get; set; }
        
        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                 if (anos >= 18 && anos < 150)
                 {
                    return true;
                 }

                 return false;
            }

            return false;

        }

        internal object ValidaDataNascimento(string dataNascimento)
        {
            throw new NotImplementedException();
        }

        public override float PagarImposto(float rendimento)
         {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
               return (rendimento / 100) * 2 ;
            }
            else if (rendimento > 3500 && rendimento < 6000)
            {
                return (rendimento / 100) * 3.5f ;
            }
            else
            {
                return (rendimento / 100) * 5;
            }
        }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime DataNasc)
        {
            throw new NotImplementedException();
        }
    }     
}


