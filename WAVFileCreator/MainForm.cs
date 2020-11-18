using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAVFileCreator
{
    public partial class MainForm : Form
    {
        SettingsForm settingsForm;
        public static bool advancedMode = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string text = riffChunkIDInput.Text + riffChunkSizeInput.Text + riffFormatInput.Text + fmtChunkIDInput.Text + fmtChunkSizeInput.Text + audioFormatInput.Text + channelsInput.Text + sampleRateInput.Text + byteRateInput.Text + blockAlignInput.Text + bitsInput.Text + dataChunkIDInput.Text + dataChunkSizeInput.Text + inp.Text.Replace(" ", "");
            byte[] bytes = StringToByteArray(text);

            // Do the actual writing
            Stream stream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "WAV Files (*.wav)|*.wav";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog1.OpenFile()) != null)
                {
                    BinaryWriter writer = new BinaryWriter(stream);
                    writer.Write(bytes);
                    stream.Close();
                    MessageBox.Show("File successfully saved.");
                }
            }
        }

        private void updateSizes(object sender, EventArgs e)
        {
            if (!advancedMode)
            {
                try
                {
                    string inputText = inp.Text.Replace(" ", "");

                    int dataSubchunkSize = inputText.Length / 2;
                    int fullChunkSize = dataSubchunkSize + 36;

                    string channels = channelsInput.Text;
                    string bits = bitsInput.Text;
                    string sampleRate = sampleRateInput.Text;

                    string channelsBigEndian = ReverseEndianness(channels);
                    string bitsBigEndian = ReverseEndianness(bits);
                    string sampleRateBigEndian = ReverseEndianness(sampleRate);

                    int blockAlign = int.Parse(channelsBigEndian, System.Globalization.NumberStyles.HexNumber) * (int.Parse(bitsBigEndian, System.Globalization.NumberStyles.HexNumber) / 8);
                    int byteRate = blockAlign * int.Parse(sampleRateBigEndian, System.Globalization.NumberStyles.HexNumber);

                    riffChunkSizeInput.Text = ReverseEndianness(fullChunkSize.ToString("X8"));
                    dataChunkSizeInput.Text = ReverseEndianness(dataSubchunkSize.ToString("X8"));
                    blockAlignInput.Text = ReverseEndianness(blockAlign.ToString("X4"));
                    byteRateInput.Text = ReverseEndianness(byteRate.ToString("X8"));
                }
                catch
                {
                    MessageBox.Show("oof occured");
                }
            }
            estimateStuff();
        }

        private void estimateStuff()
        {
            string outputText = riffChunkIDInput.Text + riffChunkSizeInput.Text + riffFormatInput.Text + fmtChunkIDInput.Text + fmtChunkSizeInput.Text + audioFormatInput.Text + channelsInput.Text + sampleRateInput.Text + byteRateInput.Text + blockAlignInput.Text + bitsInput.Text + dataChunkIDInput.Text + dataChunkSizeInput.Text + inp.Text.Replace(" ", "");
            int estFileSize = outputText.Length / 2;

            string byteRateStr = ReverseEndianness(byteRateInput.Text);
            int byteRate = int.Parse(byteRateStr, System.Globalization.NumberStyles.HexNumber);
            int dataLength = inp.Text.Replace(" ", "").Length / 2;
            float estLength = (float)dataLength / (float)byteRate;

            lengthLabel.Text = String.Format("Length: {0:0.##}s", estLength);
            fileSizeLabel.Text = "File Size: " + estFileSize.ToString() + " bytes";
        }

        public void updateAbility(bool isChecked)
        {
            riffChunkIDInput.Enabled = isChecked;
            riffChunkSizeInput.Enabled = isChecked;
            riffFormatInput.Enabled = isChecked;

            fmtChunkIDInput.Enabled = isChecked;
            fmtChunkSizeInput.Enabled = isChecked;
            byteRateInput.Enabled = isChecked;
            blockAlignInput.Enabled = isChecked;

            dataChunkIDInput.Enabled = isChecked;
            dataChunkSizeInput.Enabled = isChecked;
        }

        public static byte[] StringToByteArray(string hex)
        {
            if (hex.Length % 2 == 0)
            {
                return Enumerable.Range(0, hex.Length)
                                 .Where(x => x % 2 == 0)
                                 .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                                 .ToArray();
            }
            else
            {
                hex = hex.Substring(0, hex.Length - 1);
                return Enumerable.Range(0, hex.Length)
                                 .Where(x => x % 2 == 0)
                                 .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                                 .ToArray();
            }
        }
        public static string ReverseEndianness(string num)
        {
            List<string> bytes = num.SplitInParts(2).ToList();
            bytes.Reverse();
            return String.Join("", bytes);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (settingsForm != null)
            {
                settingsForm.Close();
            }
            settingsForm = new SettingsForm();
            settingsForm.Show();
        }
    }

    static class StringExtensions // https://stackoverflow.com/a/4133475/6106196
    {
        public static IEnumerable<String> SplitInParts(this String s, Int32 partLength)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            if (partLength <= 0)
            {
                throw new ArgumentException("Part length has to be positive.", nameof(partLength));
            }

            for (var i = 0; i < s.Length; i += partLength)
            {
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
            }
        }
    }
}
