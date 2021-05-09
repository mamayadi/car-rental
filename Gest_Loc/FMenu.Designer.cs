
namespace Gest_Loc
{
    partial class FMenu
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TS_Btn_Vot = new System.Windows.Forms.ToolStripLabel();
            this.TS_Btn_Loc = new System.Windows.Forms.ToolStripLabel();
            this.TS_Btn_RerLoc = new System.Windows.Forms.ToolStripLabel();
            this.TS_Btn_Cl = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Btn_Vot,
            this.TS_Btn_Loc,
            this.TS_Btn_RerLoc,
            this.TS_Btn_Cl});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TS_Btn_Vot
            // 
            this.TS_Btn_Vot.Name = "TS_Btn_Vot";
            this.TS_Btn_Vot.Size = new System.Drawing.Size(44, 22);
            this.TS_Btn_Vot.Text = "Voiture";
            this.TS_Btn_Vot.Click += new System.EventHandler(this.TS_Btn_Vot_Click);
            // 
            // TS_Btn_Loc
            // 
            this.TS_Btn_Loc.Name = "TS_Btn_Loc";
            this.TS_Btn_Loc.Size = new System.Drawing.Size(53, 22);
            this.TS_Btn_Loc.Text = "Location";
            this.TS_Btn_Loc.Click += new System.EventHandler(this.TS_Btn_Loc_Click);
            // 
            // TS_Btn_RerLoc
            // 
            this.TS_Btn_RerLoc.Name = "TS_Btn_RerLoc";
            this.TS_Btn_RerLoc.Size = new System.Drawing.Size(91, 22);
            this.TS_Btn_RerLoc.Text = "Retour Location";
            this.TS_Btn_RerLoc.Click += new System.EventHandler(this.TS_Btn_RerLoc_Click);
            // 
            // TS_Btn_Cl
            // 
            this.TS_Btn_Cl.Name = "TS_Btn_Cl";
            this.TS_Btn_Cl.Size = new System.Drawing.Size(43, 22);
            this.TS_Btn_Cl.Text = "Clients";
            this.TS_Btn_Cl.Click += new System.EventHandler(this.TS_Btn_Cl_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FMenu";
            this.Text = "Société de location de voitures";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel TS_Btn_Vot;
        private System.Windows.Forms.ToolStripLabel TS_Btn_Loc;
        private System.Windows.Forms.ToolStripLabel TS_Btn_RerLoc;
        private System.Windows.Forms.ToolStripLabel TS_Btn_Cl;
    }
}