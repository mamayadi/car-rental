﻿
namespace Gest_Loc
{
    partial class FListeVoit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListeVoit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtmodele = new MetroFramework.Controls.MetroTextBox();
            this.Rech_Voit = new System.Windows.Forms.PictureBox();
            this.combomarque = new MetroFramework.Controls.MetroComboBox();
            this.Dg_Voit = new MetroFramework.Controls.MetroGrid();
            this.Immatriculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modèle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilométrage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Rech_Voit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Voit)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(24, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Marque";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(270, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Modèle";
            // 
            // txtmodele
            // 
            // 
            // 
            // 
            this.txtmodele.CustomButton.Image = null;
            this.txtmodele.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtmodele.CustomButton.Name = "";
            this.txtmodele.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtmodele.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmodele.CustomButton.TabIndex = 1;
            this.txtmodele.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmodele.CustomButton.UseSelectable = true;
            this.txtmodele.CustomButton.Visible = false;
            this.txtmodele.Lines = new string[0];
            this.txtmodele.Location = new System.Drawing.Point(348, 84);
            this.txtmodele.MaxLength = 32767;
            this.txtmodele.Name = "txtmodele";
            this.txtmodele.PasswordChar = '\0';
            this.txtmodele.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmodele.SelectedText = "";
            this.txtmodele.SelectionLength = 0;
            this.txtmodele.SelectionStart = 0;
            this.txtmodele.ShortcutsEnabled = true;
            this.txtmodele.Size = new System.Drawing.Size(153, 23);
            this.txtmodele.TabIndex = 2;
            this.txtmodele.UseSelectable = true;
            this.txtmodele.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmodele.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rech_Voit
            // 
            this.Rech_Voit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rech_Voit.BackgroundImage")));
            this.Rech_Voit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rech_Voit.Location = new System.Drawing.Point(523, 80);
            this.Rech_Voit.Name = "Rech_Voit";
            this.Rech_Voit.Size = new System.Drawing.Size(43, 30);
            this.Rech_Voit.TabIndex = 3;
            this.Rech_Voit.TabStop = false;
            this.Rech_Voit.Click += new System.EventHandler(this.Rech_Voit_Click);
            // 
            // combomarque
            // 
            this.combomarque.DisplayMember = "marq_v";
            this.combomarque.FormattingEnabled = true;
            this.combomarque.ItemHeight = 23;
            this.combomarque.Location = new System.Drawing.Point(91, 81);
            this.combomarque.Name = "combomarque";
            this.combomarque.Size = new System.Drawing.Size(146, 29);
            this.combomarque.TabIndex = 4;
            this.combomarque.UseSelectable = true;
            // 
            // Dg_Voit
            // 
            this.Dg_Voit.AllowUserToResizeRows = false;
            this.Dg_Voit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dg_Voit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg_Voit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dg_Voit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Voit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dg_Voit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Voit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Immatriculation,
            this.Marque,
            this.Modèle,
            this.Kilométrage,
            this.PrixLocation});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dg_Voit.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dg_Voit.EnableHeadersVisualStyles = false;
            this.Dg_Voit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dg_Voit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dg_Voit.Location = new System.Drawing.Point(24, 138);
            this.Dg_Voit.Name = "Dg_Voit";
            this.Dg_Voit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Voit.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dg_Voit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dg_Voit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg_Voit.Size = new System.Drawing.Size(542, 224);
            this.Dg_Voit.TabIndex = 5;
            this.Dg_Voit.DoubleClick += new System.EventHandler(this.Dg_Voit_DoubleClick);
            // 
            // Immatriculation
            // 
            this.Immatriculation.HeaderText = "Immatriculation";
            this.Immatriculation.Name = "Immatriculation";
            // 
            // Marque
            // 
            this.Marque.HeaderText = "Marque";
            this.Marque.Name = "Marque";
            // 
            // Modèle
            // 
            this.Modèle.HeaderText = "Modèle";
            this.Modèle.Name = "Modèle";
            // 
            // Kilométrage
            // 
            this.Kilométrage.HeaderText = "Kilométrage";
            this.Kilométrage.Name = "Kilométrage";
            // 
            // PrixLocation
            // 
            this.PrixLocation.HeaderText = "Prix Location";
            this.PrixLocation.Name = "PrixLocation";
            // 
            // FListeVoit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 393);
            this.Controls.Add(this.Dg_Voit);
            this.Controls.Add(this.combomarque);
            this.Controls.Add(this.Rech_Voit);
            this.Controls.Add(this.txtmodele);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FListeVoit";
            this.Text = "Liste des voitures disponibles";
            this.Load += new System.EventHandler(this.FListeVoit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rech_Voit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Voit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtmodele;
        private System.Windows.Forms.PictureBox Rech_Voit;
        private MetroFramework.Controls.MetroComboBox combomarque;
        private MetroFramework.Controls.MetroGrid Dg_Voit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Immatriculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modèle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilométrage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixLocation;
    }
}