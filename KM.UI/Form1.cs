using KM.Business.Abstract;
using KM.Business.Concrete;
using KM.Entities.Concrete;
using KM.Veritabani.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMUI
{
    public partial class Form1 : Form
    {
        IUrunServis _urunServis;
        IKategoriServis _kategoriServis;
        public Form1()
        {
            InitializeComponent();
            _urunServis = new UrunKontrol(new EfUrunDal());
            _kategoriServis = new KategoriKontrol(new EfKategoriDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            kategori();

        }

        private void listele()
        {
            dgwUrun.DataSource = _urunServis.listele();
        }

        public void kategori()
        {
            cbkategori.DataSource = _kategoriServis.listele();
            cbkategori.DisplayMember = "CategoryName";
            cbkategori.ValueMember = "CategoryId";

            cbKategoriSec.DataSource = _kategoriServis.listele();
            cbKategoriSec.DisplayMember = "CategoryName";
            cbKategoriSec.ValueMember = "CategoryId";

            cbUpdatekategori.DataSource = _kategoriServis.listele();
            cbUpdatekategori.DisplayMember = "CategoryName";
            cbUpdatekategori.ValueMember = "CategoryId";
        }

        private void cbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwUrun.DataSource = _urunServis.kategoriyeGöre(Convert.ToInt32(cbkategori.SelectedValue));
            }
            catch
            {
            }

        }

        private void txtUrun_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUrun.Text))
            {
                dgwUrun.DataSource = _urunServis.ismeGöre(txtUrun.Text);
            }
            else
            {
                listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _urunServis.ekle(new Product()
            {
                CategoryId = Convert.ToInt32(cbKategoriSec.SelectedValue),
                ProductName = txtUrunAd.Text,
                QuantityPerUnit = txtBirim.Text,
                UnitPrice = Convert.ToDecimal(txtfiyat.Text),
                UnitsInStock = Convert.ToInt16(txtStok.Text)
            });
            MessageBox.Show("Kayıt Başarılı");
            listele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            _urunServis.guncelle(new Product()
            {
                ProductId = Convert.ToInt32(dgwUrun.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cbUpdatekategori.SelectedValue),
                ProductName = txtUpdateAd.Text,
                QuantityPerUnit = txtUpdateBirim.Text,
                UnitPrice = Convert.ToDecimal(txtUpdateFiyat.Text),
                UnitsInStock = Convert.ToInt16(txtUpdateStok.Text)
            });
            MessageBox.Show("Güncelleme Başarılı");
            listele();
        }

        private void dgwUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwUrun.CurrentRow;

            txtUpdateAd.Text = row.Cells[1].Value.ToString();
            cbUpdatekategori.SelectedValue = row.Cells[2].Value;
            txtUpdateFiyat.Text = row.Cells[3].Value.ToString();
            txtUpdateBirim.Text = row.Cells[4].Value.ToString();
            txtUpdateStok.Text = row.Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _urunServis.sil(new Product()
            {
                ProductId = Convert.ToInt32(dgwUrun.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cbUpdatekategori.SelectedValue),
                ProductName = txtUpdateAd.Text,
                QuantityPerUnit = txtUpdateBirim.Text,
                UnitPrice = Convert.ToDecimal(txtUpdateFiyat.Text),
                UnitsInStock = Convert.ToInt16(txtUpdateStok.Text)

            });
            MessageBox.Show("Silme Başarılı");
            listele();
        }
    }
}
