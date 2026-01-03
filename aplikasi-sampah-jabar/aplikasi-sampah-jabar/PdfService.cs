using aplikasi_sampah_jabar; // Sesuaikan namespace
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace AplikasiSampah.Services
{
    public class PdfService
    {
        // Fungsi untuk mencetak Laporan Sederhana
        public void ExportLaporanSampah(string namaFile, string judulLaporan, string isiLaporan)
        {
            try
            {
                // 1. Buat Dokumen Ukuran A4
                Document doc = new Document(PageSize.A4, 25, 25, 30, 30);

                // 2. Siapkan File Stream (Tempat file disimpan)
                PdfWriter.GetInstance(doc, new FileStream(namaFile, FileMode.Create));

                // 3. Buka Dokumen untuk ditulis
                doc.Open();

                // 4. Tambahkan Judul
                Paragraph judul = new Paragraph(judulLaporan, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                judul.Alignment = Element.ALIGN_CENTER;
                doc.Add(judul);

                doc.Add(new Chunk("\n")); // Spasi kosong

                // 5. Tambahkan Isi Laporan
                Paragraph isi = new Paragraph(isiLaporan, FontFactory.GetFont(FontFactory.HELVETICA, 12));
                doc.Add(isi);

                // 6. Tutup Dokumen (Selesai)
                doc.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal membuat PDF: " + ex.Message);
            }
        }
    }
}