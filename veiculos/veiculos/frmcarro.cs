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
        public frmcarro()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            menu.Show();
            this.Hide();
        }
    }
}
