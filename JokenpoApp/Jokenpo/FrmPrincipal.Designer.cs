namespace Jokenpo
{
    partial class FrmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPapel1 = new System.Windows.Forms.Button();
            this.btnPedra1 = new System.Windows.Forms.Button();
            this.btnTesoura1 = new System.Windows.Forms.Button();
            this.btnTesoura2 = new System.Windows.Forms.Button();
            this.btnPedra2 = new System.Windows.Forms.Button();
            this.btnPapel2 = new System.Windows.Forms.Button();
            this.btnAvaliar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-Vindo ao Jokenpo!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione a jogada do Jogador 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selecione a jogada do Jogador 2:";
            // 
            // btnPapel1
            // 
            this.btnPapel1.Location = new System.Drawing.Point(49, 161);
            this.btnPapel1.Name = "btnPapel1";
            this.btnPapel1.Size = new System.Drawing.Size(112, 23);
            this.btnPapel1.TabIndex = 3;
            this.btnPapel1.Text = "Papel";
            this.btnPapel1.UseVisualStyleBackColor = true;
            this.btnPapel1.Click += new System.EventHandler(this.btnPapel1_Click);
            // 
            // btnPedra1
            // 
            this.btnPedra1.Location = new System.Drawing.Point(167, 161);
            this.btnPedra1.Name = "btnPedra1";
            this.btnPedra1.Size = new System.Drawing.Size(112, 23);
            this.btnPedra1.TabIndex = 4;
            this.btnPedra1.Text = "Pedra";
            this.btnPedra1.UseVisualStyleBackColor = true;
            this.btnPedra1.Click += new System.EventHandler(this.btnPedra1_Click);
            // 
            // btnTesoura1
            // 
            this.btnTesoura1.Location = new System.Drawing.Point(285, 161);
            this.btnTesoura1.Name = "btnTesoura1";
            this.btnTesoura1.Size = new System.Drawing.Size(112, 23);
            this.btnTesoura1.TabIndex = 5;
            this.btnTesoura1.Text = "Tesoura";
            this.btnTesoura1.UseVisualStyleBackColor = true;
            this.btnTesoura1.Click += new System.EventHandler(this.btnTesoura1_Click);
            // 
            // btnTesoura2
            // 
            this.btnTesoura2.Location = new System.Drawing.Point(285, 248);
            this.btnTesoura2.Name = "btnTesoura2";
            this.btnTesoura2.Size = new System.Drawing.Size(112, 23);
            this.btnTesoura2.TabIndex = 8;
            this.btnTesoura2.Text = "Tesoura";
            this.btnTesoura2.UseVisualStyleBackColor = true;
            this.btnTesoura2.Click += new System.EventHandler(this.btnTesoura2_Click);
            // 
            // btnPedra2
            // 
            this.btnPedra2.Location = new System.Drawing.Point(167, 248);
            this.btnPedra2.Name = "btnPedra2";
            this.btnPedra2.Size = new System.Drawing.Size(112, 23);
            this.btnPedra2.TabIndex = 7;
            this.btnPedra2.Text = "Pedra";
            this.btnPedra2.UseVisualStyleBackColor = true;
            this.btnPedra2.Click += new System.EventHandler(this.btnPedra2_Click);
            // 
            // btnPapel2
            // 
            this.btnPapel2.Location = new System.Drawing.Point(49, 248);
            this.btnPapel2.Name = "btnPapel2";
            this.btnPapel2.Size = new System.Drawing.Size(112, 23);
            this.btnPapel2.TabIndex = 6;
            this.btnPapel2.Text = "Papel";
            this.btnPapel2.UseVisualStyleBackColor = true;
            this.btnPapel2.Click += new System.EventHandler(this.btnPapel2_Click);
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.Location = new System.Drawing.Point(49, 330);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(547, 51);
            this.btnAvaliar.TabIndex = 9;
            this.btnAvaliar.Text = "AVALIAR RESULTADO";
            this.btnAvaliar.UseVisualStyleBackColor = true;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 431);
            this.Controls.Add(this.btnAvaliar);
            this.Controls.Add(this.btnTesoura2);
            this.Controls.Add(this.btnPedra2);
            this.Controls.Add(this.btnPapel2);
            this.Controls.Add(this.btnTesoura1);
            this.Controls.Add(this.btnPedra1);
            this.Controls.Add(this.btnPapel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokenpo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPapel1;
        private System.Windows.Forms.Button btnPedra1;
        private System.Windows.Forms.Button btnTesoura1;
        private System.Windows.Forms.Button btnTesoura2;
        private System.Windows.Forms.Button btnPedra2;
        private System.Windows.Forms.Button btnPapel2;
        private System.Windows.Forms.Button btnAvaliar;
    }
}

