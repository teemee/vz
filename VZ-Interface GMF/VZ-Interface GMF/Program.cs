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
            public string path;

            //hier soll mal noch ne ini realisiert werden. Um einstellungen dauerhaft speichern zu können
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section,
              string key, string val, string filePath);

            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section,
              string key, string def, StringBuilder retVal,
              int size, string filePath);

            public IniFile(string INIPath)
            {
                path = INIPath;
            }

            public void IniWriteValue(string Section, string Key, string Value)
            {
                WritePrivateProfileString(Section, Key, Value, this.path);
            }

            public string IniReadValue(string Section, string Key)
            {
                StringBuilder temp = new StringBuilder(255);
                int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
                return temp.ToString();
            }
        }

   



       
    }

