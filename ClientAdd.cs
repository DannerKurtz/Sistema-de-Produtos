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
    public partial class ClientAdd : Form
    {
        public ClientAdd()
        {
            InitializeComponent();
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";
            mtb_identity.Mask = "000,000,000 - 00";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            string query = String.Format("INSERT INTO  tb_client (t_nameClient, t_cpf_cnpj, t_telephone, t_email, t_address, t_district, t_status) VALUES ('{0}','{1}','{2}','{3}', '{4}', '{5}','{6}');", tb_name.Text, mtb_identity.Text, mtb_telephone.Text, tb_email.Text, tb_endereco.Text, tb_bairro.Text, cb_status.SelectedValue);

            Banco.DML(query);
            MessageBox.Show("Dados, inseridos");
            Close();
        }
        private void rb_cpf_CheckedChanged(object sender, EventArgs e)
        {
            mtb_identity.Mask = "000,000,000 - 00";
        }

        private void rb_cnpj_CheckedChanged(object sender, EventArgs e)
        {
            mtb_identity.Mask = "00,000,000/0000-00";
        }
    }
}
