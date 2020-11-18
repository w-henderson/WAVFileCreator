﻿using System;
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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            constantChange.Checked = MainForm.advancedMode;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            MainForm.advancedMode = constantChange.Checked;
            Program.form.updateAbility(constantChange.Checked);
            Close();
        }
    }
}