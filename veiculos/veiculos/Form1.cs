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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void btncar_Click(object sender, EventArgs e)
        {
            frmcarro carro = new frmcarro();
            carro.Show();
            this.Hide();
        }

        private void btncami_Click(object sender, EventArgs e)
        {
            frmcaminhao caminhao = new frmcaminhao();
            caminhao.Show();
            this.Hide();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

}
