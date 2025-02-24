using Microsoft.VisualBasic.Logging;
using System.Security.Cryptography;
using System.Text.Json;

namespace Cipherizer
{
    public partial class Form1 : Form
    {
        static int[][] alphabetList = [];
        static Log Logger = new Log();
        //const RandomNumberGenerator numGen = RandomNumberGenerator.GetInt32;
        public Form1()
        {
            InitializeComponent();
        }
        private static int[][] GenAlphabets(int num)
        {
            int[][] alphabetsOut = [];
            for (int i = 0; i < num; i++)
            {
                int[] chars = Enumerable.Range(32, 96).ToArray();
                Span<int> charSpan = chars;
                RandomNumberGenerator.Shuffle(charSpan);
                chars = charSpan.ToArray();
                alphabetsOut = (int[][])alphabetsOut.Append(chars);
            }
            return alphabetsOut;
        }
        public static string EncodeString(string inString)
        {
            List<char> stringCharacters = [];
            int count = 0;
            foreach (char i in inString.ToCharArray())
            {
                int[] alphabet = alphabetList[count % 30];
                stringCharacters.Add((char)(Array.IndexOf(alphabet, i) + 32));
                ++count;
            }
            String outString = new string(stringCharacters.ToArray());
            return outString;
        }
        public static string DecodeString(string inString)
        {
            int count = 0;
            char[] stringCharacters = [];
            foreach (char curChar in inString.ToCharArray())
            {
                int[] alphabet = alphabetList[count % 30];
                int asciiCode = (int)curChar - 32;
                stringCharacters.Append((char)alphabet[asciiCode]);
                ++count;
                //i = alphabet.get();
            }
            String outString = new string(stringCharacters.ToArray());
            return outString;
        }
        private void genAlphabets_Click(object sender, EventArgs e)
        {
            alphabetList = GenAlphabets(30);
            Logger.WriteEntry(alphabetList[0].Length.ToString());
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
                alphabetList = (int[][])JsonSerializer.Deserialize(fs, typeof(int[][]));

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
