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
                using (StreamReader tr = new StreamReader(sPath + sTextFile, Encoding.GetEncoding(1252)))
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
        public static string readFromFile(string sFile)
        {
            string s = "";
            using (StreamReader sr = new StreamReader(sFile, Encoding.GetEncoding(1252)))
            {
                String line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    s += line;
                }
            }
            return s;
        }
        public static string[] readLinesFromFile(string sFile)
        {
            string[] s;
            int iCount = 0;
            using (StreamReader sr = new StreamReader(sFile, Encoding.GetEncoding(1252)))
            {
                String line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    iCount++;
                }
            }
            s = new string[iCount];
            iCount = 0;
            using (StreamReader sr = new StreamReader(sFile, Encoding.GetEncoding(1252)))
            {
                String line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    s[iCount] = line;
                    iCount++;
                }
            }

            return s;
        }

        public static bool putFileContent(string sTextFile, string sContent)
        {
            bool bRet = false;
            try
            {
                string sPath="";
                if(!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName( sTextFile))){
                    sPath = Utils.AppPath;
                    if (System.Diagnostics.Debugger.IsAttached)
                        sPath += "\\content\\";
                }
                using (StreamWriter sw = new StreamWriter(sPath + sTextFile, false, Encoding.GetEncoding(1252)))
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

        /// <summary>
        /// check a string if is a decimal number using a comma (DE culture)
        /// </summary>
        /// <param name="sText">the string with the number inside</param>
        /// <returns>True, if number is OK</returns>
        public static bool isDecimal(ref string sText)
        {
            if (sText == ""){
                sText = "0";
                return true;
            }
            Single s1 = 0;
            Single s2 = 0;
            string sTest = "";
            bool bRet = false;
            string sParse = sText.Replace(",", ".");
            try
            {
                //try to convert to a number
                s1 = Single.Parse(sParse, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);  //this uses a dot as decimal char
                //convert back to string to test result
                sTest = s1.ToString();
                s2 = Single.Parse(sTest, System.Globalization.CultureInfo.CurrentCulture);                  //uses a comma? as decimal
                if (s1 == s2)
                {
                    sText = s2.ToString("0.00");
                    bRet = true;
                }
            }
            catch { }
            return bRet;
        }
        /// <summary>
        /// convert a decimal number string to a single value
        /// used to convert text to a DB conform single format
        /// </summary>
        /// <param name="sText"></param>
        /// <returns></returns>
        public static Single getSingle(string sText)
        {
            Single s = 0;
            try
            {
                s = Single.Parse(sText, System.Globalization.CultureInfo.CurrentCulture);
            }
            catch
            {
            }
            return s;
        }

        public static bool checkPassword()
        {
            bool bRet = false;
            FormPassword fp= new FormPassword();
            if (fp.ShowDialog() == DialogResult.OK)
                bRet = true;
            fp.Dispose();
            return bRet;
        }
        public static string Right(string s, int len)
        {
            return s.Substring(s.Length - len);
        }
        public static string EscapeHtml(string inp)
        {
            string htm="";
            int l;
		    htm = "";
		    for( l = 0; l<inp.Length; l++){
			    switch (inp[l]){// Case Mid(inp, l, 1)
				    case 'ä':
					    htm = htm + "&auml;";
                        break;
				    case 'ö':
					    htm = htm + "&ouml;";
                        break;
				    case 'ü':
					    htm = htm + "&uuml;";
                        break;
				    case 'ß':
					    htm = htm + "&szlig;";
                        break;
				    case 'Ä':
					    htm = htm + "&Auml;";
                        break;
				    case 'Ö':
					    htm = htm + "&Ouml;";
                        break;
				    case 'Ü':
					    htm = htm + "&Uuml;";
                        break;
				    case '<':
					    htm = htm + "&lt;";
                        break;
				    case '>':
					    htm = htm + "&gt;";
                        break;
				    case '\r': //Is = Chr(13)
					    htm = htm + "<br>";
                        break;
				    case '\n': //Is = Chr(10)
					    //htm = htm;
                        break;
				    case 'Ø':// Is = Chr(216)
					    htm = htm + "&Oslash;";
                        break;
				    default:
					    htm = htm + inp[l];
                        break;
			    }
		    }
		    return htm;
        }

        public static string EscapeLink(String sIn){
		    //'Wandelt Zeichen im String l in ISO-Code (zb Blank->%20)
            int i=0;
            string tmp;		
		    tmp = "";
            //tmp = System.Uri.EscapeDataString(sIn);
            //return tmp;

            byte[] bytes = Encoding.UTF8.GetBytes(sIn);
            for (i = 0; i<sIn.Length; i++){
                switch (sIn[i])
                {
                    case 'Ä':
                        tmp += "%C4";
                        break;
                    case 'ä':
                        tmp += "%E4";
                        break;
                    case 'Ö':
                        tmp += "%D6";
                        break;
                    case 'ö':
                        tmp += "%F6";
                        break;
                    case 'Ü':
                        tmp += "%DC";
                        break;
                    case 'ü':
                        tmp += "%FC";
                        break;
                    case 'ß':
                        tmp += "%DF";
                        break;
                    default:
                        tmp += sIn[i];
                        break;
                }
                //if (bytes[i] > 48 && bytes[i] <= 127)
                //{
                //    tmp += Encoding.UTF8.GetString(bytes, i, 1);
                //}
                //else
                //{
                //    if (bytes[i] > 127)
                //        tmp += "%" + string.Format("{0:x2}", Encoding.UTF8.GetString(bytes, i, 1));
                //    else
                //        tmp += Encoding.UTF8.GetString(bytes, i, 1);
                //}
            }
		    //'Ä %C4, ä %E4, Ö %D6, ö %F6, Ü %DC, ü %FC, ß %DF
		    return tmp;
        }
        public static bool isReadOnly(string sFile)
        {
            bool bRet = false;
            if (System.IO.File.Exists(sFile))
            {
                if (System.IO.File.GetAttributes(sFile) == FileAttributes.ReadOnly)
                    bRet = true;
                else
                    bRet = false;
            }
            else
                bRet = false;
            return bRet;
        }
        public static string Info_anfordern
        {
            get { return "http://cgi05.puretec.de/cgi-bin/fb_form?clsid=86ee91a0ccefec60568de1c4fd0c0460"; }
        }
        public static string Counter_htm
        {
            get { return "<img  src=" + Constants.ii + "http://cgicounter.puretec.de/cgi-bin/cnt?clsid=86ee91a0ccefec60568de1c4fd0c04601" + Constants.ii + ">"; }
        }
        public static string LoadFrameSet
        {
            get
            {
                BiederDBSettings2 _sett = new BiederDBSettings2();
                return "<script language=" + Constants.ii + "JavaScript" + Constants.ii + Constants.vbCrLf + "><!--" + 
                    Constants.vbCrLf + "if(top.frames.length < 1)" + Constants.vbCrLf + "top.location.href=" + Constants.ii + 
                    _sett.startSeite + Constants.ii + ";" + Constants.vbCrLf + "// -->" + Constants.vbCrLf + "</script>";
            }
        }
        public static string Top_Gif
        {
            get { 
                BiederDBSettings2 _sett = new BiederDBSettings2();
                return "<a href=" + Constants.ii + _sett.startSeite + Constants.ii + " target=" + Constants.ii + "_parent" + Constants.ii + "><img src=" + Constants.ii + "_topback.gif" + Constants.ii + " width=" + Constants.ii + "600" + Constants.ii + " height=" + Constants.ii + "60" + Constants.ii + " alt border=" + Constants.ii + "0" + Constants.ii + "></a><br>"; 
            }
        }
        public static string htmValue(string inp)
        {
            string sRet = Constants.ii+Constants.ii;
            if (inp != "")
                sRet = Constants.ii + inp + Constants.ii;
            return sRet;
        }
	    public static string text2htm(String inp){
            string htm="";
		    if (inp == ""){
			    htm = Constants.ii + Constants.ii;
			    return htm;
		    }
            int l;
		    htm = "";
		    for( l = 0; l<inp.Length; l++){
			    switch (inp[l]){// Case Mid(inp, l, 1)
				    case 'ä':
					    htm = htm + "&auml;";
                        break;
				    case 'ö':
					    htm = htm + "&ouml;";
                        break;
				    case 'ü':
					    htm = htm + "&uuml;";
                        break;
				    case 'ß':
					    htm = htm + "&szlig;";
                        break;
				    case 'Ä':
					    htm = htm + "&Auml;";
                        break;
				    case 'Ö':
					    htm = htm + "&Ouml;";
                        break;
				    case 'Ü':
					    htm = htm + "&Uuml;";
                        break;
				    case '<':
					    htm = htm + "&lt;";
                        break;
				    case '>':
					    htm = htm + "&gt;";
                        break;
				    case '\r': //Is = Chr(13)
					    htm = htm + "<br>";
                        break;
				    case '\n': //Is = Chr(10)
					    //htm = htm;
                        break;
				    case 'Ø':// Is = Chr(216)
					    htm = htm + "&Oslash;";
                        break;
				    default:
					    htm = htm + inp[l];
                        break;
			    }
		    }
		    return htm;
        }
        public static bool existfile(string sFile)
        {
            bool bRet = false;
            try
            {
                if (System.IO.File.Exists(sFile))
                    bRet = true;
            }
            catch (Exception)
            {
            }
            return bRet;
        }
    }
    public static class Strings
    {
        public static string Right(string s, int len)
        {
            return s.Substring(s.Length - len);
        }
        public static string Mid(string s, int iOffset, int iLen)
        {
            return s.Substring(iOffset, iLen);
        }
        public static string Left(string s, int iLen)
        {
            return s.Substring(0, iLen);
        }
    }
    public static class Conversion
    {
        public static string Hex(int iVal, int iLen)
        {
            return iVal.ToString("x"+iLen.ToString());
        }
        public static string Hex(int iVal)
        {
            return iVal.ToString("x6");
        }
        public static int Val(string hexString)
        {
            if (hexString.StartsWith("&H"))
            {
                hexString = hexString.Substring(2);
                return Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            }
            else
                return Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
        }
    }
    public static class Constants
    {
        public static string ii = "\""; 
        public static string vbCrLf="\r\n";
    }
}
