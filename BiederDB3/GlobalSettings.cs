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

        #region settings

        public class settings
        {
            public string programShellFolder;
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

            static XMLsettings xmlsettings = null;
            public settings()
            {
                if (xmlsettings != null)
                    return;
                try
                {
                    xmlsettings = new XMLsettings();
                    if (File.Exists(Utils.xmlSettingsFile))
                    {
                        xmlsettings.readXML();
                    }
                    else
                    {
                        this.setDefaults();
                    }
                }
                catch (Exception ex)
                {
                    setDefaults();
                    System.Diagnostics.Debug.WriteLine("Exception in settings(): " + ex.Message);
                }
            }
            private void setDefaults(){
                xmlsettings.bg_artikel = defaultSettings.bg_artikel;
                xmlsettings.bg_left = defaultSettings.bg_left;
                xmlsettings.bg_main = defaultSettings.bg_main;
                xmlsettings.bg_top = defaultSettings.bg_top;
                xmlsettings.CustomIndexFile = defaultSettings.CustomIndexFile;
                xmlsettings.datenbank = defaultSettings.datenbank;
                xmlsettings.iview = defaultSettings.iview;
                xmlsettings.mainPage = defaultSettings.mainPage;
                xmlsettings.PasswortSchutzEin = defaultSettings.PasswortSchutzEin;
                xmlsettings.showTime = defaultSettings.showTime;
                xmlsettings.sortField = defaultSettings.sortField;
                xmlsettings.UseCustomIndexFile = defaultSettings.UseCustomIndexFile;
                xmlsettings.webKopf = defaultSettings.webKopf;
                xmlsettings.webRoot = defaultSettings.webRoot;
                
                xmlsettings.saveXml();
            }
            //private void setDefaults()
            //{
            //    datenbank = @"C:\Program Files\BiederDB\CDdatabase.mdb";
            //    sortField = "HGR_ID";
            //    webRoot = @"C:\Bieder.Web";
            //    webKopf = @"C:\Program Files\BiederDB\_top.htm";
            //    mainPage = @"C:\Program Files\BiederDB\_main.htm";
            //    iview = @"D:\TOOLS\irfanview\iview375.exe";
            //    showTime = 3;
            //    PasswortSchutzEin = false;
            //    CustomIndexFile = "index.htm";
            //    UseCustomIndexFile = false;
            //    bg_top = false;
            //    bg_left = false;
            //    bg_main = false;
            //    bg_artikel = false;
            //}
            public void read()
            {
                if (File.Exists(Utils.xmlSettingsFile))
                {
                    //xmlsettings = new XMLsettings();
                    try
                    {
                        xmlsettings.readXML();
                    }
                    catch (Exception ex)
                    {
                        LoggerClass.log("Exception in settings(): " + ex.Message);

                        //programShellFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                        xmlsettings.datenbank = xmlsettings.datenbank.Replace(@"C:\Program Files", programShellFolder);
                        xmlsettings.webKopf = xmlsettings.webKopf.Replace(@"C:\Program Files", programShellFolder);
                        xmlsettings.mainPage = xmlsettings.mainPage.Replace(@"C:\Program Files", programShellFolder);

                        xmlsettings.saveXml();
                    }
                }
                
            }
            public void save()
            {
                xmlsettings.saveXml();
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
        }
        /// <summary>
        /// defines default settings
        /// </summary>
        public static class defaultSettings
        {
            public static string datenbank = @"C:\Program Files\BiederDB\CDdatabase.mdb";
            public static string    sortField = "HGR_ID";
            public static string    webRoot = @"C:\Bieder.Web";
            public static string webKopf = @"C:\Program Files\BiederDB\_top.htm";
            public static string mainPage = @"C:\Program Files\BiederDB\_main.htm";
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

        }

        /// <summary>
        /// settings XML serialize/deserialize
        /// </summary>
        [Serializable]
        public class XMLsettings
        {
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

            public XMLsettings()
            {
            }

            public XMLsettings readXML()
            {
                    return deserialize(Utils.xmlSettingsFile);
            }
            public bool saveXml()
            {
                return serialize(this, Utils.xmlSettingsFile);
            }

            public static XMLsettings deserialize(string sXMLfile)
            {
                XmlSerializer xs = new XmlSerializer(typeof(XMLsettings));
                Stream stream = File.Open(Utils.xmlSettingsFile, FileMode.Open);
                XMLsettings sett = (XMLsettings)xs.Deserialize(stream);
                stream.Close();
                return sett;
            }
            public static bool serialize(XMLsettings datamodel, string sXMLfile)
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