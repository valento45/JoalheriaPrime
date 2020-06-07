using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JOALHERIADAL
{
    public class NetworkLog
    {
        public static void Insert(Exception ex, string pCommand)
        {
            try
            {
                XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", null));
                XElement cabecalho = new XElement("LOG");
                XElement erro = new XElement("ERRORS");
                erro.Add(new XElement("Message", ex.Message));
                erro.Add(new XElement("StackTrace", ex.StackTrace));
                erro.Add(new XElement("Detalhes", (ex.InnerException != null ? ex.InnerException.Message : "") + (pCommand != null && pCommand.Length > 0 ? " - " + pCommand : "")));
                erro.Add(new XElement("Data", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));

                cabecalho.Add(erro);
                xml.Add(cabecalho);

                string caminho = Directory.GetCurrentDirectory();
                caminho = caminho.Substring(0, caminho.Length - 19) + "Logs\\Erros\\";
               
                xml.Save(caminho + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss").Replace("/", "").Replace(":", "") + ".xml");
            }
            catch(Exception x)
            {
                MessageBox.Show("Falha ao registrar no Log!" + "\n\r\n\r\n\r" + x.Message);
            };
        }


        public static string Insert_Two(Exception ex, string pCommand)
        {
            string filePath = "";
            try
            {
                XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", null));
                XElement cabecalho = new XElement("LOG");
                XElement erro = new XElement("ERRORS");
                erro.Add(new XElement("Message", ex.Message));
                erro.Add(new XElement("StackTrace", ex.StackTrace));
                erro.Add(new XElement("Detalhes", (ex.InnerException != null ? ex.InnerException.Message : "") + (pCommand != null && pCommand.Length > 0 ? " - " + pCommand : "")));
                erro.Add(new XElement("Data", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));

                cabecalho.Add(erro);
                xml.Add(cabecalho);

                string caminho = Directory.GetCurrentDirectory();
                caminho = caminho.Substring(0, caminho.Length - 19) + "Logs\\Erros\\";
                filePath = caminho + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss").Replace("/", "").Replace(":", "") + ".xml";
                xml.Save(caminho + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss").Replace("/", "").Replace(":", "") + ".xml");
            }
            catch (Exception x)
            {
                MessageBox.Show("Falha ao registrar no Log!" + "\n\r\n\r\n\r" + x.Message);
            };
            return filePath;
        }
    }
}
