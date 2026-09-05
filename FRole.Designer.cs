
namespace Renita_Perhotelan_XIIRPLB
{
    partial class FRole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtrole = new Guna.UI2.WinForms.Guna2TextBox();
            this.btntambah = new Guna.UI2.WinForms.Guna2Button();
            this.btnubah = new Guna.UI2.WinForms.Guna2Button();
            this.btnhapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnbatal = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrole
            // 
            this.txtrole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrole.DefaultText = "";
            this.txtrole.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtrole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtrole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtrole.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtrole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtrole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtrole.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtrole.Location = new System.Drawing.Point(509, 95);
            this.txtrole.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtrole.Name = "txtrole";
            this.txtrole.PlaceholderText = "";
            this.txtrole.SelectedText = "";
            this.txtrole.Size = new System.Drawing.Size(343, 72);
            this.txtrole.TabIndex = 0;
            // 
            // btntambah
            // 
            this.btntambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntambah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btntambah.ForeColor = System.Drawing.Color.White;
            this.btntambah.Location = new System.Drawing.Point(373, 191);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(180, 45);
            this.btntambah.TabIndex = 1;
            this.btntambah.Text = "Simpan";
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // btnubah
            // 
            this.btnubah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnubah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnubah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnubah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnubah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnubah.ForeColor = System.Drawing.Color.White;
            this.btnubah.Location = new System.Drawing.Point(600, 191);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(180, 45);
            this.btnubah.TabIndex = 2;
            this.btnubah.Text = "Ubah";
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhapus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhapus.ForeColor = System.Drawing.Color.White;
            this.btnhapus.Location = new System.Drawing.Point(829, 191);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(180, 45);
            this.btnhapus.TabIndex = 3;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnbatal
            // 
            this.btnbatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbatal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbatal.ForeColor = System.Drawing.Color.White;
            this.btnbatal.Location = new System.Drawing.Point(600, 273);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(180, 45);
            this.btnbatal.TabIndex = 4;
            this.btnbatal.Text = "Batal";
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 27;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 441);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 72;
            this.guna2DataGridView1.RowTemplate.Height = 31;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1371, 269);
            this.guna2DataGridView1.TabIndex = 5;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 27;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 31;
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = " ";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = " ";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            // 
            // FRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 710);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.txtrole);
            this.Name = "FRole";
            this.Text = "FRole";
            this.Load += new System.EventHandler(this.FRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2TextBox txtrole;
        private Guna.UI2.WinForms.Guna2Button btntambah;
        private Guna.UI2.WinForms.Guna2Button btnubah;
        private Guna.UI2.WinForms.Guna2Button btnhapus;
        private Guna.UI2.WinForms.Guna2Button btnbatal;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}