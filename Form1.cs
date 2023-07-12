using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_03Login
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnConectar_Click(object sender, EventArgs e)
		{
			string usuario;
			string senha;

			usuario = txtUsuario.Text;
			senha = txtsenha.Text;

			if (usuario == "Vito666" && senha == "666") {
				MessageBox.Show("Conectado com sucesso ඞ");
				PanelSaldo.Visible = true;

			}else{

				MessageBox.Show("Usuário ou senha incorretos.");
			}

		}
	}
}
