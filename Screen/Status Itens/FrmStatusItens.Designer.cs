﻿namespace achados_e_perdidos_senac.Screen.Status_Itens
{
    partial class FrmStatusItens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatusItens));
            this.picboxSenac = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSenac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxSenac
            // 
            this.picboxSenac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxSenac.BackgroundImage")));
            this.picboxSenac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxSenac.Location = new System.Drawing.Point(43, 41);
            this.picboxSenac.Name = "picboxSenac";
            this.picboxSenac.Size = new System.Drawing.Size(173, 87);
            this.picboxSenac.TabIndex = 0;
            this.picboxSenac.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 418);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FrmStatusItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picboxSenac);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmStatusItens";
            this.Text = "FrmStatusItens";
            ((System.ComponentModel.ISupportInitialize)(this.picboxSenac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxSenac;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}