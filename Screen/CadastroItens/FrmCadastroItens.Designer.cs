namespace achados_e_perdidos_senac.CadastroItens
{
    partial class FrmCadastroItens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroItens));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectStatus = new System.Windows.Forms.ComboBox();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSubirArquivo = new achados_e_perdidos_senac.Screen.Login.roundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectAndar = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.SelectCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarItem = new achados_e_perdidos_senac.Screen.Login.roundButton();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 503);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.SelectStatus);
            this.panel2.Controls.Add(this.txtNomeItem);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnSubirArquivo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.SelectAndar);
            this.panel2.Controls.Add(this.dateTimePickerDataCadastro);
            this.panel2.Controls.Add(this.SelectCategoria);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSalvarItem);
            this.panel2.Controls.Add(this.pictureBoxFoto);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 477);
            this.panel2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label5.Location = new System.Drawing.Point(358, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Nome do ítem:";
            // 
            // SelectStatus
            // 
            this.SelectStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectStatus.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectStatus.FormattingEnabled = true;
            this.SelectStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectStatus.Items.AddRange(new object[] {
            "Perdido",
            "Devolvido"});
            this.SelectStatus.Location = new System.Drawing.Point(87, 83);
            this.SelectStatus.Name = "SelectStatus";
            this.SelectStatus.Size = new System.Drawing.Size(205, 36);
            this.SelectStatus.TabIndex = 37;
            this.SelectStatus.TabStop = false;
            this.SelectStatus.Text = "Status do item";
            this.SelectStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(359, 128);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(330, 20);
            this.txtNomeItem.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(88, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 56);
            this.panel3.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(87, 302);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(205, 83);
            this.txtDescricao.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(240, 400);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 39);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnSubirArquivo
            // 
            this.btnSubirArquivo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubirArquivo.ClickColor = System.Drawing.Color.Transparent;
            this.btnSubirArquivo.CornerRadius = 10;
            this.btnSubirArquivo.DefaultColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubirArquivo.FlatAppearance.BorderSize = 0;
            this.btnSubirArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirArquivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubirArquivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.btnSubirArquivo.HoverColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSubirArquivo.Location = new System.Drawing.Point(87, 400);
            this.btnSubirArquivo.Name = "btnSubirArquivo";
            this.btnSubirArquivo.Size = new System.Drawing.Size(147, 39);
            this.btnSubirArquivo.TabIndex = 12;
            this.btnSubirArquivo.Text = "Subir Arquivo";
            this.btnSubirArquivo.UseVisualStyleBackColor = false;
            this.btnSubirArquivo.Click += new System.EventHandler(this.btnSubirArquivo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label3.Location = new System.Drawing.Point(84, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Descrição do ítem:";
            // 
            // SelectAndar
            // 
            this.SelectAndar.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAndar.FormattingEnabled = true;
            this.SelectAndar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectAndar.Items.AddRange(new object[] {
            "SS",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.SelectAndar.Location = new System.Drawing.Point(87, 175);
            this.SelectAndar.Name = "SelectAndar";
            this.SelectAndar.Size = new System.Drawing.Size(205, 36);
            this.SelectAndar.TabIndex = 30;
            this.SelectAndar.Text = "Andar";
            // 
            // dateTimePickerDataCadastro
            // 
            this.dateTimePickerDataCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerDataCadastro.CalendarMonthBackground = System.Drawing.SystemColors.WindowText;
            this.dateTimePickerDataCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerDataCadastro.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataCadastro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerDataCadastro.Location = new System.Drawing.Point(88, 224);
            this.dateTimePickerDataCadastro.Name = "dateTimePickerDataCadastro";
            this.dateTimePickerDataCadastro.RightToLeftLayout = true;
            this.dateTimePickerDataCadastro.Size = new System.Drawing.Size(205, 35);
            this.dateTimePickerDataCadastro.TabIndex = 9;
            // 
            // SelectCategoria
            // 
            this.SelectCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCategoria.FormattingEnabled = true;
            this.SelectCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectCategoria.Items.AddRange(new object[] {
            "Eletrônicos",
            "Documentos",
            "Acessorios Pessoais",
            "Roupas",
            "Livros, Materiais de Estudo",
            "Chaves",
            "Outros"});
            this.SelectCategoria.Location = new System.Drawing.Point(88, 128);
            this.SelectCategoria.Name = "SelectCategoria";
            this.SelectCategoria.Size = new System.Drawing.Size(205, 36);
            this.SelectCategoria.TabIndex = 29;
            this.SelectCategoria.TabStop = false;
            this.SelectCategoria.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label2.Location = new System.Drawing.Point(413, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 36);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cadastrar Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label1.Location = new System.Drawing.Point(356, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "A imagem do item aparecerá aqui";
            // 
            // btnSalvarItem
            // 
            this.btnSalvarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnSalvarItem.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(95)))));
            this.btnSalvarItem.CornerRadius = 10;
            this.btnSalvarItem.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.btnSalvarItem.FlatAppearance.BorderSize = 0;
            this.btnSalvarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvarItem.ForeColor = System.Drawing.Color.White;
            this.btnSalvarItem.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnSalvarItem.Location = new System.Drawing.Point(453, 400);
            this.btnSalvarItem.Name = "btnSalvarItem";
            this.btnSalvarItem.Size = new System.Drawing.Size(147, 39);
            this.btnSalvarItem.TabIndex = 13;
            this.btnSalvarItem.Text = "Salvar Item";
            this.btnSalvarItem.UseVisualStyleBackColor = false;
            this.btnSalvarItem.Click += new System.EventHandler(this.btnSalvarItem_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxFoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFoto.Location = new System.Drawing.Point(359, 215);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(330, 166);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 4;
            this.pictureBoxFoto.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(26, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 471);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCadastroItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 526);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Achados e Perdidos - Senac Lapa Tito";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataCadastro;
        private Screen.Login.roundButton btnSubirArquivo;
        private Screen.Login.roundButton btnSalvarItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox SelectCategoria;
        private System.Windows.Forms.ComboBox SelectAndar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.ComboBox SelectStatus;
        private System.Windows.Forms.Label label5;
    }
}