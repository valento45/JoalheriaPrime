using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JOALHERIABLL;
using JOALHERIADAL;

namespace JOALHERIA.UI
{
    public partial class frmConfigurarU : Form
    {
        UsuarioBLL Usuario_;

        string node;
        public frmConfigurarU(UsuarioBLL usuarioDAL)
        {
            InitializeComponent();
            Usuario_ = usuarioDAL;
            pnlIncluirEditar.Visible = pnlPermissoes.Visible = false;
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void NodeSelecionado()
        {
            if (treeView1.SelectedNode.Name == "NoUincluir")
            {
                pnlPermissoes.Visible = false;
                pnlIncluirEditar.Visible = true;
                node = treeView1.SelectedNode.Name;
            }
            if (treeView1.SelectedNode.Name == "NoUPermissoes")
            {
                pnlIncluirEditar.Visible = false;
                pnlPermissoes.Visible = true;                
                node = treeView1.SelectedNode.Name;
                PopulaGrid(dgvPermissoesUsuario);
            }
        }
        private void PopulaGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (var user in UsuarioDAL.ListarTodosUsuarios_().OrderBy(n => n.Usuario).ToList())
                dgv.Rows.Add(user.Idusuario, user.Nome, user.Rg, user.Cpf, user.Endereco, user.Telefone, user.Tipo, user.Usuario, user.Senha, user.Permissoes);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usuario_ = UsuarioDAL.GetById(Convert.ToInt32(dgvPermissoesUsuario.SelectedCells[colId.Index].Value));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string permissao = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                
            }

        }

        private void frmConfigurarU_Load(object sender, EventArgs e)
        {

        }

       

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            NodeSelecionado();
        }
    }
}

