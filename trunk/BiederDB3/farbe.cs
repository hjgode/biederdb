using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BiederDB3
{
    using Microsoft.VisualBasic;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    public static class farbe
    {
        //public farbe()
        //{
        //    read_colors();
        //}
        public struct html_farben
        {
            public string name;
            public string html;
            public int rgb_Renamed;
            public override string ToString()
            {
                return name;
            }
        }

        public static html_farben[] farben;

        public const short left_bgcolor = 0;
        public const short left_txtcolor = left_bgcolor+1;
        public const short left_link = left_bgcolor + 2;
        public const short left_vlink = left_bgcolor + 3;
        public const short left_alink = left_bgcolor + 4;
        public const short left_tbl_bgcolor = left_bgcolor + 5;
        public const short left_tbl_bordercolor = left_bgcolor + 6;
        public const short left_bordercolorlight = left_bgcolor + 7;
        public const short left_bordercolordark = left_bgcolor + 8;
        public const short portal_bgcolor = left_bgcolor + 9;
        public const short portal_txtcolor = left_bgcolor + 10;
        public const short portal_link = left_bgcolor + 11;
        public const short portal_vlink = left_bgcolor + 12;
        public const short portal_alink = left_bgcolor + 13;
        public const short kategorie_bgcolor = left_bgcolor + 14;
        public const short kategorie_txtcolor = left_bgcolor + 15;
        public const short kategorie_link = left_bgcolor + 16;
        public const short kategorie_vlink = left_bgcolor + 17;
        public const short kategorie_alink = left_bgcolor + 18;
        public const short artikel_bgcolor = left_bgcolor + 19;
        public const short artikel_txtcolor = left_bgcolor + 20;
        public const short artikel_link = left_bgcolor + 21;
        public const short artikel_vlink = left_bgcolor + 22;
        public const short artikel_alink = left_bgcolor + 23;

        public static int max_colors;
        [DllImport("oleaut32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern int OleTranslateColor(int lOleColor, int lHPalette, ref int lColorRef);

        public static int OleConvertColor(int Color)
        {
            int nColor = 0;

            OleTranslateColor(Color, 0, ref nColor);
            return nColor;
        }

        public static string RGB2HTML(int RGBColor)
        {
            string nRGBHex = null;
            string nSysColor = null;

            nRGBHex = Strings.Right("000000" + Conversion.Hex(OleConvertColor(RGBColor)), 6);
            return "#" + Strings.Right(nRGBHex, 2) + Strings.Mid(nRGBHex, 3, 2) + Strings.Left(nRGBHex, 2);
        }
        public static void write_colors()
        {
            using (StreamWriter sw = new StreamWriter(Utils.AppPath + "\\colors.dat"))
            {
                for (int i = 0; i < max_colors; i++)
                {
                    sw.WriteLine(farben[i].html);
                }
            }
        }
        public static int HTML2RGB(ref string HTMLColor)
        {
            int functionReturnValue = 0;

            if (Strings.Left(HTMLColor, 1) == "#")
            {
                functionReturnValue = (65536 * Conversion.Val("&H" + Strings.Right(HTMLColor, 2))) + (256 * Conversion.Val("&H" + Strings.Mid(HTMLColor, 4, 2))) + Conversion.Val("&H" + Strings.Mid(HTMLColor, 2, 2));
            }
            else
            {
                functionReturnValue = (65536 * Conversion.Val("&H" + Strings.Right(HTMLColor, 2))) + (256 * Conversion.Val("&H" + Strings.Mid(HTMLColor, 3, 2))) + Conversion.Val("&H" + Strings.Left(HTMLColor, 2));
            }
            return functionReturnValue;
        }
        public static void read_colors()
        {
            int i = 0;
            i = 0;
            max_colors = 30;
            farben = new html_farben[max_colors + 1];

            if (!System.IO.File.Exists(Utils.AppPath + "colors.dat"))
            {
                farben[left_bgcolor].html = "#000000";
                farben[left_txtcolor].html = "#FFFFFF";
                farben[left_link].html = "#000000";
                farben[left_vlink].html = "#000000";
                farben[left_alink].html = "#FF0000";
                farben[left_tbl_bgcolor].html = "#66CCFF";
                farben[left_tbl_bordercolor].html = "#C0C0C0";
                farben[left_bordercolorlight].html = "#0000FF";
                farben[left_bordercolordark].html = "#FF0000";
                farben[portal_bgcolor].html = "#000000";
                farben[portal_txtcolor].html = "#66CCFF";
                farben[portal_link].html = "#FFFFFF";
                farben[portal_vlink].html = "#AAAAAA";
                farben[portal_alink].html = "#FFFFFF";
                farben[kategorie_bgcolor].html = "#000000";
                farben[kategorie_txtcolor].html = "#66CCFF";
                farben[kategorie_link].html = "#FFFFFF";
                farben[kategorie_vlink].html = "#AAAAAA";
                farben[kategorie_alink].html = "#FFFFFF";
                farben[artikel_bgcolor].html = "#000000";
                farben[artikel_txtcolor].html = "#66CCFF";
                farben[artikel_link].html = "#FFFFFF";
                farben[artikel_vlink].html = "#AAAAAA";
                farben[artikel_alink].html = "#FFFFFF";

            }
            else
            {
                using (StreamReader sr = new StreamReader(Utils.AppPath + "colors.dat"))
                {
                    String line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    int j = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        farben[j].html = line;
                        farben[j].rgb_Renamed = HTML2RGB(ref farben[j].html);
                        j++;
                    }
                }
 
            }
            i = 0;
            farben[i].name = "left_bgcolor";
            i = i + 1;
            farben[i].name = "left_txtcolor";
            i = i + 1;
            farben[i].name = "left_link";
            i = i + 1;
            farben[i].name = "left_vlink";
            i = i + 1;
            farben[i].name = "left_alink";
            i = i + 1;
            farben[i].name = "left_tbl_bgcolor";
            i = i + 1;
            farben[i].name = "left_tbl_bordercolor";
            i = i + 1;
            farben[i].name = "left_bordercolorlight";
            i = i + 1;
            farben[i].name = "left_bordercolordark";
            i = i + 1;
            farben[i].name = "portal_bgcolor";
            i = i + 1;
            farben[i].name = "portal_txtcolor";
            i = i + 1;
            farben[i].name = "portal_link";
            i = i + 1;
            farben[i].name = "portal_vlink";
            i = i + 1;
            farben[i].name = "portal_alink";
            i = i + 1;
            farben[i].name = "kategorie_bgcolor";
            i = i + 1;
            farben[i].name = "kategorie_txtcolor";
            i = i + 1;
            farben[i].name = "kategorie_link";
            i = i + 1;
            farben[i].name = "kategorie_vlink";
            i = i + 1;
            farben[i].name = "kategorie_alink";
            i = i + 1;
            farben[i].name = "artikel_bgcolor";
            i = i + 1;
            farben[i].name = "artikel_txtcolor";
            i = i + 1;
            farben[i].name = "artikel_link";
            i = i + 1;
            farben[i].name = "artikel_vlink";
            i = i + 1;
            farben[i].name = "artikel_alink";
            max_colors = i;
        }
        public static double RGBofHtml(ref string s)
        {
            s = "&H" + Strings.Right(s, 6);
            return Conversion.Val(s);
        }
        public static string RGB_2_HTML(ref int l)
        {
            string nRGBHex = null;
            nRGBHex = Strings.Right("000000" + Conversion.Hex(l), 6);
            return "#" + Strings.Right(nRGBHex, 2) + Strings.Mid(nRGBHex, 3, 2) + Strings.Left(nRGBHex, 2);

        }
        public static string htmValue(string v)
        {
            string functionReturnValue = null;
            //UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            if (v==null || string.IsNullOrEmpty(v))
            {
                functionReturnValue = Constants.ii + Constants.ii;
                return functionReturnValue;
            }
            functionReturnValue = Constants.ii + v + Constants.ii;
            return functionReturnValue;
        }

    }
}
