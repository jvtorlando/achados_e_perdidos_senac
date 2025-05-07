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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SelectCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarItem = new achados_e_perdidos_senac.Screen.Login.roundButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSubirArquivo = new achados_e_perdidos_senac.Screen.Login.roundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.SelectCategoria);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSalvarItem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dateTimePickerDataCadastro);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 485);
            this.panel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "SS",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox2.Location = new System.Drawing.Point(466, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 21);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.Text = "Andar";
            // 
            // SelectCategoria
            // 
            this.SelectCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectCategoria.FormattingEnabled = true;
            this.SelectCategoria.Items.AddRange(new object[] {
            "Eletrônicos",
            "Documentos",
            "Acessorios Pessoais",
            "Roupas",
            "Livros, Materiais de Estudo",
            "Chaves",
            "Outros"});
            this.SelectCategoria.Location = new System.Drawing.Point(466, 39);
            this.SelectCategoria.Name = "SelectCategoria";
            this.SelectCategoria.Size = new System.Drawing.Size(205, 21);
            this.SelectCategoria.TabIndex = 29;
            this.SelectCategoria.TabStop = false;
            this.SelectCategoria.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.label4.Location = new System.Drawing.Point(447, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data";
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
            this.btnSalvarItem.Location = new System.Drawing.Point(560, 425);
            this.btnSalvarItem.Name = "btnSalvarItem";
            this.btnSalvarItem.Size = new System.Drawing.Size(147, 39);
            this.btnSalvarItem.TabIndex = 13;
            this.btnSalvarItem.Text = "Salvar Item";
            this.btnSalvarItem.UseVisualStyleBackColor = false;
            this.btnSalvarItem.Click += new System.EventHandler(this.btnSalvarItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(447, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Local";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(447, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBoxFoto);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnSubirArquivo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(8, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 484);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(246, 287);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 39);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxFoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFoto.Location = new System.Drawing.Point(80, 103);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(258, 123);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFoto.TabIndex = 4;
            this.pictureBoxFoto.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(137, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 50);
            this.panel3.TabIndex = 2;
            // 
            // btnSubirArquivo
            // 
            this.btnSubirArquivo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubirArquivo.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(95)))));
            this.btnSubirArquivo.CornerRadius = 10;
            this.btnSubirArquivo.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.btnSubirArquivo.FlatAppearance.BorderSize = 0;
            this.btnSubirArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirArquivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubirArquivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.btnSubirArquivo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnSubirArquivo.Location = new System.Drawing.Point(80, 287);
            this.btnSubirArquivo.Name = "btnSubirArquivo";
            this.btnSubirArquivo.Size = new System.Drawing.Size(147, 39);
            this.btnSubirArquivo.TabIndex = 12;
            this.btnSubirArquivo.Text = "Subir Arquivo";
            this.btnSubirArquivo.UseVisualStyleBackColor = false;
            this.btnSubirArquivo.Click += new System.EventHandler(this.btnSubirArquivo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 465);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePickerDataCadastro
            // 
            this.dateTimePickerDataCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerDataCadastro.CalendarMonthBackground = System.Drawing.SystemColors.WindowText;
            this.dateTimePickerDataCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerDataCadastro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataCadastro.Location = new System.Drawing.Point(466, 121);
            this.dateTimePickerDataCadastro.Name = "dateTimePickerDataCadastro";
            this.dateTimePickerDataCadastro.RightToLeftLayout = true;
            this.dateTimePickerDataCadastro.Size = new System.Drawing.Size(205, 22);
            this.dateTimePickerDataCadastro.TabIndex = 9;
            this.dateTimePickerDataCadastro.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(544, 268);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 32);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // FrmCadastroItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 492);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroItens";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox SelectCategoria;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}