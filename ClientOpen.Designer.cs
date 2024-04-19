namespace Sistema_de_Produtos
{
    partial class ClientOpen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientOpen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_user = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_cnpj = new System.Windows.Forms.RadioButton();
            this.rb_cpf = new System.Windows.Forms.RadioButton();
            this.mtb_identity = new System.Windows.Forms.MaskedTextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_telephone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_history = new System.Windows.Forms.TabPage();
            this.dgv_history = new System.Windows.Forms.DataGridView();
            this.tp_observation = new System.Windows.Forms.TabPage();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).BeginInit();
            this.tp_observation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 22;
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
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(35, 8);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(65, 13);
            this.lb_user.TabIndex = 13;
            this.lb_user.Text = "Sem usuário";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lb_user);
            this.panel3.Controls.Add(this.pb_user);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 420);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 30);
            this.panel3.TabIndex = 38;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_bairro);
            this.panel1.Controls.Add(this.tb_endereco);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_status);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rb_cnpj);
            this.panel1.Controls.Add(this.rb_cpf);
            this.panel1.Controls.Add(this.mtb_identity);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mtb_telephone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 81);
            this.panel1.TabIndex = 39;
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
            this.tb_bairro.Size = new System.Drawing.Size(143, 20);
            this.tb_bairro.TabIndex = 51;
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(6, 55);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(238, 20);
            this.tb_endereco.TabIndex = 50;
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
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(617, 15);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(133, 21);
            this.cb_status.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "STATUS";
            // 
            // rb_cnpj
            // 
            this.rb_cnpj.AutoSize = true;
            this.rb_cnpj.Location = new System.Drawing.Point(300, -2);
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
            this.rb_cpf.Location = new System.Drawing.Point(259, -2);
            this.rb_cpf.Name = "rb_cpf";
            this.rb_cpf.Size = new System.Drawing.Size(45, 17);
            this.rb_cpf.TabIndex = 45;
            this.rb_cpf.TabStop = true;
            this.rb_cpf.Text = "CPF";
            this.rb_cpf.UseVisualStyleBackColor = true;
            // 
            // mtb_identity
            // 
            this.mtb_identity.Location = new System.Drawing.Point(259, 16);
            this.mtb_identity.Name = "mtb_identity";
            this.mtb_identity.Size = new System.Drawing.Size(103, 20);
            this.mtb_identity.TabIndex = 44;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(368, 16);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(243, 20);
            this.tb_email.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "E-MAIL";
            // 
            // mtb_telephone
            // 
            this.mtb_telephone.Location = new System.Drawing.Point(165, 16);
            this.mtb_telephone.Mask = "(00) 99999-9999";
            this.mtb_telephone.Name = "mtb_telephone";
            this.mtb_telephone.Size = new System.Drawing.Size(87, 20);
            this.mtb_telephone.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "TELEFONE";
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
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_history);
            this.tabControl1.Controls.Add(this.tp_observation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 315);
            this.tabControl1.TabIndex = 40;
            // 
            // tp_history
            // 
            this.tp_history.Controls.Add(this.dgv_history);
            this.tp_history.Location = new System.Drawing.Point(4, 22);
            this.tp_history.Name = "tp_history";
            this.tp_history.Padding = new System.Windows.Forms.Padding(3);
            this.tp_history.Size = new System.Drawing.Size(749, 289);
            this.tp_history.TabIndex = 0;
            this.tp_history.Text = "Histórico de Compras";
            this.tp_history.UseVisualStyleBackColor = true;
            // 
            // dgv_history
            // 
            this.dgv_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_history.Location = new System.Drawing.Point(3, 3);
            this.dgv_history.Name = "dgv_history";
            this.dgv_history.Size = new System.Drawing.Size(743, 283);
            this.dgv_history.TabIndex = 0;
            // 
            // tp_observation
            // 
            this.tp_observation.Controls.Add(this.btn_salvar);
            this.tp_observation.Controls.Add(this.richTextBox1);
            this.tp_observation.Location = new System.Drawing.Point(4, 22);
            this.tp_observation.Name = "tp_observation";
            this.tp_observation.Padding = new System.Windows.Forms.Padding(3);
            this.tp_observation.Size = new System.Drawing.Size(749, 289);
            this.tp_observation.TabIndex = 1;
            this.tp_observation.Text = "Observação";
            this.tp_observation.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(8, 260);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(733, 248);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(675, 52);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 53;
            this.btn_save.Text = "Salvar Alteração";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ClientOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientOpen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tp_history.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).EndInit();
            this.tp_observation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_cnpj;
        private System.Windows.Forms.RadioButton rb_cpf;
        private System.Windows.Forms.MaskedTextBox mtb_identity;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_telephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_history;
        private System.Windows.Forms.TabPage tp_observation;
        private System.Windows.Forms.DataGridView dgv_history;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_save;
    }
}