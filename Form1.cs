using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech4You
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas frmMarcas= new frmMarcas();
            frmMarcas.MdiParent = frmMenu.ActiveForm;
            frmMarcas.Show();
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            frmModelos frmModelos = new frmModelos();
            frmModelos.MdiParent = frmMenu.ActiveForm;
            frmModelos.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Botão para sair da APP
            Application.Exit();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ato de fechar em si
            if (MessageBox.Show("Tem a certeza que pretende sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }
    }
}
