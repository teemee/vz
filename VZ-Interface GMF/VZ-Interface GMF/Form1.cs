using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //initialisieren der Felder, die die verbleibenden Zeichen für die Inserteingabe anzeigen
            insertZeile1verbleibend.Text = insertLine1.MaxLength.ToString();
            insertZeile2verbleibend.Text = insertLine2.MaxLength.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SendInsert_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insertLine1_TextChanged(object sender, EventArgs e)
        {
            int eingabe = insertLine1.MaxLength - insertLine1.TextLength;
            insertZeile1verbleibend.Text = eingabe.ToString();
        }

        private void insertLine2_TextChanged(object sender, EventArgs e)
        {
            int eingabe = insertLine2.MaxLength - insertLine2.TextLength;
            insertZeile2verbleibend.Text = eingabe.ToString();
        }

        private void openCrawlerFile_FileOk(object sender, CancelEventArgs e)
        {
            string crawlerpfad = openCrawlerFile.FileName;
            crawlerPfad.Text = crawlerpfad;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openCrawlerFile.ShowDialog();
        }

        

       
    }
}
