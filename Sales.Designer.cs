namespace Sistema_de_Produtos
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_user = new System.Windows.Forms.Label();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_nameClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_openSale = new System.Windows.Forms.Button();
            this.btn_cancelSale = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Controls.Add(this.pb_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 27);
            this.panel1.TabIndex = 0;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicialToolStripMenuItem
            // 
            this.inicialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVendaToolStripMenuItem,
            this.abrirVendaToolStripMenuItem,
            this.cancelarVendaToolStripMenuItem});
            this.inicialToolStripMenuItem.Name = "inicialToolStripMenuItem";
            this.inicialToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.inicialToolStripMenuItem.Text = "Vendas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_nameClient);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_openSale);
            this.panel2.Controls.Add(this.btn_cancelSale);
            this.panel2.Controls.Add(this.btn_sales);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 80);
            this.panel2.TabIndex = 3;
            // 
            // tb_nameClient
            // 
            this.tb_nameClient.Location = new System.Drawing.Point(12, 51);
            this.tb_nameClient.Name = "tb_nameClient";
            this.tb_nameClient.Size = new System.Drawing.Size(475, 20);
            this.tb_nameClient.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Cliente";
            // 
            // btn_openSale
            // 
            this.btn_openSale.Location = new System.Drawing.Point(308, 12);
            this.btn_openSale.Name = "btn_openSale";
            this.btn_openSale.Size = new System.Drawing.Size(75, 20);
            this.btn_openSale.TabIndex = 3;
            this.btn_openSale.Text = "Abrir Venda";
            this.btn_openSale.UseVisualStyleBackColor = true;
            this.btn_openSale.Click += new System.EventHandler(this.btn_openSale_Click);
            // 
            // btn_cancelSale
            // 
            this.btn_cancelSale.Location = new System.Drawing.Point(389, 12);
            this.btn_cancelSale.Name = "btn_cancelSale";
            this.btn_cancelSale.Size = new System.Drawing.Size(98, 20);
            this.btn_cancelSale.TabIndex = 2;
            this.btn_cancelSale.Text = "Cancelar Venda";
            this.btn_cancelSale.UseVisualStyleBackColor = true;
            // 
            // btn_sales
            // 
            this.btn_sales.Location = new System.Drawing.Point(227, 12);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(75, 20);
            this.btn_sales.TabIndex = 1;
            this.btn_sales.Text = "Nova Venda";
            this.btn_sales.UseVisualStyleBackColor = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(500, 319);
            this.dataGridView1.TabIndex = 4;
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaVendaToolStripMenuItem.Text = "Nova Venda";
            this.novaVendaToolStripMenuItem.Click += new System.EventHandler(this.novaVendaToolStripMenuItem_Click);
            // 
            // abrirVendaToolStripMenuItem
            // 
            this.abrirVendaToolStripMenuItem.Name = "abrirVendaToolStripMenuItem";
            this.abrirVendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirVendaToolStripMenuItem.Text = "Abrir Venda";
            this.abrirVendaToolStripMenuItem.Click += new System.EventHandler(this.abrirVendaToolStripMenuItem_Click);
            // 
            // cancelarVendaToolStripMenuItem
            // 
            this.cancelarVendaToolStripMenuItem.Name = "cancelarVendaToolStripMenuItem";
            this.cancelarVendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelarVendaToolStripMenuItem.Text = "Cancelar Venda";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicialToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tb_nameClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_openSale;
        private System.Windows.Forms.Button btn_cancelSale;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarVendaToolStripMenuItem;
    }
}