using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tentativa_de_telas
{
    public partial class FrmTelaInicio : Form
    {
        public FrmTelaInicio()
        {
            InitializeComponent();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telainicionovo_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void TxtUsuario_TextChanged_1(object sender, EventArgs e)
        {   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String User = "caua";
            String Password = "caua123";


            if (TxtUsuario.Text == User & TxtSenha.Text == Password)
            {
                MessageBox.Show("Acesso Liberado!");
                FrmCatalogo frmCatalogo = new FrmCatalogo();
                frmCatalogo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorreto");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vamos para area de cadastro");
            FrmTelaCadastro frmTelaCadastro = new FrmTelaCadastro();
            frmTelaCadastro.Show();
            this.Hide();
        }
    }
}
