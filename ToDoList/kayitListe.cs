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
    public partial class kayitListe : Form
    {
        todoService todoService;
        public kayitListe()
        {
            InitializeComponent();
            todoService = new todoService();
        }

        private void kayitListe_Load(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe();
            grdListe.Columns["ID"].Visible = false;
        }

        private List<todo> TumListe()
        {
           return todoService.kayitListe();
        }

        private void btnTümListe_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe();
            grdListe.Columns["ID"].Visible = false;
        }

        private void btnTamamlandı_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(x => x.durum == "Tamamlandı").ToList();
            grdListe.Columns["ID"].Visible = false;
        }

        private void btnTamamlanamadı_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(x => x.durum == "Tamamlanmadı").ToList();
            grdListe.Columns["ID"].Visible = false;
        }

        private void btnIptalEdildi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(x => x.durum == "İptal edildi").ToList();
            grdListe.Columns["ID"].Visible = false;
        }
    }
}
