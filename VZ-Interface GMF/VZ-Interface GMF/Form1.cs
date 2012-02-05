using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
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
            String blubb = server + " SET InfoZ1 s_text \"" + insert1 + "\"" + " SET InfoZ2 s_text \"" + insert2 + "\"";
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
            vars.crawlerPath = openCrawlerFile.FileName;
            boxCrawlerPfad.Text = vars.crawlerPath;
            // Auslesen der Datei
            StreamReader readCrawler = new StreamReader(vars.crawlerPath,System.Text.Encoding.Default);
            string crawlerText = readCrawler.ReadToEnd();
            readCrawler.Close();
            textBoxCrawler.Text = crawlerText;
            //trennen von Filename und Pfad und speichern in verschiedene Variablen
            //int i = vars.crawlerPath.Length;
            //string s = "";
            //while (s != "\\")
            //{

            //}

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
            //Verarbeitung Button 'REIN'
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
            //Verarbeitung Button 'RAUS'
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

            //Speichern auf Bank einleiten
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
            //Fallunterscheidung, Entweder Insert auf Bank 1 legen und Buttonfarbe zurücksetzen...
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
                //oder Bankinhalt in die beiden Insert-Felder legen
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

        private void buttonOpenCrawler_Click(object sender, EventArgs e)
        {
            openCrawlerFile.ShowDialog();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Auslesen der Datei
            StreamReader readCrawler = new StreamReader(vars.crawlerPath, System.Text.Encoding.Default);
            string crawlerText = readCrawler.ReadToEnd();
            readCrawler.Close();
            textBoxCrawler.Text = crawlerText;
        }

        //OnAir bringen des neuen Crawl-Textes / Aktualisierung des Crawlers
        private void buttonSaveCrawl_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            //schreiben des Crawl-Textfeldes in 'CrawlText' und ersetzen der Zeilenumbrüche in Leerzeichen
            String CrawlText = Regex.Replace(textBoxCrawler.Text, "\r\n", " ");
            String blubb = server + " SET crawler l_loop 0 SET crawler l_loop 1 SET crawler s_trig_append \"" + CrawlText + "\"";
            String arguments = Encoding.Default.GetString(Encoding.UTF8.GetBytes(blubb));

            //Ausführen der Sender-Exe zu VZ mit übergabe von 'arguments'
            //und Unterdrückung vom Konsolenfenster und so Kram
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

        private void buttonCrawlLoopOn_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            String blubb = server + " SET crawler l_loop 1";
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

        private void buttonCrawlLoopOff_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            String blubb = server + " SET crawler l_loop 0";
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

        private void buttonCrawlReset_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            String blubb = server + " SET crawler l_reset 1";
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

        private void buttonCrawlAppend_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            //schreiben des Crawl-Textfeldes in 'CrawlText' und ersetzen der Zeilenumbrüche in Leerzeichen
            String CrawlText = Regex.Replace(textBoxCrawler.Text, "\r\n", " ");
            String blubb = server + " SET crawler s_trig_append \"" + CrawlText + "\"";
            String arguments = Encoding.Default.GetString(Encoding.UTF8.GetBytes(blubb));

            //Ausführen der Sender-Exe zu VZ mit übergabe von 'arguments'
            //und Unterdrückung vom Konsolenfenster und so Kram
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

        //Button "Auf anfang" - neuladen der Szene und einblenden der Bauchbinde
        private void buttonVzInit_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            String blubb = server + " LOAD_SCENE ./projects/guten-morgen-filstal/guten-morgen-filstal.xml START_DIRECTOR main 0";
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
        //Realisierung der 6 leeren-Buttons der 6 Slots - schreibt einfach ---- in den jeweiligen Slot
        private void buttonClear1_Click(object sender, EventArgs e)
        {
            labelSet11.Text = "----";
            labelSet12.Text = "----";
        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {
            labelSet21.Text = "----";
            labelSet22.Text = "----";
        }

        private void buttonClear3_Click(object sender, EventArgs e)
        {
            labelSet31.Text = "----";
            labelSet32.Text = "----";
        }

        private void buttonClear4_Click(object sender, EventArgs e)
        {
            labelSet41.Text = "----";
            labelSet42.Text = "----";
        }

        private void buttonClear5_Click(object sender, EventArgs e)
        {
            labelSet51.Text = "----";
            labelSet52.Text = "----";
        }

        private void buttonClear6_Click(object sender, EventArgs e)
        {
            labelSet61.Text = "----";
            labelSet62.Text = "----";
        }

        // OnAir Buttons der Slots.
        private void buttonAir1_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            //einlesen der Slot-Labels
            String insert1 = labelSet11.Text;
            String insert2 = labelSet12.Text;
            //Bauen den Control-Strings für VZ
            String blubb = server + " SET InfoZ1 s_text \"" + insert1 + "\"" + " SET InfoZ2 s_text \"" + insert2 + "\"";
            //Wandlung in UTF8 und übergabe an Kommandozeile
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

        private void buttonAir2_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            String insert1 = labelSet21.Text;
            String insert2 = labelSet22.Text;
            String blubb = server + " SET InfoZ1 s_text \"" + insert1 + "\"" + " SET InfoZ2 s_text \"" + insert2 + "\"";
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

        private void buttonAir3_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            String insert1 = labelSet31.Text;
            String insert2 = labelSet32.Text;
            String blubb = server + " SET InfoZ1 s_text \"" + insert1 + "\"" + " SET InfoZ2 s_text \"" + insert2 + "\"";
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

        private void buttonAir4_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            String insert1 = labelSet41.Text;
            String insert2 = labelSet42.Text;
            String blubb = server + " SET InfoZ1 s_text \"" + insert1 + "\"" + " SET InfoZ2 s_text \"" + insert2 + "\"";
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

        private void buttonAir5_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            String insert1 = labelSet51.Text;
            String insert2 = labelSet52.Text;
            String blubb = server + " SET InfoZ1 s_text \"" + insert1 + "\"" + " SET InfoZ2 s_text \"" + insert2 + "\"";
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

        private void buttonAir6_Click(object sender, EventArgs e)
        {
            String server = textBoxServer.Text;
            String senderExePfad = boxSenderPfad.Text;
            String insert1 = labelSet61.Text;
            String insert2 = labelSet62.Text;
            String blubb = server + " SET InfoZ1 s_text \"" + insert1 + "\"" + " SET InfoZ2 s_text \"" + insert2 + "\"";
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

      

     
      


        

       
    }
}
