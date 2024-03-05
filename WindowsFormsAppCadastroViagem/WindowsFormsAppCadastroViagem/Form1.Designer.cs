namespace WindowsFormsAppCadastroViagem
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pictureBoxPrincipal = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.statusStripPrincipal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelPai = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimparDados = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExluir = new System.Windows.Forms.Button();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.dataGridViewDadosAlunos = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblProtocolo = new System.Windows.Forms.Label();
            this.txbNomeAluno = new System.Windows.Forms.TextBox();
            this.txbProtocolo = new System.Windows.Forms.TextBox();
            this.groupBoxId = new System.Windows.Forms.GroupBox();
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txbCurso = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txbAno = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.txbDataMatricula = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txbObservacoes = new System.Windows.Forms.TextBox();
            this.btnCarregarDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrincipal)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.statusStripPrincipal.SuspendLayout();
            this.panelPai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDadosAlunos)).BeginInit();
            this.groupBoxId.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPrincipal
            // 
            this.pictureBoxPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrincipal.Image")));
            this.pictureBoxPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPrincipal.Name = "pictureBoxPrincipal";
            this.pictureBoxPrincipal.Size = new System.Drawing.Size(388, 578);
            this.pictureBoxPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrincipal.TabIndex = 0;
            this.pictureBoxPrincipal.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LightBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(821, 124);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Arte de Aprender";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(388, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(821, 124);
            this.panelTitle.TabIndex = 2;
            // 
            // statusStripPrincipal
            // 
            this.statusStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripPrincipal.Location = new System.Drawing.Point(388, 553);
            this.statusStripPrincipal.Name = "statusStripPrincipal";
            this.statusStripPrincipal.Size = new System.Drawing.Size(821, 25);
            this.statusStripPrincipal.TabIndex = 3;
            this.statusStripPrincipal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(126, 20);
            this.toolStripStatusLabel1.Text = "Status do sistema";
            // 
            // panelPai
            // 
            this.panelPai.Controls.Add(this.btnCarregarDados);
            this.panelPai.Controls.Add(this.txbObservacoes);
            this.panelPai.Controls.Add(this.lblObservacoes);
            this.panelPai.Controls.Add(this.txbDataMatricula);
            this.panelPai.Controls.Add(this.lblCadastro);
            this.panelPai.Controls.Add(this.txbRG);
            this.panelPai.Controls.Add(this.lblRG);
            this.panelPai.Controls.Add(this.txbCPF);
            this.panelPai.Controls.Add(this.lblCPF);
            this.panelPai.Controls.Add(this.txbAno);
            this.panelPai.Controls.Add(this.lblAno);
            this.panelPai.Controls.Add(this.txbCurso);
            this.panelPai.Controls.Add(this.lblCurso);
            this.panelPai.Controls.Add(this.groupBoxId);
            this.panelPai.Controls.Add(this.txbProtocolo);
            this.panelPai.Controls.Add(this.txbNomeAluno);
            this.panelPai.Controls.Add(this.lblProtocolo);
            this.panelPai.Controls.Add(this.lblNome);
            this.panelPai.Controls.Add(this.dataGridViewDadosAlunos);
            this.panelPai.Controls.Add(this.btnTestarConexao);
            this.panelPai.Controls.Add(this.btnExluir);
            this.panelPai.Controls.Add(this.btnEditar);
            this.panelPai.Controls.Add(this.btnCancelar);
            this.panelPai.Controls.Add(this.btnLimparDados);
            this.panelPai.Controls.Add(this.btnSalvar);
            this.panelPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPai.Location = new System.Drawing.Point(388, 124);
            this.panelPai.Name = "panelPai";
            this.panelPai.Size = new System.Drawing.Size(821, 429);
            this.panelPai.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSalvar.Location = new System.Drawing.Point(37, 389);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(73, 37);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimparDados
            // 
            this.btnLimparDados.AutoSize = true;
            this.btnLimparDados.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimparDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparDados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimparDados.FlatAppearance.BorderSize = 0;
            this.btnLimparDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimparDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnLimparDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparDados.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparDados.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLimparDados.Location = new System.Drawing.Point(116, 389);
            this.btnLimparDados.Name = "btnLimparDados";
            this.btnLimparDados.Size = new System.Drawing.Size(79, 37);
            this.btnLimparDados.TabIndex = 7;
            this.btnLimparDados.Text = "Limpar";
            this.btnLimparDados.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCancelar.Location = new System.Drawing.Point(201, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEditar.Location = new System.Drawing.Point(287, 389);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 37);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExluir
            // 
            this.btnExluir.AutoSize = true;
            this.btnExluir.BackColor = System.Drawing.Color.LightBlue;
            this.btnExluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExluir.FlatAppearance.BorderSize = 0;
            this.btnExluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnExluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExluir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExluir.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnExluir.Location = new System.Drawing.Point(368, 389);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(76, 37);
            this.btnExluir.TabIndex = 10;
            this.btnExluir.Text = "Excluir";
            this.btnExluir.UseVisualStyleBackColor = false;
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.AutoSize = true;
            this.btnTestarConexao.BackColor = System.Drawing.Color.LightBlue;
            this.btnTestarConexao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestarConexao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTestarConexao.FlatAppearance.BorderSize = 0;
            this.btnTestarConexao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnTestarConexao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnTestarConexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestarConexao.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarConexao.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTestarConexao.Location = new System.Drawing.Point(626, 389);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(162, 37);
            this.btnTestarConexao.TabIndex = 12;
            this.btnTestarConexao.Text = "Verificar conexão DB";
            this.btnTestarConexao.UseVisualStyleBackColor = false;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // dataGridViewDadosAlunos
            // 
            this.dataGridViewDadosAlunos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDadosAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDadosAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDadosAlunos.Location = new System.Drawing.Point(11, 281);
            this.dataGridViewDadosAlunos.MultiSelect = false;
            this.dataGridViewDadosAlunos.Name = "dataGridViewDadosAlunos";
            this.dataGridViewDadosAlunos.ReadOnly = true;
            this.dataGridViewDadosAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDadosAlunos.Size = new System.Drawing.Size(798, 102);
            this.dataGridViewDadosAlunos.TabIndex = 15;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(7, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(129, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do aluno";
            // 
            // lblProtocolo
            // 
            this.lblProtocolo.AutoSize = true;
            this.lblProtocolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtocolo.Location = new System.Drawing.Point(317, 128);
            this.lblProtocolo.Name = "lblProtocolo";
            this.lblProtocolo.Size = new System.Drawing.Size(178, 21);
            this.lblProtocolo.TabIndex = 0;
            this.lblProtocolo.Text = "Protocolo do cadastro";
            // 
            // txbNomeAluno
            // 
            this.txbNomeAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNomeAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeAluno.Location = new System.Drawing.Point(142, 56);
            this.txbNomeAluno.Name = "txbNomeAluno";
            this.txbNomeAluno.Size = new System.Drawing.Size(231, 22);
            this.txbNomeAluno.TabIndex = 0;
            // 
            // txbProtocolo
            // 
            this.txbProtocolo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbProtocolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProtocolo.ForeColor = System.Drawing.Color.Red;
            this.txbProtocolo.Location = new System.Drawing.Point(501, 128);
            this.txbProtocolo.Name = "txbProtocolo";
            this.txbProtocolo.Size = new System.Drawing.Size(246, 22);
            this.txbProtocolo.TabIndex = 14;
            // 
            // groupBoxId
            // 
            this.groupBoxId.Controls.Add(this.lblIdentificacao);
            this.groupBoxId.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxId.Location = new System.Drawing.Point(11, 6);
            this.groupBoxId.Name = "groupBoxId";
            this.groupBoxId.Size = new System.Drawing.Size(125, 44);
            this.groupBoxId.TabIndex = 0;
            this.groupBoxId.TabStop = false;
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.ForeColor = System.Drawing.Color.Red;
            this.lblIdentificacao.Location = new System.Drawing.Point(6, 14);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Size = new System.Drawing.Size(113, 27);
            this.lblIdentificacao.TabIndex = 0;
            this.lblIdentificacao.Text = "label1";
            this.lblIdentificacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(379, 56);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(53, 21);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso";
            // 
            // txbCurso
            // 
            this.txbCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCurso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbCurso.Location = new System.Drawing.Point(438, 56);
            this.txbCurso.Name = "txbCurso";
            this.txbCurso.Size = new System.Drawing.Size(136, 22);
            this.txbCurso.TabIndex = 1;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(580, 56);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(41, 21);
            this.lblAno.TabIndex = 0;
            this.lblAno.Text = "Ano";
            // 
            // txbAno
            // 
            this.txbAno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbAno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbAno.Location = new System.Drawing.Point(627, 56);
            this.txbAno.Name = "txbAno";
            this.txbAno.Size = new System.Drawing.Size(56, 22);
            this.txbAno.TabIndex = 2;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(7, 94);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 21);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF";
            // 
            // txbCPF
            // 
            this.txbCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbCPF.Location = new System.Drawing.Point(51, 93);
            this.txbCPF.MaxLength = 11;
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(115, 22);
            this.txbCPF.TabIndex = 3;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(172, 94);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(31, 21);
            this.lblRG.TabIndex = 0;
            this.lblRG.Text = "RG";
            // 
            // txbRG
            // 
            this.txbRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbRG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbRG.Location = new System.Drawing.Point(209, 94);
            this.txbRG.MaxLength = 7;
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(78, 22);
            this.txbRG.TabIndex = 4;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(7, 127);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(146, 21);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Data da matrícula";
            // 
            // txbDataMatricula
            // 
            this.txbDataMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDataMatricula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDataMatricula.ForeColor = System.Drawing.Color.Red;
            this.txbDataMatricula.Location = new System.Drawing.Point(159, 127);
            this.txbDataMatricula.MaxLength = 50;
            this.txbDataMatricula.Name = "txbDataMatricula";
            this.txbDataMatricula.Size = new System.Drawing.Size(152, 22);
            this.txbDataMatricula.TabIndex = 13;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.Location = new System.Drawing.Point(7, 165);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(107, 21);
            this.lblObservacoes.TabIndex = 0;
            this.lblObservacoes.Text = "Observações";
            // 
            // txbObservacoes
            // 
            this.txbObservacoes.AllowDrop = true;
            this.txbObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbObservacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbObservacoes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbObservacoes.Location = new System.Drawing.Point(11, 189);
            this.txbObservacoes.Multiline = true;
            this.txbObservacoes.Name = "txbObservacoes";
            this.txbObservacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbObservacoes.Size = new System.Drawing.Size(798, 86);
            this.txbObservacoes.TabIndex = 5;
            // 
            // btnCarregarDados
            // 
            this.btnCarregarDados.AutoSize = true;
            this.btnCarregarDados.BackColor = System.Drawing.Color.LightBlue;
            this.btnCarregarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregarDados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCarregarDados.FlatAppearance.BorderSize = 0;
            this.btnCarregarDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnCarregarDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnCarregarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarDados.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarDados.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCarregarDados.Location = new System.Drawing.Point(450, 389);
            this.btnCarregarDados.Name = "btnCarregarDados";
            this.btnCarregarDados.Size = new System.Drawing.Size(170, 37);
            this.btnCarregarDados.TabIndex = 11;
            this.btnCarregarDados.Text = "Carregar dados do DB";
            this.btnCarregarDados.UseVisualStyleBackColor = false;
            this.btnCarregarDados.Click += new System.EventHandler(this.btnCarregarDados_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 578);
            this.Controls.Add(this.panelPai);
            this.Controls.Add(this.statusStripPrincipal);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.pictureBoxPrincipal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1225, 617);
            this.MinimumSize = new System.Drawing.Size(0, 617);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arte de Aprender";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrincipal)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.statusStripPrincipal.ResumeLayout(false);
            this.statusStripPrincipal.PerformLayout();
            this.panelPai.ResumeLayout(false);
            this.panelPai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDadosAlunos)).EndInit();
            this.groupBoxId.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPrincipal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.StatusStrip statusStripPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panelPai;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimparDados;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.DataGridView dataGridViewDadosAlunos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbProtocolo;
        private System.Windows.Forms.TextBox txbNomeAluno;
        private System.Windows.Forms.Label lblProtocolo;
        private System.Windows.Forms.TextBox txbCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.GroupBox groupBoxId;
        private System.Windows.Forms.Label lblIdentificacao;
        private System.Windows.Forms.TextBox txbAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox txbObservacoes;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.TextBox txbDataMatricula;
        private System.Windows.Forms.Button btnCarregarDados;
    }
}

