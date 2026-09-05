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
    public partial class Ffasilitas_tipe_kamar : Form
    {
        public Ffasilitas_tipe_kamar()
        {
            InitializeComponent();
            tampildata();
        } 
        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();

            DBhotel.crud("SELECT tipe_kamar_fasilitas.id_tipe_fasilitas, tipe_kamar.nama_tipe, fasilitas.nama_fasilitas FROM tipe_kamar_fasilitas INNER JOIN tipe_kamar ON tipe_kamar_fasilitas.id_tipe = tipe_kamar.id_tipe INNER JOIN fasilitas ON tipe_kamar_fasilitas.id_fasilitas = fasilitas.id_fasilitas"); 
            foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_tipe_fasilitas"];
                string tipe = "" + baris["nama_tipe"];
                string fasilitas = "" + baris["nama_fasilitas"]; 
                guna2DataGridView1.Rows.Add(id, tipe, fasilitas);
            }
        }
        public void bersih()
        {
            cmbtipekamar.SelectedIndex = -1;
            cmbfasilitas.SelectedIndex = -1;
            cmbtipekamar.Select();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            DBhotel.crud($"SELECT id_tipe FROM tipe_kamar WHERE nama_tipe = '{cmbtipekamar.Text}'");
            string idtipe = "" + DBhotel.ds.Tables[0].Rows[0]["id_tipe"];

            DBhotel.crud($"SELECT id_fasilitas FROM fasilitas WHERE nama_fasilitas = '{cmbfasilitas.Text}'");
            string idfasilitas = "" + DBhotel.ds.Tables[0].Rows[0]["id_fasilitas"];

            DBhotel.crud($"INSERT INTO tipe_kamar_fasilitas (id_tipe, id_fasilitas) VALUES ('{idtipe}', '{idfasilitas}')");

            tampildata();
            bersih();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index; 
            string id = "" + guna2DataGridView1.Rows[baris].Cells[0].Value;

            DBhotel.crud($"SELECT id_tipe FROM tipe_kamar WHERE nama_tipe = '{cmbtipekamar.Text}'");
            string idtipe = "" + DBhotel.ds.Tables[0].Rows[0]["id_tipe"];

            DBhotel.crud($"SELECT id_fasilitas FROM fasilitas WHERE nama_fasilitas = '{cmbfasilitas.Text}'");
            string idfasilitas = "" + DBhotel.ds.Tables[0].Rows[0]["id_fasilitas"];

            DBhotel.crud($"UPDATE tipe_kamar_fasilitas SET id_tipe = '{idtipe}', id_fasilitas = '{idfasilitas}' WHERE id_tipe_fasilitas = '{id}'");

            tampildata();
            bersih();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            if (baris < 0) return; 
            string tipe = "" + guna2DataGridView1.Rows[baris].Cells[1].Value;
            string fasilitas = "" + guna2DataGridView1.Rows[baris].Cells[2].Value; 
            cmbtipekamar.Text = tipe;
            cmbfasilitas.Text = fasilitas;
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index; 
            string id = "" + guna2DataGridView1.Rows[baris].Cells[0].Value; 
            DBhotel.crud($"DELETE FROM tipe_kamar_fasilitas WHERE id_tipe_fasilitas = '{id}'");

            tampildata();
            bersih();
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            bersih();
        }
    }
}

