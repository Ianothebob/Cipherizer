namespace Cipherizer
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
            textBox1 = new TextBox();
            genAlphabets = new Button();
            outAlphabets = new Button();
            inAlphabets = new Button();
            encodeText = new Button();
            decodeText = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlDark;
            textBox1.Location = new Point(34, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(744, 124);
            textBox1.TabIndex = 0;
            // 
            // genAlphabets
            // 
            genAlphabets.BackColor = SystemColors.ControlDark;
            genAlphabets.ForeColor = SystemColors.ControlLight;
            genAlphabets.Location = new Point(287, 142);
            genAlphabets.Name = "genAlphabets";
            genAlphabets.Size = new Size(239, 71);
            genAlphabets.TabIndex = 1;
            genAlphabets.Text = "Generate Alphabet";
            genAlphabets.UseVisualStyleBackColor = false;
            genAlphabets.Click += genAlphabets_Click;
            // 
            // outAlphabets
            // 
            outAlphabets.BackColor = SystemColors.ControlDark;
            outAlphabets.Location = new Point(287, 216);
            outAlphabets.Name = "outAlphabets";
            outAlphabets.Size = new Size(239, 71);
            outAlphabets.TabIndex = 2;
            outAlphabets.Text = "Export Alphabet";
            outAlphabets.UseVisualStyleBackColor = false;
            outAlphabets.Click += outAlphabets_Click;
            // 
            // inAlphabets
            // 
            inAlphabets.BackColor = SystemColors.ControlDark;
            inAlphabets.Location = new Point(287, 290);
            inAlphabets.Name = "inAlphabets";
            inAlphabets.Size = new Size(239, 71);
            inAlphabets.TabIndex = 3;
            inAlphabets.Text = "Import Alphabet";
            inAlphabets.UseVisualStyleBackColor = false;
            inAlphabets.Click += inAlphabets_Click;
            // 
            // encodeText
            // 
            encodeText.BackColor = SystemColors.ControlDark;
            encodeText.Location = new Point(287, 364);
            encodeText.Name = "encodeText";
            encodeText.Size = new Size(239, 71);
            encodeText.TabIndex = 4;
            encodeText.Text = "Encode Text";
            encodeText.UseVisualStyleBackColor = false;
            encodeText.Click += encipherText_Click;
            // 
            // decodeText
            // 
            decodeText.BackColor = SystemColors.ControlDark;
            decodeText.Location = new Point(287, 438);
            decodeText.Name = "decodeText";
            decodeText.Size = new Size(239, 71);
            decodeText.TabIndex = 5;
            decodeText.Text = "Decode Text";
            decodeText.UseVisualStyleBackColor = false;
            decodeText.Click += decipherText_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(813, 530);
            Controls.Add(decodeText);
            Controls.Add(encodeText);
            Controls.Add(inAlphabets);
            Controls.Add(outAlphabets);
            Controls.Add(genAlphabets);
            Controls.Add(textBox1);
            ForeColor = SystemColors.ControlLight;
            Name = "Ecipherer Supreme";
            Text = "Ecipherer Supreme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button genAlphabets;
        private Button outAlphabets;
        private Button inAlphabets;
        private Button encodeText;
        private Button decodeText;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
