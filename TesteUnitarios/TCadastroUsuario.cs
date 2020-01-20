using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;//chamando a utilização do nunit

namespace TesteUnitarios
{
    [TestFixture]
    public class TCadastroUsuario
    {
        private JOALHERIA.BLL.UsuarioBLL usuarioBLL = new JOALHERIA.BLL.UsuarioBLL();
        private JOALHERIA.DAL.UsuarioDAL usuarioDAL = new JOALHERIA.DAL.UsuarioDAL();

        [Test]  //é a indicação de que a classe abaixo é uma classe que contém casos de teste.
        public void TestarCadastro()
        {
            Boolean result = usuarioDAL.TEfetuarCadastro();
            Assert.AreEqual(true, result);            
        }

        [Test] //é utilizado para fazer com que o método que vem abaixo se torne um método de teste
        public void TestarCadastro2()
        {
            Boolean result = usuarioDAL.TEfetuarCadastro();
            Assert.AreEqual(false, result);            
        }

    }//
}//
