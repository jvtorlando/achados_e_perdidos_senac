namespace achados_e_perdidos_senac.Screen.Retirada_de_item
{
    partial class FrmRetiradaItem
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
            this.dgvRetiradaItem = new System.Windows.Forms.DataGridView();
            this.btnConfirmarStatus = new achados_e_perdidos_senac.Screen.Login.roundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetiradaItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRetiradaItem
            // 
            this.dgvRetiradaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetiradaItem.Location = new System.Drawing.Point(104, 68);
            this.dgvRetiradaItem.Name = "dgvRetiradaItem";
            this.dgvRetiradaItem.Size = new System.Drawing.Size(327, 154);
            this.dgvRetiradaItem.TabIndex = 0;
            this.dgvRetiradaItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRetiradaItem_CellValueChanged);
            // 
            // btnConfirmarStatus
            // 
            this.btnConfirmarStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.btnConfirmarStatus.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(95)))));
            this.btnConfirmarStatus.CornerRadius = 10;
            this.btnConfirmarStatus.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.btnConfirmarStatus.FlatAppearance.BorderSize = 0;
            this.btnConfirmarStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarStatus.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarStatus.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnConfirmarStatus.Location = new System.Drawing.Point(183, 251);
            this.btnConfirmarStatus.Name = "btnConfirmarStatus";
            this.btnConfirmarStatus.Size = new System.Drawing.Size(165, 42);
            this.btnConfirmarStatus.TabIndex = 1;
            this.btnConfirmarStatus.Text = "Confirmar Status";
            this.btnConfirmarStatus.UseVisualStyleBackColor = false;
            // 
            // FrmRetiradaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 472);
            this.Controls.Add(this.btnConfirmarStatus);
            this.Controls.Add(this.dgvRetiradaItem);
            this.MaximizeBox = false;
            this.Name = "FrmRetiradaItem";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmRetiradaItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetiradaItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRetiradaItem;
        private Login.roundButton btnConfirmarStatus;
    }
}