using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace AdmitereFacultate
{
    public partial class Form1 : Form
    {
        List<Candidat> listaCandidat = new List<Candidat>();
        List<Facultate> listaFacultate = new List<Facultate>();
        List<Medie> listaMedii = new List<Medie>();
        public Form1()
        {
            InitializeComponent();
            sex_cb.Text = "Maculin";
            tip_invatamant_cb.Text = "IF";
        }

        private void candidat_bt_Click(object sender, EventArgs e)
        {
            string cnp;
            string cetatenie;
            string nume;
            string initialaTatalui;
            string prenume;
            string sex;
            string adresa;
            string nrTelefon;
            string email;

            cnp = cnp_tb.Text;
            cetatenie = cetatenie_tb.Text;
            nume = nume_tb.Text;
            initialaTatalui = initialaTatalui_tb.Text;
            prenume = prenume_tb.Text;
            sex = sex_cb.Text;
            adresa = adresa_tb.Text;
            nrTelefon = nrTelefon_tb.Text;
            email = email_tb.Text;
            if(cnp.ToString().Length==13 && adresa.Length>5 && nrTelefon.Length==10 && email.Length > 5)
            {
                Candidat c = new Candidat(cnp, cetatenie, nume, initialaTatalui, prenume, sex, adresa, nrTelefon, email);
                string connString= @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = candidati.accdb";
                OleDbConnection conexiune = new OleDbConnection(connString);
                OleDbCommand candidat = new OleDbCommand();
                candidat.Connection = conexiune;
                try
                {
                    conexiune.Open();
                    candidat.CommandText = "INSERT INTO candidati VALUES(?,?,?,?,?,?,?,?,?)";
                    candidat.Parameters.Add("cnp", OleDbType.Char,14).Value = cnp;
                    candidat.Parameters.Add("cetatenie", OleDbType.Char, 30).Value = cetatenie;
                    candidat.Parameters.Add("nume", OleDbType.Char, 30).Value = nume;
                    candidat.Parameters.Add("initiala_tatalui", OleDbType.Char, 3).Value = initialaTatalui;
                    candidat.Parameters.Add("prenume", OleDbType.Char, 30).Value = prenume;
                    candidat.Parameters.Add("sex", OleDbType.Char, 10).Value = sex;
                    candidat.Parameters.Add("adresa", OleDbType.Char, 60).Value = adresa;
                    candidat.Parameters.Add("numar_telefon", OleDbType.Integer).Value = nrTelefon;
                    candidat.Parameters.Add("email", OleDbType.Char, 40).Value = email;
                    candidat.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show(c.ToString());
                    listaCandidat.Add(c);
                    conexiune.Close();
                    cnp_tb.Clear();
                    cetatenie_tb.Clear();
                    nume_tb.Clear();
                    initialaTatalui_tb.Clear();
                    prenume_tb.Clear();
                    adresa_tb.Clear();
                    nrTelefon_tb.Clear();
                    email_tb.Clear();
                }
            }
            else
           {
                MessageBox.Show("A fost detectata cel putin o eroare");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(listaFacultate);
            form.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cnp_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cnp_tb.Text))
            {
                errorProvider1.SetError(cnp_tb, "Acest camp nu poate fi lasat gol");
            }
            else if (cnp_tb.Text.Length < 13 && cnp_tb.Text.Length>13)
            {
                errorProvider1.SetError(cnp_tb, "Acest camp trebuie sa contina 13 cifre ");
            }
            else
            {
                errorProvider1.SetError(cnp_tb, null);
            }
        }

        private void nrTelefon_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nrTelefon_tb.Text))
            {
                errorProvider1.SetError(nrTelefon_tb, "Acest camp nu poate fi lasat gol");
            }
            else if (nrTelefon_tb.Text.Length < 10 && nrTelefon_tb.Text.Length > 10)
            {
                errorProvider1.SetError(nrTelefon_tb, "Acest camp trebuie sa contina 10 cifre ");
            }
            else
            {
                errorProvider1.SetError(nrTelefon_tb, null);
            }
        }

        private void cetatenie_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cetatenie_tb.Text))
            {
                errorProvider1.SetError(cetatenie_tb, "Acest camp nu poate fi lasat gol");
            }
           
            else
            {
                errorProvider1.SetError(cetatenie_tb, null);
            }
        }

        private void nume_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nume_tb.Text))
            {
                errorProvider1.SetError(nume_tb, "Acest camp nu poate fi lasat gol");
            }

            else
            {
                errorProvider1.SetError(nume_tb, null);
            }
        }

        private void initialaTatalui_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(initialaTatalui_tb.Text))
            {
                errorProvider1.SetError(initialaTatalui_tb, "Acest camp nu poate fi lasat gol");
            }

            else
            {
                errorProvider1.SetError(initialaTatalui_tb, null);
            }
        }

        private void prenume_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(prenume_tb.Text))
            {
                errorProvider1.SetError(prenume_tb, "Acest camp nu poate fi lasat gol");
            }

            else
            {
                errorProvider1.SetError(prenume_tb, null);
            }
        }

        private void adresa_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(adresa_tb.Text))
            {
                errorProvider1.SetError(adresa_tb, "Acest camp nu poate fi lasat gol");
            }

            else
            {
                errorProvider1.SetError(adresa_tb, null);
            }
        }

        private void email_tb_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(email_tb.Text))
            {
                errorProvider1.SetError(email_tb, "Acest camp nu poate fi lasat gol");
            }
            else if (email_tb.Text.Length < 5 )
            {
                errorProvider1.SetError(email_tb, "Acest camp trebuie sa contina 5 caractere ");
            }
            else
            {
                errorProvider1.SetError(nrTelefon_tb, null);
            }
        }

        private void optiune_bt_Click(object sender, EventArgs e)
        {
            string cnp;
            string tip;
            string denumire;
            string specializare;

            cnp = cnp_candidat_tb.Text;
            tip = tip_invatamant_cb.Text;
            denumire = denumire_tb.Text;
            specializare = specializare_tb.Text;

            if (cnp.ToString().Length == 13 )
            {
                Facultate f= new Facultate(cnp, tip,denumire,specializare);

                string connString1 = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Facultati.accdb";
                OleDbConnection conexiunef = new OleDbConnection(connString1);
                OleDbCommand facultate = new OleDbCommand();
                facultate.Connection = conexiunef;
                try
                {
                    conexiunef.Open();
                    facultate.CommandText = "INSERT INTO Facultati VALUES(?,?,?,?)";
                    facultate.Parameters.Add("cnp", OleDbType.Char).Value = cnp;
                    facultate.Parameters.Add("tip_invatamant", OleDbType.Char, 30).Value = tip;
                    facultate.Parameters.Add("facultate", OleDbType.Char, 30).Value = facultate;
                    facultate.Parameters.Add("specializare", OleDbType.Char, 30).Value = specializare;
                   
                   


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show(f.ToString());
                    listaFacultate.Add(f);
                    conexiunef.Close();
                    cnp_candidat_tb.Clear();
                    specializare_tb.Clear();
                    denumire_tb.Clear();
                   
                }
            }
            else
            {
                MessageBox.Show("A fost detectata cel putin o eroare");
            }

        }

        private void cnp_candidat_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cnp_candidat_tb.Text))
            {
                errorProvider1.SetError(cnp_candidat_tb, "Acest camp nu poate fi lasat gol");
            }
            else if (cnp_candidat_tb.Text.Length < 13 && cnp_candidat_tb.Text.Length > 13)
            {
                errorProvider1.SetError(cnp_candidat_tb, "Acest camp trebuie sa contina 13 cifre ");
            }
            else
            {
                errorProvider1.SetError(cnp_candidat_tb, null);
            }

        }

        private void denumire_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(denumire_tb.Text))
            {
                errorProvider1.SetError(denumire_tb, "Acest camp nu poate fi lasat gol");
            }

            else
            {
                errorProvider1.SetError(denumire_tb, null);
            }
        }

        private void specializare_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(specializare_tb.Text))
            {
                errorProvider1.SetError(specializare_tb, "Acest camp nu poate fi lasat gol");
            }

            else
            {
                errorProvider1.SetError(specializare_tb, null);
            }
        }

        private void medie_bt_Click(object sender, EventArgs e)
        {
            string cnp_medie;
            double medie_liceu;
            double medie_bac;
            double medie_admitere;
            cnp_medie = cnp_medie_tb.Text;
            medie_liceu = double.Parse(medie_liceu_tb.Text);
            medie_bac = double.Parse(medie_bac_tb.Text);
            medie_admitere = medie_bac * 0.6 + medie_liceu * 0.4;

            if (cnp_medie.ToString().Length == 13)
            {
                Medie m= new Medie(cnp_medie, medie_liceu, medie_bac);

                string connString2 = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = medii.accdb";
                OleDbConnection conexiunem= new OleDbConnection(connString2);
                OleDbCommand medie = new OleDbCommand();
                medie.Connection = conexiunem;
                try
                {
                    conexiunem.Open();
                    medie.CommandText = "INSERT INTO medii VALUES(?,?,?,?)";
                    medie.Parameters.Add("cnp", OleDbType.Char).Value = cnp_medie;
                    medie.Parameters.Add("medie_liceu", OleDbType.Double).Value = medie_liceu;
                    medie.Parameters.Add("medie_bacalaureat", OleDbType.Double).Value = medie_bac;
                   medie.Parameters.Add("medie_admitere", OleDbType.Double).Value = medie_admitere;




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show(m.ToString());
                    listaMedii.Add(m);
                    conexiunem.Close();
                    cnp_medie_tb.Clear();
                    medie_liceu_tb.Clear();
                    medie_bac_tb.Clear();

                }
            }
            else
            {
                MessageBox.Show("A fost detectata cel putin o eroare");
            }

        }

       
        private void cnp_medie_tb_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cnp_medie_tb.Text))
            {
                errorProvider1.SetError(cnp_medie_tb, "Acest camp nu poate fi lasat gol");
            }
            else if (cnp_medie_tb.Text.Length < 13 && cnp_medie_tb.Text.Length > 13)
            {
                errorProvider1.SetError(cnp_medie_tb, "Acest camp trebuie sa contina 13 cifre ");
            }
            else
            {
                errorProvider1.SetError(cnp_medie_tb, null);
            }
        }

        private void medie_liceu_tb_TextChanged(object sender, EventArgs e)
        {
            if (medie_liceu_tb==null)
            {
                errorProvider1.SetError(medie_liceu_tb, "Acest camp nu trebuie sa fie null ");
            }
            else
            {
                errorProvider1.SetError(medie_liceu_tb, null);
            }

        }

        private void medie_bac_tb_TextChanged(object sender, EventArgs e)
        {
            if (medie_bac_tb == null)
            {
                errorProvider1.SetError(medie_bac_tb, "Acest camp nu trebuie sa fie null ");
            }
            else
            {
                errorProvider1.SetError(medie_bac_tb, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.ShowDialog();
        }
    }
}
