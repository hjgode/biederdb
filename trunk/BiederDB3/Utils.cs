using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Windows.Forms;

namespace BiederDB3
{
    static class Utils
    {
        static string  _appPath = "";
        public static string AppPath
        {
            get {
                if (_appPath == "")
                {
                    _appPath = Path.GetDirectoryName(Application.ExecutablePath);
                    if (!_appPath.EndsWith(@"\"))
                        _appPath += @"\";
                }
                return _appPath;
            }
        }
        static string _xmlSettingsFile = "";
        public static string xmlSettingsFile{
            get {
                if (_xmlSettingsFile == "")
                    _xmlSettingsFile = Utils.AppPath + "settings.xml";
                return _xmlSettingsFile; }
        }
        /// <summary>
        /// read the contents of a file in the application dir
        /// uses content dir if run from debug
        /// </summary>
        /// <param name="sTextFile"></param>
        /// <returns></returns>
        public static string getFileContent(string sTextFile)
        {
            string s="";
            try
            {
                string sPath = Utils.AppPath;
                if (System.Diagnostics.Debugger.IsAttached)
                    sPath += "\\content\\";
                using (StreamReader tr = new StreamReader(sPath + sTextFile))
                {
                    s = tr.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                LoggerClass.log("Exception in getFileContent() for '" + sTextFile + "'" + ": " + ex.Message);
            }
            return s;
        }
        public static bool putFileContent(string sTextFile, string sContent)
        {
            bool bRet = false;
            try
            {
                string sPath = Utils.AppPath;
                if (System.Diagnostics.Debugger.IsAttached)
                    sPath += "\\content\\";
                using (StreamWriter sw = new StreamWriter(sPath + sTextFile))
                {
                    sw.WriteLine(sContent);
                    sw.Flush();
                }
                bRet = true;
            }
            catch(Exception ex)
            {
                LoggerClass.log("Exception in putFileContent() for '" + sTextFile + "'" + ": " + ex.Message);
            }
            return bRet;
        }
        public static string replaceBRbyCR(string sIn)
        {
            string s="";
            s = sIn.Replace("<br>", "\r\n");
            s=System.Web.HttpUtility.HtmlDecode(s);
            return s;
        }
        public static string replaceCRbyBR(string sIn)
        {
            string s="";
            s = sIn.Replace("\r\n", "<br>");
            return s;
        }
        public static string specialEncode(string sIn)
        {
            string s="";
            s = sIn.Replace("ä", "&auml;");
            s = s.Replace("ö", "&ouml;");
            s = s.Replace("ü", "&uuml;");

            s = s.Replace("Ä", "&Auml;");
            s = s.Replace("Ü", "&Uuml;");
            s = s.Replace("Ö", "&Ouml;");
            
            s = s.Replace("ß", "&szlig;");

            return s;
        }
        public static string specialDecode(string sIn)
        {
            string s="";
            s = sIn.Replace ("&auml;","ä" );
            s = s.Replace   ("&ouml;","ö" );
            s = s.Replace   ("&uuml;","ü" );
                             
            s = s.Replace   ("&Auml;","Ä" );
            s = s.Replace   ("&Uuml;","Ü" );
            s = s.Replace   ("&Ouml;","Ö" );
                             
            s = s.Replace   ("&szlig;","ß");

            return s;
        }
        public static void showInfoMsg(string sText, string sTitle){
            System.Windows.Forms.MessageBox.Show(sText, sText, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
        public static void showErrorMsg(string sText, string sTitle)
        {
            System.Windows.Forms.MessageBox.Show(sText, sText, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
        }
        public static void showWarningMsg(string sText, string sTitle)
        {
            System.Windows.Forms.MessageBox.Show(sText, sText, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
        }
        /// <summary>
        /// show Yes No question
        /// returns true for yes selected
        /// </summary>
        /// <param name="sText"></param>
        /// <param name="sTitle"></param>
        /// <returns>true for yes selected</returns>
        public static bool showQuestionYesNo(string sText, string sTitle)
        {
            if (MessageBox.Show(sText, sTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return false;
            return true;
        }
    }
}
