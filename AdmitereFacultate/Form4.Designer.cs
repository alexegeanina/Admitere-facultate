namespace AdmitereFacultate
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.candidati_lv = new System.Windows.Forms.ListView();
            this.Cnp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cetatenie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Initiala_tatalui = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nr_Tefelon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // candidati_lv
            // 
            this.candidati_lv.CheckBoxes = true;
            this.candidati_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cnp,
            this.Cetatenie,
            this.Nume,
            this.Initiala_tatalui,
            this.Prenume,
            this.Sex,
            this.Adresa,
            this.Nr_Tefelon,
            this.Email});
            this.candidati_lv.FullRowSelect = true;
            this.candidati_lv.GridLines = true;
            this.candidati_lv.HideSelection = false;
            this.candidati_lv.Location = new System.Drawing.Point(29, 12);
            this.candidati_lv.Name = "candidati_lv";
            this.candidati_lv.Size = new System.Drawing.Size(901, 256);
            this.candidati_lv.TabIndex = 8;
            this.candidati_lv.UseCompatibleStateImageBehavior = false;
            this.candidati_lv.View = System.Windows.Forms.View.Details;
            // 
            // Cnp
            // 
            this.Cnp.Text = "Cnp";
            this.Cnp.Width = 85;
            // 
            // Cetatenie
            // 
            this.Cetatenie.Text = "Cetatenie";
            this.Cetatenie.Width = 75;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 84;
            // 
            // Initiala_tatalui
            // 
            this.Initiala_tatalui.Text = "Initiala tatalui";
            this.Initiala_tatalui.Width = 93;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 67;
            // 
            // Sex
            // 
            this.Sex.Text = "Sex";
            this.Sex.Width = 70;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 92;
            // 
            // Nr_Tefelon
            // 
            this.Nr_Tefelon.Text = "Numar de telefon";
            this.Nr_Tefelon.Width = 129;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 77;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(58, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Vizualizare candidati";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(360, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "Stergere inregistrare";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1221, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.candidati_lv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Informatii candidati";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView candidati_lv;
        private System.Windows.Forms.ColumnHeader Cnp;
        private System.Windows.Forms.ColumnHeader Cetatenie;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Initiala_tatalui;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader Nr_Tefelon;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}