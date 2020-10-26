using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmitereFacultate
{
    public partial class Form4 : Form
    {
       
        public Form4()
        {
          
            
           

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = candidati.accdb";
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM candidati", conexiune);

            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["cnp"].ToString());
                    //itm.Add(reader["cetatenie"].ToString());
                   itm.SubItems.Add(reader["cetatenie"].ToString());
                    itm.SubItems.Add(reader["nume"].ToString());
                    itm.SubItems.Add(reader["initiala_tatalui"].ToString());
                    itm.SubItems.Add(reader["prenume"].ToString());
                    itm.SubItems.Add(reader["sex"].ToString());
                    itm.SubItems.Add(reader["adresa"].ToString());
                    itm.SubItems.Add(reader["numar_telefon"].ToString());
                    itm.SubItems.Add(reader["email"].ToString());


                    candidati_lv.Items.Add(itm);

                   
                  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = candidati.accdb";
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand candidat = new OleDbCommand();
            candidat.Connection = conexiune;

            try
            {
                conexiune.Open();
                foreach (ListViewItem itm in candidati_lv.Items)
                {
                    if (itm.Checked)
                    {
                       string cnp = itm.SubItems[0].Text;
                        candidat.CommandText = "DELETE FROM candidati where cnp ="+"'"+cnp+"'";
                         candidat.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
           
            button1_Click(sender, e);
        }
    }
}
