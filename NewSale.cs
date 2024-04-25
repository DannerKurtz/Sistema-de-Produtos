using Microsoft.SqlServer.Server;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Produtos
{
    public partial class NewSale : Form
    {
        int idSale;
        int idProduct;
        int idClient;
        //Consultas de banco de dados
        string queryStart = String.Format(@"SELECT * FROM tb_sales WHERE t_status = 'open';");
        string openSalesInquiry = String.Format(@"SELECT n_idSales FROM tb_sales WHERE t_status = 'open'");
        string queryCreateSale = String.Format(@"INSERT INTO tb_sales (t_status) VALUE ('open')");
        string querySaleItens = String.Format(@"
                SELECT
                    tb_salesproductsrelationship.n_idProduct as 'Cod. Produto',
                    tb_products.t_nameProduct as 'Nome do Produto',
                    tb_salesproductsrelationship.n_amount as 'Quantidade',
                    tb_products.f_finalValue as 'Valor do produto',
                    ROUND(tb_products.f_finalValue * tb_salesproductsrelationship.n_amount, 2) as 'Valor Total do Produto'
                FROM   
                    tb_salesproductsrelationship
                INNER JOIN
                    tb_products ON tb_salesproductsrelationship.n_idProduct = tb_products.n_idProducts
                INNER JOIN
                    tb_sales ON tb_sales.n_idSales = tb_salesproductsrelationship.n_idSale
                WHERE   
                    tb_sales.t_status = 'open';");
        public NewSale()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            bool queryVerification; 
            dt = Banco.DQL(queryStart);
            queryVerification = dt.Rows.Count == 0;
            if (queryVerification)
            {
                Banco.DML(queryCreateSale);
                dt = Banco.DQL(openSalesInquiry);
                idSale = dt.Rows[0].Field<int>("n_idSales");
            }
            else
            {
                dt = Banco.DQL(openSalesInquiry);
                idSale = dt.Rows[0].Field<int>("n_idSales");
                MessageBox.Show("Venda em aberto!");
            }
            dgv_saleItens.DataSource = Banco.DQL(querySaleItens);
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
                idClient = dataTable.Rows[0].Field<int>("n_idClient");
                
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
        private void mtb_discount_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Banco.DQL(querySaleItens);
            decimal totalSum = 0;
            decimal discont;

            if (e.KeyCode == Keys.Enter)
            {
                discont = Convert.ToDecimal(mtb_discount.Text.Replace("%", ""));
                foreach (DataRow row in dt.Rows)
                {
                    totalSum += Convert.ToDecimal(row["Valor Total do Produto"]);
                }
                discont = totalSum * (discont / 100) ;
                totalSum -= discont;
                tb_totalValue.Text = totalSum.ToString();
            }
    }

        private void btn_completeSale_Click(object sender, EventArgs e)
        {
            string queryFinish = String.Format(@"
             UPDATE tb_sales
             SET 
                 n_idClient = {0},
                 n_discount = {1},
                 d_date = '{2:yyyy-MM-dd}',
                 t_status = 'finish',
                 f_amount = {3}
             WHERE t_status = 'open';",
             idClient,
             Convert.ToInt32(mtb_discount.Text.Replace("%", "")),
             DateTime.Today,
             Convert.ToDecimal(tb_totalValue.Text));
            Banco.DML(queryFinish);
            MessageBox.Show("Venda finalizada com sucesso");
        }
    }
}
