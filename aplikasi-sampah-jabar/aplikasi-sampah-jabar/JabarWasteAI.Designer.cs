namespace aplikasi_sampah_jabar
{
    partial class JabarWasteAI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlChatContainer = new System.Windows.Forms.Panel();
            this.pnlChatHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInputArea = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnKirim = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            this.pnlChatContainer.SuspendLayout();
            this.pnlInputArea.SuspendLayout(); // Tambahan penting
            this.SuspendLayout();

            // 
            // pnlChatContainer (Panel Utama / Kotak Putih)
            // 
            this.pnlChatContainer.BackColor = System.Drawing.Color.White;
            this.pnlChatContainer.Controls.Add(this.pnlChatHistory); // History di atas
            this.pnlChatContainer.Controls.Add(this.pnlInputArea);   // Input area di bawah
            this.pnlChatContainer.Location = new System.Drawing.Point(30, 70);
            this.pnlChatContainer.Name = "pnlChatContainer";
            this.pnlChatContainer.Size = new System.Drawing.Size(880, 500);
            this.pnlChatContainer.TabIndex = 0;

            // 
            // pnlChatHistory (Area Chatting)
            // 
            this.pnlChatHistory.AutoScroll = true;
            this.pnlChatHistory.Dock = System.Windows.Forms.DockStyle.Fill; // Mengisi sisa ruang
            this.pnlChatHistory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlChatHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlChatHistory.Name = "pnlChatHistory";
            this.pnlChatHistory.Padding = new System.Windows.Forms.Padding(10);
            this.pnlChatHistory.Size = new System.Drawing.Size(880, 440);
            this.pnlChatHistory.TabIndex = 0;
            this.pnlChatHistory.WrapContents = false;
            // Hapus baris Paint event jika di backend tidak ada isinya, biar bersih
            // this.pnlChatHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChatHistory_Paint);

            // 
            // pnlInputArea (Panel Bawah tempat ngetik)
            // 
            this.pnlInputArea.BackColor = System.Drawing.Color.WhiteSmoke; // Sedikit beda warna biar jelas
            this.pnlInputArea.Controls.Add(this.txtInput);  // Masukkan Textbox (Fill)
            this.pnlInputArea.Controls.Add(this.btnKirim);  // Masukkan Tombol (Right)
            this.pnlInputArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInputArea.Location = new System.Drawing.Point(0, 440);
            this.pnlInputArea.Name = "pnlInputArea";
            this.pnlInputArea.Padding = new System.Windows.Forms.Padding(10);
            this.pnlInputArea.Size = new System.Drawing.Size(880, 60);
            this.pnlInputArea.TabIndex = 1;

            // 
            // btnKirim (Tombol Kirim)
            // 
            this.btnKirim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnKirim.Dock = System.Windows.Forms.DockStyle.Right; // Nempel Kanan
            this.btnKirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKirim.ForeColor = System.Drawing.Color.White;
            this.btnKirim.Location = new System.Drawing.Point(770, 10); // Posisi otomatis diatur Dock
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(100, 40); // Tinggi disamakan dengan input area
            this.btnKirim.TabIndex = 1;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = false;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);

            // 
            // txtInput (Kotak Ketik)
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill; // Mengisi sisa ruang kiri
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtInput.Location = new System.Drawing.Point(10, 10);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(760, 39); // Lebar otomatis menyesuaikan
            this.txtInput.TabIndex = 0;
            // Event Enter Key (Opsional, sangat berguna)
            this.txtInput.KeyDown += (s, e) => { if (e.KeyCode == System.Windows.Forms.Keys.Enter) { btnKirim.PerformClick(); e.SuppressKeyPress = true; } };

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(386, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "🤖 Jabar Waste AI Assistant";

            // 
            // JabarWasteAI (Form Utama)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlChatContainer);
            this.Name = "JabarWasteAI";
            this.Size = new System.Drawing.Size(940, 600);
            this.pnlChatContainer.ResumeLayout(false);
            this.pnlInputArea.ResumeLayout(false);
            this.pnlInputArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlChatContainer;
        private System.Windows.Forms.FlowLayoutPanel pnlChatHistory;
        private System.Windows.Forms.Panel pnlInputArea;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.Label lblTitle;
    }
}