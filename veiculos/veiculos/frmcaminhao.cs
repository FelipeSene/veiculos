using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veiculos
{
    public partial class frmcaminhao : Form
    {

        Caminhao caminhao;
        public frmcaminhao()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            caminhao = new Caminhao(txtcabine.Text, txtporte.Text, (Convert.ToInt32(txteixos.Text)), txtmarca.Text, (Convert.ToInt32(txtpassageiros.Text)),
            (Convert.ToInt32(txtchassi.Text)), txtmodelo.Text, txtplaca.Text);

            txtmarca.Clear();
            txtpassageiros.Clear();
            txtchassi.Clear();
            txtcabine.Clear();
            txtporte.Clear();
            txtmodelo.Clear();
            txteixos.Clear();
            txtplaca.Clear();

            MessageBox.Show("Caminhão cadastrado com sucesso.");

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.Aparece());
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            menu.Show();
            this.Hide();
        }
    }
}
