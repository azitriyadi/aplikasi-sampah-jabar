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
<<<<<<< HEAD
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(190, 130);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
=======
            SuspendLayout();
            // 
>>>>>>> origin/feature/be-chatbot-logic
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
=======
            ClientSize = new Size(1154, 768);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Mistral AI Chatbot";
            ResumeLayout(false);
        }
>>>>>>> origin/feature/be-chatbot-logic
    }
}
