using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JOALHERIABLL;
namespace JOALHERIA.UI
{
    public class Modulo
    {
        public static bool CanAcces(Modulos modulos)
        {
            if (LoginBLL.User.Permissoes.Contains((Char)modulos))
                return true;
            else
                return false;
        }
    }

    public enum Modulos
    {
        Usuario = 'u',
        Estoque = 'e',
        Financeiro = 'f',
        Cliente = 'c',

    }
}
