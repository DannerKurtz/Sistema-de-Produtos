namespace Sistema_de_Produtos
{
    partial class ClientAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientAdd));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_user = new System.Windows.Forms.Label();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_telephone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.mtb_identity = new System.Windows.Forms.MaskedTextBox();
            this.rb_cpf = new System.Windows.Forms.RadioButton();
            this.rb_cnpj = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lb_user);
            this.panel3.Controls.Add(this.pb_user);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 30);
            this.panel3.TabIndex = 5;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(35, 8);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(65, 13);
            this.lb_user.TabIndex = 13;
            this.lb_user.Text = "Sem usuário";
            // 
            // pb_user
            // 
            this.pb_user.Image = global::Sistema_de_Produtos.Properties.Resources.novo_usuario;
            this.pb_user.Location = new System.Drawing.Point(9, 4);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(20, 20);
            this.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_user.TabIndex = 12;
            this.pb_user.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(9, 49);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(153, 20);
            this.tb_name.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "TELEFONE";
            // 
            // mtb_telephone
            // 
            this.mtb_telephone.Location = new System.Drawing.Point(187, 49);
            this.mtb_telephone.Mask = "(00) 99999-9999";
            this.mtb_telephone.Name = "mtb_telephone";
            this.mtb_telephone.Size = new System.Drawing.Size(87, 20);
            this.mtb_telephone.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "E-MAIL";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(9, 100);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(243, 20);
            this.tb_email.TabIndex = 12;
            // 
            // mtb_identity
            // 
            this.mtb_identity.Location = new System.Drawing.Point(302, 49);
            this.mtb_identity.Name = "mtb_identity";
            this.mtb_identity.Size = new System.Drawing.Size(103, 20);
            this.mtb_identity.TabIndex = 13;
            // 
            // rb_cpf
            // 
            this.rb_cpf.AutoSize = true;
            this.rb_cpf.Checked = true;
            this.rb_cpf.Location = new System.Drawing.Point(302, 31);
            this.rb_cpf.Name = "rb_cpf";
            this.rb_cpf.Size = new System.Drawing.Size(45, 17);
            this.rb_cpf.TabIndex = 14;
            this.rb_cpf.TabStop = true;
            this.rb_cpf.Text = "CPF";
            this.rb_cpf.UseVisualStyleBackColor = true;
            this.rb_cpf.CheckedChanged += new System.EventHandler(this.rb_cpf_CheckedChanged);
            // 
            // rb_cnpj
            // 
            this.rb_cnpj.AutoSize = true;
            this.rb_cnpj.Location = new System.Drawing.Point(353, 31);
            this.rb_cnpj.Name = "rb_cnpj";
            this.rb_cnpj.Size = new System.Drawing.Size(52, 17);
            this.rb_cnpj.TabIndex = 15;
            this.rb_cnpj.Text = "CNPJ";
            this.rb_cnpj.UseVisualStyleBackColor = true;
            this.rb_cnpj.CheckedChanged += new System.EventHandler(this.rb_cnpj_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "STATUS";
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(272, 100);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(133, 21);
            this.cb_status.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "ENDEREÇO";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(9, 151);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(238, 20);
            this.tb_endereco.TabIndex = 19;
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(262, 151);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(143, 20);
            this.tb_bairro.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "BAIRRO";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(330, 177);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ClientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 235);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_bairro);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_cnpj);
            this.Controls.Add(this.rb_cpf);
            this.Controls.Add(this.mtb_identity);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtb_telephone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Cliente";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_telephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.MaskedTextBox mtb_identity;
        private System.Windows.Forms.RadioButton rb_cpf;
        private System.Windows.Forms.RadioButton rb_cnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_save;
    }
}