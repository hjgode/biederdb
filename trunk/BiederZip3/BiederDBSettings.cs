using System;
using System.Text;
using System.Xml;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;

using System.IO;

namespace BiederDB3
{
    public class BiederDBSettings2{
        VastAbyss.Configuration.ApplicationSettings _mySettings;
        public string datenbank;
        public string sortField;
        public string webRoot;
        public string webKopf;
        public string mainPage;
        public string iview;
        //public string StartSeite;

        public int showTime;

        /// <summary>
        /// defines is SlideShow exit needs a password
        /// </summary>
        public bool PasswortSchutzEin;

        public string startSeite;

        public bool UseCustomIndexFile;

        public bool bg_top;
        public bool bg_left;
        public bool bg_main;
        public bool bg_artikel;

        public string der_biedermann_default = "<blockquote><p>Der Biedermann, Landhausm&ouml;bel in vielen Varianten, Gr&uuml;nstr. 6, 42103 Wuppertal, Telefon: 0202-470068, Fax: 0202/6980567<br>&Ouml;ffnungszeiten: Mo-Fr 11-18:30 Uhr, Sa 10-16 Uhr</p></blockquote>";

        public BiederDBSettings2()
        {
            _mySettings = new VastAbyss.Configuration.ApplicationSettings();
            _mySettings.GetValue("datenbank", defaultSettings.datenbank);

            datenbank = _mySettings.GetValue("datenbank", defaultSettings.datenbank);
            sortField = _mySettings.GetValue("hgr_id", defaultSettings.sortField);
            webRoot = _mySettings.GetValue("webroot", defaultSettings.webRoot);
            webKopf = _mySettings.GetValue("webkopf", defaultSettings.webKopf);
            mainPage = _mySettings.GetValue("mainpage", defaultSettings.mainPage);
            iview = _mySettings.GetValue("iview", defaultSettings.iview);
            showTime = _mySettings.GetValue("showtime", defaultSettings.showTime);
            PasswortSchutzEin = _mySettings.GetValue("passwordschutzein", defaultSettings.PasswortSchutzEin);
            
            startSeite = _mySettings.GetValue("customindex", defaultSettings.StartSeite);
            UseCustomIndexFile = _mySettings.GetValue("usecustomindexfile", defaultSettings.UseCustomIndexFile);

            bg_top = _mySettings.GetValue("bg_top", defaultSettings.bg_top);
            bg_left = _mySettings.GetValue("bg_left", defaultSettings.bg_left);
            bg_main = _mySettings.GetValue("bg_main", defaultSettings.bg_main);
            bg_artikel = _mySettings.GetValue("bg_artikel", defaultSettings.bg_artikel);
            //StartSeite = _mySettings.GetValue("startseite", defaultSettings.startseite);
        }
        public int bPathValidated
        {
            get
            {
                try
                {
                    int iRet = 0;
                    if (!File.Exists(datenbank))
                        iRet += 0x02;
                    if (!File.Exists(webKopf))
                        iRet += 0x04;
                    if (!File.Exists(mainPage))
                        iRet += 0x08;
                    if (!File.Exists(iview))
                        iRet += 0x10;
                    return iRet;
                }
                catch (Exception)
                {
                    return -99;
                }
            }
        }
        public bool bIsValidFile(string sFile)
        {
            bool bRet = false;
            try
            {
                //file?
                if (File.Exists(sFile))
                {
                    FileInfo fi = new FileInfo(sFile);
                    if (fi.Length > 0)
                        bRet = true;
                }
                if(Directory.Exists(sFile))
                    return true;
            }
            catch (Exception)
            {
            }
            return bRet;
        }
        public void save()
        {
            _mySettings.SetValue("datenbank", datenbank);
            _mySettings.SetValue("hgr_id", sortField);
            _mySettings.SetValue("webroot", webRoot);
            _mySettings.SetValue("webkopf", webKopf);
            _mySettings.SetValue("mainpage", mainPage);
            _mySettings.SetValue("iview", iview);
            _mySettings.SetValue("showtime", showTime);
            _mySettings.SetValue("passwordschutzein", PasswortSchutzEin);
            _mySettings.SetValue("customindex", startSeite);
            _mySettings.SetValue("usecustomindexfile", UseCustomIndexFile);
            _mySettings.SetValue("bg_top", bg_top);
            _mySettings.SetValue("bg_left", bg_left);
            _mySettings.SetValue("bg_main", bg_main);
            _mySettings.SetValue("bg_artikel", bg_artikel);

            _mySettings.SaveConfiguration();
        }
        private static class defaultSettings
        {
            private static string _datenbank = @"C:\Program Files\BiederDB\CDdatabase.mdb";
            public static string datenbank
            {
                get { return _datenbank.Replace(@"C:\Program Files", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)); }
                set { _datenbank = value; }
            }
            public static string sortField = "Hgr_ID";
            public static string webRoot = @"C:\Bieder.Web";
            private static string _webKopf = @"C:\Program Files\BiederDB\_top.htm";
            public static string webKopf
            {
                get { return _webKopf.Replace(@"C:\Program Files", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)); }
                set { _webKopf = value; }
            }
            private static string _mainPage = @"C:\Program Files\BiederDB\_main.htm";
            public static string mainPage
            {
                get
                { return _mainPage.Replace(@"C:\Program Files", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)); }
                set { _mainPage = value; }
            }
            public static string iview = @"D:\TOOLS\irfanview\iview375.exe";
            public static int showTime = 3;
            public static bool PasswortSchutzEin = false;
            public static string StartSeite = "index.htm";
            public static bool UseCustomIndexFile = false;
            public static bool bg_top = false;
            public static bool bg_left = false;
            public static bool bg_main = false;
            public static bool bg_artikel = false;
            public static string der_biedermann_default = "<blockquote><p>Der Biedermann, Landhausm&ouml;bel in vielen Varianten, Gr&uuml;nstr. 6, 42103 Wuppertal, Telefon: 0202-470068, Fax: 0202/6980567<br>&Ouml;ffnungszeiten: Mo-Fr 11-18:30 Uhr, Sa 10-16 Uhr</p></blockquote>";
            //public static string startseite = "index.htm";

        } // class defaultSettings
        public string keywords_htm
        {
            get
            {
                string keyfile = null;
                string s = null;
                keyfile = Utils.AppPath + "_keywords.htm";
                if (System.IO.File.Exists(keyfile))
                {
                    s = "";
                    using (StreamReader sr = new StreamReader(keyfile, Encoding.GetEncoding(1252)))
                    {
                        String line;
                        // Read and display lines from the file until the end of 
                        // the file is reached.
                        while ((line = sr.ReadLine()) != null)
                        {
                            s += line;
                        }
                    }
                }
                else
                {
                    //UPGRADE_WARNING: Couldn't resolve default property of object keywords_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    s = "<meta name=" + Constants.ii + "keywords" + Constants.ii + " content=" + Constants.ii + "Der Biedermann, Landhausm&ouml;bel, Wuppertal, Naturholz, M&ouml;bel, Tische, Schr&auml;nke, St&uuml;hle, Bett, Stuhl, Tisch, Schrank, Kasten" + Constants.ii + ">";
                }
                return s;
            }
            
        }
        public string Der_Biedermann
        {
            get
            {
                string sDer_Biedermann="";
                if(System.IO.File.Exists(Utils.AppPath+ "Der_Biedermann.txt"))
                {
                    using (StreamReader sr = new StreamReader(Utils.AppPath + "Der_Biedermann.txt", Encoding.GetEncoding(1252)))
                    {
                        String line;
                        // Read and display lines from the file until the end of 
                        // the file is reached.
                        while ((line = sr.ReadLine()) != null)
                        {
                            sDer_Biedermann += line;
                        }
                    }
                }
                else
                    sDer_Biedermann ="<blockquote><p>Der Biedermann, Landhausm&ouml;bel in vielen Varianten, Gr&uuml;nstr. 6, 42103 Wuppertal, Telefon: 0202-470068, Fax: 0202/6980567<br>&Ouml;ffnungszeiten: Mo-Fr 11-18:30 Uhr, Sa 10-16 Uhr</p></blockquote>";
                return sDer_Biedermann;
            }
        }
    }//class BiederDBSettings2
}

