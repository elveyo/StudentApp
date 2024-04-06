using DLWMS.WinForms.DB;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Reports
{
    public partial class frmIzvjestaj : Form
    {
        private KonekcijaNaBazu DB = DLWMSdb.Baza;
        public frmIzvjestaj()
        {
            InitializeComponent();

        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {         
            this.reportViewer1.RefreshReport();
            //var studentiPredmeti = DB.StudentiPredmeti.ToList();
            //double prosjek  = 0;
            //if(studentiPredmeti.Count > 0)
            //{
            //    prosjek = studentiPredmeti.Average(sp=>sp.Ocjena);
            //}
            //var rpc = new ReportParameterCollection();
            //rpc.Add(new ReportParameter("pProsjek", prosjek.ToString()));
            //reportViewer1.LocalReport.SetParameters(rpc);

            //var tabela = new DLWMS.StudentiPredmetiDataTable();
            //foreach (var sp in studentiPredmeti)
            //{
            //    var red = tabela.NewStudentiPredmetiRow();
            //    red.Student = sp.Student.ToString();
            //    red.Predmet = sp.Predmet.ToString();
            //    red.Datum = sp.DatumPolaganja.ToString();
            //    red.Ocjena = sp.Ocjena.ToString();

            //    tabela.AddStudentiPredmetiRow(red);
            //}
            //var rds = new ReportDataSource();
            //rds.Value = tabela;
            //rds.Name = "StudentiPredmetiDS";
            //reportViewer1.LocalReport.DataSources.Add(rds);
            //reportViewer1.RefreshReport();
            


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
