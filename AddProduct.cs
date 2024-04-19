using MySqlX.XDevAPI.Common;
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
    public partial class ProductEditing : Form
    {
        string idSelect;
        public ProductEditing(string id)
        {
            InitializeComponent();
            idSelect = id;
            if (id != "")
            {
                string query = String.Format(@"
                    SELECT
                        *
                    FROM 
                        tb_products
                    WHERE
                        n_idProducts={0}", id);
                DataTable dt = Banco.DQL(query);
                tb_id.Text = id;
                tb_productName.Text = dt.Rows[0].Field<string>("t_nameProduct");
                tb_costValue.Text = dt.Rows[0].Field<float>("f_costValue").ToString();
                tb_profitPorcentage.Text = dt.Rows[0].Field<float>("n_profitPercentage").ToString(); 
                tb_profit.Text = dt.Rows[0].Field<float>("f_profit").ToString();
                tb_finalValue.Text = dt.Rows[0].Field<float>("f_finalValue").ToString();
                nud_quantity.Value = dt.Rows[0].Field<int>("n_quantity");
                string queryComboBox = String.Format(@"
                SELECT 
                    t_category
                FROM
                    tb_products
                GROUP BY
                    t_category;");
                cb_category.DataSource = Banco.DQL(queryComboBox);
                cb_category.ValueMember = "t_category";
                cb_category.Text = dt.Rows[0].Field<string>("t_category");
            }
            else
            {
                string queryComboBox = String.Format(@"
                SELECT 
                    t_category
                FROM
                    tb_products
                GROUP BY
                    t_category;");
                cb_category.DataSource = Banco.DQL(queryComboBox);
                cb_category.ValueMember = "t_category";
                btn_clear.Visible = false;
                btn_save.Visible = false;
                btn_addNewProduct.Visible = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            tb_productName.Text = "";
            tb_costValue.Text = "";
            tb_profitPorcentage.Text = "";
            tb_profit.Text = "";
            tb_finalValue.Text = "";
            nud_quantity.Value = 1;

            btn_clear.Visible = false;
            btn_save.Visible = false;
            btn_addNewProduct.Visible = true;
        }

        private void btn_addNewProduct_Click(object sender, EventArgs e)
        {
            string query = String.Format(@"
                INSERT INTO
                    tb_products
                (t_nameProduct, n_quantity, t_category, f_costValue, n_profitPercentage, f_profit, f_finalValue)
                VALUES
                ('{0}',{1},'{2}',{3},{4},{5},{6})",tb_productName.Text, nud_quantity.Value, cb_category.Text, float.Parse(tb_costValue.Text), float.Parse(tb_profitPorcentage.Text), float.Parse(tb_profit.Text), float.Parse(tb_finalValue.Text));
            Banco.DML(query);
            MessageBox.Show("Novo Produto Cadastrado");
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string query = String.Format(@"
                UPDATE
                    tb_products
                SET
                    t_nameProduct='{0}', 
                    n_quantity={1}, 
                    t_category='{2}', 
                    f_costValue={3}, 
                    n_profitPercentage={4}, 
                    f_profit={5}, 
                    f_finalValue={6}
                WHERE
                    n_idProducts={7};", tb_productName.Text, nud_quantity.Value, cb_category.Text, float.Parse(tb_costValue.Text), float.Parse(tb_profitPorcentage.Text), float.Parse(tb_profit.Text), float.Parse(tb_finalValue.Text),idSelect);
            Banco.DML(query);
            MessageBox.Show("Produto Salvo");
            Close();
        }
    }
}
