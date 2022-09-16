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
    public partial class frmcarro : Form
    {

        Carro carro;
        public frmcarro()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            carro = new Carro(txtcarroceria.Text, (Convert.ToInt32(txtportas.Text)), (Convert.ToInt32(txtmalas.Text)), txtmarca.Text, (Convert.ToInt32(txtpassageiros.Text)),
            (Convert.ToInt32(txtchassi.Text)), txtmodelo.Text, txtplaca.Text);

            txtmarca.Clear();
            txtpassageiros.Clear();
            txtchassi.Clear();
            txtmodelo.Clear();
            txtplaca.Clear();
            txtcarroceria.Clear();
            txtportas.Clear();
            txtmalas.Clear();
            

            MessageBox.Show("Carro cadastrado com sucesso.");

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.Aparece());
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            menu.Show();
            this.Hide();
        }
    }
}
