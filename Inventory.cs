using Org.BouncyCastle.Asn1.Esf;
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
    public partial class Inventory : Form
    {
        string idSelect;
        public Inventory()
        {
            InitializeComponent();
        }

        

        private void Inventory_Load(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            string query = String.Format(@"
                SELECT 
                    n_idProducts as 'ID',
                    t_nameProduct as 'Nome do Produto',
                    t_category as 'Categoria'
                FROM    
                    tb_products;");
            dgv_product.DataSource = Banco.DQL(query);
            string queryComboBox = String.Format(@"
                SELECT 
                    t_category
                FROM
                    tb_products
                GROUP BY
                    t_category;");
            cb_category.DataSource = Banco.DQL(queryComboBox);
            cb_category.ValueMember = "t_category";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string valueToSearch = " ";
            string columnName = "";

            if (tb_productName.Text != "")
            {
                valueToSearch = tb_productName.Text;
                columnName = "Nome do Produto";
            }
            else if (cb_category.Text != "")
            {
                valueToSearch = cb_category.Text;
                columnName = "Categoria";
            }

            if (!string.IsNullOrEmpty(valueToSearch) && !string.IsNullOrEmpty(columnName))
            {
                foreach (DataGridViewRow row in dgv_product.Rows)
                {
                    if (row.Cells[columnName].Value != null && row.Cells[columnName].Value.ToString().Equals(valueToSearch))
                    {
                        row.Selected = true;
                        dgv_product.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_product_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int countLine = dgv.SelectedRows.Count;
            if (countLine > 0)
            {
                DataTable dt = new DataTable();
                string vID = dgv.SelectedRows[0].Cells[0].Value.ToString();
                idSelect = vID;
                string query = String.Format(@"
                SELECT * FROM tb_products WHERE n_idProducts={0}", vID);
                dt = Banco.DQL(query);
                tb_productName.Text = dt.Rows[0].Field<string>("t_nameProduct").ToString();
                cb_category.Text = dt.Rows[0].Field<string>("t_category");
                btn_Product.Text = "Abrir Produto";
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            btn_Product.Text = "Novo Produto";
            tb_productName.Clear();
            cb_category.SelectedIndex = -1;
            dgv_product.ClearSelection();
            idSelect = "";
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            ProductEditing productEditing = new ProductEditing(idSelect);
            productEditing.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            string query = String.Format(@"
                SELECT 
                    n_idProducts as 'ID',
                    t_nameProduct as 'Nome do Produto',
                    t_category as 'Categoria'
                FROM    
                    tb_products;");
            dgv_product.DataSource = Banco.DQL(query);
            string queryComboBox = String.Format(@"
                SELECT 
                    t_category
                FROM
                    tb_products
                GROUP BY
                    t_category;");
            cb_category.DataSource = Banco.DQL(queryComboBox);
            cb_category.ValueMember = "t_category";
        }
    }
}
