namespace SQLNAUI
{
    partial class FrmSQLNAUI
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
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFilePreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtFileSpec = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtLogFile = new System.Windows.Forms.TextBox();
            this.BtnParse = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtCommand = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TxtSQLHint = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.AddExtension = false;
            this.OpenFileDialog1.CheckFileExists = false;
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.OpenFileDialog1.SupportMultiDottedExtensions = true;
            this.OpenFileDialog1.ValidateNames = false;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1275, 31);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // MnuFile
            // 
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFileOpen,
            this.MnuFilePreferences,
            this.MnuFileExit});
            this.MnuFile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(49, 27);
            this.MnuFile.Text = "&File";
            // 
            // MnuFileOpen
            // 
            this.MnuFileOpen.Name = "MnuFileOpen";
            this.MnuFileOpen.Size = new System.Drawing.Size(182, 28);
            this.MnuFileOpen.Text = "&Open";
            this.MnuFileOpen.Click += new System.EventHandler(this.MnuFileOpen_Click);
            // 
            // MnuFilePreferences
            // 
            this.MnuFilePreferences.Name = "MnuFilePreferences";
            this.MnuFilePreferences.Size = new System.Drawing.Size(182, 28);
            this.MnuFilePreferences.Text = "&Preferences";
            this.MnuFilePreferences.Click += new System.EventHandler(this.MnuFilePreferences_Click);
            // 
            // MnuFileExit
            // 
            this.MnuFileExit.Name = "MnuFileExit";
            this.MnuFileExit.Size = new System.Drawing.Size(182, 28);
            this.MnuFileExit.Text = "E&xit";
            this.MnuFileExit.Click += new System.EventHandler(this.MnuFileExit_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(35, 59);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(146, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "File(s) to process:";
            // 
            // TxtFileSpec
            // 
            this.TxtFileSpec.AllowDrop = true;
            this.TxtFileSpec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFileSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFileSpec.Location = new System.Drawing.Point(221, 59);
            this.TxtFileSpec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtFileSpec.Name = "TxtFileSpec";
            this.TxtFileSpec.Size = new System.Drawing.Size(1036, 26);
            this.TxtFileSpec.TabIndex = 2;
            this.TxtFileSpec.TextChanged += new System.EventHandler(this.TxtFileSpec_TextChanged);
            this.TxtFileSpec.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFileSpec_DragDrop);
            this.TxtFileSpec.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFileSpec_DragEnter);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(35, 103);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 20);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Log file:";
            // 
            // TxtLogFile
            // 
            this.TxtLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLogFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogFile.Location = new System.Drawing.Point(221, 103);
            this.TxtLogFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLogFile.Name = "TxtLogFile";
            this.TxtLogFile.Size = new System.Drawing.Size(1036, 26);
            this.TxtLogFile.TabIndex = 4;
            this.TxtLogFile.TextChanged += new System.EventHandler(this.TxtLogFile_TextChanged);
            // 
            // BtnParse
            // 
            this.BtnParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnParse.Location = new System.Drawing.Point(1109, 309);
            this.BtnParse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnParse.Name = "BtnParse";
            this.BtnParse.Size = new System.Drawing.Size(149, 37);
            this.BtnParse.TabIndex = 5;
            this.BtnParse.Text = "Parse";
            this.BtnParse.UseVisualStyleBackColor = true;
            this.BtnParse.Click += new System.EventHandler(this.BtnParse_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(35, 210);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(127, 20);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Command Line:";
            // 
            // TxtCommand
            // 
            this.TxtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCommand.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCommand.Location = new System.Drawing.Point(221, 208);
            this.TxtCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCommand.Multiline = true;
            this.TxtCommand.Name = "TxtCommand";
            this.TxtCommand.ReadOnly = true;
            this.TxtCommand.Size = new System.Drawing.Size(863, 137);
            this.TxtCommand.TabIndex = 7;
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(39, 373);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(1219, 105);
            this.TextBox1.TabIndex = 8;
            // 
            // TxtSQLHint
            // 
            this.TxtSQLHint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSQLHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSQLHint.Location = new System.Drawing.Point(221, 154);
            this.TxtSQLHint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSQLHint.Name = "TxtSQLHint";
            this.TxtSQLHint.Size = new System.Drawing.Size(1036, 26);
            this.TxtSQLHint.TabIndex = 10;
            this.TxtSQLHint.TextChanged += new System.EventHandler(this.TxtSQLHint_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(35, 154);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(148, 20);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "SQL IP,Port Hints:";
            // 
            // FrmSQLNAUI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 494);
            this.Controls.Add(this.TxtSQLHint);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.TxtCommand);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BtnParse);
            this.Controls.Add(this.TxtLogFile);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtFileSpec);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSQLNAUI";
            this.Text = "App Service Network Trace Analyzer";
            this.Load += new System.EventHandler(this.FrmSQLNAUI_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuFile;
        private System.Windows.Forms.ToolStripMenuItem MnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MnuFileExit;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TxtFileSpec;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox TxtLogFile;
        private System.Windows.Forms.Button BtnParse;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox TxtCommand;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TxtSQLHint;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.ToolStripMenuItem MnuFilePreferences;
    }
}

