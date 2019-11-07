namespace Sistema_cantina
{
	partial class Form1
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
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lstCaixa = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(29, 67);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 20);
			this.txtCodigo.TabIndex = 1;
			this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Location = new System.Drawing.Point(132, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(83, 13);
			this.lblTitulo.TabIndex = 2;
			this.lblTitulo.Text = "Sistema Cantina";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Código do produto";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(68, 228);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(61, 13);
			this.lblTotal.TabIndex = 4;
			this.lblTotal.Text = "Valor Total:";
			// 
			// lstCaixa
			// 
			this.lstCaixa.FormattingEnabled = true;
			this.lstCaixa.Location = new System.Drawing.Point(135, 51);
			this.lstCaixa.Name = "lstCaixa";
			this.lstCaixa.Size = new System.Drawing.Size(231, 173);
			this.lstCaixa.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 310);
			this.Controls.Add(this.lstCaixa);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.txtCodigo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.ListBox lstCaixa;
	}
}

