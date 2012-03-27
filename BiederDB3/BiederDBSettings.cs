using System;
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

        public int showTime;

        public bool PasswortSchutzEin;

        public string CustomIndexFile;

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
            CustomIndexFile = _mySettings.GetValue("customindex", defaultSettings.CustomIndexFile);
            UseCustomIndexFile = _mySettings.GetValue("usecustomindexfile", defaultSettings.UseCustomIndexFile);
            bg_top = _mySettings.GetValue("bg_top", defaultSettings.bg_top);
            bg_left = _mySettings.GetValue("bg_left", defaultSettings.bg_left);
            bg_main = _mySettings.GetValue("bg_main", defaultSettings.bg_main);
            bg_artikel = _mySettings.GetValue("bg_artikel", defaultSettings.bg_artikel);
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
            _mySettings.SetValue("customindex", CustomIndexFile);
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
            public static string CustomIndexFile = "index.htm";
            public static bool UseCustomIndexFile = false;
            public static bool bg_top = false;
            public static bool bg_left = false;
            public static bool bg_main = false;
            public static bool bg_artikel = false;
            public static string der_biedermann_default = "<blockquote><p>Der Biedermann, Landhausm&ouml;bel in vielen Varianten, Gr&uuml;nstr. 6, 42103 Wuppertal, Telefon: 0202-470068, Fax: 0202/6980567<br>&Ouml;ffnungszeiten: Mo-Fr 11-18:30 Uhr, Sa 10-16 Uhr</p></blockquote>";

        } // class defaultSettings
    }//class BiederDBSettings2
}

