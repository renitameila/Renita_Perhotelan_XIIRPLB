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
    public partial class FLayanan : Form
    {
        public FLayanan()
        {
            InitializeComponent();
            tampildata();
        }

        private void cmbkategori_DropDown(object sender, EventArgs e)
        {
            cmbkategori.Items.Clear();
            cmbkategori.Items.Add("Makanan");
            cmbkategori.Items.Add("Laundry");
            cmbkategori.Items.Add("Kamar");
            cmbkategori.Items.Add("Transportasi");
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
            DBhotel.crud("SELECT id_layanan, nama_layanan, kategori, harga, satuan, deskripsi, status FROM layanan");

            foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
            {
                string idlayanan = "" + baris["id_layanan"];
                string nama = "" + baris["nama_layanan"];
                string kategori = "" + baris["kategori"];
                string harga = "" + baris["harga"];
                string satuan = "" + baris["satuan"];
                string deskripsi = "" + baris["deskripsi"];
                string status = "" + baris["status"];

                guna2DataGridView1.Rows.Add(idlayanan, nama, kategori, harga, satuan, deskripsi, status);
            }
        }

        public void bersih()
        {
            txtlayanan.Clear();
            cmbkategori.SelectedIndex = -1;
            txtharga.Clear();
            txtsatuan.Clear();
            txtdeskripsi.Clear();
            cmbstatus.SelectedIndex = -1;
            txtlayanan.Select();
        }
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            DBhotel.crud($"INSERT INTO layanan (nama_layanan, kategori, harga, satuan, deskripsi, status) VALUES ('{txtlayanan.Text}', '{cmbkategori.Text}', '{txtharga.Text}', '{txtsatuan.Text}', '{txtdeskripsi.Text}', '{cmbstatus.Text}')");

            tampildata();
            bersih();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index; 
            string idlayanan = "" + guna2DataGridView1.Rows[baris].Cells[0].Value; 
            DBhotel.crud($"UPDATE layanan SET nama_layanan = '{txtlayanan.Text}', kategori = '{cmbkategori.Text}', harga = '{txtharga.Text}', satuan = '{txtsatuan.Text}', deskripsi = '{txtdeskripsi.Text}', status = '{cmbstatus.Text}' WHERE id_layanan = '{idlayanan}'");

            tampildata();
            bersih();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            if (baris < 0) return;

            string nama = "" + guna2DataGridView1.Rows[baris].Cells[1].Value;
            string kategori = "" + guna2DataGridView1.Rows[baris].Cells[2].Value;
            string harga = "" + guna2DataGridView1.Rows[baris].Cells[3].Value;
            string satuan = "" + guna2DataGridView1.Rows[baris].Cells[4].Value;
            string deskripsi = "" + guna2DataGridView1.Rows[baris].Cells[5].Value;
            string status = "" + guna2DataGridView1.Rows[baris].Cells[6].Value;

            txtlayanan.Text = nama;
            cmbkategori.Text = kategori;
            txtharga.Text = harga;
            txtsatuan.Text = satuan;
            txtdeskripsi.Text = deskripsi;
            cmbstatus.Text = status;
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index; 
            string idlayanan = "" + guna2DataGridView1.Rows[baris].Cells[0].Value; 
            DBhotel.crud($"DELETE FROM layanan WHERE id_layanan = '{idlayanan}'");

            tampildata();
            bersih();
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            bersih();
        }
    }
}
