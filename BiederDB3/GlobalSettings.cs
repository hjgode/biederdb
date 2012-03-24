using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Serialization;

namespace BiederDB3
{
    public class GlobalSettings
    {
        public GlobalSettings()
        {

        }

        #region settings

        public class defaultSettings:settings
        {
            public string datenbank = @"C:\Program Files\BiederDB\CDdatabase.mdb";
            public string    sortField = "HGR_ID";
            public string    webRoot = @"C:\Bieder.Web";
            public string    webKopf = @"C:\Program Files\BiederDB\_top.htm";
            public string    mainPage = @"C:\Program Files\BiederDB\_main.htm";
            public string    iview = @"D:\TOOLS\irfanview\iview375.exe";
            public int    showTime = 3;
            public bool PasswortSchutzEin = false;
            public string    CustomIndexFile = "index.htm";
            public bool    UseCustomIndexFile = false;
            public bool    bg_top = false;
            public bool    bg_left = false;
            public bool    bg_main = false;
            public bool    bg_artikel = false;

        }
        [Serializable]
        public class settings
        {
            [NonSerialized]
            public string programShellFolder;
            //[XmlText(typeof(string))]
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

            [NonSerialized]
            public string der_biedermann_default = "<blockquote><p>Der Biedermann, Landhausm&ouml;bel in vielen Varianten, Gr&uuml;nstr. 6, 42103 Wuppertal, Telefon: 0202-470068, Fax: 0202/6980567<br>&Ouml;ffnungszeiten: Mo-Fr 11-18:30 Uhr, Sa 10-16 Uhr</p></blockquote>";

            [NonSerialized]
            private GlobalSettings global = new GlobalSettings();

            private void setDefaults()
            {
                datenbank = @"C:\Program Files\BiederDB\CDdatabase.mdb";
                sortField = "HGR_ID";
                webRoot = @"C:\Bieder.Web";
                webKopf = @"C:\Program Files\BiederDB\_top.htm";
                mainPage = @"C:\Program Files\BiederDB\_main.htm";
                iview = @"D:\TOOLS\irfanview\iview375.exe";
                showTime = 3;
                PasswortSchutzEin = false;
                CustomIndexFile = "index.htm";
                UseCustomIndexFile = false;
                bg_top = false;
                bg_left = false;
                bg_main = false;
                bg_artikel = false;
            }
            public settings()
            {
                //if (!File.Exists(Utils.AppPath + "settings.xml"))
                //{
                //    setDefaults();
                //}
                //else
                //    read();
                setDefaults();
                programShellFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                datenbank = datenbank.Replace(@"C:\Program Files", programShellFolder);
                webKopf = webKopf.Replace(@"C:\Program Files", programShellFolder);
                mainPage = mainPage.Replace(@"C:\Program Files", programShellFolder);

            }

            public int bPathValidated
            {
                get
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
            }
            public settings read()
            {
                if (System.IO.File.Exists(Utils.AppPath + "settings.xml"))
                {
                    return deserialize(Utils.AppPath + "settings.xml");
                }
                else
                    return new defaultSettings();
            }
            public bool save()
            {
                serialize(this, Utils.AppPath + "settings.xml");
                this.read();
                return serialize(this, Utils.AppPath + "settings.xml");
            }

            public static settings deserialize(string sXMLfile)
            {
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(settings));
                    Stream stream = File.Open(Utils.AppPath + "settings.xml", FileMode.Open);
                    settings sett = (settings)xs.Deserialize(stream);
                    stream.Close();
                    return sett;
                }
                catch (Exception ex)
                {
                    LoggerClass.log("Exception in settings deserialize: " + ex.Message);
                    return new defaultSettings();
                }
            }
            public static bool serialize(settings datamodel, string sXMLfile)
            {
                bool bRet = false;
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(settings));
                    //omit xmlns:xsi from xml output
                    //Create our own namespaces for the output
                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                    //Add an empty namespace and empty value
                    ns.Add("", "");
                    //StreamWriter sw = new StreamWriter("./SystemHealth.out.xml");
                    StreamWriter sw = new StreamWriter(sXMLfile);
                    xs.Serialize(sw, datamodel, ns);
                    sw.Close();
                    bRet = true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Exception in 'settings serialize' for " + sXMLfile + "' Ex=" + ex.Message);
                }
                return bRet;
            }

        }
        #endregion
        //public void write_ini()
        //{
        //    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(utils.AppPath + "biederdb.ini"))
        //    {
        //        sw.WriteLine(this.datenbank);
        //        sw.WriteLine(sortField);
        //        sw.WriteLine(webroot);
        //        sw.WriteLine(webkopf);
        //        sw.WriteLine(startpage);
        //        sw.WriteLine(iview);
        //        sw.WriteLine(ShowTime);
        //        sw.WriteLine(PasswortSchutzEin.ToString());
        //        sw.WriteLine(StartSeite);

        //        sw.WriteLine(bg_top.ToString());
        //        sw.WriteLine(bg_left.ToString());
        //        sw.WriteLine(bg_main.ToString());
        //        sw.WriteLine(bg_artikel.ToString());
        //    }
        //}
        //public void read_ini()
        //{
        //    //On Error Resume Next
        //    using (System.IO.StringReader sr = new System.IO.StringReader(AppPath + "biederdb.ini"))
        //    {
        //        datenbank = sr.ReadLine();
        //        sortField = sr.ReadLine();
        //        webroot = sr.ReadLine();
        //        webkopf = sr.ReadLine();
        //        startpage = sr.ReadLine();
        //        iview = sr.ReadLine();
        //        ShowTime = sr.ReadLine();
        //        PasswortSchutzEin = double.Parse(sr.ReadLine());
        //        StartSeite = sr.ReadLine();
        //        bg_top = double.Parse(sr.ReadLine());
        //        bg_left = double.Parse(sr.ReadLine());
        //        bg_main = double.Parse(sr.ReadLine());
        //        bg_artikel = double.Parse(sr.ReadLine());
        //    }
        //}

    }
}