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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSQLNAUI));
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtFileSpec = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtLogFile = new System.Windows.Forms.TextBox();
            this.BtnParse = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtCommand = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSourceIP = new System.Windows.Forms.TextBox();
            this.TxtDestinationIP = new System.Windows.Forms.TextBox();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(35, 36);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(119, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "File to Analyze";
            // 
            // TxtFileSpec
            // 
            this.TxtFileSpec.AllowDrop = true;
            this.TxtFileSpec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFileSpec.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtFileSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFileSpec.Location = new System.Drawing.Point(235, 33);
            this.TxtFileSpec.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFileSpec.Name = "TxtFileSpec";
            this.TxtFileSpec.ReadOnly = true;
            this.TxtFileSpec.Size = new System.Drawing.Size(831, 26);
            this.TxtFileSpec.TabIndex = 2;
            this.TxtFileSpec.TextChanged += new System.EventHandler(this.TxtFileSpec_TextChanged);
            this.TxtFileSpec.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFileSpec_DragDrop);
            this.TxtFileSpec.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFileSpec_DragEnter);
            this.TxtFileSpec.Enter += new System.EventHandler(this.TxtFileSpec_Enter);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(35, 88);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(163, 20);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Log File Output Path";
            // 
            // TxtLogFile
            // 
            this.TxtLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLogFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtLogFile.Enabled = false;
            this.TxtLogFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogFile.Location = new System.Drawing.Point(235, 85);
            this.TxtLogFile.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLogFile.Name = "TxtLogFile";
            this.TxtLogFile.Size = new System.Drawing.Size(831, 26);
            this.TxtLogFile.TabIndex = 4;
            this.TxtLogFile.TextChanged += new System.EventHandler(this.TxtLogFile_TextChanged);
            // 
            // BtnParse
            // 
            this.BtnParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnParse.Enabled = false;
            this.BtnParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnParse.Location = new System.Drawing.Point(470, 393);
            this.BtnParse.Margin = new System.Windows.Forms.Padding(4);
            this.BtnParse.Name = "BtnParse";
            this.BtnParse.Size = new System.Drawing.Size(379, 45);
            this.BtnParse.TabIndex = 5;
            this.BtnParse.Text = "Analyze Trace";
            this.BtnParse.UseVisualStyleBackColor = true;
            this.BtnParse.Click += new System.EventHandler(this.BtnParse_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(35, 317);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(169, 20);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Simulated Command:";
            // 
            // TxtCommand
            // 
            this.TxtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCommand.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtCommand.Enabled = false;
            this.TxtCommand.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCommand.Location = new System.Drawing.Point(235, 317);
            this.TxtCommand.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCommand.Multiline = true;
            this.TxtCommand.Name = "TxtCommand";
            this.TxtCommand.ReadOnly = true;
            this.TxtCommand.Size = new System.Drawing.Size(849, 58);
            this.TxtCommand.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1104, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Source IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Destination IP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Port";
            // 
            // TxtSourceIP
            // 
            this.TxtSourceIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSourceIP.Location = new System.Drawing.Point(235, 136);
            this.TxtSourceIP.Name = "TxtSourceIP";
            this.TxtSourceIP.Size = new System.Drawing.Size(387, 27);
            this.TxtSourceIP.TabIndex = 15;
            this.TxtSourceIP.TextChanged += new System.EventHandler(this.TxtSourceIP_TextChanged);
            // 
            // TxtDestinationIP
            // 
            this.TxtDestinationIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDestinationIP.Location = new System.Drawing.Point(235, 188);
            this.TxtDestinationIP.Name = "TxtDestinationIP";
            this.TxtDestinationIP.Size = new System.Drawing.Size(387, 27);
            this.TxtDestinationIP.TabIndex = 16;
            this.TxtDestinationIP.TextChanged += new System.EventHandler(this.TxtDestinationIP_TextChanged);
            // 
            // TxtPort
            // 
            this.TxtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPort.Location = new System.Drawing.Point(235, 241);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(100, 27);
            this.TxtPort.TabIndex = 17;
            this.TxtPort.TextChanged += new System.EventHandler(this.TxtPort_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1255, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLNAUI.Properties.Resources.app_icon1;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1152, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 105);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSQLNAUI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.TxtDestinationIP);
            this.Controls.Add(this.TxtSourceIP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtCommand);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BtnParse);
            this.Controls.Add(this.TxtLogFile);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtFileSpec);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSQLNAUI";
            this.Text = "Azure App Service Network Trace Analyzer";
            this.Load += new System.EventHandler(this.FrmSQLNAUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TxtFileSpec;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox TxtLogFile;
        private System.Windows.Forms.Button BtnParse;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox TxtCommand;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSourceIP;
        private System.Windows.Forms.TextBox TxtDestinationIP;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

