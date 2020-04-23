using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOALHERIABLL
{
    public class LoginBLL
    {

        int idlogin;
        int idcaixa;
        int idusuario;
        string usuario;
        DateTime data_login;
        decimal valor_caixa;

        public static UsuarioBLL User;
        public int Idlogin
        {
            get
            {
                return idlogin;
            }

            set
            {
                idlogin = value;
            }
        }

        public int Idcaixa
        {
            get
            {
                return idcaixa;
            }

            set
            {
                idcaixa = value;
            }
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

        public DateTime Data_login
        {
            get
            {
                return data_login;
            }

            set
            {
                data_login = value;
            }
        }

        public decimal Valor_caixa
        {
            get
            {
                return valor_caixa;
            }

            set
            {
                valor_caixa = value;
            }
        }
    }
}
