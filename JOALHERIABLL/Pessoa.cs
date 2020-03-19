using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOALHERIABLL
{
    public abstract class Pessoa
    {
        int idpessoa;
        string nome;
        string tipo_documento;
        string documento;
        string cpf_cnpj;
        DateTime data_nascimento;
        string email;
        string telefone;
        string endereco;
        string cidade;
        string uf;
        string complemento;        
        string tipo_pessoa;

        public int Idpessoa { get => idpessoa; set => idpessoa = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Tipo_documento { get => tipo_documento; set => tipo_documento = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public DateTime Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Tipo_pessoa { get => tipo_pessoa; set => tipo_pessoa = value; }


    }
}
