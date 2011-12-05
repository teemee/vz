namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.insertLine1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insertLine2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SendInsert = new System.Windows.Forms.Button();
            this.insertZeile1verbleibend = new System.Windows.Forms.Label();
            this.insertZeile2verbleibend = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOpenCrawler = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.boxCrawlerPfad = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.testLabel = new System.Windows.Forms.Label();
            this.buttonOpenSender = new System.Windows.Forms.Button();
            this.boxSenderPfad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openCrawlerFile = new System.Windows.Forms.OpenFileDialog();
            this.openSenderExe = new System.Windows.Forms.OpenFileDialog();
            this.buttonInsertOn = new System.Windows.Forms.Button();
            this.buttonInsertOff = new System.Windows.Forms.Button();
            this.buttonLoadScene = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertLine1
            // 
            this.insertLine1.Location = new System.Drawing.Point(101, 114);
            this.insertLine1.MaxLength = 35;
            this.insertLine1.Name = "insertLine1";
            this.insertLine1.Size = new System.Drawing.Size(243, 20);
            this.insertLine1.TabIndex = 0;
            this.insertLine1.TextChanged += new System.EventHandler(this.insertLine1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert Zeile 1";
            // 
            // insertLine2
            // 
            this.insertLine2.Location = new System.Drawing.Point(101, 140);
            this.insertLine2.MaxLength = 35;
            this.insertLine2.Name = "insertLine2";
            this.insertLine2.Size = new System.Drawing.Size(243, 20);
            this.insertLine2.TabIndex = 2;
            this.insertLine2.TextChanged += new System.EventHandler(this.insertLine2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insert Zeile 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SendInsert
            // 
            this.SendInsert.Location = new System.Drawing.Point(101, 166);
            this.SendInsert.Name = "SendInsert";
            this.SendInsert.Size = new System.Drawing.Size(75, 23);
            this.SendInsert.TabIndex = 4;
            this.SendInsert.Text = "OnAir";
            this.SendInsert.UseVisualStyleBackColor = true;
            this.SendInsert.Click += new System.EventHandler(this.SendInsert_Click);
            // 
            // insertZeile1verbleibend
            // 
            this.insertZeile1verbleibend.AutoSize = true;
            this.insertZeile1verbleibend.Location = new System.Drawing.Point(345, 117);
            this.insertZeile1verbleibend.Name = "insertZeile1verbleibend";
            this.insertZeile1verbleibend.Size = new System.Drawing.Size(34, 13);
            this.insertZeile1verbleibend.TabIndex = 5;
            this.insertZeile1verbleibend.Text = "verb1";
            // 
            // insertZeile2verbleibend
            // 
            this.insertZeile2verbleibend.AutoSize = true;
            this.insertZeile2verbleibend.Location = new System.Drawing.Point(345, 143);
            this.insertZeile2verbleibend.Name = "insertZeile2verbleibend";
            this.insertZeile2verbleibend.Size = new System.Drawing.Size(34, 13);
            this.insertZeile2verbleibend.TabIndex = 6;
            this.insertZeile2verbleibend.Text = "verb2";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 499);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonLoadScene);
            this.tabPage1.Controls.Add(this.buttonInsertOff);
            this.tabPage1.Controls.Add(this.buttonInsertOn);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.insertZeile2verbleibend);
            this.tabPage1.Controls.Add(this.SendInsert);
            this.tabPage1.Controls.Add(this.insertZeile1verbleibend);
            this.tabPage1.Controls.Add(this.insertLine1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.insertLine2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OnAir Gedöns";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOpenCrawler);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.boxCrawlerPfad);
            this.groupBox2.Location = new System.Drawing.Point(16, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 234);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crawler";
            // 
            // buttonOpenCrawler
            // 
            this.buttonOpenCrawler.Location = new System.Drawing.Point(363, 34);
            this.buttonOpenCrawler.Name = "buttonOpenCrawler";
            this.buttonOpenCrawler.Size = new System.Drawing.Size(24, 23);
            this.buttonOpenCrawler.TabIndex = 2;
            this.buttonOpenCrawler.Text = "...";
            this.buttonOpenCrawler.UseVisualStyleBackColor = true;
            this.buttonOpenCrawler.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pfad zum Textfile";
            // 
            // boxCrawlerPfad
            // 
            this.boxCrawlerPfad.Location = new System.Drawing.Point(9, 35);
            this.boxCrawlerPfad.Name = "boxCrawlerPfad";
            this.boxCrawlerPfad.Size = new System.Drawing.Size(348, 20);
            this.boxCrawlerPfad.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.testLabel);
            this.tabPage2.Controls.Add(this.buttonOpenSender);
            this.tabPage2.Controls.Add(this.boxSenderPfad);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxServer);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Einstellungen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(20, 177);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(35, 13);
            this.testLabel.TabIndex = 5;
            this.testLabel.Text = "label6";
            // 
            // buttonOpenSender
            // 
            this.buttonOpenSender.Location = new System.Drawing.Point(382, 91);
            this.buttonOpenSender.Name = "buttonOpenSender";
            this.buttonOpenSender.Size = new System.Drawing.Size(24, 23);
            this.buttonOpenSender.TabIndex = 4;
            this.buttonOpenSender.Text = "...";
            this.buttonOpenSender.UseVisualStyleBackColor = true;
            this.buttonOpenSender.Click += new System.EventHandler(this.buttonOpenSender_Click);
            // 
            // boxSenderPfad
            // 
            this.boxSenderPfad.Location = new System.Drawing.Point(23, 91);
            this.boxSenderPfad.Name = "boxSenderPfad";
            this.boxSenderPfad.Size = new System.Drawing.Size(353, 20);
            this.boxSenderPfad.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Pfad zur VzCmdSender.exe";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(62, 17);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(117, 20);
            this.textBoxServer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Server:";
            // 
            // openCrawlerFile
            // 
            this.openCrawlerFile.FileName = "openFileDialog1";
            this.openCrawlerFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openCrawlerFile_FileOk);
            // 
            // openSenderExe
            // 
            this.openSenderExe.FileName = "openFileDialog1";
            this.openSenderExe.FileOk += new System.ComponentModel.CancelEventHandler(this.openSenderExe_FileOk);
            // 
            // buttonInsertOn
            // 
            this.buttonInsertOn.Location = new System.Drawing.Point(178, 30);
            this.buttonInsertOn.Name = "buttonInsertOn";
            this.buttonInsertOn.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertOn.TabIndex = 10;
            this.buttonInsertOn.Text = "REIN";
            this.buttonInsertOn.UseVisualStyleBackColor = true;
            this.buttonInsertOn.Click += new System.EventHandler(this.buttonInsertOn_Click);
            // 
            // buttonInsertOff
            // 
            this.buttonInsertOff.Location = new System.Drawing.Point(259, 30);
            this.buttonInsertOff.Name = "buttonInsertOff";
            this.buttonInsertOff.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertOff.TabIndex = 11;
            this.buttonInsertOff.Text = "RAUS";
            this.buttonInsertOff.UseVisualStyleBackColor = true;
            this.buttonInsertOff.Click += new System.EventHandler(this.buttonInsertOff_Click);
            // 
            // buttonLoadScene
            // 
            this.buttonLoadScene.Location = new System.Drawing.Point(25, 30);
            this.buttonLoadScene.Name = "buttonLoadScene";
            this.buttonLoadScene.Size = new System.Drawing.Size(83, 23);
            this.buttonLoadScene.TabIndex = 12;
            this.buttonLoadScene.Text = "Szene laden";
            this.buttonLoadScene.UseVisualStyleBackColor = true;
            this.buttonLoadScene.Click += new System.EventHandler(this.buttonLoadScene_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 523);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "VZ-Interface GMF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox insertLine1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox insertLine2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SendInsert;
        private System.Windows.Forms.Label insertZeile1verbleibend;
        private System.Windows.Forms.Label insertZeile2verbleibend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openCrawlerFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxCrawlerPfad;
        private System.Windows.Forms.Button buttonOpenCrawler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOpenSender;
        private System.Windows.Forms.TextBox boxSenderPfad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.OpenFileDialog openSenderExe;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button buttonInsertOff;
        private System.Windows.Forms.Button buttonInsertOn;
        private System.Windows.Forms.Button buttonLoadScene;
    }
}

