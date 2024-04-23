using MySqlX.XDevAPI.Relational;
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
    public partial class NewSale : Form
    {
        int idSale;
        int idProduct;
        public NewSale()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void tb_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dataTable = new DataTable();
                string query = String.Format(@"
                SELECT 
                    *
                FROM
                    tb_client
                WHERE
                    t_nameClient = '{0}';", tb_name.Text);

                dataTable = Banco.DQL(query);
                mtb_identity.Text = dataTable.Rows[0].Field<string>("t_cpf_cnpj");
                mtb_telephone.Text = dataTable.Rows[0].Field<string>("t_telephone");
                tb_email.Text = dataTable.Rows[0].Field<string>("t_email");
                tb_endereco.Text = dataTable.Rows[0].Field<string>("t_address");
                tb_bairro.Text = dataTable.Rows[0].Field<string>("t_district");
                idSale = dataTable.Rows[0].Field<int>("n_idClient");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string query = String.Format(@"
                SELECT  
                    *
                FROM
                    tb_products
                WHERE 
                    t_nameProduct = '{0}';",tb_product.Text);
            dataTable = Banco.DQL(query);
            tb_product.Text = dataTable.Rows[0].Field<String>("t_nameProduct");
            tb_productCode.Text = dataTable.Rows[0].Field<int>("n_idProducts").ToString();
            idProduct = dataTable.Rows[0].Field<int>("n_idProducts");
            string queryAdd = String.Format(@"
                INSERT INTO  
                    tb_salesproductsrelationship
                    (n_idSale, n_idProduct, n_amount)
                VALUES
                    ({0},{1},{2});", idSale, idProduct, nud_quantity.Value);
            Banco.DML(queryAdd);
        }
        private void OpenSale()
        {
            string queryOpenSale = String.Format(@"");
        }
    }
}
