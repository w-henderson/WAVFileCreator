
namespace WAVFileCreator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.riffFormatInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.riffChunkSizeInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.riffChunkIDInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bitsInput = new System.Windows.Forms.TextBox();
            this.blockAlignInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.byteRateInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sampleRateInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.channelsInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.audioFormatInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fmtChunkSizeInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fmtChunkIDInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataChunkSizeInput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataChunkIDInput = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.inp = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "WAV File Creator (from scratch)";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1015, 29);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(101, 63);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.riffFormatInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.riffChunkSizeInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.riffChunkIDInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(36, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1080, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RIFF Header";
            // 
            // riffFormatInput
            // 
            this.riffFormatInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.riffFormatInput.Enabled = false;
            this.riffFormatInput.Font = new System.Drawing.Font("Consolas", 12F);
            this.riffFormatInput.Location = new System.Drawing.Point(360, 60);
            this.riffFormatInput.Margin = new System.Windows.Forms.Padding(4);
            this.riffFormatInput.Name = "riffFormatInput";
            this.riffFormatInput.Size = new System.Drawing.Size(160, 45);
            this.riffFormatInput.TabIndex = 5;
            this.riffFormatInput.Text = "57415645";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Format";
            // 
            // riffChunkSizeInput
            // 
            this.riffChunkSizeInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.riffChunkSizeInput.Enabled = false;
            this.riffChunkSizeInput.Font = new System.Drawing.Font("Consolas", 12F);
            this.riffChunkSizeInput.Location = new System.Drawing.Point(180, 60);
            this.riffChunkSizeInput.Margin = new System.Windows.Forms.Padding(4);
            this.riffChunkSizeInput.Name = "riffChunkSizeInput";
            this.riffChunkSizeInput.Size = new System.Drawing.Size(168, 45);
            this.riffChunkSizeInput.TabIndex = 3;
            this.riffChunkSizeInput.Text = "24000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chunk Size (Auto)";
            // 
            // riffChunkIDInput
            // 
            this.riffChunkIDInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.riffChunkIDInput.Enabled = false;
            this.riffChunkIDInput.Font = new System.Drawing.Font("Consolas", 12F);
            this.riffChunkIDInput.Location = new System.Drawing.Point(12, 60);
            this.riffChunkIDInput.Margin = new System.Windows.Forms.Padding(4);
            this.riffChunkIDInput.Name = "riffChunkIDInput";
            this.riffChunkIDInput.Size = new System.Drawing.Size(156, 45);
            this.riffChunkIDInput.TabIndex = 1;
            this.riffChunkIDInput.Text = "52494646";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chunk ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.bitsInput);
            this.groupBox2.Controls.Add(this.blockAlignInput);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.byteRateInput);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.sampleRateInput);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.channelsInput);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.audioFormatInput);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.fmtChunkSizeInput);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.fmtChunkIDInput);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(38, 240);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1078, 127);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Format Subchunk";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(972, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Bits";
            // 
            // bitsInput
            // 
            this.bitsInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.bitsInput.Font = new System.Drawing.Font("Consolas", 12F);
            this.bitsInput.Location = new System.Drawing.Point(978, 60);
            this.bitsInput.Margin = new System.Windows.Forms.Padding(4);
            this.bitsInput.Name = "bitsInput";
            this.bitsInput.Size = new System.Drawing.Size(80, 45);
            this.bitsInput.TabIndex = 14;
            this.bitsInput.Text = "0800";
            this.bitsInput.TextChanged += new System.EventHandler(this.updateSizes);
            // 
            // blockAlignInput
            // 
            this.blockAlignInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.blockAlignInput.Enabled = false;
            this.blockAlignInput.Font = new System.Drawing.Font("Consolas", 12F);
            this.blockAlignInput.Location = new System.Drawing.Point(886, 60);
            this.blockAlignInput.Margin = new System.Windows.Forms.Padding(4);
            this.blockAlignInput.Name = "blockAlignInput";
            this.blockAlignInput.Size = new System.Drawing.Size(80, 45);
            this.blockAlignInput.TabIndex = 13;
            this.blockAlignInput.Text = "0100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(850, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Block Align";
            // 
            // byteRateInput
            // 
            this.byteRateInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.byteRateInput.Enabled = false;
            this.byteRateInput.Font = new System.Drawing.Font("Consolas", 12F);
            this.byteRateInput.Location = new System.Drawing.Point(710, 60);
            this.byteRateInput.Margin = new System.Windows.Forms.Padding(4);
            this.byteRateInput.Name = "byteRateInput";
            this.byteRateInput.Size = new System.Drawing.Size(168, 45);
            this.byteRateInput.TabIndex = 7;
            this.byteRateInput.Text = "401f0000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(706, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Byte Rate";
            // 
            // sampleRateInput
            // 
            this.sampleRateInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.sampleRateInput.Font = new System.Drawing.Font("Consolas", 12F);
            this.sampleRateInput.Location = new System.Drawing.Point(542, 60);
            this.sampleRateInput.Margin = new System.Windows.Forms.Padding(4);
            this.sampleRateInput.Name = "sampleRateInput";
            this.sampleRateInput.Size = new System.Drawing.Size(156, 45);
            this.sampleRateInput.TabIndex = 11;
            this.sampleRateInput.Text = "401f0000";
            this.sampleRateInput.TextChanged += new System.EventHandler(this.updateSizes);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sample Rate";
            // 
            // channelsInput
            // 
            this.channelsInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.channelsInput.Font = new System.Drawing.Font("Consolas", 12F);
            this.channelsInput.Location = new System.Drawing.Point(450, 60);
            this.channelsInput.Margin = new System.Windows.Forms.Padding(4);
            this.channelsInput.Name = "channelsInput";
            this.channelsInput.Size = new System.Drawing.Size(80, 45);
            this.channelsInput.TabIndex = 9;
            this.channelsInput.Text = "0100";
            this.channelsInput.TextChanged += new System.EventHandler(this.updateSizes);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Channels";
            // 
            // audioFormatInput
            // 
            this.audioFormatInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.audioFormatInput.Font = new System.Drawing.Font("Consolas", 12F);
            this.audioFormatInput.Location = new System.Drawing.Point(358, 60);
            this.audioFormatInput.Margin = new System.Windows.Forms.Padding(4);
            this.audioFormatInput.Name = "audioFormatInput";
            this.audioFormatInput.Size = new System.Drawing.Size(80, 45);
            this.audioFormatInput.TabIndex = 7;
            this.audioFormatInput.Text = "0100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Audio Format";
            // 
            // fmtChunkSizeInput
            // 
            this.fmtChunkSizeInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.fmtChunkSizeInput.Enabled = false;
            this.fmtChunkSizeInput.Font = new System.Drawing.Font("Consolas", 12F);
            this.fmtChunkSizeInput.Location = new System.Drawing.Point(180, 60);
            this.fmtChunkSizeInput.Margin = new System.Windows.Forms.Padding(4);
            this.fmtChunkSizeInput.Name = "fmtChunkSizeInput";
            this.fmtChunkSizeInput.Size = new System.Drawing.Size(168, 45);
            this.fmtChunkSizeInput.TabIndex = 3;
            this.fmtChunkSizeInput.Text = "10000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chunk Size";
            // 
            // fmtChunkIDInput
            // 
            this.fmtChunkIDInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.fmtChunkIDInput.Enabled = false;
            this.fmtChunkIDInput.Font = new System.Drawing.Font("Consolas", 12F);
            this.fmtChunkIDInput.Location = new System.Drawing.Point(12, 60);
            this.fmtChunkIDInput.Margin = new System.Windows.Forms.Padding(4);
            this.fmtChunkIDInput.Name = "fmtChunkIDInput";
            this.fmtChunkIDInput.Size = new System.Drawing.Size(156, 45);
            this.fmtChunkIDInput.TabIndex = 1;
            this.fmtChunkIDInput.Text = "666d7420";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chunk ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.dataChunkSizeInput);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.dataChunkIDInput);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.inp);
            this.groupBox3.Location = new System.Drawing.Point(38, 379);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(1078, 748);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Subchunk";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 117);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 25);
            this.label15.TabIndex = 8;
            this.label15.Text = "Data";
            // 
            // dataChunkSizeInput
            // 
            this.dataChunkSizeInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.dataChunkSizeInput.Enabled = false;
            this.dataChunkSizeInput.Font = new System.Drawing.Font("Consolas", 12F);
            this.dataChunkSizeInput.Location = new System.Drawing.Point(182, 60);
            this.dataChunkSizeInput.Margin = new System.Windows.Forms.Padding(4);
            this.dataChunkSizeInput.Name = "dataChunkSizeInput";
            this.dataChunkSizeInput.Size = new System.Drawing.Size(168, 45);
            this.dataChunkSizeInput.TabIndex = 7;
            this.dataChunkSizeInput.Text = "00000000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(178, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 25);
            this.label13.TabIndex = 6;
            this.label13.Text = "Chunk Size (Auto)";
            // 
            // dataChunkIDInput
            // 
            this.dataChunkIDInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.dataChunkIDInput.Enabled = false;
            this.dataChunkIDInput.Font = new System.Drawing.Font("Consolas", 12F);
            this.dataChunkIDInput.Location = new System.Drawing.Point(14, 60);
            this.dataChunkIDInput.Margin = new System.Windows.Forms.Padding(4);
            this.dataChunkIDInput.Name = "dataChunkIDInput";
            this.dataChunkIDInput.Size = new System.Drawing.Size(156, 45);
            this.dataChunkIDInput.TabIndex = 5;
            this.dataChunkIDInput.Text = "64617461";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "Chunk ID";
            // 
            // inp
            // 
            this.inp.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.inp.Font = new System.Drawing.Font("Consolas", 12F);
            this.inp.Location = new System.Drawing.Point(14, 146);
            this.inp.Margin = new System.Windows.Forms.Padding(4);
            this.inp.MaxLength = 2147483647;
            this.inp.Multiline = true;
            this.inp.Name = "inp";
            this.inp.Size = new System.Drawing.Size(1044, 583);
            this.inp.TabIndex = 2;
            this.inp.TextChanged += new System.EventHandler(this.updateSizes);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(46, 1133);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(113, 25);
            this.lengthLabel.TabIndex = 8;
            this.lengthLabel.Text = "Length: 0s";
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(204, 1133);
            this.fileSizeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(189, 25);
            this.fileSizeLabel.TabIndex = 9;
            this.fileSizeLabel.Text = "File Size: 44 bytes";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(802, 1133);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(303, 25);
            this.label16.TabIndex = 10;
            this.label16.Text = "Created by William Henderson";
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(827, 29);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(180, 63);
            this.settingsButton.TabIndex = 11;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1156, 1181);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Text = "WAVFileCreator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox riffChunkIDInput;
        private System.Windows.Forms.TextBox riffChunkSizeInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox riffFormatInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox fmtChunkSizeInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fmtChunkIDInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox audioFormatInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox channelsInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sampleRateInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox byteRateInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox blockAlignInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bitsInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox inp;
        private System.Windows.Forms.TextBox dataChunkSizeInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox dataChunkIDInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button settingsButton;
    }
}

