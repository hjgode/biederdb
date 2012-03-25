using System;
using System.Xml;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BiederDB3
{
	public class BiederDBSettings
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
		private genericSettings _mySettings;
		public BiederDBSettings ()
		{
			_mySettings=new genericSettings();
			_mySettings.GetSetting("datenbank", defaultSettings.datenbank);
		}
        private static class defaultSettings
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

	}
		// http://www.codeproject.com/Articles/15530/Quick-and-Dirty-Settings-Persistence-with-XML
		/*
		private void Form1_Load(object sender, EventArgs e)
		{
		  this.Top = settings.GetSetting("Form1/Top", this.Top);
		  this.Left = settings.GetSetting("Form1/Left", this.Left);
		}
		private void Form1_FormClosing(object sender, 
		                   FormClosingEventArgs e)
		{
		  settings.PutSetting("Form1/Top", this.Top);
		  settings.PutSetting("Form1/Left", this.Left);
		}
		
		This generates an XML file like this:
		Collapse | Copy Code
		
		<settings>
		  <Form1>
		    <Top>187</Top>
		    <Left>256</Left>
		  </Form1>
		</settings>
		*/
		public class genericSettings{
	    XmlDocument xmlDocument = new XmlDocument();
	    string documentPath = Utils.AppPath + "settings.xml";
	
	    public  genericSettings()
	    { try {xmlDocument.Load(documentPath);}
	      catch {xmlDocument.LoadXml("<settings></settings>");}
	    }
	
	    public int GetSetting(string xPath, int defaultValue)
	    { return Convert.ToInt16(GetSetting(xPath, Convert.ToString(defaultValue))); }
	
	    public void PutSetting(string xPath, int value)
	    { PutSetting(xPath, Convert.ToString(value)); }
	
	    public string GetSetting(string xPath,  string defaultValue)
	    { XmlNode xmlNode = xmlDocument.SelectSingleNode("settings/" + xPath );
	      if (xmlNode != null) {return xmlNode.InnerText;}
	      else { return defaultValue;}
	    }
	
	    public void PutSetting(string xPath,  string value)
	    { XmlNode xmlNode = xmlDocument.SelectSingleNode("settings/" + xPath);
	      if (xmlNode == null) { xmlNode = createMissingNode("settings/" + xPath); }
	      xmlNode.InnerText = value;
	      xmlDocument.Save(documentPath);
	    }
	
	    private XmlNode createMissingNode(string xPath)
	    { string[] xPathSections = xPath.Split('/');
	      string currentXPath = "";
	      XmlNode testNode = null;
	      XmlNode currentNode = xmlDocument.SelectSingleNode("settings");
	      foreach (string xPathSection in xPathSections)
	      { currentXPath += xPathSection;
	        testNode = xmlDocument.SelectSingleNode(currentXPath);
	        if (testNode == null)
	        {
	            currentNode.InnerXml += "<" + 
	                        xPathSection + "></" + 
	                        xPathSection + ">";
	        }
	        currentNode = xmlDocument.SelectSingleNode(currentXPath);
	        currentXPath += "/";
	      }
	      return currentNode;
	    }
		
	      public T GetSetting<T>(string xPath, T defaultValue)
          {
               XmlNode xmlNode = xmlDocument.SelectSingleNode("settings/" + xPath);
               if (xmlNode != null)
               {
                    return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(xmlNode.InnerText);
               }
               else { return defaultValue; }
          }
 
          public void PutSetting(string xPath, object value)
          {
               XmlNode xmlNode = xmlDocument.SelectSingleNode("settings/" + xPath);
               if (xmlNode == null) { xmlNode = createMissingNode("settings/" + xPath); }
               xmlNode.InnerText = TypeDescriptor.GetConverter(value.GetType()).ConvertToString(value);
               xmlDocument.Save(documentPath);
          }
		//################################################################
/*
		public T GetValueAs() {
		    if (string.IsNullOrEmpty(this.Value)) return default(T);
		    return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(this.Value);
		}
		 
		public void SetValue(object value) {
		    this.Value = TypeDescriptor.GetConverter(value.GetType()).ConvertToString(value);
		}
		//----------------------------------------------------------------
            public T GetSetting<T>(string xPath, T defaultvalue )
            {
                  string sValue = GetSetting(xPath, defaultvalue.ToString() );
                  T result= defaultvalue;
                  if( ConvertFromStringToT<T>(sValue, ref result ))
                        return result;
                  return defaultvalue;
            }
 */
            public void PutSetting<T>(string xPath, T value)
            {
                  string s="";
                  if (ConvertFromTToString<T>(out s, value))
                        PutSetting(xPath, s);
            }
 
     // From: http://www.sellsbrothers.com/news/showTopic.aspx?ixTopic=1898
     // Generics Q: Best way to convert a string to a T?
     // Comment by Chris Sells, Saturday, November 05, 2005 8:26 AM
            static private bool ConvertFromStringToT<T>(string s, ref T value)
            {
                  TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
                  if (!converter.CanConvertFrom(typeof(string)))
                  {
                        return false;
                  }
                  value = (T)converter.ConvertFrom(s);
                  return true;
            }
 
            // Adapted from ConvertFromStringToT above
            static private bool ConvertFromTToString<T>(out string s, T value)
            {
                  TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
                  if (!converter.CanConvertTo(typeof(string)))
                  {
                        s = "";
                        return false;
                  }
                  s = (string)converter.ConvertToString(value);
                  return true;
            }
	}
}

