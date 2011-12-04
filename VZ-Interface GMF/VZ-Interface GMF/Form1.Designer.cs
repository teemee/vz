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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.crawlerPfad = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openCrawlerFile = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertLine1
            // 
            this.insertLine1.Location = new System.Drawing.Point(101, 48);
            this.insertLine1.MaxLength = 45;
            this.insertLine1.Name = "insertLine1";
            this.insertLine1.Size = new System.Drawing.Size(243, 20);
            this.insertLine1.TabIndex = 0;
            this.insertLine1.TextChanged += new System.EventHandler(this.insertLine1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert Zeile 1";
            // 
            // insertLine2
            // 
            this.insertLine2.Location = new System.Drawing.Point(101, 74);
            this.insertLine2.MaxLength = 45;
            this.insertLine2.Name = "insertLine2";
            this.insertLine2.Size = new System.Drawing.Size(243, 20);
            this.insertLine2.TabIndex = 2;
            this.insertLine2.TextChanged += new System.EventHandler(this.insertLine2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insert Zeile 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SendInsert
            // 
            this.SendInsert.Location = new System.Drawing.Point(101, 100);
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
            this.insertZeile1verbleibend.Location = new System.Drawing.Point(345, 51);
            this.insertZeile1verbleibend.Name = "insertZeile1verbleibend";
            this.insertZeile1verbleibend.Size = new System.Drawing.Size(34, 13);
            this.insertZeile1verbleibend.TabIndex = 5;
            this.insertZeile1verbleibend.Text = "verb1";
            // 
            // insertZeile2verbleibend
            // 
            this.insertZeile2verbleibend.AutoSize = true;
            this.insertZeile2verbleibend.Location = new System.Drawing.Point(345, 77);
            this.insertZeile2verbleibend.Name = "insertZeile2verbleibend";
            this.insertZeile2verbleibend.Size = new System.Drawing.Size(34, 13);
            this.insertZeile2verbleibend.TabIndex = 6;
            this.insertZeile2verbleibend.Text = "verb2";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
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
            this.tabControl1.Size = new System.Drawing.Size(433, 433);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(425, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OnAir Gedöns";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOpen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.crawlerPfad);
            this.groupBox2.Location = new System.Drawing.Point(16, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 230);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crawler";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(363, 34);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(24, 23);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
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
            // crawlerPfad
            // 
            this.crawlerPfad.Location = new System.Drawing.Point(9, 35);
            this.crawlerPfad.Name = "crawlerPfad";
            this.crawlerPfad.Size = new System.Drawing.Size(348, 20);
            this.crawlerPfad.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Einstellungen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openCrawlerFile
            // 
            this.openCrawlerFile.FileName = "openFileDialog1";
            this.openCrawlerFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openCrawlerFile_FileOk);
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
        private System.Windows.Forms.TextBox crawlerPfad;
        private System.Windows.Forms.Button buttonOpen;
    }
}

