namespace ColoniaDePescadores
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panelDeNavegacao = new System.Windows.Forms.Panel();
            this.panelDePaginas = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnParceiros = new System.Windows.Forms.Button();
            this.btnColaboradores = new System.Windows.Forms.Button();
            this.btnFinanciamento = new System.Windows.Forms.Button();
            this.btnAreaPescador = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelDeNavegacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDeNavegacao
            // 
            this.panelDeNavegacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(43)))));
            this.panelDeNavegacao.Controls.Add(this.btnSair);
            this.panelDeNavegacao.Controls.Add(this.btnParceiros);
            this.panelDeNavegacao.Controls.Add(this.btnColaboradores);
            this.panelDeNavegacao.Controls.Add(this.btnFinanciamento);
            this.panelDeNavegacao.Controls.Add(this.btnAreaPescador);
            this.panelDeNavegacao.Controls.Add(this.pictureBoxLogo);
            this.panelDeNavegacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeNavegacao.Location = new System.Drawing.Point(0, 0);
            this.panelDeNavegacao.Name = "panelDeNavegacao";
            this.panelDeNavegacao.Size = new System.Drawing.Size(1904, 80);
            this.panelDeNavegacao.TabIndex = 0;
            // 
            // panelDePaginas
            // 
            this.panelDePaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDePaginas.Location = new System.Drawing.Point(0, 80);
            this.panelDePaginas.Name = "panelDePaginas";
            this.panelDePaginas.Size = new System.Drawing.Size(1904, 961);
            this.panelDePaginas.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(186)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = global::ColoniaDePescadores.Properties.Resources.Sair_do_sistema;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(1728, 10);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 61);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnParceiros
            // 
            this.btnParceiros.BackColor = System.Drawing.Color.Transparent;
            this.btnParceiros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParceiros.FlatAppearance.BorderSize = 0;
            this.btnParceiros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.btnParceiros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(186)))));
            this.btnParceiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParceiros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParceiros.ForeColor = System.Drawing.Color.White;
            this.btnParceiros.Image = global::ColoniaDePescadores.Properties.Resources.categorias_;
            this.btnParceiros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnParceiros.Location = new System.Drawing.Point(1411, 10);
            this.btnParceiros.Name = "btnParceiros";
            this.btnParceiros.Size = new System.Drawing.Size(146, 61);
            this.btnParceiros.TabIndex = 4;
            this.btnParceiros.Text = "Parceiros";
            this.btnParceiros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnParceiros.UseVisualStyleBackColor = false;
            this.btnParceiros.Click += new System.EventHandler(this.btnParceiros_Click);
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.BackColor = System.Drawing.Color.Transparent;
            this.btnColaboradores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColaboradores.FlatAppearance.BorderSize = 0;
            this.btnColaboradores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.btnColaboradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(186)))));
            this.btnColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColaboradores.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaboradores.ForeColor = System.Drawing.Color.White;
            this.btnColaboradores.Image = global::ColoniaDePescadores.Properties.Resources.funcionarios;
            this.btnColaboradores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColaboradores.Location = new System.Drawing.Point(1017, 10);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Size = new System.Drawing.Size(222, 61);
            this.btnColaboradores.TabIndex = 3;
            this.btnColaboradores.Text = "Colaboradores";
            this.btnColaboradores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColaboradores.UseVisualStyleBackColor = false;
            this.btnColaboradores.Click += new System.EventHandler(this.btnColaboradores_Click);
            // 
            // btnFinanciamento
            // 
            this.btnFinanciamento.BackColor = System.Drawing.Color.Transparent;
            this.btnFinanciamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinanciamento.FlatAppearance.BorderSize = 0;
            this.btnFinanciamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.btnFinanciamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(186)))));
            this.btnFinanciamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanciamento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanciamento.ForeColor = System.Drawing.Color.White;
            this.btnFinanciamento.Image = global::ColoniaDePescadores.Properties.Resources.Finanças;
            this.btnFinanciamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinanciamento.Location = new System.Drawing.Point(628, 10);
            this.btnFinanciamento.Name = "btnFinanciamento";
            this.btnFinanciamento.Size = new System.Drawing.Size(220, 61);
            this.btnFinanciamento.TabIndex = 2;
            this.btnFinanciamento.Text = "Financiamento";
            this.btnFinanciamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinanciamento.UseVisualStyleBackColor = false;
            this.btnFinanciamento.Click += new System.EventHandler(this.btnFinanciamento_Click);
            // 
            // btnAreaPescador
            // 
            this.btnAreaPescador.BackColor = System.Drawing.Color.Transparent;
            this.btnAreaPescador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAreaPescador.FlatAppearance.BorderSize = 0;
            this.btnAreaPescador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.btnAreaPescador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(186)))));
            this.btnAreaPescador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreaPescador.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaPescador.ForeColor = System.Drawing.Color.White;
            this.btnAreaPescador.Image = global::ColoniaDePescadores.Properties.Resources.clients;
            this.btnAreaPescador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAreaPescador.Location = new System.Drawing.Point(199, 10);
            this.btnAreaPescador.Name = "btnAreaPescador";
            this.btnAreaPescador.Size = new System.Drawing.Size(262, 61);
            this.btnAreaPescador.TabIndex = 1;
            this.btnAreaPescador.Text = "Área do Pescador";
            this.btnAreaPescador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAreaPescador.UseVisualStyleBackColor = false;
            this.btnAreaPescador.Click += new System.EventHandler(this.btnAreaPescador_Click_1);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.Image = global::ColoniaDePescadores.Properties.Resources.logo_marlin;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(86, 80);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 24;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click_1);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelDePaginas);
            this.Controls.Add(this.panelDeNavegacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spark - Colônia da Pesca";
            this.panelDeNavegacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDeNavegacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnParceiros;
        private System.Windows.Forms.Button btnColaboradores;
        private System.Windows.Forms.Button btnFinanciamento;
        private System.Windows.Forms.Button btnAreaPescador;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelDePaginas;
    }
}

