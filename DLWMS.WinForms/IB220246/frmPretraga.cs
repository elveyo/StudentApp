using DLWMS.WinForms.DB;
using DLWMS.WinForms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DLWMS.WinForms.IB220246
{
    public partial class frmPretraga : Form
    {
        private KonekcijaNaBazu DB = DLWMSdb.Baza;
        public frmPretraga()
        {
            InitializeComponent();
            dgvStudentPredmeti.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvStudentPredmeti.DataSource = null;
            List<StudentPredmet> lista;
            if(tbPredmet.Text.Length > 0 )
            {
                 lista = DB.StudentiPredmeti.Where(sp => sp.Predmet.Naziv.Contains(tbPredmet.Text)).ToList();

            }
            else {
                lista = DB.StudentiPredmeti.ToList();
            }

            dgvStudentPredmeti.DataSource = lista;
            this.Text = $"Ukupno zapisa : {lista.Count}";

        }

        private void tbPredmet_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvStudentPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var field = dgvStudentPredmeti.Columns[e.ColumnIndex];
            if(field is DataGridViewButtonColumn)
            {
                var sk = dgvStudentPredmeti.Rows[e.RowIndex].DataBoundItem as StudentPredmet;
                if(field.Index == 4)
                {
                    DB.StudentiPredmeti.Remove(sk);
                    DB.SaveChanges();
                    LoadData();


                }else if(field.Index == 5){

                    frmStudentSlike nova = new frmStudentSlike(sk.Student);
                    nova.ShowDialog();
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            frmIzvjestaj nova = new frmIzvjestaj();
            nova.ShowDialog();

        }

        private int Sumiraj()
        {
            int Od = int.Parse(tbOd.Text);
            int Do = int.Parse(tbDo.Text);
            int suma = 0;
            for (int i = Od; i < Do; i++)
            {
                suma += i;
                Thread.Sleep(1000);
            }
            return suma;
        }
        private async void button1_Click(object sender, EventArgs e)
        {

            int sumiranje = await Task.Run(() => Sumiraj());
            tbSuma.Text = sumiranje.ToString();
            


        }
    }
}
