using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Produtos
{
    public partial class Client : Form
    {
        string queryClient = String.Format(@"
                SELECT
                    n_idClient as 'ID',
                    t_nameClient as 'Nome',
                    t_cpf_cnpj as 'Identificação',
                    t_telephone as 'Telefone',
                    t_email as 'e-mail',
                    t_status as 'Status'
                FROM
                    tb_client;
            ");
        private BindingSource bindingSource;
        int idSelecionado;
        public Client()
        {
            InitializeComponent();
        }
        public void AtualizarDados()
        {
            dgv_client.DataSource = Banco.DQL(queryClient);
        }
        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientAdd add = new ClientAdd();    
            add.ShowDialog();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientOpen open = new ClientOpen(idSelecionado); 
            open.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ClientAdd add = new ClientAdd();
            add.ShowDialog();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = Banco.DQL(queryClient);
            dgv_client.DataSource = bindingSource;
        }

        private void dgv_client_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int countLine = dgv.SelectedRows.Count;
            if (countLine > 0)
            {
                DataTable dt = new DataTable();
                string vID = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string query = String.Format(@"
                SELECT * FROM tb_client WHERE n_idClient={0}",vID);
                dt = Banco.DQL(query);
                tb_id.Text = dt.Rows[0].Field<Int32>("n_idClient").ToString();
                tb_name.Text = dt.Rows[0].Field<string>("t_nameClient");
                mtb_cpfORcnpj.Text = dt.Rows[0].Field<string>("t_cpf_cnpj");

                idSelecionado = dt.Rows[0].Field<Int32>("n_idClient");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string valueToSearch = " ";
            string columnName = "";

            if (tb_id.Text != "")
            {
                valueToSearch = tb_id.Text;
                columnName = "ID";
            }
            else if (tb_name.Text != "")
            {
                valueToSearch = tb_name.Text;
                columnName = "Nome";
            }
            else if (mtb_cpfORcnpj.Text != "")
            {
                valueToSearch = mtb_cpfORcnpj.Text;
                columnName = "Identificação";
            }

            if (!string.IsNullOrEmpty(valueToSearch) && !string.IsNullOrEmpty(columnName))
            {
                foreach (DataGridViewRow row in dgv_client.Rows)
                {
                    if (row.Cells[columnName].Value != null && row.Cells[columnName].Value.ToString().Equals(valueToSearch))
                    {
                        row.Selected = true;
                        dgv_client.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
            
        }

        private void rb_cpf_CheckedChanged(object sender, EventArgs e)
        {
            mtb_cpfORcnpj.Mask = "000,000,000 - 00";
        }

        private void rb_cnpj_CheckedChanged(object sender, EventArgs e)
        {
            mtb_cpfORcnpj.Mask = "00,000,000/0000-00";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = Banco.DQL(queryClient);
            dgv_client.DataSource = bindingSource;
        }

        private void bnt_clear_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
            tb_name.Clear();
            mtb_cpfORcnpj.Clear();
            dgv_client.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientOpen openClient = new ClientOpen(idSelecionado);
            openClient.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Essa ação excluirá permanentemente", "Deseja excluir?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string queryDelete = String.Format(@"
                    DELETE FROM
                        tb_client
                    WHERE
                        n_idClient={0};  
                ", idSelecionado);
                Banco.DML(queryDelete);
            }
        }
    }
}
