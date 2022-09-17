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

            if (String.IsNullOrWhiteSpace(txtmarca.Text) || String.IsNullOrWhiteSpace(txtpassageiros.Text) || String.IsNullOrWhiteSpace(txtchassi.Text)
             || String.IsNullOrWhiteSpace(txtmodelo.Text) || String.IsNullOrWhiteSpace(txtplaca.Text) || String.IsNullOrWhiteSpace(txtcabine.Text) 
             || String.IsNullOrWhiteSpace(txtporte.Text) || String.IsNullOrWhiteSpace(txteixos.Text))
            {

                MessageBox.Show("Todos os campos devem ser preenchidos.");

            } 
            else 
            {

                caminhao = new Caminhao(txtcabine.Text, txtporte.Text, Convert.ToInt32(txteixos.Text), txtmarca.Text, Convert.ToInt32(txtpassageiros.Text),
                Convert.ToInt32(txtchassi.Text), txtmodelo.Text, txtplaca.Text);

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

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {

            if (caminhao == null)
            {
                MessageBox.Show("Nenhum caminhão cadastrado.");
            }
            else
            {
                MessageBox.Show(caminhao.Aparece());
            }

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            menu.Show();
            this.Hide();
        }
    }
}
