
namespace WAVFileCreator
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.constantChange = new System.Windows.Forms.CheckBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.wavlangEnabledCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "WAV File Creator Settings";
            // 
            // constantChange
            // 
            this.constantChange.AutoSize = true;
            this.constantChange.Location = new System.Drawing.Point(18, 54);
            this.constantChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.constantChange.Name = "constantChange";
            this.constantChange.Size = new System.Drawing.Size(339, 17);
            this.constantChange.TabIndex = 2;
            this.constantChange.Text = "Allow changing of constant or auto parameters (not recommended)";
            this.constantChange.UseVisualStyleBackColor = true;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(263, 99);
            this.saveSettingsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(94, 32);
            this.saveSettingsButton.TabIndex = 3;
            this.saveSettingsButton.Text = "Save Settings";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // wavlangEnabledCheck
            // 
            this.wavlangEnabledCheck.AutoSize = true;
            this.wavlangEnabledCheck.Checked = true;
            this.wavlangEnabledCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wavlangEnabledCheck.Location = new System.Drawing.Point(18, 75);
            this.wavlangEnabledCheck.Margin = new System.Windows.Forms.Padding(2);
            this.wavlangEnabledCheck.Name = "wavlangEnabledCheck";
            this.wavlangEnabledCheck.Size = new System.Drawing.Size(192, 17);
            this.wavlangEnabledCheck.TabIndex = 4;
            this.wavlangEnabledCheck.Text = "Enable Wavlang (see docs for info)";
            this.wavlangEnabledCheck.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.saveSettingsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 142);
            this.Controls.Add(this.wavlangEnabledCheck);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.constantChange);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox constantChange;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.CheckBox wavlangEnabledCheck;
    }
}