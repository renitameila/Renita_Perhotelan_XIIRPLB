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
    public partial class Freservasi : Form
    {
        public Freservasi()
        {
            InitializeComponent();
            tampildata();
            tampilkamar();
            tampiltamu();
        }
        public void tampiltamu()
        {
            cmbtamu.Items.Clear(); 
            DBhotel.crud("SELECT id_tamu, nama_lengkap FROM tamu"); 
            foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
            {
                cmbtamu.Items.Add("" + baris["nama_lengkap"]);
            }
        }
        public void tampilkamar()
        {
            cmbkamar.Items.Clear(); 
            DBhotel.crud("SELECT nomor_kamar FROM kamar WHERE status_kamar = 'Tersedia'"); 
            foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
            {
                cmbkamar.Items.Add("" + baris["nomor_kamar"]);
            }
        }
        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear(); 
            DBhotel.crud("SELECT reservasi.id_reservasi, reservasi.kode_reservasi, tamu.nama_lengkap, kamar.nomor_kamar, reservasi.tanggal_reservasi, reservasi.tanggal_checkin, reservasi.tanggal_checkout, reservasi.jumlah_tamu, reservasi.status FROM reservasi INNER JOIN tamu ON reservasi.id_tamu = tamu.id_tamu INNER JOIN kamar ON reservasi.id_kamar = kamar.id_kamar");
            foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_reservasi"];
                string kode = "" + baris["kode_reservasi"];
                string nama = "" + baris["nama_lengkap"];
                string kamar = "" + baris["nomor_kamar"];
                string tanggalreservasi = "" + baris["tanggal_reservasi"];
                string checkin = "" + baris["tanggal_checkin"];
                string checkout = "" + baris["tanggal_checkout"];
                string jumlah = "" + baris["jumlah_tamu"];
                string status = "" + baris["status"];

                guna2DataGridView1.Rows.Add(id, kode, nama, kamar, tanggalreservasi, checkin, checkout, jumlah, status);
            }
        }
        public void bersih()
        {
            txtkode.Clear();
            cmbtamu.SelectedIndex = -1;
            cmbkamar.SelectedIndex = -1;
            dtreservasi.Value = DateTime.Now;
            dtcheckin.Value = DateTime.Now;
            dtcheckout.Value = DateTime.Now;
            txtjumlahtamu.Clear();
            cmbstatus.SelectedIndex = -1;

            txtkode.Select();
        }

        private void cmbstatus_DropDown(object sender, EventArgs e)
        {
            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Menunggu");
            cmbstatus.Items.Add("Dikonfirmasi");
            cmbstatus.Items.Add("Check-In");
            cmbstatus.Items.Add("Selesai");
            cmbstatus.Items.Add("Dibatalkan");
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            DBhotel.crud($"SELECT id_tamu FROM tamu WHERE nama_lengkap = '{cmbtamu.Text}'");
            string idtamu = "" + DBhotel.ds.Tables[0].Rows[0]["id_tamu"];

            DBhotel.crud($"SELECT id_kamar FROM kamar WHERE nomor_kamar = '{cmbkamar.Text}'");
            string idkamar = "" + DBhotel.ds.Tables[0].Rows[0]["id_kamar"];

            DBhotel.crud($"INSERT INTO reservasi (kode_reservasi, id_tamu, id_kamar, tanggal_reservasi, tanggal_checkin, tanggal_checkout, jumlah_tamu, status) VALUES ('{txtkode.Text}', '{idtamu}', '{idkamar}', '{dtreservasi.Value.ToString("yyyy-MM-dd")}', '{dtcheckin.Value.ToString("yyyy-MM-dd")}', '{dtcheckout.Value.ToString("yyyy-MM-dd")}', '{txtjumlahtamu.Text}', '{cmbstatus.Text}')");

            DBhotel.crud($"UPDATE kamar SET status_kamar = 'Dipesan' WHERE id_kamar = '{idkamar}'");

            tampildata();
            tampilkamar();
            bersih();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            if (baris < 0) return; 
            string id = "" + guna2DataGridView1.Rows[baris].Cells[0].Value; 
            DBhotel.crud($"SELECT * FROM reservasi WHERE id_reservasi = '{id}'");

            foreach (DataRow data in DBhotel.ds.Tables[0].Rows)
            {
                txtkode.Text = "" + data["kode_reservasi"];

                DBhotel.crud($"SELECT nama_lengkap FROM tamu WHERE id_tamu = '{data["id_tamu"]}'");
                cmbtamu.Text = "" + DBhotel.ds.Tables[0].Rows[0]["nama_lengkap"];

                DBhotel.crud($"SELECT nomor_kamar FROM kamar WHERE id_kamar = '{data["id_kamar"]}'");
                cmbkamar.Text = "" + DBhotel.ds.Tables[0].Rows[0]["nomor_kamar"];

                dtreservasi.Value = Convert.ToDateTime(data["tanggal_reservasi"]);
                dtcheckin.Value = Convert.ToDateTime(data["tanggal_checkin"]);
                dtcheckout.Value = Convert.ToDateTime(data["tanggal_checkout"]);
                txtjumlahtamu.Text = "" + data["jumlah_tamu"];
                cmbstatus.Text = "" + data["status"];
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index; 
            string id = "" + guna2DataGridView1.Rows[baris].Cells[0].Value; 

            DBhotel.crud($"SELECT id_tamu FROM tamu WHERE nama_lengkap = '{cmbtamu.Text}'");
            string idtamu = "" + DBhotel.ds.Tables[0].Rows[0]["id_tamu"];

            DBhotel.crud($"SELECT id_kamar FROM kamar WHERE nomor_kamar = '{cmbkamar.Text}'");
            string idkamar = "" + DBhotel.ds.Tables[0].Rows[0]["id_kamar"];

            DBhotel.crud($"UPDATE reservasi SET kode_reservasi = '{txtkode.Text}', id_tamu = '{idtamu}', id_kamar = '{idkamar}', tanggal_reservasi = '{dtreservasi.Value.ToString("yyyy-MM-dd")}', tanggal_checkin = '{dtcheckin.Value.ToString("yyyy-MM-dd")}', tanggal_checkout = '{dtcheckout.Value.ToString("yyyy-MM-dd")}', jumlah_tamu = '{txtjumlahtamu.Text}', status = '{cmbstatus.Text}' WHERE id_reservasi = '{id}'");

            tampildata();
            tampilkamar();
            bersih();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index;
            string id = "" + guna2DataGridView1.Rows[baris].Cells[0].Value;

            DBhotel.crud($"SELECT id_kamar FROM reservasi WHERE id_reservasi = '{id}'");
            string idkamar = "" + DBhotel.ds.Tables[0].Rows[0]["id_kamar"];

            DBhotel.crud($"DELETE FROM reservasi WHERE id_reservasi = '{id}' ");
            DBhotel.crud($"UPDATE reservasi SET status_kamar = 'Tersedia' WHERE id_kamar = '{idkamar}'");

            tampildata();
            tampilkamar();
            bersih();

        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            bersih();
        }
    }
}
