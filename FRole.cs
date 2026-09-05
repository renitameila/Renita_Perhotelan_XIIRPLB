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
    public partial class FRole : Form
    {
        public FRole()
        {
            InitializeComponent();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            DBhotel.crud($"INSERT INTO role (role) VALUES ('{txtrole.Text}')"); 
            DBhotel.crud("SELECT * FROM role"); 
            guna2DataGridView1.Rows.Clear(); 
            foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_role"];
                string role = "" + baris ["role"];
                guna2DataGridView1.Rows.Add(id, role);
            }

            txtrole.Clear();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex; 
            if (baris < 0)
                return; 
            string idnya = guna2DataGridView1.Rows[baris].Cells[0].Value.ToString(); 
            DBhotel.crud($"SELECT * FROM role WHERE id_role = '{idnya}'"); 
            foreach (DataRow bariss in DBhotel.ds.Tables[0].Rows)
            {
                string role = "" + bariss["role"];
                txtrole.Text = role;
            }
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index; 

            string idrole = "" + guna2DataGridView1.Rows[baris].Cells[0].Value;
            string role = txtrole.Text; 
            DBhotel.crud($"UPDATE role SET role = '{role}' WHERE id_role = {idrole}"); 
            tampildata();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            int baris = guna2DataGridView1.CurrentRow.Index; 
            string idrole = "" + guna2DataGridView1.Rows[baris].Cells[0].Value;
            
            DialogResult jawab = MessageBox.Show("Apakah mau dihapus?", "Konfirmasi",
                MessageBoxButtons.YesNo); 
            if (jawab == DialogResult.Yes)
            {
                DBhotel.crud($"DELETE FROM role WHERE id_role = {idrole}"); 
                tampildata();
            }
        }
        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DBhotel.crud($"Select * from role ");
            foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_role"];
                string role = "" + baris["role"]; 
                guna2DataGridView1.Rows.Add(id, role);

            }

        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            txtrole.Clear();
        }

        private void FRole_Load(object sender, EventArgs e)
        {
            tampildata();
            txtrole.Select();
        }
    }
    


}
