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
    public partial class FTamu : Form
    {
        public FTamu()
        {
            InitializeComponent();
            tampildata();
        }

        private void cmbjk_DropDown(object sender, EventArgs e)
        {
            cmbjk.Items.Clear();
            cmbjk.Items.Add("Laki - Laki");
            cmbjk.Items.Add("Perempuan");
        }

        private void cmbjenisid_DropDown(object sender, EventArgs e)
        {
            cmbjenisid.Items.Clear();
            cmbjenisid.Items.Add("KTP"); 
            cmbjenisid.Items.Add("PASPOR");
        }

        private void cmbkewarganegaraan_DropDown(object sender, EventArgs e)
        {
            cmbkewarganegaraan.Items.Clear();
            cmbkewarganegaraan.Items.Add("WNI"); 
            cmbkewarganegaraan.Items.Add("WNA");
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DBhotel.crud("SELECT id_tamu, nama_lengkap, jenis_identitas, no_identitas, jenis_kelamin, no_telepon, email, status_kewarganegaraan FROM tamu");

            foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
            {
                string idtamu = "" + baris["id_tamu"];
                string nama = "" + baris["nama_lengkap"];
                string identitas = "" + baris["jenis_identitas"];
                string noidentitas = "" + baris["no_identitas"];
                string jeniskelamin = "" + baris["jenis_kelamin"];
                string telepon = "" + baris["no_telepon"];
                string email = "" + baris["email"];
                string kewarganegaraan = "" + baris["status_kewarganegaraan"];

                guna2DataGridView1.Rows.Add(idtamu, nama, identitas, noidentitas, jeniskelamin, telepon, email, kewarganegaraan);
            }
        }

        public void bersih()
        {
            txtnama.Clear();
            txtnoiden.Clear();
            txttl.Clear();
            txtnohp.Clear();
            txtemail.Clear();
            txtalamat.Clear();
            txtcatatan.Clear();

            cmbjenisid.SelectedIndex = -1;
            cmbjk.SelectedIndex = -1;
            cmbkewarganegaraan.SelectedIndex = -1;

            datetl.Value = DateTime.Now;

            txtnama.Select();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            DBhotel.crud($"INSERT INTO tamu (nama_lengkap, jenis_identitas, no_identitas, jenis_kelamin, tempat_lahir, tanggal_lahir, status_kewarganegaraan, no_telepon, email, alamat, catatan) VALUES ('{txtnama.Text}', '{cmbjenisid.Text}', '{txtnoiden.Text}', '{cmbjk.Text}', '{txttl.Text}', '{datetl.Value.ToString("yyyy-MM-dd")}', '{cmbkewarganegaraan.Text}', '{txtnohp.Text}', '{txtemail.Text}', '{txtalamat.Text}', '{txtcatatan.Text}')");

            tampildata();
            bersih();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index;
            string idtamu = "" + guna2DataGridView1.Rows[baris].Cells[0].Value;

            DBhotel.crud($"UPDATE tamu SET nama_lengkap = '{txtnama.Text}', jenis_identitas = '{cmbjenisid.Text}', no_identitas = '{txtnoiden.Text}', jenis_kelamin = '{cmbjk.Text}', tempat_lahir = '{txttl.Text}', tanggal_lahir = '{datetl.Value.ToString("yyyy-MM-dd")}', status_kewarganegaraan = '{cmbkewarganegaraan.Text}', no_telepon = '{txttl.Text}', email = '{txtemail.Text}', alamat = '{txtalamat.Text}', catatan = '{txtcatatan.Text}' WHERE id_tamu = '{idtamu}'");

            tampildata();
            bersih();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            if (baris < 0) return;

            string idtamu = "" + guna2DataGridView1.Rows[baris].Cells[0].Value;

            DBhotel.crud($"SELECT * FROM tamu WHERE id_tamu = '{idtamu}'");

            foreach (DataRow data in DBhotel.ds.Tables[0].Rows)
            {
                txtnama.Text = "" + data["nama_lengkap"];
                cmbjenisid.Text = "" + data["jenis_identitas"];
                txtnoiden.Text = "" + data["no_identitas"];
                cmbjk.Text = "" + data["jenis_kelamin"];
                txttl.Text = "" + data["tempat_lahir"];
                datetl.Value = Convert.ToDateTime(data["tanggal_lahir"]);
                cmbkewarganegaraan.Text = "" + data["status_kewarganegaraan"];
                txtnohp.Text = "" + data["no_telepon"];
                txtemail.Text = "" + data["email"];
                txtalamat.Text = "" + data["alamat"];
                txtcatatan.Text = "" + data["catatan"];
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index; 
            string idtamu = "" + guna2DataGridView1.Rows[baris].Cells[0].Value; 
            DBhotel.crud($"DELETE FROM tamu WHERE id_tamu = '{idtamu}'");

            tampildata();
            bersih();
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void FTamu_Load(object sender, EventArgs e)
        {
            tampildata();
        }
    }
}
