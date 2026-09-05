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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBhotel.crud($"SELECT * FROM user WHERE Username = '{txtuser.Text}' AND Password = '{txtpass.Text}';");
            int cekbaris = DBhotel.ds.Tables[0].Rows.Count;
            if (cekbaris == 1)
            {
                DataRow baris = DBhotel.ds.Tables[0].Rows[0];  ;
                MDIParent1 Renita = new MDIParent1(); 
                Renita.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username/password salah");
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
        }

       
    }
}
