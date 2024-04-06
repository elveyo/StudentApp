using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.P5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB220246
{
    public partial class frmStudentSlike : Form
    {
        private KonekcijaNaBazu DB = DLWMSdb.Baza;
        private Student student;
        private List<StudentSlika> trenutneSlike;
        private int index = 0;
        public frmStudentSlike(Student student)
        {
            InitializeComponent();
            this.student = student;

        }

        private void frmStudentSlike_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pbOdabranaSlika_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbOdabranaSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            if(Validator.ValidirajKontrolu(rtbOpis,errOpis,"Morate unijeti opis")
            && Validator.ValidirajKontrolu(pbOdabranaSlika,errSlika,"Morate unijeti sliku"))
            {
                var novaSlika = new StudentSlika()
                {
                    Student = student,
                    Slika = ImageHelper.FromImageToByte(pbOdabranaSlika.Image),
                    Opis = rtbOpis.Text,
                    DatumDodavanja = DateTime.Now,
                };
                DB.StudentSlike.Add(novaSlika);
                DB.SaveChanges();
                rtbOpis.Text = "";
                pbOdabranaSlika.Image = null;
                LoadData();
            }
        }

        private void LoadData()
        {
            trenutneSlike = DB.StudentSlike.Where(s=>s.Student.Id == student.Id).ToList();
            if (trenutneSlike.Count > 0)
            {
                PostaviSliku(index);
            }
        }

        private void PostaviSliku(int index)
        {
            lblBrojSlike.Text = $"Slika {index+1}/{trenutneSlike.Count}";
            pbTrenutnaSlika.Image = ImageHelper.FromByteToImage(trenutneSlike[index].Slika);
            lblDatum.Text = trenutneSlike[index].DatumDodavanja.ToString();
            lblOpis.Text = trenutneSlike[index].Opis;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (index >= trenutneSlike.Count-1)
            {
                return;
            }
            index++;

            PostaviSliku(index);
            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if(index <= 0)
            {
                return;
            }
            index--;
            PostaviSliku(index);

        }
    }
}
