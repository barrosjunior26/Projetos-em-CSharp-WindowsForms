namespace ColoniaDePescadores
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelLateralLogin = new System.Windows.Forms.Panel();
            this.pictureBoxImagemPesca = new System.Windows.Forms.PictureBox();
            this.labelTituloLogin = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.pictureBoxLogoPesca = new System.Windows.Forms.PictureBox();
            this.btnVerSenha = new System.Windows.Forms.Button();
            this.pictureBoxSenha = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsuário = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.BntEntrar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panelLateralLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemPesca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoPesca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuário)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1017, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(124, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panelLateralLogin
            // 
            this.panelLateralLogin.Controls.Add(this.pictureBoxImagemPesca);
            this.panelLateralLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateralLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLateralLogin.Name = "panelLateralLogin";
            this.panelLateralLogin.Size = new System.Drawing.Size(414, 554);
            this.panelLateralLogin.TabIndex = 1;
            // 
            // pictureBoxImagemPesca
            // 
            this.pictureBoxImagemPesca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImagemPesca.Image = global::ColoniaDePescadores.Properties.Resources.pexels_quang_nguyen_vinh_2131904cópiaeditada;
            this.pictureBoxImagemPesca.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImagemPesca.Name = "pictureBoxImagemPesca";
            this.pictureBoxImagemPesca.Size = new System.Drawing.Size(414, 554);
            this.pictureBoxImagemPesca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagemPesca.TabIndex = 0;
            this.pictureBoxImagemPesca.TabStop = false;
            // 
            // labelTituloLogin
            // 
            this.labelTituloLogin.AutoSize = true;
            this.labelTituloLogin.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(186)))));
            this.labelTituloLogin.Location = new System.Drawing.Point(420, 203);
            this.labelTituloLogin.Name = "labelTituloLogin";
            this.labelTituloLogin.Size = new System.Drawing.Size(365, 56);
            this.labelTituloLogin.TabIndex = 7;
            this.labelTituloLogin.Text = "Faça seu login";
            // 
            // txbUsuario
            // 
            this.txbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsuario.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(466, 262);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(511, 30);
            this.txbUsuario.TabIndex = 10;
            // 
            // txbSenha
            // 
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSenha.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(466, 299);
            this.txbSenha.MaxLength = 6;
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(511, 30);
            this.txbSenha.TabIndex = 11;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // pictureBoxLogoPesca
            // 
            this.pictureBoxLogoPesca.Image = global::ColoniaDePescadores.Properties.Resources.logo_do_meu_projeto1;
            this.pictureBoxLogoPesca.Location = new System.Drawing.Point(883, 0);
            this.pictureBoxLogoPesca.Name = "pictureBoxLogoPesca";
            this.pictureBoxLogoPesca.Size = new System.Drawing.Size(134, 129);
            this.pictureBoxLogoPesca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoPesca.TabIndex = 13;
            this.pictureBoxLogoPesca.TabStop = false;
            // 
            // btnVerSenha
            // 
            this.btnVerSenha.BackColor = System.Drawing.Color.White;
            this.btnVerSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerSenha.FlatAppearance.BorderSize = 0;
            this.btnVerSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSenha.Image = global::ColoniaDePescadores.Properties.Resources.eye;
            this.btnVerSenha.Location = new System.Drawing.Point(936, 299);
            this.btnVerSenha.Name = "btnVerSenha";
            this.btnVerSenha.Size = new System.Drawing.Size(41, 30);
            this.btnVerSenha.TabIndex = 12;
            this.btnVerSenha.UseVisualStyleBackColor = false;
            this.btnVerSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVerSenha_MouseDown);
            this.btnVerSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVerSenha_MouseUp);
            // 
            // pictureBoxSenha
            // 
            this.pictureBoxSenha.Image = global::ColoniaDePescadores.Properties.Resources.security;
            this.pictureBoxSenha.Location = new System.Drawing.Point(430, 298);
            this.pictureBoxSenha.Name = "pictureBoxSenha";
            this.pictureBoxSenha.Size = new System.Drawing.Size(30, 31);
            this.pictureBoxSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSenha.TabIndex = 9;
            this.pictureBoxSenha.TabStop = false;
            // 
            // pictureBoxUsuário
            // 
            this.pictureBoxUsuário.Image = global::ColoniaDePescadores.Properties.Resources.userLogin;
            this.pictureBoxUsuário.Location = new System.Drawing.Point(430, 261);
            this.pictureBoxUsuário.Name = "pictureBoxUsuário";
            this.pictureBoxUsuário.Size = new System.Drawing.Size(30, 31);
            this.pictureBoxUsuário.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsuário.TabIndex = 8;
            this.pictureBoxUsuário.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Image = global::ColoniaDePescadores.Properties.Resources.Sair_do_sistema;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(833, 498);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 53);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTestarConexao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestarConexao.FlatAppearance.BorderSize = 0;
            this.btnTestarConexao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarConexao.ForeColor = System.Drawing.Color.Black;
            this.btnTestarConexao.Image = global::ColoniaDePescadores.Properties.Resources.conexao_na_nuvem;
            this.btnTestarConexao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTestarConexao.Location = new System.Drawing.Point(728, 498);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(99, 53);
            this.btnTestarConexao.TabIndex = 5;
            this.btnTestarConexao.Text = "Testar Conexão";
            this.btnTestarConexao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTestarConexao.UseVisualStyleBackColor = false;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Image = global::ColoniaDePescadores.Properties.Resources.Botão_limpar_limpo;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(623, 498);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 53);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // BntEntrar
            // 
            this.BntEntrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BntEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BntEntrar.FlatAppearance.BorderSize = 0;
            this.BntEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(186)))));
            this.BntEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(186)))));
            this.BntEntrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntEntrar.ForeColor = System.Drawing.Color.Black;
            this.BntEntrar.Image = global::ColoniaDePescadores.Properties.Resources.conecte_se;
            this.BntEntrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BntEntrar.Location = new System.Drawing.Point(518, 498);
            this.BntEntrar.Name = "BntEntrar";
            this.BntEntrar.Size = new System.Drawing.Size(99, 53);
            this.BntEntrar.TabIndex = 3;
            this.BntEntrar.Text = "Acessar";
            this.BntEntrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BntEntrar.UseVisualStyleBackColor = false;
            this.BntEntrar.Click += new System.EventHandler(this.BntEntrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1017, 576);
            this.Controls.Add(this.pictureBoxLogoPesca);
            this.Controls.Add(this.btnVerSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.pictureBoxSenha);
            this.Controls.Add(this.pictureBoxUsuário);
            this.Controls.Add(this.labelTituloLogin);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTestarConexao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.BntEntrar);
            this.Controls.Add(this.panelLateralLogin);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spark - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelLateralLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemPesca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoPesca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuário)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panelLateralLogin;
        private System.Windows.Forms.PictureBox pictureBoxImagemPesca;
        private System.Windows.Forms.Button BntEntrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label labelTituloLogin;
        private System.Windows.Forms.PictureBox pictureBoxUsuário;
        private System.Windows.Forms.PictureBox pictureBoxSenha;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnVerSenha;
        private System.Windows.Forms.PictureBox pictureBoxLogoPesca;
    }
}