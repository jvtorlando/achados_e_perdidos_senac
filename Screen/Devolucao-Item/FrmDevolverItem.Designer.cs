namespace achados_e_perdidos_senac.Screen.Devolucao_Item
{
    partial class FrmDevolverItem
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
            this.btnConfirmarEntrega = new achados_e_perdidos_senac.Screen.Login.roundButton();
            this.dgvItensEntrega = new System.Windows.Forms.DataGridView();
            this.roundButton1 = new achados_e_perdidos_senac.Screen.Login.roundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarEntrega
            // 
            this.btnConfirmarEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.btnConfirmarEntrega.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(95)))));
            this.btnConfirmarEntrega.CornerRadius = 10;
            this.btnConfirmarEntrega.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.btnConfirmarEntrega.FlatAppearance.BorderSize = 0;
            this.btnConfirmarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarEntrega.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarEntrega.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarEntrega.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnConfirmarEntrega.Location = new System.Drawing.Point(189, 360);
            this.btnConfirmarEntrega.Name = "btnConfirmarEntrega";
            this.btnConfirmarEntrega.Size = new System.Drawing.Size(144, 52);
            this.btnConfirmarEntrega.TabIndex = 0;
            this.btnConfirmarEntrega.Text = "Confirmar Entrega";
            this.btnConfirmarEntrega.UseVisualStyleBackColor = false;
            this.btnConfirmarEntrega.Click += new System.EventHandler(this.btnConfirmarEntrega_Click);
            // 
            // dgvItensEntrega
            // 
            this.dgvItensEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensEntrega.Location = new System.Drawing.Point(300, 159);
            this.dgvItensEntrega.Name = "dgvItensEntrega";
            this.dgvItensEntrega.Size = new System.Drawing.Size(295, 140);
            this.dgvItensEntrega.TabIndex = 1;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.roundButton1.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(95)))));
            this.roundButton1.CornerRadius = 10;
            this.roundButton1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.roundButton1.Location = new System.Drawing.Point(92, 224);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(86, 49);
            this.roundButton1.TabIndex = 2;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // FrmDevolverItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.dgvItensEntrega);
            this.Controls.Add(this.btnConfirmarEntrega);
            this.Name = "FrmDevolverItem";
            this.Text = "FrmDevolverItem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensEntrega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Login.roundButton btnConfirmarEntrega;
        private System.Windows.Forms.DataGridView dgvItensEntrega;
        private Login.roundButton roundButton1;
    }
}