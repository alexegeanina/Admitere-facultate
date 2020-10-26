namespace AdmitereFacultate
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prelucareaDatelorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriereaInFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireaDinFisierTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_scriere = new System.Windows.Forms.TextBox();
            this.tb_citire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prelucareaDatelorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prelucareaDatelorToolStripMenuItem
            // 
            this.prelucareaDatelorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriereaInFisierToolStripMenuItem,
            this.citireaDinFisierTxtToolStripMenuItem});
            this.prelucareaDatelorToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prelucareaDatelorToolStripMenuItem.Name = "prelucareaDatelorToolStripMenuItem";
            this.prelucareaDatelorToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.prelucareaDatelorToolStripMenuItem.Text = "Prelucarea datelor";
            // 
            // scriereaInFisierToolStripMenuItem
            // 
            this.scriereaInFisierToolStripMenuItem.Name = "scriereaInFisierToolStripMenuItem";
            this.scriereaInFisierToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.scriereaInFisierToolStripMenuItem.Text = "Scrierea in fisier txt";
            this.scriereaInFisierToolStripMenuItem.Click += new System.EventHandler(this.scriereaInFisierToolStripMenuItem_Click);
            // 
            // citireaDinFisierTxtToolStripMenuItem
            // 
            this.citireaDinFisierTxtToolStripMenuItem.Name = "citireaDinFisierTxtToolStripMenuItem";
            this.citireaDinFisierTxtToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.citireaDinFisierTxtToolStripMenuItem.Text = "Citirea din fisier txt";
            this.citireaDinFisierTxtToolStripMenuItem.Click += new System.EventHandler(this.citireaDinFisierTxtToolStripMenuItem_Click);
            // 
            // tb_scriere
            // 
            this.tb_scriere.Location = new System.Drawing.Point(23, 81);
            this.tb_scriere.Multiline = true;
            this.tb_scriere.Name = "tb_scriere";
            this.tb_scriere.Size = new System.Drawing.Size(749, 101);
            this.tb_scriere.TabIndex = 2;
            // 
            // tb_citire
            // 
            this.tb_citire.Location = new System.Drawing.Point(23, 248);
            this.tb_citire.Multiline = true;
            this.tb_citire.Name = "tb_citire";
            this.tb_citire.ReadOnly = true;
            this.tb_citire.Size = new System.Drawing.Size(749, 103);
            this.tb_citire.TabIndex = 3;
            this.tb_citire.TextChanged += new System.EventHandler(this.tb_citire_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduceti textul :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(23, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Infromatiile din fisier sunt: ";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_citire);
            this.Controls.Add(this.tb_scriere);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Situatie medii";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prelucareaDatelorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriereaInFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireaDinFisierTxtToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_scriere;
        private System.Windows.Forms.TextBox tb_citire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}