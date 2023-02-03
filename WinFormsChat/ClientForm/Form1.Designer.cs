namespace ClientForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChatContent = new System.Windows.Forms.RichTextBox();
            this.SendBox = new System.Windows.Forms.RichTextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatContent
            // 
            this.ChatContent.Location = new System.Drawing.Point(6, 6);
            this.ChatContent.Name = "ChatContent";
            this.ChatContent.ReadOnly = true;
            this.ChatContent.Size = new System.Drawing.Size(378, 401);
            this.ChatContent.TabIndex = 0;
            this.ChatContent.Text = "";
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(410, 6);
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(378, 401);
            this.SendBox.TabIndex = 1;
            this.SendBox.Text = "";
            this.SendBox.TextChanged += new System.EventHandler(this.SendBox_TextChanged);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(410, 413);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(378, 23);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(6, 413);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(378, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.ChatContent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox ChatContent;
        private RichTextBox SendBox;
        private Button Send;
        private Button Start;
    }
}