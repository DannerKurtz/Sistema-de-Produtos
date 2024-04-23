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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSale newSale = new NewSale();
            newSale.ShowDialog();
        }

        private void abrirVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSale openSale = new OpenSale();
            openSale.ShowDialog();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            NewSale newSale = new NewSale();
            newSale.ShowDialog();
        }

        private void btn_openSale_Click(object sender, EventArgs e)
        {
            OpenSale openSale = new OpenSale();
            openSale.ShowDialog();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            string query = String.Format(@"
                SELECT
                    tb_sales.n_idSales as 'Num. Venda',
                    tb_client.t_nameClient as 'Nome Cliente', 
                    tb_sales.f_amount as 'Valor Total',
                    tb_sales.d_date as 'Data'
                FROM
                    tb_sales
                INNER JOIN
                    tb_client ON tb_sales.n_idClient = tb_client.n_idClient;");
            dgv_sales.DataSource = Banco.DQL(query);
        }
    }
}
