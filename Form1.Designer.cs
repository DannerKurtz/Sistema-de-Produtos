namespace Sistema_de_Produtos
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_client = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_sales = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_workOrder = new System.Windows.Forms.Button();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(248, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicialToolStripMenuItem
            // 
            this.inicialToolStripMenuItem.Name = "inicialToolStripMenuItem";
            this.inicialToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.inicialToolStripMenuItem.Text = "Inicial";
            // 
            // btn_client
            // 
            this.btn_client.BackColor = System.Drawing.Color.Transparent;
            this.btn_client.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_client.Location = new System.Drawing.Point(12, 133);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(100, 21);
            this.btn_client.TabIndex = 2;
            this.btn_client.Text = "Clientes";
            this.btn_client.UseVisualStyleBackColor = false;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Produtos.Properties.Resources.cliente;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema_de_Produtos.Properties.Resources.vendas;
            this.pictureBox2.Location = new System.Drawing.Point(132, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btn_sales
            // 
            this.btn_sales.BackColor = System.Drawing.Color.Transparent;
            this.btn_sales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_sales.Location = new System.Drawing.Point(132, 133);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(100, 21);
            this.btn_sales.TabIndex = 4;
            this.btn_sales.Text = "Vendas";
            this.btn_sales.UseVisualStyleBackColor = false;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sistema_de_Produtos.Properties.Resources.estoque_pronto;
            this.pictureBox3.Location = new System.Drawing.Point(12, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_inventory.Location = new System.Drawing.Point(12, 276);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(100, 21);
            this.btn_inventory.TabIndex = 6;
            this.btn_inventory.Text = "Estoque";
            this.btn_inventory.UseVisualStyleBackColor = false;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sistema_de_Produtos.Properties.Resources.servico_de_entrega;
            this.pictureBox4.Location = new System.Drawing.Point(132, 170);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // btn_workOrder
            // 
            this.btn_workOrder.BackColor = System.Drawing.Color.Transparent;
            this.btn_workOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_workOrder.Location = new System.Drawing.Point(132, 276);
            this.btn_workOrder.Name = "btn_workOrder";
            this.btn_workOrder.Size = new System.Drawing.Size(100, 21);
            this.btn_workOrder.TabIndex = 8;
            this.btn_workOrder.Text = "Ordem de Serviço";
            this.btn_workOrder.UseVisualStyleBackColor = false;
            // 
            // pb_user
            // 
            this.pb_user.Image = global::Sistema_de_Produtos.Properties.Resources.novo_usuario;
            this.pb_user.Location = new System.Drawing.Point(12, 305);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(20, 20);
            this.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_user.TabIndex = 10;
            this.pb_user.TabStop = false;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(38, 309);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(65, 13);
            this.lb_user.TabIndex = 11;
            this.lb_user.Text = "Sem usuário";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 331);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.pb_user);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_workOrder);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_inventory);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicialToolStripMenuItem;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_workOrder;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.Label lb_user;
    }
}

