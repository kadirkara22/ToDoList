using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.BusinessService;
using ToDoList.Entities;

namespace ToDoList
{
    public partial class yeniKayit : Form
    {
        public yeniKayit()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            todoService todoService = new todoService();
          int sonuc=todoService.kayitYeni(new Entities.todo()
            {
                id = Guid.NewGuid(),
                baslik = txtBaslik.Text,
                kisaAciklama = txtKisaAciklama.Text,
                aciklama = txtAciklama.Text,
                durum = cmbDurum.SelectedItem.ToString(),
                onemDerece=int.Parse(txtDerece.Text),
                olusturmaTarih=DateTime.Now
            });
            if (sonuc>0)
            {
                MessageBox.Show("KAyıt ekleme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result= MessageBox.Show("Yeni Kayıt ekleme işlemine devam etmek ister misiniz?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    foreach (Control item in Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = string.Empty;
                        }
                    }
                }
                else
                {
                    Form kayitListe = Application.OpenForms["kayitListe"];
                    if (kayitListe==null)
                    {
                        kayitListe = new kayitListe();
                        kayitListe.MdiParent = Application.OpenForms["Form1"];
                        kayitListe.StartPosition = FormStartPosition.CenterScreen;
                        kayitListe.Show();
                        this.Close();
                    }
                    else
                    {
                       GroupBox Liste=(GroupBox)kayitListe.Controls["grpBoxListe"];
                       DataGridView grdLİste =(DataGridView)Liste.Controls["grdListe"];
                      List<todo> GuncelListe= todoService.kayitListe();
                        grdLİste.DataSource = null;
                        grdLİste.DataSource = GuncelListe;
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("KAyıt ekleme işleminde hata", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnYeniKayit_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnYeniKayit_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtBaslik_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txtBaslik_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }
    }
}
