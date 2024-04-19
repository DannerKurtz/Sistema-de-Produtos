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
    public partial class ClientOpen : Form
    {
        int idSelecionado;
        public ClientOpen(int id)
        {
            InitializeComponent();
            idSelecionado = id;
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";
            mtb_identity.Mask = "000,000,000 - 00";

            DataTable dt = new DataTable();
            string query = String.Format(@"
                SELECT * FROM tb_client WHERE n_idClient={0}", idSelecionado);
            dt = Banco.DQL(query);
            tb_name.Text = dt.Rows[0].Field<string>("t_nameClient");
            mtb_telephone.Text = dt.Rows[0].Field<string>("t_telephone");
            mtb_identity.Text = dt.Rows[0].Field<string>("t_cpf_cnpj");
            tb_email.Text = dt.Rows[0].Field<string>("t_email");
            tb_endereco.Text = dt.Rows[0].Field<string>("t_address");
            tb_bairro.Text = dt.Rows[0].Field<string>("t_district");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja salvar as alterações?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                string query = String.Format(@"
                    UPDATE tb_client
                    SET
                        t_nameClient='{0}',
                        t_cpf_cnpj='{1}',
                        t_telephone='{2}',
                        t_email='{3}',
                        t_address='{4}',
                        t_district='{5}',
                        t_status='{6}'
                    WHERE   
                        n_idClient={7};
                ", tb_name.Text, mtb_identity.Text, mtb_telephone.Text, tb_email.Text, tb_endereco.Text, tb_bairro.Text, cb_status.SelectedValue, idSelecionado); 
                Banco.DML(query);
            }
        }
    }
}
