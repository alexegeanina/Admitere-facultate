using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AdmitereFacultate
{
    public partial class Form3 : Form
    {
       


        public Form3()
        {
            InitializeComponent();
        }

        private void incarcareDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var grafic = tabel.ChartAreas[0];
            grafic.AxisX.IntervalType = DateTimeIntervalType.Number;

            tabel.Series["Numar locuri"].Points.AddXY("CSIE",350 );
            tabel.Series["Numar locuri"].Points.AddXY("CIG", 400);
            tabel.Series["Numar locuri"].Points.AddXY("DREPT", 150);
            tabel.Series["Numar locuri"].Points.AddXY("BT", 170);
            tabel.Series["Numar locuri"].Points.AddXY("ETA", 100);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void incarcareDateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var grafic = tabel.ChartAreas[0];
            grafic.AxisX.IntervalType = DateTimeIntervalType.Number;

            tabel.Series["Numar locuri"].Points.AddXY("CSIE", 350);
            tabel.Series["Numar locuri"].Points.AddXY("CIG", 400);
            tabel.Series["Numar locuri"].Points.AddXY("DREPT", 150);
            tabel.Series["Numar locuri"].Points.AddXY("BT", 170);
            tabel.Series["Numar locuri"].Points.AddXY("ETA", 100);
        }
    }
}
