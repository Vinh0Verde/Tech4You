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
    public partial class frmMarcas : Form
    {
        OleDbConnection Conn;
        int iID = 0;
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void LigarBD()
        {
            string sConnectionString = "";
            Conn = new OleDbConnection();
            try
            {
                sConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\BD\\BDTech4You.accdb";
                Conn.ConnectionString = sConnectionString;
                Conn.Open();
            }
            catch
            {
                MessageBox.Show("Ligação NOT OK");
            }
        }

        private void FormatarListView()
        {
            lvMarcas.View = View.Details;
            lvMarcas.GridLines = true;
            lvMarcas.FullRowSelect = true;
            lvMarcas.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lvMarcas.Columns.Add("Marca", 110, HorizontalAlignment.Left);
        }

        private void Listar()
        {
            lvMarcas.Clear();
            FormatarListView();
            OleDbCommand command;
            OleDbDataReader dbDataReader;
            string sSql;
            sSql = "SELECT ID_Marca, DescMarca FROM Marcas";
            LigarBD();
            command = new OleDbCommand(sSql, Conn);
            dbDataReader = command.ExecuteReader();
            while (dbDataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dbDataReader.GetInt32(0).ToString(), dbDataReader.GetString(1)});
                lvMarcas.Items.Add(item);
            }
            Conn.Close();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            Listar();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            OleDbCommand command;
            OleDbDataReader dbDataReader;
            string sSql;
            sSql = "SELECT DescMarca FROM Marcas WHERE DescMarca='" + txtMarca.Text + "'";
            LigarBD();
            command = new OleDbCommand(sSql, Conn);
            dbDataReader = command.ExecuteReader();
            if (dbDataReader.Read())
            {
                MessageBox.Show("A marca já existe no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtMarca.Text == "")
                {
                    MessageBox.Show("O campo é de preenchimento obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sSql = "INSERT INTO Marcas (DescMarca) VALUES ('" + txtMarca.Text + "')";
                    command = new OleDbCommand(sSql, Conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Marca registada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                }
            }
            Conn.Close();
        }

        private void lvMarcas_DoubleClick(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            txtMarca.Text = lvMarcas.SelectedItems[0].SubItems[1].Text;
            iID = Convert.ToInt32(lvMarcas.SelectedItems[0].Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            OleDbCommand command;
            string sSql;
            sSql = "UPDATE Marcas SET DescMarca = '" + txtMarca.Text + "' WHERE ID_Marca= " + iID + "";
            LigarBD();
            command = new OleDbCommand(sSql, Conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Modelo editado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
            Conn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pretende eliminar a marca selecionada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnEditar.Enabled = false;
                OleDbCommand command;
                string sSql;
                sSql = "DELETE FROM Marcas WHERE ID_Marca=" + lvMarcas.SelectedItems[0].Text + "";
                LigarBD();
                command = new OleDbCommand(sSql, Conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Marca eliminada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
                Conn.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
