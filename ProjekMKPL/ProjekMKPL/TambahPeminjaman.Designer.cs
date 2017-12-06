namespace ProjekMKPL
{
    partial class TambahPeminjaman
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
            this.tbSearchNIM = new System.Windows.Forms.TextBox();
            this.tbSearchBuku = new System.Windows.Forms.TextBox();
            this.dgvNIM = new System.Windows.Forms.DataGridView();
            this.dgvBuku = new System.Windows.Forms.DataGridView();
            this.gbDetailPeminjaman = new System.Windows.Forms.GroupBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btBatal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNamaPeminjam = new System.Windows.Forms.Label();
            this.lbNIM = new System.Windows.Forms.Label();
            this.lbJudul = new System.Windows.Forms.Label();
            this.lbPengarang = new System.Windows.Forms.Label();
            this.btPilih = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).BeginInit();
            this.gbDetailPeminjaman.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearchNIM
            // 
            this.tbSearchNIM.Location = new System.Drawing.Point(12, 12);
            this.tbSearchNIM.Name = "tbSearchNIM";
            this.tbSearchNIM.Size = new System.Drawing.Size(248, 20);
            this.tbSearchNIM.TabIndex = 0;
            this.tbSearchNIM.TextChanged += new System.EventHandler(this.tbSearchNIM_TextChanged);
            // 
            // tbSearchBuku
            // 
            this.tbSearchBuku.Location = new System.Drawing.Point(266, 12);
            this.tbSearchBuku.Name = "tbSearchBuku";
            this.tbSearchBuku.Size = new System.Drawing.Size(184, 20);
            this.tbSearchBuku.TabIndex = 0;
            this.tbSearchBuku.TextChanged += new System.EventHandler(this.tbSearchBuku_TextChanged);
            // 
            // dgvNIM
            // 
            this.dgvNIM.AllowUserToAddRows = false;
            this.dgvNIM.AllowUserToDeleteRows = false;
            this.dgvNIM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNIM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNIM.Location = new System.Drawing.Point(13, 39);
            this.dgvNIM.Name = "dgvNIM";
            this.dgvNIM.RowHeadersVisible = false;
            this.dgvNIM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNIM.ShowEditingIcon = false;
            this.dgvNIM.Size = new System.Drawing.Size(247, 44);
            this.dgvNIM.TabIndex = 1;
            // 
            // dgvBuku
            // 
            this.dgvBuku.AllowUserToAddRows = false;
            this.dgvBuku.AllowUserToDeleteRows = false;
            this.dgvBuku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuku.Location = new System.Drawing.Point(266, 39);
            this.dgvBuku.Name = "dgvBuku";
            this.dgvBuku.RowHeadersVisible = false;
            this.dgvBuku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuku.ShowEditingIcon = false;
            this.dgvBuku.Size = new System.Drawing.Size(184, 44);
            this.dgvBuku.TabIndex = 1;
            // 
            // gbDetailPeminjaman
            // 
            this.gbDetailPeminjaman.Controls.Add(this.lbPengarang);
            this.gbDetailPeminjaman.Controls.Add(this.lbJudul);
            this.gbDetailPeminjaman.Controls.Add(this.lbNIM);
            this.gbDetailPeminjaman.Controls.Add(this.lbNamaPeminjam);
            this.gbDetailPeminjaman.Controls.Add(this.label4);
            this.gbDetailPeminjaman.Controls.Add(this.label3);
            this.gbDetailPeminjaman.Controls.Add(this.label2);
            this.gbDetailPeminjaman.Controls.Add(this.label1);
            this.gbDetailPeminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbDetailPeminjaman.ForeColor = System.Drawing.Color.White;
            this.gbDetailPeminjaman.Location = new System.Drawing.Point(13, 113);
            this.gbDetailPeminjaman.Name = "gbDetailPeminjaman";
            this.gbDetailPeminjaman.Size = new System.Drawing.Size(437, 163);
            this.gbDetailPeminjaman.TabIndex = 2;
            this.gbDetailPeminjaman.TabStop = false;
            this.gbDetailPeminjaman.Text = "Detail Peminjaman";
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(345, 285);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(105, 25);
            this.btSimpan.TabIndex = 3;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btBatal
            // 
            this.btBatal.Location = new System.Drawing.Point(13, 285);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(105, 25);
            this.btBatal.TabIndex = 3;
            this.btBatal.Text = "Batal";
            this.btBatal.UseVisualStyleBackColor = true;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Peminjam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "NIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Judul Buku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pengarang";
            // 
            // lbNamaPeminjam
            // 
            this.lbNamaPeminjam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNamaPeminjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lbNamaPeminjam.Location = new System.Drawing.Point(182, 36);
            this.lbNamaPeminjam.Name = "lbNamaPeminjam";
            this.lbNamaPeminjam.Size = new System.Drawing.Size(238, 15);
            this.lbNamaPeminjam.TabIndex = 1;
            // 
            // lbNIM
            // 
            this.lbNIM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lbNIM.Location = new System.Drawing.Point(182, 66);
            this.lbNIM.Name = "lbNIM";
            this.lbNIM.Size = new System.Drawing.Size(238, 15);
            this.lbNIM.TabIndex = 1;
            // 
            // lbJudul
            // 
            this.lbJudul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lbJudul.Location = new System.Drawing.Point(182, 95);
            this.lbJudul.Name = "lbJudul";
            this.lbJudul.Size = new System.Drawing.Size(238, 15);
            this.lbJudul.TabIndex = 1;
            // 
            // lbPengarang
            // 
            this.lbPengarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPengarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lbPengarang.Location = new System.Drawing.Point(182, 125);
            this.lbPengarang.Name = "lbPengarang";
            this.lbPengarang.Size = new System.Drawing.Size(238, 15);
            this.lbPengarang.TabIndex = 1;
            // 
            // btPilih
            // 
            this.btPilih.Location = new System.Drawing.Point(345, 85);
            this.btPilih.Name = "btPilih";
            this.btPilih.Size = new System.Drawing.Size(105, 25);
            this.btPilih.TabIndex = 3;
            this.btPilih.Text = "Pilih";
            this.btPilih.UseVisualStyleBackColor = true;
            this.btPilih.Click += new System.EventHandler(this.btPilih_Click);
            // 
            // TambahPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(462, 322);
            this.Controls.Add(this.btBatal);
            this.Controls.Add(this.btPilih);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.gbDetailPeminjaman);
            this.Controls.Add(this.dgvBuku);
            this.Controls.Add(this.dgvNIM);
            this.Controls.Add(this.tbSearchBuku);
            this.Controls.Add(this.tbSearchNIM);
            this.Name = "TambahPeminjaman";
            this.Text = "Tambah Peminjaman";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).EndInit();
            this.gbDetailPeminjaman.ResumeLayout(false);
            this.gbDetailPeminjaman.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchNIM;
        private System.Windows.Forms.TextBox tbSearchBuku;
        private System.Windows.Forms.DataGridView dgvNIM;
        private System.Windows.Forms.DataGridView dgvBuku;
        private System.Windows.Forms.GroupBox gbDetailPeminjaman;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btBatal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPengarang;
        private System.Windows.Forms.Label lbJudul;
        private System.Windows.Forms.Label lbNIM;
        private System.Windows.Forms.Label lbNamaPeminjam;
        private System.Windows.Forms.Button btPilih;
    }
}