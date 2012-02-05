using System;
using System.IO;
using System.Security.Permissions;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Hier soll die überprüfung OnFileChange für den Crawler passieren
            FileSystemWatcher watch = new FileSystemWatcher();
            watch.Path = vars.crawlerPath;
            

        }
    }



        public class IniFile
        {
            private string filePath;
         
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section,
            string key,
            string val,
            string filePath);
 
            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section,
            string key,
            string def,
            StringBuilder retVal,
            int size,
            string filePath);
        
            public IniFile(string filePath)
            {
                this.filePath = filePath;
            }
 
            public void Write(string section, string key, string value)
            {
                WritePrivateProfileString(section, key, value.ToLower(), this.filePath);
            }
 
            public string Read(string section, string key)
            {
                StringBuilder SB = new StringBuilder(255);
                int i = GetPrivateProfileString(section, key, "", SB, 255, this.filePath);
                return SB.ToString();
            }
         
            public string FilePath
            {
                get { return this.filePath; }
                set { this.filePath = value; }
            }
        }

   



       
    }

