
namespace Aula_03Login
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
			this.lblusuario = new System.Windows.Forms.Label();
			this.lblsenha = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtsenha = new System.Windows.Forms.TextBox();
			this.btnConectar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.PanelSaldo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.PanelSaldo.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblusuario
			// 
			this.lblusuario.AutoSize = true;
			this.lblusuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblusuario.Location = new System.Drawing.Point(40, 41);
			this.lblusuario.Name = "lblusuario";
			this.lblusuario.Size = new System.Drawing.Size(122, 16);
			this.lblusuario.TabIndex = 0;
			this.lblusuario.Text = "Digite seu Usuário";
			// 
			// lblsenha
			// 
			this.lblsenha.AutoSize = true;
			this.lblsenha.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblsenha.Location = new System.Drawing.Point(40, 158);
			this.lblsenha.Name = "lblsenha";
			this.lblsenha.Size = new System.Drawing.Size(111, 16);
			this.lblsenha.TabIndex = 1;
			this.lblsenha.Text = "Digite sua senha";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(43, 84);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(242, 20);
			this.txtUsuario.TabIndex = 2;
			// 
			// txtsenha
			// 
			this.txtsenha.Location = new System.Drawing.Point(43, 203);
			this.txtsenha.Name = "txtsenha";
			this.txtsenha.PasswordChar = 'ඞ';
			this.txtsenha.Size = new System.Drawing.Size(242, 20);
			this.txtsenha.TabIndex = 3;
			// 
			// btnConectar
			// 
			this.btnConectar.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConectar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConectar.ForeColor = System.Drawing.Color.Aqua;
			this.btnConectar.Location = new System.Drawing.Point(67, 254);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(195, 49);
			this.btnConectar.TabIndex = 4;
			this.btnConectar.Text = "Conectar";
			this.btnConectar.UseVisualStyleBackColor = false;
			this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel1.Controls.Add(this.lblusuario);
			this.panel1.Controls.Add(this.btnConectar);
			this.panel1.Controls.Add(this.txtUsuario);
			this.panel1.Controls.Add(this.lblsenha);
			this.panel1.Controls.Add(this.txtsenha);
			this.panel1.Location = new System.Drawing.Point(43, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(354, 342);
			this.panel1.TabIndex = 5;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// PanelSaldo
			// 
			this.PanelSaldo.Controls.Add(this.checkBox1);
			this.PanelSaldo.Controls.Add(this.button1);
			this.PanelSaldo.Controls.Add(this.textBox1);
			this.PanelSaldo.Controls.Add(this.label1);
			this.PanelSaldo.Location = new System.Drawing.Point(501, 39);
			this.PanelSaldo.Name = "PanelSaldo";
			this.PanelSaldo.Size = new System.Drawing.Size(295, 212);
			this.PanelSaldo.TabIndex = 6;
			this.PanelSaldo.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Seu Saldo R$ 0";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(52, 107);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(142, 20);
			this.textBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Turquoise;
			this.button1.Location = new System.Drawing.Point(52, 147);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "Salvar";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(52, 84);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(71, 17);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Aumentar";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.ClientSize = new System.Drawing.Size(882, 433);
			this.Controls.Add(this.PanelSaldo);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.PanelSaldo.ResumeLayout(false);
			this.PanelSaldo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblusuario;
		private System.Windows.Forms.Label lblsenha;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtsenha;
		private System.Windows.Forms.Button btnConectar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel PanelSaldo;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}

