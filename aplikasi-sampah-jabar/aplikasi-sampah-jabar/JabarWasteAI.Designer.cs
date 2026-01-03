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
            pnlChatContainer = new Panel();
            pnlChatHistory = new FlowLayoutPanel();
            pnlInputArea = new Panel();
            txtInput = new TextBox();
            btnKirim = new Button();
            lblTitle = new Label();
            pnlChatContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChatContainer
            // 
            pnlChatContainer.BackColor = Color.White;
            pnlChatContainer.Controls.Add(pnlChatHistory);
            pnlChatContainer.Controls.Add(pnlInputArea);
            pnlChatContainer.Location = new Point(30, 70);
            pnlChatContainer.Name = "pnlChatContainer";
            pnlChatContainer.Size = new Size(880, 500);
            pnlChatContainer.TabIndex = 0;
            // 
            // pnlChatHistory
            // 
            pnlChatHistory.AutoScroll = true;
            pnlChatHistory.Dock = DockStyle.Fill;
            pnlChatHistory.FlowDirection = FlowDirection.TopDown;
            pnlChatHistory.Location = new Point(0, 0);
            pnlChatHistory.Name = "pnlChatHistory";
            pnlChatHistory.Padding = new Padding(10);
            pnlChatHistory.Size = new Size(880, 440);
            pnlChatHistory.TabIndex = 0;
            pnlChatHistory.WrapContents = false;
            pnlChatHistory.Paint += pnlChatHistory_Paint;
            // 
            // pnlInputArea
            // 
            pnlInputArea.Dock = DockStyle.Bottom;
            pnlInputArea.Location = new Point(0, 440);
            pnlInputArea.Name = "pnlInputArea";
            pnlInputArea.Padding = new Padding(10);
            pnlInputArea.Size = new Size(880, 60);
            pnlInputArea.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Dock = DockStyle.Fill;
            txtInput.Font = new Font("Segoe UI", 12F);
            txtInput.Location = new Point(10, 10);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 39);
            txtInput.TabIndex = 0;
            // 
            // btnKirim
            // 
            btnKirim.BackColor = Color.FromArgb(245, 158, 11);
            btnKirim.Dock = DockStyle.Right;
            btnKirim.FlatStyle = FlatStyle.Flat;
            btnKirim.ForeColor = Color.White;
            btnKirim.Location = new Point(0, 0);
            btnKirim.Name = "btnKirim";
            btnKirim.Size = new Size(100, 23);
            btnKirim.TabIndex = 0;
            btnKirim.Text = "Kirim";
            btnKirim.UseVisualStyleBackColor = false;
            btnKirim.Click += btnKirim_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(386, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Jabar Waste AI Assistant";
            // 
            // JabarWasteAI
            // 
            BackColor = Color.FromArgb(245, 246, 250);
            Controls.Add(pnlChatContainer);
            Controls.Add(lblTitle);
            Name = "JabarWasteAI";
            Size = new Size(940, 600);
            pnlChatContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel pnlChatContainer;
        private System.Windows.Forms.FlowLayoutPanel pnlChatHistory;
        private System.Windows.Forms.Panel pnlInputArea;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.Label lblTitle;
    }
}