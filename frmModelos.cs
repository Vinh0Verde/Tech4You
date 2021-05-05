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
    public partial class frmModelos : Form
    {
        OleDbConnection Conn;
        int iID = 0;

        public frmModelos()
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
            lvModelos.View = View.Details;
            lvModelos.GridLines = true;
            lvModelos.FullRowSelect = true;
            lvModelos.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lvModelos.Columns.Add("Marca", 150, HorizontalAlignment.Left);
            lvModelos.Columns.Add("Modelo", 150, HorizontalAlignment.Left);
        }

        private void Listar()
        {
            lvModelos.Clear();
            FormatarListView();
            OleDbCommand command;
            OleDbDataReader dbDataReader;
            string sSql;
            sSql = "SELECT * FROM Marcas INNER JOIN Modelos ON Marcas.ID_Marca = Modelos.ID_Marca";
            LigarBD();
            command = new OleDbCommand(sSql, Conn);
            dbDataReader = command.ExecuteReader();
            while (dbDataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dbDataReader.GetInt32(2).ToString(), dbDataReader.GetString(1), dbDataReader.GetString(3) });
                lvModelos.Items.Add(item);
            }
            Conn.Close();
        }

        private void CarregarCBB()
        {
            OleDbCommand command;
            OleDbDataReader dbDataReader;
            string sSql;
            sSql = "SELECT DescMarca FROM Marcas";
            LigarBD();
            command = new OleDbCommand(sSql, Conn);
            dbDataReader = command.ExecuteReader();
            while (dbDataReader.Read())
            {
                cbbMarcas.Items.Add(dbDataReader.GetString(0));
            }
            cbbMarcas.SelectedIndex = 0;
        }

        private void frmModelos_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            Listar();
            CarregarCBB();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            OleDbCommand command;
            OleDbDataReader dbDataReader;
            string sSql;
            sSql = "SELECT DescModelos FROM Modelos WHERE DescModelos ='" + txtModelo.Text + "'";
            LigarBD();
            command = new OleDbCommand(sSql, Conn);
            dbDataReader = command.ExecuteReader();
            if (dbDataReader.Read())
            {
                MessageBox.Show("O Modelo já existe no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtModelo.Text == "")
                {
                    MessageBox.Show("O campo é de preenchimento obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sSql = "SELECT ID_Marca FROM Marcas WHERE DescMarca = '" + cbbMarcas.Text + "'";
                    command = new OleDbCommand(sSql, Conn);
                    dbDataReader=command.ExecuteReader();
                    if (dbDataReader.Read())
                    {
                        iID = dbDataReader.GetInt32(0);
                    }
                    sSql = "INSERT INTO Modelos (DescModelos, ID_Marca) VALUES ('" + txtModelo.Text + "'," + iID + ")";
                    command = new OleDbCommand(sSql, Conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Modelo registado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                }
            }
            Conn.Close();
        }

        private void lvMarcas_DoubleClick(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            lvModelos.Text = lvModelos.SelectedItems[0].SubItems[1].Text;
            iID = Convert.ToInt32(lvModelos.SelectedItems[0].Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            OleDbCommand command;
            string sSql;
            sSql = "UPDATE Modelos SET DescModelos = '" + txtModelo.Text + "' WHERE ID_Marca = " + iID + "";
            LigarBD();
            command = new OleDbCommand(sSql, Conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Modelo editado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
            Conn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pretende eliminar o modelo selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnEditar.Enabled = false;
                OleDbCommand command;
                string sSql;
                sSql = "DELETE FROM Modelos WHERE ID_Modelos=" + lvModelos.SelectedItems[0].Text + "";
                LigarBD();
                command = new OleDbCommand(sSql, Conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Modelo eliminado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
