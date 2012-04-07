using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BiederDB3
{
    public partial class FormFarben : Form
    {
        BiederDBSettings2 _settings;
        public FormFarben()
        {
            InitializeComponent();
            _settings = new BiederDBSettings2();
            
        }
        public void create_sample()
        {
            write_top_htm();
            System.IO.File.Copy(Utils.AppPath + "\\_top.htm", Utils.AppPath + "\\sample\\top.htm");
            System.IO.File.Copy(Utils.AppPath + "\\_topback.gif", Utils.AppPath + "\\sample\\_topback.gif");
            System.IO.File.Copy(Utils.AppPath + "\\_mainback.gif", Utils.AppPath + "\\sample\\_mainback.gif");
            System.IO.File.Copy(Utils.AppPath + "\\_lftback.gif", Utils.AppPath + "\\sample\\_lftback.gif");
            System.IO.File.Copy(Utils.AppPath + "\\_artback.gif", Utils.AppPath + "\\sample\\_artback.gif");
            int f = 0;
            string txt = null;
            txt = "";
            txt = txt + "<html><head><title>Testpage</title></head>" + Constants.vbCrLf;
            txt = txt + "<body bgcolor=" + Constants.ii + farbe.farben[farbe.kategorie_bgcolor].html + Constants.ii;
            txt = txt + " text=" + Constants.ii + farbe.farben[farbe.kategorie_txtcolor].html + Constants.ii;
            txt = txt + " link=" + Constants.ii + farbe.farben[farbe.kategorie_link].html + Constants.ii;
            txt = txt + " vlink=" + Constants.ii + farbe.farben[farbe.kategorie_vlink].html + Constants.ii;
            txt = txt + " alink=" + Constants.ii + farbe.farben[farbe.kategorie_alink].html + Constants.ii;
            if (_settings.bg_main)
                txt = txt + " background=" + farbe.htmValue("_mainback.gif");
            txt = txt + ">" + Constants.vbCrLf;
            txt = txt + "<h4>Kategorie Beispieltext</h4>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.kategorie_txtcolor].html + Constants.ii + ">Textfarbe</font><br>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.kategorie_link].html + Constants.ii + ">Textfarbe Link</font><br>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.kategorie_vlink].html + Constants.ii + ">Textfarbe besuchter Link</font><br>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.kategorie_alink].html + Constants.ii + ">Textfarbe aktiver Link</font><br>" + Constants.vbCrLf;
            txt = txt + "</body></html>" + Constants.vbCrLf;
            
            using (StreamWriter sw = new StreamWriter(Utils.AppPath + "\\sample\\kategorie.htm"))
            {
                sw.WriteLine(txt);
            }

            txt = "";
            txt = txt + "<html><head><title>Testpage</title></head>" + Constants.vbCrLf;
            txt = txt + "<body bgcolor=" + Constants.ii + farbe.farben[farbe.artikel_bgcolor].html + Constants.ii;
            txt = txt + " text=" + Constants.ii + farbe.farben[farbe.artikel_txtcolor].html + Constants.ii;
            if (_settings.bg_artikel)
                txt = txt + " background=" + farbe.htmValue("_artback.gif") + Constants.vbCrLf;
            txt = txt + " link=" + Constants.ii + farbe.farben[farbe.artikel_link].html + Constants.ii;
            txt = txt + " vlink=" + Constants.ii + farbe.farben[farbe.artikel_vlink].html + Constants.ii;
            txt = txt + " alink=" + Constants.ii + farbe.farben[farbe.artikel_alink].html + Constants.ii + ">" + Constants.vbCrLf;
            txt = txt + "<h4>Artikel Beispieltext</h4>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.artikel_txtcolor].html + Constants.ii + ">Textfarbe</font><br>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.artikel_link].html + Constants.ii + ">Textfarbe Link</font><br>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.artikel_vlink].html + Constants.ii + ">Textfarbe besuchter Link</font><br>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.artikel_alink].html + Constants.ii + ">Textfarbe aktiver Link</font><br>" + Constants.vbCrLf;
            txt = txt + "</body></html>" + Constants.vbCrLf;

            using (StreamWriter sw = new StreamWriter(Utils.AppPath + "\\sample\\artikel.htm"))
            {
                sw.WriteLine(txt);
            }

            txt = "";
            txt = txt + "<html><head><title>Testpage</title></head>" + Constants.vbCrLf;
            txt = txt + "<body bgcolor=" + Constants.ii + farbe.farben[farbe.portal_bgcolor].html + Constants.ii;
            txt = txt + " text=" + Constants.ii + farbe.farben[farbe.portal_txtcolor].html + Constants.ii;
            txt = txt + " link=" + Constants.ii + farbe.farben[farbe.portal_link].html + Constants.ii;
            txt = txt + " vlink=" + Constants.ii + farbe.farben[farbe.portal_vlink].html + Constants.ii;
            txt = txt + " alink=" + Constants.ii + farbe.farben[farbe.portal_alink].html + Constants.ii;
            if (_settings.bg_main)
                txt = txt + " background=" + farbe.htmValue("_mainback.gif");
            txt = txt + ">" + Constants.vbCrLf;
            txt = txt + "<h4>Portal Beispieltext</h4>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.portal_txtcolor].html + Constants.ii + ">Textfarbe</font><br>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.portal_link].html + Constants.ii + ">Textfarbe Link</font><br>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.portal_vlink].html + Constants.ii + ">Textfarbe besuchter Link</font><br>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.portal_alink].html + Constants.ii + ">Textfarbe aktiver Link</font><br>" + Constants.vbCrLf;
            txt = txt + "</body></html>" + Constants.vbCrLf;

            using (StreamWriter sw = new StreamWriter(Utils.AppPath + "\\sample\\portal.htm"))
            {
                sw.WriteLine(txt);
            }

            txt = "";
            txt = txt + "<html><head><title>Testpage</title></head>" + Constants.vbCrLf;
            txt = txt + "<body bgcolor=" + Constants.ii + farbe.farben[farbe.left_bgcolor].html + Constants.ii;
            txt = txt + " text=" + Constants.ii + farbe.farben[farbe.left_txtcolor].html + Constants.ii;
            txt = txt + " link=" + Constants.ii + farbe.farben[farbe.left_link].html + Constants.ii;
            txt = txt + " vlink=" + Constants.ii + farbe.farben[farbe.left_vlink].html + Constants.ii;
            txt = txt + " alink=" + Constants.ii + farbe.farben[farbe.left_alink].html + Constants.ii;
            if (_settings.bg_left)
                txt = txt + " background=" + farbe.htmValue("_lftback.gif");
            txt = txt + ">" + Constants.vbCrLf;

            txt = txt + "<h4>Left Beispieltext</h4>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.left_txtcolor].html + Constants.ii + ">Textfarbe</font><br>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.left_link].html + Constants.ii + ">Textfarbe Link</font><br>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.left_vlink].html + Constants.ii + ">Textfarbe besuchter Link</font><br>" + Constants.vbCrLf;
            txt = txt + "<font color=" + Constants.ii + farbe.farben[farbe.left_alink].html + Constants.ii + ">Textfarbe aktiver Link</font><br>" + Constants.vbCrLf;
                        txt = txt + "<table bgcolor=" + Constants.ii + farbe.farben[farbe.left_tbl_bgcolor].html + Constants.ii + Constants.vbCrLf;
            txt = txt + " bordercolor=" + Constants.ii + farbe.farben[farbe.left_tbl_bordercolor].html + Constants.ii + Constants.vbCrLf;
            txt = txt + " border=" + Constants.ii + "2" + Constants.ii + " + vbcrlf";
            txt = txt + " bordercolorlight=" + Constants.ii + farbe.farben[farbe.left_bordercolorlight].html + Constants.ii + Constants.vbCrLf;
            txt = txt + " bordercolordark=" + Constants.ii + farbe.farben[farbe.left_bordercolordark].html + Constants.ii + ">";
            txt = txt + " <tr><td>Tabellentext<br>Rahmenfarbe normal,<br>hell und dunkel</td></tr>" + Constants.vbCrLf;
            txt = txt + "</body></html>" + Constants.vbCrLf;
            
            using (StreamWriter sw = new StreamWriter(Utils.AppPath + "\\sample\\left.htm"))
            {
                sw.WriteLine(txt);
            }
        }
        public void write_top_htm()
        {
            string htm = null;

            htm = "<!DOCTYPE HTML PUBLIC " + Constants.ii + "-//W3C//DTD HTML 4.0 Transitional//EN" + Constants.ii + ">";
            htm = htm + "<html>";
            htm = htm + "";
            htm = htm + "<head>";
            htm = htm + "<title>Der Biedermann, Landhausmöbel in Wuppertal</title>";
            //UPGRADE_WARNING: Couldn't resolve default property of object keywords_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            htm = htm + _settings.keywords_htm;
            //NEU okt 2006
            //htm = htm + "<META NAME=" + Constants.ii + "author" + Constants.ii + "CONTENT=" + Constants.ii + "HJG" + Constants.ii + ">"
            //htm = htm + "<META NAME=" + Constants.ii + "copyright" + Constants.ii + "CONTENT=" + Constants.ii + "HJG" + Constants.ii + ">"
            //htm = htm + "<META NAME=" + Constants.ii + "keywords" + Constants.ii + "CONTENT=" + Constants.ii + "Der Biedermann, Landhausm&ouml;bel, Wuppertal, Naturholz, M&ouml;bel, Tische, Schr&auml;nke, St&uuml;hle, Bett, Stuhl, Tisch, Schrank, Kasten " + Constants.ii + ">"
            //htm = htm + "<META NAME=" + Constants.ii + "description" + Constants.ii + "CONTENT=" + Constants.ii + "Naturholzm&ouml;bel im Landhausstil " + Constants.ii + ">"
            //htm = htm + "<META NAME=" + Constants.ii + "audience" + Constants.ii + "CONTENT=" + Constants.ii + "Alle" + Constants.ii + ">"
            //htm = htm + "<META NAME=" + Constants.ii + "page-type" + Constants.ii + "CONTENT=" + Constants.ii + "Möbelhandel" + Constants.ii + ">"
            //htm = htm + "<META NAME=" + Constants.ii + "robots" + Constants.ii + "CONTENT=" + Constants.ii + "INDEX,FOLLOW" + Constants.ii + ">"
            htm = htm + "</head>";
            htm = htm + "<body bgcolor=" + Constants.ii + farbe.farben[farbe.portal_bgcolor].html + Constants.ii;
            htm = htm + " text=" + Constants.ii + farbe.farben[farbe.portal_txtcolor].html + Constants.ii;
            htm = htm + " link=" + Constants.ii + farbe.farben[farbe.portal_link].html + Constants.ii;
            htm = htm + " vlink=" + Constants.ii + farbe.farben[farbe.portal_vlink].html + Constants.ii;
            htm = htm + " alink=" + Constants.ii + farbe.farben[farbe.portal_alink].html + Constants.ii + ">" + Constants.vbCrLf;
            htm = htm + "<blockquote>";
            htm = htm + "<p><a href=" + Constants.ii + "index.htm" + Constants.ii + " target=" + Constants.ii + "_parent" + Constants.ii + ">";
            if (bg_top == 1)
            {
                htm = htm + "<img src=" + Constants.ii + "_topback.gif" + Constants.ii + " alt border=" + Constants.ii + "0" + Constants.ii + "></a><br>";
            }
            else
            {
                htm = htm + "<h3>Der Biedermann</h3></a><br>";
            }
            htm = htm + "</blockquote>";
            //UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            htm = htm + Der_Biedermann;
            htm = htm + "</body>";
            htm = htm + "</html>";
            using (StreamWriter sw = new StreamWriter(Utils.AppPath + "\\_top.htm"))
            {
                sw.WriteLine(htm);
            }

        }

    }
}
