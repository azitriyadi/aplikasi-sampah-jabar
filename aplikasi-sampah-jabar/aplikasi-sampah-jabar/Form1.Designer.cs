using System.Windows.Forms;

namespace MistralChatbot
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private RichTextBox txtConversation;
        private TextBox txtMessage;
        private Button btnSend;
        private Button btnClear;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private TextBox txtApiKey;
        private Label label1;
        private ComboBox cmbModel;
        private Label label2;
        private Button btnSaveChat;
        private Label lblModelInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtConversation = new RichTextBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            btnClear = new Button();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            txtApiKey = new TextBox();
            label1 = new Label();
            cmbModel = new ComboBox();
            label2 = new Label();
            btnSaveChat = new Button();
            lblModelInfo = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtConversation
            // 
            txtConversation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtConversation.Location = new Point(20, 77);
            txtConversation.Margin = new Padding(5, 6, 5, 6);
            txtConversation.Name = "txtConversation";
            txtConversation.ReadOnly = true;
            txtConversation.Size = new Size(1111, 416);
            txtConversation.TabIndex = 0;
            txtConversation.Text = "";
            // 
            // txtMessage
            // 
            txtMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMessage.Location = new Point(20, 516);
            txtMessage.Margin = new Padding(5, 6, 5, 6);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(944, 112);
            txtMessage.TabIndex = 1;
            txtMessage.KeyPress += txtMessage_KeyPress;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.Location = new Point(977, 516);
            btnSend.Margin = new Padding(5, 6, 5, 6);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(157, 115);
            btnSend.TabIndex = 2;
            btnSend.Text = "Kirim";
            btnSend.Click += btnSend_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.Location = new Point(20, 643);
            btnClear.Margin = new Padding(5, 6, 5, 6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(157, 58);
            btnClear.TabIndex = 3;
            btnClear.Text = "Bersihkan";
            btnClear.Click += btnClear_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 736);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 23, 0);
            statusStrip1.Size = new Size(1154, 32);
            statusStrip1.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(46, 25);
            lblStatus.Text = "Siap";
            // 
            // txtApiKey
            // 
            txtApiKey.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtApiKey.Location = new Point(847, 23);
            txtApiKey.Margin = new Padding(5, 6, 5, 6);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.PasswordChar = '*';
            txtApiKey.Size = new Size(284, 31);
            txtApiKey.TabIndex = 5;
            txtApiKey.TextChanged += txtApiKey_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(764, 29);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 9;
            label1.Text = "API Key:";
            // 
            // cmbModel
            // 
            cmbModel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModel.Location = new Point(514, 23);
            cmbModel.Margin = new Padding(5, 6, 5, 6);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(231, 33);
            cmbModel.TabIndex = 6;
            cmbModel.SelectedIndexChanged += cmbModel_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(430, 29);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 8;
            label2.Text = "Model:";
            // 
            // btnSaveChat
            // 
            btnSaveChat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveChat.Location = new Point(977, 643);
            btnSaveChat.Margin = new Padding(5, 6, 5, 6);
            btnSaveChat.Name = "btnSaveChat";
            btnSaveChat.Size = new Size(157, 58);
            btnSaveChat.TabIndex = 7;
            btnSaveChat.Text = "Simpan";
            // 
            // lblModelInfo
            // 
            lblModelInfo.AutoSize = true;
            lblModelInfo.Location = new Point(20, 29);
            lblModelInfo.Margin = new Padding(5, 0, 5, 0);
            lblModelInfo.Name = "lblModelInfo";
            lblModelInfo.Size = new Size(161, 25);
            lblModelInfo.TabIndex = 0;
            lblModelInfo.Text = "Model: mistral-tiny";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 768);
            Controls.Add(lblModelInfo);
            Controls.Add(btnSaveChat);
            Controls.Add(label2);
            Controls.Add(cmbModel);
            Controls.Add(label1);
            Controls.Add(txtApiKey);
            Controls.Add(statusStrip1);
            Controls.Add(btnClear);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(txtConversation);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Mistral AI Chatbot";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
