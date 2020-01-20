using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOALHERIABLL
{
    public class ClienteBLL
    {
        int idcliente;
        string nome;
        string rg;
        string cpf;
        DateTime data_nascimento;
        string email;
        string telefone;
        string endereco;
        string cidade;
        string uf;
        string tipo_cliente;

        public int Idcliente
        {
            get
            {
                return idcliente;
            }

            set
            {
                idcliente = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public DateTime Data_nascimento
        {
            get
            {
                return data_nascimento;
            }

            set
            {
                data_nascimento = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Uf
        {
            get
            {
                return uf;
            }

            set
            {
                uf = value;
            }
        }

        public string Tipo_cliente
        {
            get
            {
                return tipo_cliente;
            }

            set
            {
                tipo_cliente = value;
            }
        }
    }
}
