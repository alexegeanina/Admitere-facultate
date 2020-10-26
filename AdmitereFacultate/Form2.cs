using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmitereFacultate
{
    public partial class Form2 : Form
    {
        List<Facultate> facultatelista=new List<Facultate>();

        public Form2(List<Facultate> listaFacultate)
        {
            InitializeComponent();
            facultatelista = listaFacultate;
            richTextBox1.DragDrop += new DragEventHandler(richTextBox1_DragDrop);
            richTextBox1.AllowDrop = true;
        }

        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            object fileName = e.Data.GetData("FileDrop");
            if (fileName != null)
            {
                var list = fileName as string[];
                if(list!=null && !string.IsNullOrWhiteSpace(list[0]))
                {
                    richTextBox1.Clear();
                    richTextBox1.LoadFile(list[0],RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void generaregrafic_bt_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            
        }
        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var file = data as string[];
                if (file.Length > 0)
                {
                    richTextBox1.LoadFile(file[0]);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" CSIE 350 locuri\n CIG 400 locuri\n DREPT 150 locuri \n BT 170 locuri \n ETA 100 locuri");
        }

        private void tiparire_bt_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
       

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Oferta universitara", new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new Point(300, 10));
            e.Graphics.DrawString(" CSIE 350 locuri\n CIG 400 locuri\n DREPT 150 locuri \n BT 170 locuri \n ETA 100 locuri", new Font("Times New Roman", 16, FontStyle.Regular), Brushes.Black, new Point(10, 40));
        }

       
       


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void afisare_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Facultate f in facultatelista)
                afisare_tb.Text += f.ToString() + Environment.NewLine;
        }
    }
}
