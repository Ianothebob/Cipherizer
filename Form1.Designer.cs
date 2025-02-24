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
            textBox1 = new TextBox()
            {
                BackColor = SystemColors.ControlDark,
                Anchor = AnchorStyles.None,
                Location = new Point(34, 12),
                Multiline = true,
                Name = "textBox1",
                Size = new Size(744, 124),
                TabIndex = 0
            };
            genAlphabets = new Button()
            {
                BackColor = SystemColors.ControlDark,
                Anchor = AnchorStyles.None,
                ForeColor = SystemColors.ControlLight,
                Location = new Point(287, 142),
                Name = "genAlphabets",
                Size = new Size(239, 71),
                TabIndex = 1,
                Text = "Generate Alphabet",
                UseVisualStyleBackColor = false
            };
            outAlphabets = new Button()
            {
                BackColor = SystemColors.ControlDark,
                Anchor = AnchorStyles.None,
                Location = new Point(287, 216),
                Name = "outAlphabets",
                Size = new Size(239, 71),
                TabIndex = 2,
                Text = "Export Alphabet",
                UseVisualStyleBackColor = false
            };
            inAlphabets = new Button()
            {
                BackColor = SystemColors.ControlDark,
                Anchor = AnchorStyles.None,
                Location = new Point(287, 290),
                Name = "inAlphabets",
                Size = new Size(239, 71),
                TabIndex = 3,
                Text = "Import Alphabet",
                UseVisualStyleBackColor = false
            };
            encodeText = new Button()
            {
                BackColor = SystemColors.ControlDark,
                Anchor = AnchorStyles.None,
                Location = new Point(287, 364),
                Name = "encodeText",
                Size = new Size(239, 71),
                TabIndex = 4,
                Text = "Encode Text",
                UseVisualStyleBackColor = false
            };
            decodeText = new Button()
            {
                BackColor = SystemColors.ControlDark,
                Anchor = AnchorStyles.None,
                Location = new Point(287, 438),
                Name = "decodeText",
                Size = new Size(239, 71),
                TabIndex = 5,
                Text = "Decode Text",
                UseVisualStyleBackColor = false
            };
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "openFileDialog1"
            };
            SuspendLayout();
            // 
            // genAlphabets
            //
            genAlphabets.Click += genAlphabets_Click;
            // 
            // outAlphabets
            // 
            outAlphabets.Click += outAlphabets_Click;
            // 
            // inAlphabets
            //
            inAlphabets.Click += inAlphabets_Click;
            // 
            // encodeText
            //
            encodeText.Click += encipherText_Click;
            // 
            // decodeText
            //
            decodeText.Click += decipherText_Click;
            // 
            // openFileDialog1
            //
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
