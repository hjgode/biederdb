using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Serialization;

    public class GlobalSettings
    {
        string _appPath = "";
        public string AppPath
        {
            get { return _appPath; }
        }
        public GlobalSettings(){
            _appPath = Path.GetDirectoryName(Application.ExecutablePath);
            if(!_appPath.EndsWith(@"\"))
                _appPath+=@"\";
        }

        #region settings

        [Serializable]
        public class settings
        {
            //[XmlText(typeof(string))]
            public string   datenbank = @"c:\Program Files\BiederDB\CDdatabase.mdb";
            public string   sortField = "HGR_ID";
            public string   webRoot = @"C:\Bieder.Web";
            public string   webKopf = @"c:\Program Files\BiederDB\_top.htm";
            public string   mainPage = @"c:\Program Files\BiederDB\_main.htm";
            public string iview = @"D:\TOOLS\irfanview\iview375.exe";
            public int   showTime = 3;
            public bool     PasswortSchutzEin = false;
            public string   CustomIndexFile = "index.htm";
            public bool UseCustomIndexFile = false;
            public bool      bg_top = false;
            public bool      bg_left = false;
            public bool      bg_main = false;
            public bool      bg_artikel = false;

            [NonSerialized]
            public string der_biedermann_default = "<blockquote><p>Der Biedermann, Landhausm&ouml;bel in vielen Varianten, Gr&uuml;nstr. 6, 42103 Wuppertal, Telefon: 0202-470068, Fax: 0202/6980567<br>&Ouml;ffnungszeiten: Mo-Fr 11-18:30 Uhr, Sa 10-16 Uhr</p></blockquote>";

            [NonSerialized]
            private GlobalSettings global = new GlobalSettings();

            public settings()
            {
            }
            public settings read()
            {
                if (System.IO.File.Exists(global.AppPath + "settings.xml"))
                {
                    return deserialize(global.AppPath + "settings.xml");
                }
                else
                    return new settings();
            }
            public bool save()
            {
                try
                {
                    serialize(this, global.AppPath + "settings.xml");
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            public static settings deserialize(string sXMLfile)
            {
                GlobalSettings global = new GlobalSettings();
                XmlSerializer xs = new XmlSerializer(typeof(settings));
                Stream stream = File.Open(global.AppPath + "settings.xml", FileMode.Open);
                settings sett = (settings)xs.Deserialize(stream);
                stream.Close();
                return sett;
            }
            public static void serialize(settings datamodel, string sXMLfile)
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
