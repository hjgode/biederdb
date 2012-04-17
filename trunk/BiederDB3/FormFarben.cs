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

            farbe.read_colors();
            
            create_sample();
            WebBrowser1.Navigate(Utils.AppPath + "sample\\sample.htm");
            fillList();
        }
        void fillList()
        {
            comboColors.Items.Clear();
            for (int x = 0; x < farbe.max_colors; x++)
            {
                comboColors.Items.Insert(x, farbe.farben[x]);
            }
            comboColors.SelectedIndex = 0;
            ColorTest.BackColor = System.Drawing.ColorTranslator.FromOle(Convert.ToInt32(farbe.farben[0].rgb_Renamed));
            cname.Text = farbe.farben[0].name;
            ColorHex.Text = farbe.farben[0].html;
        }
        public void create_sample()
        {
            write_top_htm();
            System.IO.File.Copy(Utils.AppPath + "_top.htm", Utils.AppPath + "sample\\top.htm", true);
            System.IO.File.Copy(Utils.AppPath + "_topback.gif", Utils.AppPath + "sample\\_topback.gif", true);
            System.IO.File.Copy(Utils.AppPath + "_mainback.gif", Utils.AppPath + "sample\\_mainback.gif", true);
            System.IO.File.Copy(Utils.AppPath + "_lftback.gif", Utils.AppPath + "sample\\_lftback.gif", true);
            System.IO.File.Copy(Utils.AppPath + "_artback.gif", Utils.AppPath + "sample\\_artback.gif", true);
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

            using (StreamWriter sw = new StreamWriter(Utils.AppPath + "sample\\kategorie.htm", false, Encoding.GetEncoding(1252)))
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

            using (StreamWriter sw = new StreamWriter(Utils.AppPath + "sample\\artikel.htm", false, Encoding.GetEncoding(1252)))
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

            using (StreamWriter sw = new StreamWriter(Utils.AppPath + "sample\\portal.htm", false, Encoding.GetEncoding(1252)))
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

            using (StreamWriter sw = new StreamWriter(Utils.AppPath + "sample\\left.htm", false, Encoding.GetEncoding(1252)))
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
            htm = htm + "<title>Der Biedermann, Landhausm&ouml;bel in Wuppertal</title>";
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
            if (_settings.bg_top)
            {
                htm = htm + "<img src=" + Constants.ii + "_topback.gif" + Constants.ii + " alt border=" + Constants.ii + "0" + Constants.ii + "></a><br>";
            }
            else
            {
                htm = htm + "<h3>Der Biedermann</h3></a><br>";
            }
            htm = htm + "</blockquote>";
            //UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            htm = htm + _settings.Der_Biedermann;
            htm = htm + "</body>";
            htm = htm + "</html>";
            using (StreamWriter sw = new StreamWriter(Utils.AppPath + "_top.htm", false, Encoding.GetEncoding(1252)))
            {
                sw.WriteLine(htm);
            }

        }

        private void comboColors_SelectedIndexChanged(object sender, EventArgs e)
        {
		    if( comboColors.SelectedIndex == -1) 
                return;
            ColorTest.BackColor = System.Drawing.ColorTranslator.FromOle(Convert.ToInt32(farbe.farben[comboColors.SelectedIndex].rgb_Renamed));
            cname.Text = farbe.farben[comboColors.SelectedIndex].name;

        }

        private void ColorTest_DoubleClick(object sender, EventArgs e)
        {
            int i = comboColors.SelectedIndex;
            if (i == -1)
                return;
            int c = 0;
            ColorDialog cdlg = new ColorDialog();
            cdlg.Color = System.Drawing.ColorTranslator.FromOle(Convert.ToInt32(farbe.HTML2RGB(ref farbe.farben[i].html)));
            cdlg.FullOpen = true;
            if (cdlg.ShowDialog() == DialogResult.OK)
            {
                c = System.Drawing.ColorTranslator.ToOle(cdlg.Color);
                farbe.farben[i].rgb_Renamed = c;
                ColorHex.Text = farbe.RGB2HTML(c);
                farbe.farben[i].html = farbe.RGB2HTML(c);
                ColorTest.BackColor = System.Drawing.ColorTranslator.FromOle(c);
                create_sample();
                WebBrowser1.Navigate(Utils.AppPath + "sample\\sample.htm");
            }

        }

        private void bt_defaultColors_Click(object sender, EventArgs e)
        {
            if (!Utils.showQuestionYesNo("Alle Farbanpassungen verwerfen und Standardfarben laden?", "Sicherheitsfrage"))
			    return;
		    else{
                try 
	            {
                    System.IO.File.Delete(Utils.AppPath + "colors.dat");
	            }
	            catch (Exception)
	            {
	            }
			    farbe.read_colors();
                fillList();
                comboColors.SelectedIndex=0;
			    create_sample();
			    WebBrowser1.Navigate(Utils.AppPath + "sample\\sample.htm");
		    }

        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if(Utils.showQuestionYesNo("Änderungen speichern?", "Internet-Farben"))
                farbe.write_colors();
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            farbe.read_colors();
            this.Close();
        }

    }
}
