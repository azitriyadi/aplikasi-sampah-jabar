<<<<<<< HEAD
﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace aplikasi_sampah_jabar
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            // Mengatur judul window aplikasi
            this.Text = "Sistem Manajemen Sampah Jabar";
        }

        // Fungsi klik menu untuk mengubah tampilan aktif
        private void Menu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Reset semua warna tombol menu ke default
            ResetMenuColors();

            // Highlight tombol yang sedang diklik (Oranye khas Sampah Jabar)
            btn.BackColor = Color.FromArgb(245, 158, 11);
            btn.ForeColor = Color.White;

            // Update label header sesuai menu yang dipilih
            lblTitle.Text = btn.Text.Trim().Substring(3); // Mengambil teks setelah emoji
        }

        private void ResetMenuColors()
        {
            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.BackColor = Color.White;
                    ctrl.ForeColor = Color.Gray;
                }
            }
        }
=======
﻿
namespace aplikasi_sampah_jabar
{
    internal class Dashboard : Form
    {
>>>>>>> origin/feature/fe-ui-forms
    }
}