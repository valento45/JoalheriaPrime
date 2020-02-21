using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace JOALHERIABLL
{
    public class UsuarioBLL
    {
        int idusuario;
        String nome;
        String rg;
        String cpf;
        String endereco;
        String telefone;
        bool tipo;
        String usuario;
        String senha;

        public UsuarioBLL(DataRow dr)
        {
            Idusuario = Convert.ToInt16(dr["IDUSUARIO"]);
            Nome = Convert.ToString(dr["NOME"]);
            Rg = Convert.ToString(dr["RG"]);
            Cpf = Convert.ToString(dr["CPF"]);
            Endereco = Convert.ToString(dr["ENDERECO"]);
            Telefone = Convert.ToString(dr["TELEFONE"]);
            Tipo = Convert.ToBoolean(dr["TIPO"]);
            Usuario = Convert.ToString(dr["USUARIO"]);
            Senha = Convert.ToString(dr["SENHA"]);
        }

        public UsuarioBLL()
        {

        }

        public int Idusuario
        {
            get
            {
                return idusuario;
            }

            set
            {
                idusuario = value;
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

        public bool Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }
    }
}
