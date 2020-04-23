namespace JOALHERIA.UI
{
    partial class frmConfigurarU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Incluir / Editar");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Permissões");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Configurações");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Usuario", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlPermissoes = new System.Windows.Forms.Panel();
            this.btnSalvarPermissoes = new System.Windows.Forms.Button();
            this.pnlPermissoes2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnEditPermissoes = new System.Windows.Forms.Button();
            this.dgvPermissoesUsuario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPermiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlIncluirEditar = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabIncluir = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabConsult = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPermissoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSelecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlConfiguracoes = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pnlFundo.SuspendLayout();
            this.pnlItems.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlPermissoes.SuspendLayout();
            this.pnlPermissoes2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissoesUsuario)).BeginInit();
            this.pnlIncluirEditar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabIncluir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlConfiguracoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFundo.Controls.Add(this.pnlItems);
            this.pnlFundo.Location = new System.Drawing.Point(12, 12);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(826, 424);
            this.pnlFundo.TabIndex = 0;
            // 
            // pnlItems
            // 
            this.pnlItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItems.Controls.Add(this.pnlPrincipal);
            this.pnlItems.Controls.Add(this.pnlConfiguracoes);
            this.pnlItems.Location = new System.Drawing.Point(3, 3);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(816, 414);
            this.pnlItems.TabIndex = 0;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlPermissoes);
            this.pnlPrincipal.Controls.Add(this.pnlIncluirEditar);
            this.pnlPrincipal.Location = new System.Drawing.Point(171, 6);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(640, 400);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // pnlPermissoes
            // 
            this.pnlPermissoes.Controls.Add(this.btnSalvarPermissoes);
            this.pnlPermissoes.Controls.Add(this.pnlPermissoes2);
            this.pnlPermissoes.Controls.Add(this.btnEditPermissoes);
            this.pnlPermissoes.Controls.Add(this.dgvPermissoesUsuario);
            this.pnlPermissoes.Location = new System.Drawing.Point(16, 13);
            this.pnlPermissoes.Name = "pnlPermissoes";
            this.pnlPermissoes.Size = new System.Drawing.Size(605, 375);
            this.pnlPermissoes.TabIndex = 1;
            // 
            // btnSalvarPermissoes
            // 
            this.btnSalvarPermissoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvarPermissoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarPermissoes.Location = new System.Drawing.Point(12, 346);
            this.btnSalvarPermissoes.Name = "btnSalvarPermissoes";
            this.btnSalvarPermissoes.Size = new System.Drawing.Size(105, 22);
            this.btnSalvarPermissoes.TabIndex = 26;
            this.btnSalvarPermissoes.Text = "&Salvar";
            this.btnSalvarPermissoes.UseVisualStyleBackColor = true;
            this.btnSalvarPermissoes.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlPermissoes2
            // 
            this.pnlPermissoes2.BackColor = System.Drawing.SystemColors.Window;
            this.pnlPermissoes2.Controls.Add(this.label13);
            this.pnlPermissoes2.Controls.Add(this.checkedListBox1);
            this.pnlPermissoes2.Controls.Add(this.lblUsuario);
            this.pnlPermissoes2.Location = new System.Drawing.Point(9, 214);
            this.pnlPermissoes2.Name = "pnlPermissoes2";
            this.pnlPermissoes2.Size = new System.Drawing.Size(586, 125);
            this.pnlPermissoes2.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Permissões para o usuário:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Usuario",
            "Estoque",
            "Financeiro",
            "Cliente",
            "Inclusao",
            "Edicao",
            "Exclusao"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 22);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(133, 94);
            this.checkedListBox1.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Thistle;
            this.lblUsuario.Location = new System.Drawing.Point(142, 5);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "admin";
            // 
            // btnEditPermissoes
            // 
            this.btnEditPermissoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditPermissoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPermissoes.Location = new System.Drawing.Point(9, 168);
            this.btnEditPermissoes.Name = "btnEditPermissoes";
            this.btnEditPermissoes.Size = new System.Drawing.Size(105, 22);
            this.btnEditPermissoes.TabIndex = 24;
            this.btnEditPermissoes.Text = "Editar Permissões";
            this.btnEditPermissoes.UseVisualStyleBackColor = true;
            this.btnEditPermissoes.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvPermissoesUsuario
            // 
            this.dgvPermissoesUsuario.AllowUserToAddRows = false;
            this.dgvPermissoesUsuario.AllowUserToDeleteRows = false;
            this.dgvPermissoesUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPermissoesUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermissoesUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.colPermiss,
            this.dataGridViewCheckBoxColumn1});
            this.dgvPermissoesUsuario.Location = new System.Drawing.Point(5, 5);
            this.dgvPermissoesUsuario.Name = "dgvPermissoesUsuario";
            this.dgvPermissoesUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermissoesUsuario.Size = new System.Drawing.Size(593, 150);
            this.dgvPermissoesUsuario.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "RG";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 48;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 52;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 78;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 74;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 53;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 68;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 63;
            // 
            // colPermiss
            // 
            this.colPermiss.HeaderText = "Permissões";
            this.colPermiss.Name = "colPermiss";
            this.colPermiss.Width = 85;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "                ";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 61;
            // 
            // pnlIncluirEditar
            // 
            this.pnlIncluirEditar.Controls.Add(this.tabControl1);
            this.pnlIncluirEditar.Location = new System.Drawing.Point(18, 18);
            this.pnlIncluirEditar.Name = "pnlIncluirEditar";
            this.pnlIncluirEditar.Size = new System.Drawing.Size(603, 370);
            this.pnlIncluirEditar.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabIncluir);
            this.tabControl1.Controls.Add(this.tabConsult);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 364);
            this.tabControl1.TabIndex = 0;
            // 
            // tabIncluir
            // 
            this.tabIncluir.Controls.Add(this.pictureBox1);
            this.tabIncluir.Controls.Add(this.btnNovo);
            this.tabIncluir.Controls.Add(this.txtCpf);
            this.tabIncluir.Controls.Add(this.txtRg);
            this.tabIncluir.Controls.Add(this.label11);
            this.tabIncluir.Controls.Add(this.btnSalvar);
            this.tabIncluir.Controls.Add(this.label9);
            this.tabIncluir.Controls.Add(this.txtSenha);
            this.tabIncluir.Controls.Add(this.txtUsuario);
            this.tabIncluir.Controls.Add(this.cmbTipo);
            this.tabIncluir.Controls.Add(this.txtTelefone);
            this.tabIncluir.Controls.Add(this.txtEndereco);
            this.tabIncluir.Controls.Add(this.txtNome);
            this.tabIncluir.Controls.Add(this.label5);
            this.tabIncluir.Controls.Add(this.label6);
            this.tabIncluir.Controls.Add(this.label7);
            this.tabIncluir.Controls.Add(this.label8);
            this.tabIncluir.Controls.Add(this.label4);
            this.tabIncluir.Controls.Add(this.label3);
            this.tabIncluir.Controls.Add(this.label2);
            this.tabIncluir.Controls.Add(this.label1);
            this.tabIncluir.Location = new System.Drawing.Point(4, 22);
            this.tabIncluir.Name = "tabIncluir";
            this.tabIncluir.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncluir.Size = new System.Drawing.Size(589, 338);
            this.tabIncluir.TabIndex = 0;
            this.tabIncluir.Text = "Incluir";
            this.tabIncluir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::JOALHERIA.Properties.Resources.Login;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(171, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::JOALHERIA.Properties.Resources.Novo_2;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(327, 245);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 39);
            this.btnNovo.TabIndex = 45;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(82, 140);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(99, 20);
            this.txtCpf.TabIndex = 44;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(82, 114);
            this.txtRg.Mask = "00.000.000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(99, 20);
            this.txtRg.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(228, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 24);
            this.label11.TabIndex = 42;
            this.label11.Text = "Incluir usuário";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::JOALHERIA.Properties.Resources.Salvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(428, 245);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 39);
            this.btnSalvar.TabIndex = 41;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(79, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(429, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "\"Exemple: Rua das magnólias Nº708, Bairro Casa Grande - Francisco Morato - SP\"";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(403, 138);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 39;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(403, 117);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 38;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Administrador",
            "Normal"});
            this.cmbTipo.Location = new System.Drawing.Point(232, 138);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 37;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(232, 113);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(121, 20);
            this.txtTelefone.TabIndex = 36;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic);
            this.txtEndereco.Location = new System.Drawing.Point(82, 206);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(421, 20);
            this.txtEndereco.TabIndex = 35;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(421, 20);
            this.txtNome.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Usuário:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "RG:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome:";
            // 
            // tabConsult
            // 
            this.tabConsult.Controls.Add(this.label10);
            this.tabConsult.Controls.Add(this.dgvUsuarios);
            this.tabConsult.Controls.Add(this.btnExcluir);
            this.tabConsult.Controls.Add(this.btnEditar);
            this.tabConsult.Location = new System.Drawing.Point(4, 22);
            this.tabConsult.Name = "tabConsult";
            this.tabConsult.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsult.Size = new System.Drawing.Size(589, 338);
            this.tabConsult.TabIndex = 1;
            this.tabConsult.Text = "Consultar/Alterar";
            this.tabConsult.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.label10.Location = new System.Drawing.Point(220, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 24);
            this.label10.TabIndex = 49;
            this.label10.Text = "Consultar Usuários";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colRg,
            this.colCpf,
            this.colEndereco,
            this.colTelefone,
            this.colTipo,
            this.colUsuario,
            this.colSenha,
            this.colPermissoes,
            this.chkSelecionar});
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 67);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(580, 229);
            this.dgvUsuarios.TabIndex = 48;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 43;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 60;
            // 
            // colRg
            // 
            this.colRg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colRg.HeaderText = "RG";
            this.colRg.Name = "colRg";
            this.colRg.ReadOnly = true;
            this.colRg.Width = 48;
            // 
            // colCpf
            // 
            this.colCpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            this.colCpf.Width = 52;
            // 
            // colEndereco
            // 
            this.colEndereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEndereco.HeaderText = "Endereço";
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.ReadOnly = true;
            this.colEndereco.Width = 78;
            // 
            // colTelefone
            // 
            this.colTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.Width = 74;
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 53;
            // 
            // colUsuario
            // 
            this.colUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            this.colUsuario.Width = 68;
            // 
            // colSenha
            // 
            this.colSenha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSenha.HeaderText = "Senha";
            this.colSenha.Name = "colSenha";
            this.colSenha.ReadOnly = true;
            this.colSenha.Width = 63;
            // 
            // colPermissoes
            // 
            this.colPermissoes.HeaderText = "Permissões";
            this.colPermissoes.Name = "colPermissoes";
            this.colPermissoes.ReadOnly = true;
            this.colPermissoes.Width = 85;
            // 
            // chkSelecionar
            // 
            this.chkSelecionar.HeaderText = "                ";
            this.chkSelecionar.Name = "chkSelecionar";
            this.chkSelecionar.Width = 61;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(108, 302);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 27);
            this.btnExcluir.TabIndex = 47;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(6, 303);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 27);
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "E&ditar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // pnlConfiguracoes
            // 
            this.pnlConfiguracoes.Controls.Add(this.treeView1);
            this.pnlConfiguracoes.Location = new System.Drawing.Point(3, 3);
            this.pnlConfiguracoes.Name = "pnlConfiguracoes";
            this.pnlConfiguracoes.Size = new System.Drawing.Size(162, 406);
            this.pnlConfiguracoes.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "NoUincluir";
            treeNode9.Text = "Incluir / Editar";
            treeNode10.Name = "NoUPermissoes";
            treeNode10.Text = "Permissões";
            treeNode11.Name = "NoUConfiguracoes";
            treeNode11.Text = "Configurações";
            treeNode12.Name = "NoU";
            treeNode12.Text = "Usuario";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(156, 400);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // frmConfigurarU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(850, 448);
            this.Controls.Add(this.pnlFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConfigurarU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfigurarU";
            this.Load += new System.EventHandler(this.frmConfigurarU_Load);
            this.pnlFundo.ResumeLayout(false);
            this.pnlItems.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPermissoes.ResumeLayout(false);
            this.pnlPermissoes2.ResumeLayout(false);
            this.pnlPermissoes2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissoesUsuario)).EndInit();
            this.pnlIncluirEditar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabIncluir.ResumeLayout(false);
            this.tabIncluir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabConsult.ResumeLayout(false);
            this.tabConsult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlConfiguracoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Panel pnlConfiguracoes;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlIncluirEditar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabIncluir;
        private System.Windows.Forms.TabPage tabConsult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPermissoes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelecionar;
        private System.Windows.Forms.Panel pnlPermissoes;
        private System.Windows.Forms.DataGridView dgvPermissoesUsuario;
        private System.Windows.Forms.Panel pnlPermissoes2;
        private System.Windows.Forms.Button btnEditPermissoes;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPermiss;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnSalvarPermissoes;
    }
}