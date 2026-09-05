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
    public partial class Fuser : Form
    {
        public Fuser()
        {
            InitializeComponent();
        }

        private void Fuser_Load(object sender, EventArgs e)
        {
            tampildata();
                DBhotel.crud("SELECT * FROM role"); 
                cmbrole.Items.Clear(); 
                foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
                {
                    string role = "" + baris["role"];
                    cmbrole.Items.Add(role);
                }
            }

        private void btntambah_Click(object sender, EventArgs e)
        {

            string idrole = ""; 
            DBhotel.crud($"SELECT id_role FROM role WHERE role = '{cmbrole.Text}'"); 
            foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
            {
                idrole = "" + baris["id_role"];
            }
             
            DBhotel.crud($"INSERT INTO `user` (username, password, id_role) VALUES ('{txtusername.Text}', '{txtpassword.Text}', '{idrole}')");
             
            DBhotel.crud(@"SELECT `user`.id_user, `user`.username, role.role FROM `user` JOIN role ON `user`.id_role = role.id_role"); 
            guna2DataGridView1.Rows.Clear(); 
            foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
            {
                string iduser = "" + baris["id_user"];
                string username = "" + baris["username"];
                string role = "" + baris["role"]; 
                guna2DataGridView1.Rows.Add(iduser, username, role);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex; 
            if (baris < 0)
                return; 
            string iduser = "" + guna2DataGridView1.Rows[baris].Cells[0].Value;

            DBhotel.crud($"SELECT * FROM `user` WHERE id_user = '{iduser}'"); 
            foreach (DataRow baris2 in DBhotel.ds.Tables[0].Rows)
            {
                string username = "" + baris2["username"];
                txtusername.Text = username; 
                string password = "" + baris2["password"];
                txtpassword.Text = password; 
                string idrole = "" + baris2["id_role"]; 
                DBhotel.crud($"SELECT role FROM role WHERE id_role = '{idrole}'"); 
                foreach (DataRow baris3 in DBhotel.ds.Tables[0].Rows)
                {
                    string role = "" + baris3["role"];
                    cmbrole.Text = role;
                }
            }
        }

        private void btnubah_Click(object sender, EventArgs e)
        { 
                int baris = guna2DataGridView1.CurrentRow.Index; 
                string iduser = "" + guna2DataGridView1.Rows[baris].Cells[0].Value; 
                string idrole = ""; 
                DBhotel.crud($"SELECT id_role FROM role WHERE role = '{cmbrole.Text}'"); 
                foreach (DataRow baris2 in DBhotel.ds.Tables[0].Rows)
                {
                    idrole = "" + baris2["id_role"];
                } 

                DBhotel.crud($"UPDATE `user` SET username = '{txtusername.Text}', password = '{txtpassword.Text}', id_role = '{idrole}' WHERE id_user = '{iduser}'"); 
                DBhotel.crud(@"SELECT `user`.id_user, `user`.username, role.role FROM `user` JOIN role ON `user`.id_role = role.id_role ");

                guna2DataGridView1.Rows.Clear();
                foreach (DataRow baris2 in DBhotel.ds.Tables[0].Rows)
                {
                    string id = "" + baris2["id_user"];
                    string username = "" + baris2["username"];
                    string role = "" + baris2["role"]; 
                    guna2DataGridView1.Rows.Add(id, username, role);
                }
            }

        private void btnhapus_Click(object sender, EventArgs e)
        { 
                int baris = guna2DataGridView1.CurrentRow.Index; 
                string iduser = "" + guna2DataGridView1.Rows[baris].Cells[0].Value; 
                DialogResult jawab = MessageBox.Show("Apakah data user ini mau dihapus?", "Konfirmasi",
                    MessageBoxButtons.YesNo);

                if (jawab == DialogResult.Yes)
                {
                    DBhotel.crud($"DELETE FROM `user` WHERE id_user = '{iduser}'");

                    DBhotel.crud(@"SELECT `user`.id_user, `user`.username, role.role FROM `user` JOIN role ON `user`.id_role = role.id_role"); 
                    guna2DataGridView1.Rows.Clear(); 
                    foreach (DataRow baris2 in DBhotel.ds.Tables[0].Rows)
                    {
                        string id = "" + baris2["id_user"];
                        string username = "" + baris2["username"];
                        string role = "" + baris2["role"]; 
                        guna2DataGridView1.Rows.Add(id, username, role);
                    }
                }
            }

        private void btnbatal_Click(object sender, EventArgs e)
        {

            txtusername.Clear();
            txtpassword.Clear();
            cmbrole.SelectedIndex = -1;
        }

        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DBhotel.crud($"Select * from user ");
            foreach (DataRow baris in DBhotel.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_user"];
                string username = "" + baris["username"];
                string role = "" + baris["id_role"];
                guna2DataGridView1.Rows.Add(id,username, role);

            }

        }
    }
    }
    


    
