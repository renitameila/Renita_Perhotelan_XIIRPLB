using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renita_Perhotelan_XIIRPLB
{
    public partial class Ffasilitas : Form
    {
        public Ffasilitas()
        {
            InitializeComponent();
            tampildata();
        }

        private void cmbkategori_DropDown(object sender, EventArgs e)
        {
            cmbkategori.Items.Clear();
            cmbkategori.Items.Add("Umum");
            cmbkategori.Items.Add("Kamar");
        }

        private void cmbstatus_DropDown(object sender, EventArgs e)
        {
            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Aktif");
            cmbstatus.Items.Add("Tidak Aktif");
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DBhotel.crud("SELECT id_fasilitas, nama_fasilitas, kategori, deskripsi, status FROM fasilitas");

            foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
            {
                string idfasilitas = "" + baris["id_fasilitas"];
                string nama = "" + baris["nama_fasilitas"];
                string kategori = "" + baris["kategori"];
                string deskripsi = "" + baris["deskripsi"];
                string status = "" + baris["status"];

                guna2DataGridView1.Rows.Add(idfasilitas, nama, kategori, deskripsi, status);
            }
        }

        public void bersih()
        {
            txtidfasilitas.Clear();
            cmbkategori.SelectedIndex = -1;
            txtdeskripsi.Clear();
            cmbstatus.SelectedIndex = -1;
            txtnmfasilitas.Select();
        }
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            DBhotel.crud($"INSERT INTO fasilitas (nama_fasilitas, kategori, deskripsi, status) VALUES ('{txtnmfasilitas.Text}', '{cmbkategori.Text}', '{txtdeskripsi.Text}', '{cmbstatus.Text}')");

            tampildata();
            bersih();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            if (baris < 0) return;

            string nama = "" + guna2DataGridView1.Rows[baris].Cells[1].Value;
            string kategori = "" + guna2DataGridView1.Rows[baris].Cells[2].Value;
            string deskripsi = "" + guna2DataGridView1.Rows[baris].Cells[3].Value;
            string status = "" + guna2DataGridView1.Rows[baris].Cells[4].Value;

            txtnmfasilitas.Text = nama;
            cmbkategori.Text = kategori;
            txtdeskripsi.Text = deskripsi;
            cmbstatus.Text = status;
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index; 
            string idfasilitas = "" + guna2DataGridView1.Rows[baris].Cells[0].Value; 
            DBhotel.crud($"UPDATE fasilitas SET nama_fasilitas = '{txtnmfasilitas.Text}', kategori = '{cmbkategori.Text}', deskripsi = '{txtdeskripsi.Text}', status = '{cmbstatus.Text}' WHERE id_fasilitas = '{idfasilitas}'");

            tampildata();
            bersih();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index; 
            string idfasilitas = "" + guna2DataGridView1.Rows[baris].Cells[0].Value; 
            DBhotel.crud($"DELETE FROM fasilitas WHERE id_fasilitas = '{idfasilitas}'");

            tampildata();
            bersih();
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            bersih();
        }
    }
}
