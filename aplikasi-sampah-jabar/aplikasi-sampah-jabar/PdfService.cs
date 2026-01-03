using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;

namespace aplikasi_sampah_jabar
{
    public class PdfService
    {
        // Fungsi utama untuk mengonversi List data sampah menjadi Tabel PDF
        public void ExportLaporanSampah(string namaFile, List<SampahModel> data)
        {
            try
            {
                // 1. Inisialisasi Dokumen A4
                Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter.GetInstance(doc, new FileStream(namaFile, FileMode.Create));
                doc.Open();

                // 2. Tambahkan Judul Laporan
                var fontJudul = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                Paragraph judul = new Paragraph("LAPORAN PENGELOLAAN SAMPAH JABAR\n", fontJudul);
                judul.Alignment = Element.ALIGN_CENTER;
                doc.Add(judul);

                doc.Add(new Paragraph("Dicetak pada: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")));
                doc.Add(new Chunk("\n")); // Spasi

                // 3. Buat Tabel dengan 5 Kolom
                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 20f, 30f, 15f, 20f, 15f });

                // Header Tabel
                string[] headers = { "Tanggal", "Nama Sampah", "Jenis", "Wilayah", "Berat" };
                foreach (var h in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(h, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Padding = 5;
                    table.AddCell(cell);
                }

                // 4. Masukkan Data dari MongoDB ke Baris Tabel
                double totalBerat = 0;
                var fontIsi = FontFactory.GetFont(FontFactory.HELVETICA, 9);

                foreach (var item in data)
                {
                    table.AddCell(new Phrase(item.TanggalInput.ToString("dd/MM/yyyy"), fontIsi));
                    table.AddCell(new Phrase(item.Nama ?? "-", fontIsi));
                    table.AddCell(new Phrase(item.Jenis ?? "-", fontIsi));
                    table.AddCell(new Phrase(item.NamaWilayah ?? "-", fontIsi));
                    table.AddCell(new Phrase(item.Berat.ToString() + " Kg", fontIsi));
                    totalBerat += item.Berat;
                }

                doc.Add(table);

                // 5. Tambahkan Total di Bawah Tabel
                doc.Add(new Chunk("\n"));
                Paragraph footer = new Paragraph($"Total Keseluruhan Berat Sampah: {totalBerat:N2} Kg",
                                   FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12));
                footer.Alignment = Element.ALIGN_RIGHT;
                doc.Add(footer);

                // 6. Selesai
                doc.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal membuat PDF: " + ex.Message);
            }
        }
    }
}