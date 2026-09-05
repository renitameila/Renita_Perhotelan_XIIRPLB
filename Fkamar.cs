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
    public partial class Fkamar : Form
    {
        public Fkamar()
        {
            InitializeComponent();
            tampildata();
            txtidkmr.ReadOnly = true;
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            DBhotel.crud($"SELECT id_tipe FROM tipe_kamar WHERE nama_tipe = '{cmbtipekmr.Text}'");
            string idtipe = "" + DBhotel.ds.Tables[0].Rows[0]["id_tipe"];
            DBhotel.crud($"INSERT INTO kamar (nomor_kamar, id_tipe, lantai, status_kamar, kondisi, catatan) VALUES ('{txtnokmr.Text}', '{idtipe}', '{cmblantai.Text}', '{cmbstatus.Text}', '{cmbkondisi.Text}', '{txtcatatan.Text}')");

            tampildata();
            bersih();
        }
        private void cmbtipekmr_DropDown(object sender, EventArgs e)
        {
            cmbtipekmr.Items.Clear();
            cmbtipekmr.Items.Add("Standard");
            cmbtipekmr.Items.Add("Superior");
            cmbtipekmr.Items.Add("Deluxe");
            cmbtipekmr.Items.Add("Family");
            cmbtipekmr.Items.Add("Suite");
        }

        private void cmbstatus_DropDown(object sender, EventArgs e)
        {
            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Tersedia");
            cmbstatus.Items.Add("Terisi");
            cmbstatus.Items.Add("Dipesan");
            cmbstatus.Items.Add("Perbaikan");
        }

     

        private void Fkamar_Load(object sender, EventArgs e)
        {
            tampildata();
            txtnokmr.Select();
        }

        private void txtnokmr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (cmbtipekmr.Text != "")
                {
                    txtcatatan.Select();
                }
            }
        }
        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DBhotel.crud($"Select * from kamar ");
            foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
            {
                string idkmr = "" + baris["id_kamar"];
                string nokmr = "" + baris["nomor_kamar"];
                string tipekmr = "" + baris["nama_tipe"];
                string lantai = "" + baris["lantai"];
                string status = "" + baris["status_kamar"];
                string kondisi = "" + baris["kondisi"]; 
                guna2DataGridView1.Rows.Add(idkmr, nokmr, tipekmr, lantai, status, kondisi);

            }

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            if (baris < 0) return;

            string nokmr = "" + guna2DataGridView1.Rows[baris].Cells[1].Value;
            string tipekmr = "" + guna2DataGridView1.Rows[baris].Cells[2].Value;
            string lantai = "" + guna2DataGridView1.Rows[baris].Cells[3].Value;
            string status = "" + guna2DataGridView1.Rows[baris].Cells[4].Value;
            string kondisi = "" + guna2DataGridView1.Rows[baris].Cells[5].Value;

            txtnokmr.Text = nokmr;
            cmblantai.Text = lantai;
            txtcatatan.Text = "";

            cmbtipekmr.Items.Clear();
            cmbtipekmr.Items.Add("Standard");
            cmbtipekmr.Items.Add("Superior");
            cmbtipekmr.Items.Add("Deluxe");
            cmbtipekmr.Items.Add("Family");
            cmbtipekmr.Items.Add("Suite");
            cmbtipekmr.Text = tipekmr;

            cmblantai.Items.Clear();
            cmblantai.Items.Add("1");
            cmblantai.Items.Add("2");
            cmblantai.Items.Add("3");
            cmblantai.Items.Add("4");
            cmblantai.Items.Add("5");
            cmblantai.Text = lantai;

            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Tersedia");
            cmbstatus.Items.Add("Terisi");
            cmbstatus.Items.Add("Dipesan");
            cmbstatus.Items.Add("Perbaikan");
            cmbstatus.Text = status;

            cmbkondisi.Items.Clear();
            cmbkondisi.Items.Add("Baik");
            cmbkondisi.Items.Add("Rusak");
            cmbkondisi.Text = kondisi;
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index;
            string idkmr = guna2DataGridView1.Rows[baris].Cells[0].Value.ToString(); 
            DBhotel.crud($"UPDATE kamar SET nomor_kamar = '{txtnokmr.Text}', lantai = '{cmblantai.Text}', status_kamar = '{cmbstatus.Text}', kondisi = '{cmbkondisi.Text}', catatan = '{txtcatatan.Text}' WHERE id_kamar = '{idkmr}'"); 
            tampildata();
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index;

            string idkmr = "" + guna2DataGridView1.Rows[baris].Cells[0].Value;

            DBhotel.crud($"DELETE FROM kamar WHERE id_kamar = '{idkmr}'");

            tampildata();
            bersih();
        }

        private void Fkamar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbkondisi_DropDown(object sender, EventArgs e)
        {
            cmbkondisi.Items.Clear();
            cmbkondisi.Items.Add("Baik");
            cmbkondisi.Items.Add("Rusak");
        }

        private void cmblantai_DropDown(object sender, EventArgs e)
        {
            cmblantai.Items.Clear();
            cmblantai.Items.Add("1"); 
            cmblantai.Items.Add("2");
            cmblantai.Items.Add("3");
            cmblantai.Items.Add("4");
            cmblantai.Items.Add("5");
        }

        public void bersih()
        {
            txtnokmr.Clear();
            cmbtipekmr.SelectedIndex = -1;
            cmblantai.SelectedIndex = -1;
            cmbstatus.SelectedIndex = -1;
            cmbkondisi.SelectedIndex = -1;
            txtcatatan.Clear();
            txtnokmr.Select();
        }
    }
}
 