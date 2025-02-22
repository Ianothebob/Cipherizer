using Microsoft.VisualBasic.Logging;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;

namespace Cipherizer
{
    public partial class Form1 : Form
    {
        static List<List<int>> alphabetList = [];
        static Log Logger = new Log();
        //const RandomNumberGenerator numGen = RandomNumberGenerator.GetInt32;
        public Form1()
        {
            InitializeComponent();
        }
        private static List<List<int>> GenAlphabets(int num)
        {
            List<List<int>> alphabetsOut = [];
            for (int i = 0; i < num; i++)
            {
                List<int> chars = Enumerable.Range(32, 96).ToList();
                Span<int> charSpan = CollectionsMarshal.AsSpan(chars);
                RandomNumberGenerator.Shuffle(charSpan);
                chars = charSpan.ToArray().ToList();
                alphabetsOut.Add(chars);
            }
            return alphabetsOut;
        }
        public static string EncodeString(string inString)
        {
            List<char> stringCharacters = [];
            int count = 0;
            foreach (char i in inString.ToCharArray())
            {
                List<int> alphabet = alphabetList[count % 30];
                stringCharacters.Add((char)(alphabet.IndexOf(i) + 32));
                ++count;
            }
            String outString = new string(stringCharacters.ToArray());
            return outString;
        }
        public static string DecodeString(string inString)
        {
            int count = 0;
            List<char> stringCharacters = [];
            foreach (char curChar in inString.ToCharArray())
            {
                List<int> alphabet = alphabetList[count % 30];
                int asciiCode = (int)curChar - 32;
                stringCharacters.Add((char)alphabet[asciiCode]);
                ++count;
                //i = alphabet.get();
            }
            String outString = new string(stringCharacters.ToArray());
            return outString;
        }
        private void genAlphabets_Click(object sender, EventArgs e)
        {
            alphabetList = GenAlphabets(30);
            Logger.WriteEntry(alphabetList[0].Count.ToString());
        }
        private void outAlphabets_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                FileStream fs =
                    (FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                JsonSerializer.Serialize(fs, alphabetList);

                fs.Close();
            }
        }
        private void inAlphabets_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                FileStream fs =
                    (FileStream)openFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                alphabetList = JsonSerializer.Deserialize(fs, typeof(List<List<int>>)) as List<List<int>>;

                fs.Close();
            }

        }
        private void encipherText_Click(object sender, EventArgs e)
        {
            textBox1.Text = EncodeString(textBox1.Text);
        }
        private void decipherText_Click(object sender, EventArgs e)
        {
            textBox1.Text = DecodeString(textBox1.Text);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
    }
}
