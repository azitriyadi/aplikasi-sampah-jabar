using System.Windows.Forms;

namespace MistralChatbot
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 768);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Mistral AI Chatbot";
            ResumeLayout(false);
        }
    }
}
