namespace achados_e_perdidos_senac.CadastroItens
{
    partial class FrmSelecionarItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarItem));
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelet = new achados_e_perdidos_senac.Screen.Login.roundButton();
            this.btnPesquisar = new achados_e_perdidos_senac.Screen.Login.roundButton();
            this.dataGridViewItens = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(234, 86);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(440, 26);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(53, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 78);
            this.panel1.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 465);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(230, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Pesquisar ítem:";
            // 
            // btnDelet
            // 
            this.btnDelet.BackColor = System.Drawing.Color.Transparent;
            this.btnDelet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelet.BackgroundImage")));
            this.btnDelet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelet.ClickColor = System.Drawing.Color.Transparent;
            this.btnDelet.CornerRadius = 10;
            this.btnDelet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelet.DefaultColor = System.Drawing.Color.Transparent;
            this.btnDelet.FlatAppearance.BorderSize = 0;
            this.btnDelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelet.ForeColor = System.Drawing.Color.Tomato;
            this.btnDelet.HoverColor = System.Drawing.Color.Transparent;
            this.btnDelet.Location = new System.Drawing.Point(713, 396);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(44, 52);
            this.btnDelet.TabIndex = 38;
            this.btnDelet.UseVisualStyleBackColor = false;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.ClickColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.CornerRadius = 10;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.DefaultColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.HoverColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Location = new System.Drawing.Point(683, 80);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(55, 37);
            this.btnPesquisar.TabIndex = 41;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // dataGridViewItens
            // 
            this.dataGridViewItens.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItens.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewItens.Name = "dataGridViewItens";
            this.dataGridViewItens.Size = new System.Drawing.Size(642, 207);
            this.dataGridViewItens.TabIndex = 1;
            this.dataGridViewItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewItens.SelectionChanged += new System.EventHandler(this.dataGridViewItens_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewItens);
            this.panel2.Location = new System.Drawing.Point(65, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 207);
            this.panel2.TabIndex = 39;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDescricao.Location = new System.Drawing.Point(3, 25);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(509, 53);
            this.lblDescricao.TabIndex = 43;
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Descrição:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblDescricao);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(69, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 83);
            this.panel3.TabIndex = 45;
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(534, 21);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(25, 23);
            this.btnHelp.TabIndex = 46;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(559, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 45);
            this.label2.TabIndex = 47;
            this.label2.Text = "Selecione a primeira fileira da \r\ntabela para ver detalhes, aperte\r\n no botão inf" +
    "o\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(713, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 55);
            this.button1.TabIndex = 48;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmSelecionarItem
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(821, 531);
            this.Name = "FrmSelecionarItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Achados e Perdidos - Senac Lapa Tito";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Screen.Login.roundButton btnDelet;
        private System.Windows.Forms.Label label3;
        private Screen.Login.roundButton btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewItens;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDescricao;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}