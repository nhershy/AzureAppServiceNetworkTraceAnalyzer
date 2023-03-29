// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQLNAUI
{
    public partial class FrmSQLNAUI : Form
    {
        bool convList = false;
        string addrFormat = "Default";
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public FrmSQLNAUI()
        {
            InitializeComponent();
            TxtCommand.Focus();
        }

        private void ExecuteCmdCommand(string Command)
        {
            ProcessStartInfo ProcessInfo;
            Process Process;

            ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + Command);
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;
            ProcessInfo.WorkingDirectory = System.IO.Directory.GetCurrentDirectory();

            Process = Process.Start(ProcessInfo);
        }

        private void UpdateOutputFilePath(string filePath)
        {
            string fileName = Path.GetFileName(filePath);
            int lastSlash = filePath.LastIndexOf('\\');
            filePath = (lastSlash > -1) ? filePath.Substring(0, lastSlash) : filePath;
            TxtLogFile.Text = filePath + "\\" + fileName +"-results.csv";
        }

        private void FrmSQLNAUI_Load(object sender, EventArgs e)
        {
            GetRegistryDefaults();
        }

        private void MnuFileOpen_Click(object sender, EventArgs e)
        {
            DialogResult result;
            this.OpenFileDialog1.Multiselect = false;
            // this.OpenFileDialog1.ValidateNames = true;
            this.OpenFileDialog1.Title = "Open Files to Analyze";
            this.OpenFileDialog1.SupportMultiDottedExtensions = true;
            this.OpenFileDialog1.CheckPathExists = true;
            this.OpenFileDialog1.Filter = @"Capture Files (*.cap;*.etl;*.pcap;*.pcapng)|*.cap;*.etl;*.pcap;*.pcapng|All Files (*.*)|*.*";
            result = this.OpenFileDialog1.ShowDialog(this.Owner);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                TxtFileSpec.Text = this.OpenFileDialog1.FileName;
                UpdateOutputFilePath(this.OpenFileDialog1.FileName);
            }

            UpdateCommand();
        }

        private void MnuFilePreferences_Click(object sender, EventArgs e)
        {
            Form Pref = new FrmPreferences();
            Pref.ShowDialog();
            GetRegistryDefaults();
            UpdateCommand();
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateCommand()
        {
            TxtCommand.Text = "SQLNA";
            if (TxtFileSpec.Text.Trim() != "") TxtCommand.Text += @" """ + TxtFileSpec.Text.Trim() + @"""";
            if (TxtLogFile.Text.Trim() != "") TxtCommand.Text += @" /output """ + TxtLogFile.Text.Trim() + @"""";
            if (TxtSourceIP.Text.Trim() != "") TxtCommand.Text += @" /source " + TxtSourceIP.Text.Trim().Replace(" ", " /source ");
            if (TxtDestinationIP.Text.Trim() != "") TxtCommand.Text += @" /dest " + TxtDestinationIP.Text.Trim().Replace(" ", " /dest ");
            if (TxtPort.Text.Trim() != "") TxtCommand.Text += @" /port " + TxtPort.Text.Trim().Replace(" ", " /port ");
            if (convList) TxtCommand.Text += @" /convList";
            if (addrFormat != "Default") TxtCommand.Text += $@" /filterFmt {addrFormat}";
        }

        private void GetRegistryDefaults()
        {
            //
            // Nonexistant values may come back null, so the ToString() will convert it to an empty string.
            // Make sure the conditional logic returns the default option in the case of an empty string.
            //

            object regValue = null;
            string value = "";

            // Conversation List
            regValue = Registry.GetValue(Program.RegPath, Program.convListValueName, "False");
            value = regValue == null ? "" : ((string)regValue).ToUpper();
            convList = value == "TRUE" ? true : false;

            // Address Format
            regValue = Registry.GetValue(Program.RegPath, Program.addrFormatValueName, "Default");
            value = regValue == null ? "" : ((string)regValue).ToUpper();
            switch (value)
            {
                case "NETMON":
                    {
                        addrFormat = "NETMON";
                        break;
                    }
                case "WIRESHARK":
                    {
                        addrFormat = "WireShark";
                        break;
                    }
                case "AUTO":
                    {
                        addrFormat = "Auto";
                        break;
                    }
                default:
                    {
                        addrFormat = "Default";
                        break;
                    }
            }
        }

        private void TxtLogFile_TextChanged(object sender, EventArgs e)
        {
            UpdateCommand();
        }

        private void TxtFileSpec_TextChanged(object sender, EventArgs e)
        {
            HideCaret(TxtFileSpec.Handle);
            UpdateCommand();

            //BtnParse
            this.BtnParse.Enabled = !string.IsNullOrWhiteSpace(this.TxtFileSpec.Text);
        }

        private void TxtSQLHint_TextChanged(object sender, EventArgs e)
        {
            UpdateCommand();
        }

        private void BtnParse_Click(object sender, EventArgs e)
        {
            if (TxtCommand.Text != "SQLNA")
            {
                //System.Diagnostics.Process.Start(System.Environment.GetEnvironmentVariable("ComSpec"), @" /K " + TxtCommand.Text);
                ExecuteCmdCommand(TxtCommand.Text);
            }
        }

        private void TxtFileSpec_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            var filePath = fileList[0].Trim('"').Replace(@"\\", @"\");
            TxtFileSpec.Text = filePath;
            UpdateOutputFilePath(filePath);
        }


        private void TxtFileSpec_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            this.OpenFileDialog1.Multiselect = false;
            // this.OpenFileDialog1.ValidateNames = true;
            this.OpenFileDialog1.Title = "Open Files to Analyze";
            this.OpenFileDialog1.SupportMultiDottedExtensions = true;
            this.OpenFileDialog1.CheckPathExists = true;
            this.OpenFileDialog1.Filter = @"Capture Files (*.cap;*.etl;*.pcap;*.pcapng)|*.cap;*.etl;*.pcap;*.pcapng|All Files (*.*)|*.*";
            result = this.OpenFileDialog1.ShowDialog(this.Owner);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                TxtFileSpec.Text = this.OpenFileDialog1.FileName;
                UpdateOutputFilePath(this.OpenFileDialog1.FileName);
            }

            UpdateCommand();
        }

        private void TxtFileSpec_Enter(object sender, EventArgs e)
        {
            HideCaret(TxtFileSpec.Handle);
        }

        private void TxtSourceIP_TextChanged(object sender, EventArgs e)
        {
            UpdateCommand();
        }

        private void TxtDestinationIP_TextChanged(object sender, EventArgs e)
        {
            UpdateCommand();
        }

        private void TxtPort_TextChanged(object sender, EventArgs e)
        {
            UpdateCommand();
        }
    }
}
