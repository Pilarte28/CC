using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCaribe2017
{
    public partial class Form2 : Form
    {
        public Form2(string nombre_reporte)
        {
            InitializeComponent();
            
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(nombre_reporte);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //lll
        }
    }
}
