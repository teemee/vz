using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
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

        public String setInsert1 = "";
        public String setInsert2 = "";


        private void SendInsert_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            String insert1 = insertLine1.Text;
            String insert2 = insertLine2.Text;
            String testcmdline = senderExePfad + " " + server + " SET InfoZ1 s_text \"" + insert1 + "\"" + " SET InfoZ2 s_text \"" + insert2 + "\"";
            String blubb = server + " SET InfoZ1 s_text \"" + insert1 + "\"" + " SET InfoZ2 s_text \"" + insert2 + "\"";
            testLabel.Text = testcmdline;
            String arguments = Encoding.Default.GetString(Encoding.UTF8.GetBytes(blubb));

            Process proc = new Process();
            proc.StartInfo.FileName = senderExePfad;
            proc.StartInfo.Arguments = arguments;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();
            proc.Close();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insertLine1_TextChanged(object sender, EventArgs e)
        {
            //Aktualisieren der Verbleibenden Zeichen Line 1
            int eingabe = insertLine1.MaxLength - insertLine1.TextLength;
            insertZeile1verbleibend.Text = eingabe.ToString();
        }

        private void insertLine2_TextChanged(object sender, EventArgs e)
        {
            //Aktualisieren der Verbleibenden Zeichen Line 2
            int eingabe = insertLine2.MaxLength - insertLine2.TextLength;
            insertZeile2verbleibend.Text = eingabe.ToString();
        }

        private void openCrawlerFile_FileOk(object sender, CancelEventArgs e)
        {
            //Schreiben des Pfades des Öffnen-Dialogs in Variable und entsprechendes Textfeld
            string crawlerpfad = openCrawlerFile.FileName;
            boxCrawlerPfad.Text = crawlerpfad;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openCrawlerFile.ShowDialog();
        }

        private void buttonOpenSender_Click(object sender, EventArgs e)
        {
            openSenderExe.ShowDialog();
        }

        private void openSenderExe_FileOk(object sender, CancelEventArgs e)
        {
            //Schreiben des Pfades des Öffnen-Dialogs in Variable und entsprechendes Textfeld
            string SenderExePfad = openSenderExe.FileName;
            boxSenderPfad.Text = SenderExePfad;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsertOn_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            String blubb = server + " START_DIRECTOR main 0";
            String arguments = Encoding.Default.GetString(Encoding.UTF8.GetBytes(blubb));

            Process proc = new Process();
            proc.StartInfo.FileName = senderExePfad;
            proc.StartInfo.Arguments = arguments;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();
            proc.Close();
        }

        private void buttonInsertOff_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            String blubb = server + " CONTINUE_DIRECTOR main";
            String arguments = Encoding.Default.GetString(Encoding.UTF8.GetBytes(blubb));

            Process proc = new Process();
            proc.StartInfo.FileName = senderExePfad;
            proc.StartInfo.Arguments = arguments;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();
            proc.Close();
        }

        private void buttonLoadScene_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            String blubb = server + " LOAD_SCENE ./projects/guten-morgen-filstal/guten-morgen-filstal.xml";
            String arguments = Encoding.Default.GetString(Encoding.UTF8.GetBytes(blubb));

            Process proc = new Process();
            proc.StartInfo.FileName = senderExePfad;
            proc.StartInfo.Arguments = arguments;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();
            proc.Close();
        }

        private void buttonToSet_Click(object sender, EventArgs e)
        {

            setInsert1 = insertLine1.Text;
            setInsert2 = insertLine2.Text;
            
            buttonSet1.BackColor = Color.Red;
            buttonSet2.BackColor = Color.Red;
            buttonSet3.BackColor = Color.Red;
            buttonSet4.BackColor = Color.Red;
            buttonSet5.BackColor = Color.Red;
            buttonSet6.BackColor = Color.Red;
        }

        private void buttonSet1_Click(object sender, EventArgs e)
        {

            if (buttonSet1.BackColor == Color.Red)
            {
                labelSet11.Text = setInsert1;
                labelSet12.Text = setInsert2;
                buttonSet1.BackColor = Color.Transparent;
                buttonSet2.BackColor = Color.Transparent;
                buttonSet3.BackColor = Color.Transparent;
                buttonSet4.BackColor = Color.Transparent;
                buttonSet5.BackColor = Color.Transparent;
                buttonSet6.BackColor = Color.Transparent;
                setInsert1 = "";
                setInsert2 = "";
            }
            else
            {
                insertLine1.Text = labelSet11.Text;
                insertLine2.Text = labelSet12.Text;
            }

        }

        private void buttonSet2_Click(object sender, EventArgs e)
        {
            if (buttonSet2.BackColor == Color.Red)
            {
                labelSet21.Text = setInsert1;
                labelSet22.Text = setInsert2;
                buttonSet1.BackColor = Color.Transparent;
                buttonSet2.BackColor = Color.Transparent;
                buttonSet3.BackColor = Color.Transparent;
                buttonSet4.BackColor = Color.Transparent;
                buttonSet5.BackColor = Color.Transparent;
                buttonSet6.BackColor = Color.Transparent;
                setInsert1 = "";
                setInsert2 = "";
            }
            else
            {
                insertLine1.Text = labelSet21.Text;
                insertLine2.Text = labelSet22.Text;
            }
        }

        private void buttonSet3_Click(object sender, EventArgs e)
        {
            if (buttonSet3.BackColor == Color.Red)
            {
                labelSet31.Text = setInsert1;
                labelSet32.Text = setInsert2;
                buttonSet1.BackColor = Color.Transparent;
                buttonSet2.BackColor = Color.Transparent;
                buttonSet3.BackColor = Color.Transparent;
                buttonSet4.BackColor = Color.Transparent;
                buttonSet5.BackColor = Color.Transparent;
                buttonSet6.BackColor = Color.Transparent;
                setInsert1 = "";
                setInsert2 = "";
            }
            else
            {
                insertLine1.Text = labelSet31.Text;
                insertLine2.Text = labelSet32.Text;
            }
        }

        private void buttonSet4_Click(object sender, EventArgs e)
        {
            if (buttonSet4.BackColor == Color.Red)
            {
                labelSet41.Text = setInsert1;
                labelSet42.Text = setInsert2;
                buttonSet1.BackColor = Color.Transparent;
                buttonSet2.BackColor = Color.Transparent;
                buttonSet3.BackColor = Color.Transparent;
                buttonSet4.BackColor = Color.Transparent;
                buttonSet5.BackColor = Color.Transparent;
                buttonSet6.BackColor = Color.Transparent;
                setInsert1 = "";
                setInsert2 = "";
            }
            else
            {
                insertLine1.Text = labelSet41.Text;
                insertLine2.Text = labelSet42.Text;
            }
        }

        private void buttonSet5_Click(object sender, EventArgs e)
        {
            if (buttonSet5.BackColor == Color.Red)
            {
                labelSet51.Text = setInsert1;
                labelSet52.Text = setInsert2;
                buttonSet1.BackColor = Color.Transparent;
                buttonSet2.BackColor = Color.Transparent;
                buttonSet3.BackColor = Color.Transparent;
                buttonSet4.BackColor = Color.Transparent;
                buttonSet5.BackColor = Color.Transparent;
                buttonSet6.BackColor = Color.Transparent;
                setInsert1 = "";
                setInsert2 = "";
            }
            else
            {
                insertLine1.Text = labelSet51.Text;
                insertLine2.Text = labelSet52.Text;
            }
        }

        private void buttonSet6_Click(object sender, EventArgs e)
        {
            if (buttonSet6.BackColor == Color.Red)
            {
                labelSet61.Text = setInsert1;
                labelSet62.Text = setInsert2;
                buttonSet1.BackColor = Color.Transparent;
                buttonSet2.BackColor = Color.Transparent;
                buttonSet3.BackColor = Color.Transparent;
                buttonSet4.BackColor = Color.Transparent;
                buttonSet5.BackColor = Color.Transparent;
                buttonSet6.BackColor = Color.Transparent;
                setInsert1 = "";
                setInsert2 = "";
            }
            else
            {
                insertLine1.Text = labelSet61.Text;
                insertLine2.Text = labelSet62.Text;
            }
        }

     
      


        

       
    }
}
