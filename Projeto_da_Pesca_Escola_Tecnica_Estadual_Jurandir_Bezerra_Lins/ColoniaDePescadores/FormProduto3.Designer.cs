namespace ColoniaDePescadores
{
    partial class FormProduto3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto3));
            this.groupBoxDescricaoTecnica1 = new System.Windows.Forms.GroupBox();
            this.lblDescricaoTecnica1 = new System.Windows.Forms.Label();
            this.pictureBoxMotot1 = new System.Windows.Forms.PictureBox();
            this.groupBoxDescricaoTecnica1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotot1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDescricaoTecnica1
            // 
            this.groupBoxDescricaoTecnica1.Controls.Add(this.lblDescricaoTecnica1);
            this.groupBoxDescricaoTecnica1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDescricaoTecnica1.Location = new System.Drawing.Point(12, 290);
            this.groupBoxDescricaoTecnica1.Name = "groupBoxDescricaoTecnica1";
            this.groupBoxDescricaoTecnica1.Size = new System.Drawing.Size(377, 339);
            this.groupBoxDescricaoTecnica1.TabIndex = 5;
            this.groupBoxDescricaoTecnica1.TabStop = false;
            this.groupBoxDescricaoTecnica1.Text = "Descrição técnica";
            // 
            // lblDescricaoTecnica1
            // 
            this.lblDescricaoTecnica1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoTecnica1.Location = new System.Drawing.Point(6, 33);
            this.lblDescricaoTecnica1.Name = "lblDescricaoTecnica1";
            this.lblDescricaoTecnica1.Size = new System.Drawing.Size(365, 309);
            this.lblDescricaoTecnica1.TabIndex = 0;
            this.lblDescricaoTecnica1.Text = resources.GetString("lblDescricaoTecnica1.Text");
            // 
            // pictureBoxMotot1
            // 
            this.pictureBoxMotot1.Image = global::ColoniaDePescadores.Properties.Resources.Motor_a_Diesel_Branco_BD7_0H_G2___Partida_Eletrica;
            this.pictureBoxMotot1.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMotot1.Name = "pictureBoxMotot1";
            this.pictureBoxMotot1.Size = new System.Drawing.Size(377, 272);
            this.pictureBoxMotot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMotot1.TabIndex = 4;
            this.pictureBoxMotot1.TabStop = false;
            // 
            // FormProduto3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 641);
            this.Controls.Add(this.groupBoxDescricaoTecnica1);
            this.Controls.Add(this.pictureBoxMotot1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProduto3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spark - Descrição do produto";
            this.groupBoxDescricaoTecnica1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotot1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDescricaoTecnica1;
        private System.Windows.Forms.Label lblDescricaoTecnica1;
        private System.Windows.Forms.PictureBox pictureBoxMotot1;
    }
}