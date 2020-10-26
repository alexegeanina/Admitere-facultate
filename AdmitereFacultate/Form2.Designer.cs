namespace AdmitereFacultate
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.generaregrafic_bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tiparire_bt = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.afisare_tb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generaregrafic_bt
            // 
            this.generaregrafic_bt.BackColor = System.Drawing.SystemColors.Highlight;
            this.generaregrafic_bt.Location = new System.Drawing.Point(611, 168);
            this.generaregrafic_bt.Name = "generaregrafic_bt";
            this.generaregrafic_bt.Size = new System.Drawing.Size(153, 54);
            this.generaregrafic_bt.TabIndex = 0;
            this.generaregrafic_bt.Text = "Grafic oferta universitara";
            this.generaregrafic_bt.UseVisualStyleBackColor = false;
            this.generaregrafic_bt.Click += new System.EventHandler(this.generaregrafic_bt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(611, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afisare oferta universitara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tiparire_bt
            // 
            this.tiparire_bt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tiparire_bt.Location = new System.Drawing.Point(611, 92);
            this.tiparire_bt.Name = "tiparire_bt";
            this.tiparire_bt.Size = new System.Drawing.Size(153, 56);
            this.tiparire_bt.TabIndex = 2;
            this.tiparire_bt.Text = "Tiparire oferta universitara";
            this.tiparire_bt.UseVisualStyleBackColor = false;
            this.tiparire_bt.Click += new System.EventHandler(this.tiparire_bt_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Drag and Drop ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(43, 347);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(721, 69);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // afisare_tb
            // 
            this.afisare_tb.Location = new System.Drawing.Point(13, 13);
            this.afisare_tb.Multiline = true;
            this.afisare_tb.Name = "afisare_tb";
            this.afisare_tb.Size = new System.Drawing.Size(578, 284);
            this.afisare_tb.TabIndex = 6;
            this.afisare_tb.Text = "\r\n";
            this.afisare_tb.TextChanged += new System.EventHandler(this.afisare_tb_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(611, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "Afisare optiuni alese astazi\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.afisare_tb);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tiparire_bt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generaregrafic_bt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Afisare facultati";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generaregrafic_bt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tiparire_bt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox afisare_tb;
        private System.Windows.Forms.Button button2;
    }
}