namespace Sistema_de_Produtos
{
    partial class NewSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSale));
            this.lb_user = new System.Windows.Forms.Label();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_searchProduct = new System.Windows.Forms.Button();
            this.tb_product = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_productCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtb_telephone = new System.Windows.Forms.MaskedTextBox();
            this.rb_cnpj = new System.Windows.Forms.RadioButton();
            this.rb_cpf = new System.Windows.Forms.RadioButton();
            this.mtb_identity = new System.Windows.Forms.MaskedTextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.btn_completeSale = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.tb_totalValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(29, 7);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(65, 13);
            this.lb_user.TabIndex = 13;
            this.lb_user.Text = "Sem usuário";
            // 
            // pb_user
            // 
            this.pb_user.Image = global::Sistema_de_Produtos.Properties.Resources.novo_usuario;
            this.pb_user.Location = new System.Drawing.Point(3, 3);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(20, 20);
            this.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_user.TabIndex = 12;
            this.pb_user.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Controls.Add(this.pb_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 27);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicialToolStripMenuItem
            // 
            this.inicialToolStripMenuItem.Name = "inicialToolStripMenuItem";
            this.inicialToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.inicialToolStripMenuItem.Text = "Vendas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nud_quantity);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_searchProduct);
            this.panel2.Controls.Add(this.tb_product);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tb_productCode);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 126);
            this.panel2.TabIndex = 4;
            // 
            // nud_quantity
            // 
            this.nud_quantity.Location = new System.Drawing.Point(485, 100);
            this.nud_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(62, 20);
            this.nud_quantity.TabIndex = 48;
            this.nud_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Qtde.";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(553, 98);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(87, 23);
            this.btn_add.TabIndex = 46;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_searchProduct
            // 
            this.btn_searchProduct.Location = new System.Drawing.Point(408, 98);
            this.btn_searchProduct.Name = "btn_searchProduct";
            this.btn_searchProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_searchProduct.TabIndex = 45;
            this.btn_searchProduct.Text = "Procurar";
            this.btn_searchProduct.UseVisualStyleBackColor = true;
            // 
            // tb_product
            // 
            this.tb_product.Location = new System.Drawing.Point(81, 100);
            this.tb_product.Name = "tb_product";
            this.tb_product.Size = new System.Drawing.Size(321, 20);
            this.tb_product.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Produto";
            // 
            // tb_productCode
            // 
            this.tb_productCode.Location = new System.Drawing.Point(6, 100);
            this.tb_productCode.Name = "tb_productCode";
            this.tb_productCode.Size = new System.Drawing.Size(69, 20);
            this.tb_productCode.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cód. produto";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tb_bairro);
            this.panel3.Controls.Add(this.tb_endereco);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.mtb_telephone);
            this.panel3.Controls.Add(this.rb_cnpj);
            this.panel3.Controls.Add(this.rb_cpf);
            this.panel3.Controls.Add(this.mtb_identity);
            this.panel3.Controls.Add(this.tb_email);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tb_name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(649, 81);
            this.panel3.TabIndex = 40;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(165, 15);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 23);
            this.btn_search.TabIndex = 53;
            this.btn_search.Text = "...";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "BAIRRO";
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(259, 55);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.ReadOnly = true;
            this.tb_bairro.Size = new System.Drawing.Size(143, 20);
            this.tb_bairro.TabIndex = 51;
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(6, 55);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.ReadOnly = true;
            this.tb_endereco.Size = new System.Drawing.Size(238, 20);
            this.tb_endereco.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "TELEFONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "ENDEREÇO";
            // 
            // mtb_telephone
            // 
            this.mtb_telephone.Location = new System.Drawing.Point(304, 16);
            this.mtb_telephone.Mask = "(00) 99999-9999";
            this.mtb_telephone.Name = "mtb_telephone";
            this.mtb_telephone.ReadOnly = true;
            this.mtb_telephone.Size = new System.Drawing.Size(87, 20);
            this.mtb_telephone.TabIndex = 41;
            // 
            // rb_cnpj
            // 
            this.rb_cnpj.AutoSize = true;
            this.rb_cnpj.Location = new System.Drawing.Point(236, -1);
            this.rb_cnpj.Name = "rb_cnpj";
            this.rb_cnpj.Size = new System.Drawing.Size(52, 17);
            this.rb_cnpj.TabIndex = 46;
            this.rb_cnpj.Text = "CNPJ";
            this.rb_cnpj.UseVisualStyleBackColor = true;
            // 
            // rb_cpf
            // 
            this.rb_cpf.AutoSize = true;
            this.rb_cpf.Checked = true;
            this.rb_cpf.Location = new System.Drawing.Point(195, -1);
            this.rb_cpf.Name = "rb_cpf";
            this.rb_cpf.Size = new System.Drawing.Size(45, 17);
            this.rb_cpf.TabIndex = 45;
            this.rb_cpf.TabStop = true;
            this.rb_cpf.Text = "CPF";
            this.rb_cpf.UseVisualStyleBackColor = true;
            // 
            // mtb_identity
            // 
            this.mtb_identity.Location = new System.Drawing.Point(195, 17);
            this.mtb_identity.Name = "mtb_identity";
            this.mtb_identity.Size = new System.Drawing.Size(103, 20);
            this.mtb_identity.TabIndex = 44;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(397, 17);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(243, 20);
            this.tb_email.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "E-MAIL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "NOME";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(6, 16);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(153, 20);
            this.tb_name.TabIndex = 38;
            this.tb_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_name_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_deleteItem);
            this.panel4.Controls.Add(this.btn_completeSale);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.tb_discount);
            this.panel4.Controls.Add(this.tb_totalValue);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 372);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(649, 51);
            this.panel4.TabIndex = 5;
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Location = new System.Drawing.Point(12, 21);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(82, 23);
            this.btn_deleteItem.TabIndex = 5;
            this.btn_deleteItem.Text = "Excluir Item";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            // 
            // btn_completeSale
            // 
            this.btn_completeSale.Location = new System.Drawing.Point(553, 22);
            this.btn_completeSale.Name = "btn_completeSale";
            this.btn_completeSale.Size = new System.Drawing.Size(87, 23);
            this.btn_completeSale.TabIndex = 4;
            this.btn_completeSale.Text = "Finalizar Venda";
            this.btn_completeSale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Desconto";
            // 
            // tb_discount
            // 
            this.tb_discount.Location = new System.Drawing.Point(326, 24);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.Size = new System.Drawing.Size(100, 20);
            this.tb_discount.TabIndex = 2;
            // 
            // tb_totalValue
            // 
            this.tb_totalValue.Location = new System.Drawing.Point(442, 24);
            this.tb_totalValue.Name = "tb_totalValue";
            this.tb_totalValue.ReadOnly = true;
            this.tb_totalValue.Size = new System.Drawing.Size(100, 20);
            this.tb_totalValue.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Valor Total";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 222);
            this.dataGridView1.TabIndex = 6;
            // 
            // NewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Venda";
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicialToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_cnpj;
        private System.Windows.Forms.RadioButton rb_cpf;
        private System.Windows.Forms.MaskedTextBox mtb_identity;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_telephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_searchProduct;
        private System.Windows.Forms.TextBox tb_product;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_productCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_completeSale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_discount;
        private System.Windows.Forms.TextBox tb_totalValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_deleteItem;
    }
}