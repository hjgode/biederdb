using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BiederDB3
{
    public partial class FormPublishForWeb : Form
    {
        bool _bListChange = false;
        bool _bAbbruch = false;
        bool _bStatus = true;
        StreamWriter swLog;

        dataclasses.Gruppentexte.gruppentext[] _gTexte;
        BiederDBSettings2 _settings;

        public FormPublishForWeb()
        {
            InitializeComponent();
            loadForm();
        }
        void loadForm()
        {
            _settings= new BiederDBSettings2();
            bt_view.Enabled = false;
            readGroups();
            Text1.Text = _settings.webKopf;
            Text2.Text = _settings.webRoot;
            Text3.Text = _settings.mainPage;
            File1._sPath = _settings.webRoot;
            loadList2();
            txt_StartSeite.Text = _settings.startSeite;
            if (txt_StartSeite.Text != "index.htm")
                Utils.showWarningMsg("Wenn Sie eine externe Datei als Hauptseite angeben, müssen Sie in diese einen Link auf die Datei 'index1.htm' einfügen, damit die generierten Webseiten erreichbar sind!", "ACHTUNG");
            farbe.read_colors();
        }

        void readGroups()
        {
            List1.Items.Clear();
            dataclasses.Gruppentexte gruppenTexte = new BiederDB3.dataclasses.Gruppentexte();
            _gTexte = gruppenTexte.getGruppenTexte();
            for (int i = 0; i < _gTexte.Length; i++)
                List1.Items.Insert(i, _gTexte[i]);

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sRemoveDoubleEntries(ListBox ctlCompare, ref ListBox ctlResult)
        {
            int iRet = 0;
            int iFindDoubleItem = 0;
            int iRemoveToCompare = 0;
            List<object> ToRemoveList = new List<object>();
            for (iRemoveToCompare = 0; iRemoveToCompare < ctlResult.Items.Count; iRemoveToCompare++)
            {
                for (iFindDoubleItem = 0; iFindDoubleItem < ctlCompare.Items.Count; iFindDoubleItem++)
                {
                    Application.DoEvents();
                    if(ctlCompare.Items[iFindDoubleItem].ToString().Equals(ctlResult.Items[iRemoveToCompare].ToString()))
                    {
                        ToRemoveList.Add(ctlResult.Items[iRemoveToCompare]);
//                        ctlResult.Items.RemoveAt(iRemoveToCompare);
                        iRet++;
                    }
                }
            }
            foreach (object oDel in ToRemoveList)
                ctlResult.Items.Remove(oDel);
            return iRet;
        }

        private void bt_copy_Click(object sender, EventArgs e)
        {
            if (List1.SelectedIndex == -1)
                return;
            List2.Items.Add(List1.SelectedItem);
        }

        private void bt_savelist_Click(object sender, EventArgs e)
        {
            string fileName = Utils.AppPath + "_publist.ini";
            dataclasses.Gruppentexte.gruppentext gText;
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding(1252)))
            {
                for (int ix = 0; ix < List2.Items.Count; ix++)
                {
                    gText = (dataclasses.Gruppentexte.gruppentext)List2.Items[ix];
                    sw.WriteLine(gText.GruppenName);
                    sw.WriteLine(gText.ID.ToString());
                }
            }
        }
        private void loadList2()
        {
            string fileName = Utils.AppPath + "_publist.ini";
            dataclasses.Gruppentexte.gruppentext gText;
            List2.Items.Clear();
            using (StreamReader sw = new StreamReader(fileName, Encoding.GetEncoding(1252)))
            {
                try
                {
                    string lineName;
                    do
                    {
                        lineName = sw.ReadLine();//gText.GruppenName
                        string lineID = sw.ReadLine();// (gText.ID.ToString());
                        if (lineID != null && lineName != null)
                        {
                            gText = new BiederDB3.dataclasses.Gruppentexte.gruppentext(lineName, int.Parse(lineID), lineName, 0);
                            List2.Items.Add(gText);
                        }
                    }while (lineName != null);
                }
                catch
                {
                }
            }
        }

        private void List2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (List2.SelectedIndex == -1)
                return;
            List2.Items.RemoveAt(List2.SelectedIndex);
            _bListChange = true;
        }

        private void List1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (List1.SelectedIndex == -1)
                return;

            if (List2.SelectedIndex == -1)
                List2.Items.Add(List1.SelectedItem);
            else
                if(List2.SelectedIndex>0)
                    List2.Items.Insert(List2.SelectedIndex - 1, List1.SelectedItem);
                else
                    List2.Items.Insert(List2.SelectedIndex, List1.SelectedItem);
            _bListChange = true;
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            _bAbbruch = false;
            //List2 enthält die zu publizierenden Kategorien
            if (List2.Items.Count == 0)
            {
                Utils.showErrorMsg("Keine Gruppe(n) gewählt", "Für Web vorbereiten");
                return;
            }
            if (chk_nur1Gruppe.Checked && List2.SelectedIndex == -1)
            {
                Utils.showErrorMsg("Sie müssen eine Gruppe auswählen", "Für Web vorbereiten");
                return;
            }
            if (!System.IO.Directory.Exists(Text2.Text))
            {
                Utils.showErrorMsg("Kann Verzeichnis '" + Text2.Text + "' nicht finden!", "Für Web vorbereiten");
                return;
            }

            txt_status.Text = "Starte...";

            //open a file to log messages
            swLog = new StreamWriter(Utils.AppPath + "_status.log", false, Encoding.GetEncoding(1252));

            int MaxArtikel;
            int ArtikelProSeite;
            string SeiteZahl, beschreibung, foto, ArtNr, foto_th;
            
            int s, AnzahlSeiten, Rest;
            int Seite;
            int Artikel;
            int nCount;

            string KategorieHtml="";
            string ArtikelHtml;
            string LeftHtml;
            string seitenliste="";

            int i;

            //string masse;
            //int NumLoops;
            //int LeftOver;
            //int file_kategorie, file_Artikel, file_left;
            //int f;
            //string tmp;
            //int p;

            //string PortalHtml="";
            string[] PortalTexte;
            string StandardText;

            bt_view.Enabled = false;
            bt_AktuellBearbeiten.Enabled = false;

            if (!status("Abbruch"))
                goto abbruch;
            weblist.Items.Clear();

            //test output path
            if (!System.IO.Directory.Exists(Text2.Text))
            {
                Utils.showErrorMsg("Fehler: Kann Verzeichnis: " + Text2.Text + "' nicht finden", "Ausgabefehler");
                goto abbruch;
            }
            if (!Text2.Text.EndsWith("\\"))
                Text2.Text += "\\";

            _bAbbruch = false;
            if (!status("Weberstellung, " +
                DateTime.Now.ToShortDateString() +
                DateTime.Now.ToShortTimeString()))
                goto abbruch;

            bt_start.Enabled = false;
            bt_close.Enabled = false;
            bt_cancel.Enabled = true;

            if (chk_nur1Gruppe.Checked)
            {
                if (!status("Erstelle nur Dateien für die Gruppe: '" + List2.SelectedItem.ToString() + "' neu"))
                    goto abbruch;
            }
            else
            {
                //'Index-, Main- und Top-Datei kopieren
                DateiKopie(Utils.AppPath + "_topback.gif", Text2.Text + "_topback.gif");
                DateiKopie(Utils.AppPath + "_lftback.gif", Text2.Text + "_lftback.gif");
                DateiKopie(Utils.AppPath + "_mainback.gif", Text2.Text + "_mainback.gif");
                DateiKopie(Utils.AppPath + "_artback.gif", Text2.Text + "_artback.gif");
                DateiKopie(Utils.AppPath + "_weg.gif", Text2.Text + "_weg.gif");
                //'DateiKopie Utils.AppPath + "logo-falk.gif", Text2.text + "logo-falk.gif"
                DateiKopie(Utils.AppPath + "_index.htm", Text2.Text + _settings.startSeite);
                DateiKopie((Text3.Text), Text2.Text + "_main.htm");
                DateiKopie((Text1.Text), Text2.Text + "_top.htm");
                DateiKopie(Utils.AppPath + "_weg.htm", Text2.Text + "_weg.htm");
                //'Die linke Seite sollte mit dem Start-Link anfangen
                //'danach alle Kategorien listen. Das bedeutet eine index.htm, eine left.htm,
                //'eine main.htm, eine top.htm,

                //left
                LeftHtml = "";
                LeftHtml = "<html>" + "\r\n" + "<head>" + "\r\n" + "<title>" + "Der Biedermann - Landhausmöbel in Wuppertal" + "</title>" + "\r\n";
                LeftHtml = LeftHtml + "<meta http-equiv=" + "\"" + "Content-Type" + "\"" + " content=" + "\"" + "text/html; charset=ISO-8859-1" + "\"" + ">" + "\r\n";
                LeftHtml = LeftHtml + "<meta name=" + "\"" + "GENERATOR" + "\"" + " content=" + "\"" + "bieder.db (c)HJ Gode" + "\"" + ">" + "\r\n";
                LeftHtml = LeftHtml + _settings.keywords_htm + "\r\n" + "</head>";
                LeftHtml = LeftHtml + "<body bgcolor=" + "\"" + farbe.farben[farbe.left_bgcolor].html + "\"" + " text=" + "\"" + farbe.farben[farbe.left_txtcolor].html + "\"";
                if (_settings.bg_left)
                    LeftHtml = LeftHtml + " background=" + "\"" + "_lftback.gif" + "\"";
                LeftHtml = LeftHtml + " link=" + "\"" + farbe.farben[farbe.left_link].html + "\"";
                LeftHtml = LeftHtml + " vlink=" + "\"" + farbe.farben[farbe.left_vlink].html + "\"";
                LeftHtml = LeftHtml + " alink=" + "\"" + farbe.farben[farbe.left_alink].html + "\"" + ">" + "\r\n";

                //'Start-Link
                LeftHtml = LeftHtml + "<table bgcolor=" + "\"" + farbe.farben[farbe.left_tbl_bgcolor].html + "\"";
                LeftHtml = LeftHtml + " bordercolor=" + "\"" + farbe.farben[farbe.left_tbl_bordercolor].html + "\"";
                LeftHtml = LeftHtml + " border=" + farbe.htmValue("2");
                LeftHtml = LeftHtml + " bordercolorlight=" + "\"" + farbe.farben[farbe.left_bordercolorlight].html + "\"";
                LeftHtml = LeftHtml + " bordercolordark=" + "\"" + farbe.farben[farbe.left_bordercolordark].html + "\"" + ">" + "\r\n";
                LeftHtml = LeftHtml + "<tr><td align=" + farbe.htmValue("center") + "><a href=" + farbe.htmValue(_settings.startSeite) + " target=" + farbe.htmValue("_parent") + ">" + "START" + "</a><br></td></tr>" + "\r\n" +
                    "<tr><td align=" + farbe.htmValue("center") + "><a href=" + farbe.htmValue("aktuell.htm") + " target=" + farbe.htmValue("main") + ">" + "Aktuelles" + "</a><br></td></tr>" + "\r\n";

                if (System.IO.File.Exists(Utils.AppPath + "stdgrp.txt"))
                {
                    string[] sInput = Utils.readLinesFromFile(Utils.AppPath + "stdgrp.txt");
                    StandardText = "";
                    for (int x = 0; x < sInput.Length; x++)
                        StandardText = Text2.Text + sInput[x] + Constants.vbCrLf;
                }
                else
                {
                    StandardText = "Auf den Produktübersichtseiten finden Sie im oberen Bereich Zahlen für die einzelnen Seiten." +
                        Constants.vbCrLf +
                        "Klicken Sie auf die Seitenzahlen, um zwischen den Seiten zu wechseln." + Constants.vbCrLf +
                        "Die Produktübersichtseiten enthalten kleine Abbildungen und Texte dazu." + Constants.vbCrLf +
                        "Klicken Sie auf eine Abbildung, um das Produktbild zu vergrössern.";
                }

                //'Portal-Texte lesen
                PortalTexte = new string[List2.Items.Count];
                dataclasses.Gruppentexte _gruppen = new BiederDB3.dataclasses.Gruppentexte();
                for (int i1 = 0; i1 < List2.Items.Count; i1++)
                {
                    dataclasses.Gruppentexte.gruppentext _gText = (dataclasses.Gruppentexte.gruppentext)List2.Items[i1];
                    PortalTexte[i1] = _gText.Gruppentext;

                    //snap = db.CreateSnapshot("select Produkttext from HoofdGroep where hgr_id = " & VB6.GetItemData(List2, i))
                    //If (IsDBNull(snap.Fields("Produkttext").Value)) Then
                    //    PortalTexte(i) = text2htm(StandardText)
                    //Else
                    //    PortalTexte(i) = text2htm(snap.Fields("Produkttext").Value.ToString())
                    //End If
                }
                //'Portal-Texte lesen ENDE

                for (i = 0; i < List2.Items.Count; i++)
                {

                    if (!status("Lefthtm: Erstelle Link für: " + List2.Items[i].ToString()))
                        goto abbruch;
                    //'Jeweils Link auf erste Artikelseite (zB betten00.htm) erstellen
                    //'NEU: Jetzt auf die Portalseiten gelinkt
                    LeftHtml = LeftHtml + "<tr><td align=" + Constants.ii + "center" + Constants.ii +
                        "><a href=" + Constants.ii + Utils.EscapeLink(List2.Items[i].ToString()) + ".htm" + Constants.ii +
                            " target=" + Constants.ii + "main" + Constants.ii + ">" + Utils.text2htm(List2.Items[i].ToString()) +
                            "</a><br></td></tr>" + Constants.vbCrLf;
                    //'Portalseiten für Produktgruppen (betten.htm etc.) erstellen
                    if (!status("PortalHtml: Erstelle Portalseite für: " + List2.Items[i].ToString()))
                        goto abbruch;

                    string PortalHtml = "";
                    PortalHtml = "<html>" + Constants.vbCrLf + "<head>" + Constants.vbCrLf +
                        "<title>" + Utils.text2htm(List2.Items[i].ToString()) + " - Der Biedermann - Landhausm&ouml;bel in Wuppertal" + "</title>" +
                        Constants.vbCrLf;
                    PortalHtml = PortalHtml + "<meta http-equiv=" + Constants.ii + "Content-Type" + Constants.ii +
                        " content=" + Constants.ii + "text/html; charset=ISO-8859-1" + Constants.ii + ">" + Constants.vbCrLf;
                    PortalHtml = PortalHtml + "<meta name=" + Constants.ii + "GENERATOR" + Constants.ii +
                        " content=" + Constants.ii + "bieder.db (c)HJ Gode" + Constants.ii + ">" + Constants.vbCrLf;
                    PortalHtml = PortalHtml + _settings.keywords_htm + "</head>" + Constants.vbCrLf;
                    PortalHtml = PortalHtml + "<body bgcolor=" + Utils.htmValue(farbe.farben[farbe.portal_bgcolor].html) +
                        " text=" + Utils.htmValue(farbe.farben[farbe.portal_txtcolor].html);

                    if (_settings.bg_main)
                        PortalHtml = PortalHtml + " background=" + Utils.htmValue("_mainback.gif");

                    //'link="#FFFFFF" vlink="#00FF00" alink="#FF00FF"
                    PortalHtml = PortalHtml + " link=" + Constants.ii + farbe.farben[farbe.portal_link].html + Constants.ii;
                    PortalHtml = PortalHtml + " vlink=" + Constants.ii + farbe.farben[farbe.portal_vlink].html + Constants.ii;
                    PortalHtml = PortalHtml + " alink=" + Constants.ii + farbe.farben[farbe.portal_alink].html + Constants.ii + ">" +
                        Constants.vbCrLf;
                    PortalHtml = PortalHtml + "<h2>" + "Produktgruppe: " + Utils.text2htm(List2.Items[i].ToString()) + Constants.vbCrLf;
                    PortalHtml = PortalHtml + "<small>[<a href=" + Constants.ii +
                        Utils.EscapeLink(List2.Items[i].ToString()) +
                        "00.htm" + Constants.ii + " target=" + Constants.ii + "main" + Constants.ii + ">" +
                        "Weiter zu den Produkten</a>]</small>" + "</h2>";
                    PortalHtml = PortalHtml + "<b>" + Utils.EscapeHtml(PortalTexte[i]) + "</b>" + Constants.vbCrLf;
                    PortalHtml = PortalHtml + Utils.LoadFrameSet + Constants.vbCrLf;
                    PortalHtml = PortalHtml + "</body>" + Constants.vbCrLf + "</html>";

                    if (Utils.isReadOnly(Text2.Text + List2.Items[i].ToString() + ".htm"))
                    {
                        if (!status("PortalHtml: Portalseite für: " + List2.Items[i].ToString() + " ist schreibgeschützt!"))
                            goto abbruch;
                    }
                    else
                    {
                        Utils.putFileContent(Text2.Text + List2.Items[i].ToString() + ".htm", PortalHtml);
                        weblist.Items.Add(List2.Items[i].ToString() + ".htm");
                    }
                }//for 
                //'Nun der Link für die Wegbeschreibung
                if (!status("Lefthtm: Erstelle Link für: Wegbeschreibung"))
                    goto abbruch;
                LeftHtml = LeftHtml + "<tr><td align=" + Constants.ii + "center" + Constants.ii + "><a href=" + Constants.ii + "_weg.htm" + Constants.ii + " target=" + Constants.ii + "main" + Constants.ii + ">" + "Wegbeschreibung" + "</a><br></td></tr>" + Constants.vbCrLf;

                //'Nun der Link für Infos und Webmaster
                if (!status("Lefthtm: Erstelle Link für: Info"))
                    goto abbruch;
                LeftHtml = LeftHtml + "<tr><td align=" + Utils.htmValue("center") + "><a href=" + Constants.ii + Utils.Info_anfordern + Constants.ii + " target=" + Constants.ii + "main" + Constants.ii + ">" + "Infos anfordern" + "<br></a></td></tr>" + Constants.vbCrLf + "<tr><td align=" + Utils.htmValue("center") + "><small><a href=" + Constants.ii + "mailto:webmaster@derbiedermann.de" + Constants.ii + "><i>Mail an Webmaster</i></a></small></td></tr>" + Constants.vbCrLf;

                //'Counter und ENDE Lefthtml
                if (!status("Lefthtm: Erstelle Link für: Counter"))
                    goto abbruch;
                LeftHtml = LeftHtml + "</table><br>" + Utils.Counter_htm + "<br><small>Letze &Auml;nderung: " + DateTime.Now.ToShortDateString() + "</small>";
                LeftHtml = LeftHtml + Utils.LoadFrameSet + Constants.vbCrLf + "</body>" + Constants.vbCrLf + "</html>";

                if (Utils.isReadOnly(Text2.Text + "_left.htm"))
                {
                    if (!status("Datei: " + Text2.Text + "_left.htm ist schreibgeschützt!"))
                        goto abbruch;
                }
                else
                {
                    Utils.putFileContent(Text2.Text + "_left.htm", LeftHtml);
                    weblist.Items.Add("_left.htm");
                }

            }//nur 1 gruppe

            ArtikelProSeite = 12;
            SeiteZahl = ((int)0).ToString("00");

            for (i = 0; i < List2.Items.Count; i++)
            {
                //'Wenn nur1Gruppe und i nicht der gewählte Eintrag ist, überspringe alles
                if (chk_nur1Gruppe.Checked && List2.SelectedIndex != i)
                    continue;// goto ExitFor_i;
                dataclasses.Artikel _art = new BiederDB3.dataclasses.Artikel();
                dataclasses.Artikel.artikel[] _artikel = _art.selectArtikel("select * from artikel where hgr_id=" + ((dataclasses.Gruppentexte.gruppentext)(List2.Items[i])).ID.ToString() + " AND Besteld > 0 order by ArtNr");
                MaxArtikel = _artikel.Length;

                if (MaxArtikel == 0)
                {
                    if (!status("Kein Artikel vorhanden, Überspringe Kategorie: " + List2.Items[i].ToString()))
                        goto abort;
                    continue;// goto ExitFor_i;
                }
                int iCurrentArtikel = 0;
                dataclasses.Artikel.artikel _currentArtikel = _artikel[iCurrentArtikel];
                //'Wieviele Ãœbersichtseiten brauchen wir
                AnzahlSeiten = MaxArtikel / ArtikelProSeite;
                //'Gibt es einen Rest?
                Rest = MaxArtikel % ArtikelProSeite;
                if (Rest > 0)
                    AnzahlSeiten = AnzahlSeiten + 1;

                for (Seite = 0; Seite < AnzahlSeiten; Seite++)
                {
                    //'For n=0 to MaxArtikel
                    //'KategorieHtml enthält Artikel-Ãœbersicht
                    KategorieHtml = "";
                    KategorieHtml = "<html>" + Constants.vbCrLf + "<head>" + Constants.vbCrLf + "<title>" + "Der Biedermann - Landhausmöbel in Wuppertal" + "</title>" + Constants.vbCrLf;

                    KategorieHtml = KategorieHtml + "<meta http-equiv=" + Constants.ii + "Content-Type" + Constants.ii + " content=" + Constants.ii + "text/html; charset=ISO-8859-1" + Constants.ii + ">" + Constants.vbCrLf;
                    KategorieHtml = KategorieHtml + "<meta name=" + Constants.ii + "GENERATOR" + Constants.ii + " content=" + Constants.ii + "bieder.db (c)HJ Gode" + Constants.ii + ">" + Constants.vbCrLf;
                    KategorieHtml = KategorieHtml + _settings.keywords_htm + "</head>" + Constants.vbCrLf;
                    KategorieHtml = KategorieHtml + "<body bgcolor=" + Utils.htmValue(farbe.farben[farbe.kategorie_bgcolor].html) + " text=" + Utils.htmValue(farbe.farben[farbe.kategorie_txtcolor].html);
                    if (_settings.bg_main)
                    {
                        KategorieHtml = KategorieHtml + " background=" + Utils.htmValue("_mainback.gif");
                    }
                    //'link="#FFFFFF" vlink="#00FF00" alink="#FF00FF"
                    KategorieHtml = KategorieHtml + " link=" + Constants.ii + farbe.farben[farbe.kategorie_link].html + Constants.ii;
                    KategorieHtml = KategorieHtml + " vlink=" + Constants.ii + farbe.farben[farbe.kategorie_vlink].html + Constants.ii;
                    KategorieHtml = KategorieHtml + " alink=" + Constants.ii + farbe.farben[farbe.kategorie_alink].html + Constants.ii + ">" + Constants.vbCrLf;
                    KategorieHtml = KategorieHtml + "<h2>" + Utils.text2htm(List2.Items[i].ToString()) + "</h2>" + Constants.vbCrLf + "<p align=" + Utils.htmValue("right") + "<small>Gesamtartikel " + MaxArtikel.ToString() + ", " + DateTime.Now.ToShortDateString() + "</small></p>";


                    //'Seiten Link-Listenzeile
                    seitenliste = "";

                    for (s = 0; s < AnzahlSeiten; s++)
                    {
                        if (s == Seite)
                        {
                            seitenliste = seitenliste + "Seite " + s.ToString("00") + " - ";
                        }
                        else
                        {
                            seitenliste = seitenliste + "<a href=" + Constants.ii + Utils.EscapeLink(List2.Items[i].ToString()) + s.ToString("00") + ".htm" + Constants.ii + ">Seite " + s.ToString("00") + "</a> - ";
                        }//if rest
                    }//Next s

                    KategorieHtml = KategorieHtml + seitenliste;
                    KategorieHtml = KategorieHtml + "<br><hr>" + Constants.vbCrLf + "<Table>" + Constants.vbCrLf;// 'Tabelle
                    KategorieHtml = KategorieHtml + "<TR valign=" + Constants.ii + "top" + Constants.ii + ">" + Constants.vbCrLf;// 'Neue Zeile
                    //'Jeweils x Artikel pro Seite
                    nCount = 1;
                    for (Artikel = 0; Artikel < ArtikelProSeite; Artikel++)
                    {
                        if (Seite * ArtikelProSeite + Artikel > MaxArtikel)
                            goto ExitFor_Artikel;
                        if (_currentArtikel.Omschrijving != "")
                            beschreibung = _currentArtikel.Omschrijving;
                        else
                            beschreibung = "-";

                        //'If Not IsNull(snap.Fields("Maat")) Then
                        //'    masse = text2htm("MaÃŸe: ") + text2htm(snap.Fields("Maat"))
                        //'Else
                        //'    masse = text2htm("MaÃŸe: -")
                        //'End If
                        if (_currentArtikel.ArtNr != "")
                            ArtNr = Utils.text2htm(_currentArtikel.ArtNr);
                        else
                            ArtNr = "-";
                        
                        //FOTO
                        if (_currentArtikel.Foto != "")
                            foto = _currentArtikel.Foto;
                        else
                            foto = "";
                        //'Foto im Zielverzeichnis nicht vorhanden?
                        if (Utils.existfile(Text2.Text + GetFilename(foto)) == false) //GetExtension returns extension including a dot
                        {
                            if (Utils.existfile(foto))
                            {
                                if (status("Kopiere " + foto) == false)
                                    goto abort;
                                //copy original file
                                DateiKopie(foto, Text2.Text + GetFilename(foto));
                            }
                            if (status("Foto-Datei nicht gefunden: " + foto) == false)
                                goto abort;
                        }
                        else
                        {
                            if (status("Foto-Datei schon im Zielverzeichnis: " + foto) == false)
                                goto abort;

                        }
                        foto = System.IO.Path.GetFileName(_currentArtikel.Foto);
                        foto_th = System.IO.Path.GetFileNameWithoutExtension(_currentArtikel.Foto) + "_th.jpg";
                        weblist.Items.Add(foto);
                        weblist.Items.Add(foto_th);
                        //'Thumbnail schon da? sonst erstellen
                        if (Utils.existfile(Text2.Text + foto_th) == false)
                        {
                            if (status("Erstelle Thumbnail: " + foto_th) == false)
                                goto abort;
                            if (createThumbnail(foto, foto_th, Text2.Text) == false)
                            {
                                if (status("Thumbnail Erstellung fehlgeschlagen: " + foto_th) == false)
                                    goto abort;
                            }
                        }
                        else
                        {
                            if (status("Thumbnail schon vorhanden: " + foto_th) == false)
                                goto abort;
                        }

                        //'Pro Artikel eine Datei mit Grossbild anlegen
                        ArtikelHtml = "";
                        ArtikelHtml = "<html>" + Constants.vbCrLf + "<head>" + Constants.vbCrLf + "<title>" + "Der Biedermann - Landhausmöbel in Wuppertal" + "</title>" + Constants.vbCrLf;
                        ArtikelHtml = ArtikelHtml + "<meta http-equiv=" + Constants.ii + "Content-Type" + Constants.ii + " content=" + Constants.ii + "text/html; charset=ISO-8859-1" + Constants.ii + ">" + Constants.vbCrLf;
                        ArtikelHtml = ArtikelHtml + "<meta name=" + Constants.ii + "GENERATOR" + Constants.ii + " content=" + Constants.ii + "bieder.db (c)HJ Gode" + Constants.ii + ">" + Constants.vbCrLf;
                        ArtikelHtml = ArtikelHtml + _settings.keywords_htm + "</head>" + Constants.vbCrLf;
                        ArtikelHtml = ArtikelHtml + "<body bgcolor=" + Utils.htmValue(farbe.farben[farbe.artikel_bgcolor].html) + " text=" + Utils.htmValue(farbe.farben[farbe.artikel_txtcolor].html);
                        if (_settings.bg_artikel)
                            ArtikelHtml = ArtikelHtml + " background=" + Utils.htmValue("_artback.gif") + Constants.vbCrLf;

                        ArtikelHtml = ArtikelHtml + " link=" + Constants.ii + farbe.farben[farbe.artikel_link].html + Constants.ii + " vlink=" + Constants.ii + farbe.farben[farbe.artikel_vlink].html + Constants.ii + " alink=" + Constants.ii + farbe.farben[farbe.artikel_alink].html + Constants.ii + ">" + Constants.vbCrLf;
                        if (_settings.bg_top)
                            ArtikelHtml = ArtikelHtml + Utils.Top_Gif + _settings.Der_Biedermann;
                        else
                            ArtikelHtml = ArtikelHtml + "<h1>Der Biedermann</h1><br>" + Constants.vbCrLf + _settings.Der_Biedermann;

                        ArtikelHtml = ArtikelHtml + "<h2>" + List2.Items[i].ToString() + "</h2><h3>ArtNr: " + ArtNr + "</h3>";
                        ArtikelHtml = ArtikelHtml + beschreibung + "<br>" + Constants.vbCrLf;
                        //'ArtikelHtml = ArtikelHtml + masse + "<br><hr>" + Constants.vbCrLf
                        ArtikelHtml = ArtikelHtml + "<hr>" + Constants.vbCrLf;
                        ArtikelHtml = ArtikelHtml + "<img src=" + Constants.ii + Utils.EscapeLink(foto) + Constants.ii + " width=640 height=480>";
                        //'<img border="0" src="bedden/bed601-bed606+bed674.jpg" width="640" height="480">
                        ArtikelHtml = ArtikelHtml + "</body>" + Constants.vbCrLf + "</html>";
                        if (Utils.isReadOnly(Text2.Text + ArtNr + ".htm") == false)
                        {
                            Utils.putFileContent(Text2.Text + ArtNr + ".htm", ArtikelHtml);
                            if (status("Schreibe Html für: " + ArtNr) == false)
                                goto abort;
                        }
                        else
                        {
                            if (status("Html für: " + ArtNr + " ist schreibgeschützt!") == false)
                                goto abort;
                        }
                        weblist.Items.Add((ArtNr + ".htm"));
                        KategorieHtml = KategorieHtml + "<TD width=" + Utils.htmValue("25%") + ">" + Constants.vbCrLf;
                        KategorieHtml = KategorieHtml + "<a href=" + Constants.ii + Utils.EscapeLink(ArtNr) + ".htm" + Constants.ii + " target=" + Constants.ii + "ZOOM" + Constants.ii + ">" + ArtNr + "<br>";
                        KategorieHtml = KategorieHtml + "<img src=" + Constants.ii + Utils.EscapeLink(foto_th) + Constants.ii + " width=160 height=120></a><br>";
                        KategorieHtml = KategorieHtml + beschreibung + "<br>" + Constants.vbCrLf;

                        //'KategorieHtml = KategorieHtml + masse + "<br>" + Constants.vbCrLf
                        KategorieHtml = KategorieHtml + "</TD>" + Constants.vbCrLf;
                        //'Neue Tabellenzeile alle 4 spalten
                        if (nCount % 4 == 0)
                            KategorieHtml = KategorieHtml + "</TR>" + Constants.vbCrLf + "<TR valign=" + Constants.ii + "top" + Constants.ii + ">" + Constants.vbCrLf;
                        nCount = nCount + 1;
                        //snap.MoveNext()
                        iCurrentArtikel++;
                        if (iCurrentArtikel > MaxArtikel-1)
                            continue;
                        else
                            _currentArtikel = _artikel[iCurrentArtikel];
                    }//Next artikel
ExitFor_Artikel:
                    KategorieHtml = KategorieHtml + "</TR></Table>" + "<hr>" + seitenliste + "<br>" + Utils.LoadFrameSet + Constants.vbCrLf + "</body>" + Constants.vbCrLf + "</html>";
                    //'Datei schreibgeschützt?
                    if (Utils.isReadOnly(Text2.Text + List2.Items[i].ToString() + Seite.ToString("00") + ".htm") == false)
                    {
                        Utils.putFileContent(Text2.Text + List2.Items[i].ToString() + Seite.ToString("00") + ".htm", KategorieHtml);
                        if (status("Schreibe Webseite " + Text2.Text + List2.Items[i].ToString() + Seite.ToString("00") + ".htm") == false)
                            goto abort;
                    }
                    else
                    {
                        if (status("Webseite " + Text2.Text + List2.Items[i].ToString() + Seite.ToString("00") + ".htm ist schreibgeschützt!") == false)
                            goto abort;
                    }
                    weblist.Items.Add((List2.Items[i].ToString() + Seite.ToString("00") + ".htm"));
                }//Next Seite
            }//Next i xxx
        //'For n = 1 To NumLoops 'Für jede Seite je 12 Artikel

        if (status("FERTIG, " + DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToShortTimeString()) == false)
            goto abort;
        //'je eine kategorie_x.htm und zu jedem Artikel eine artikel_x.htm
        //'mit Grossbild und Text
        //'Für jede Kategorie muss eine Indexdatei mit den Thumbnails erstellt werden
        //'Alle Quelldateien müssen nach WebRoot kopiert werden
        //'Für jedes Bild muss das Thumbnail ermittelt werden
        //'Für jedes Thumbnail muss eine HTM-Datei mit dem Grossbild und dem Text generiert werden

    abort:
    abbruch:
        if(chk_cleanwebdir.Enabled && chk_cleanwebdir.Checked)
            CleanWebDir();
        bt_start.Enabled = true;
        bt_close.Enabled = true;
        bt_cancel.Enabled = false;
        bt_view.Enabled = true;
        bt_AktuellBearbeiten.Enabled = true;
        swLog.Close();

        }//BT_Start

        void DateiKopie(string sSrc, string sTrg){
            try{
                status("Kopiere '" + sSrc +"' nach '" + sTrg +"'");
                System.IO.File.Copy(sSrc, sTrg, true);
                weblist.Items.Add(System.IO.Path.GetFileName(sTrg));
            }
            catch(Exception ex){
                status("Kopieren fehlgeschlagen! " +ex.Message);
            }
        }

        string GetFilenameWithoutExt(string sFile)
        {
            return System.IO.Path.GetFileNameWithoutExtension(sFile);
        }
        /// <summary>
        /// returns file name and extension of file path
        /// </summary>
        /// <param name="sFile"></param>
        /// <returns></returns>
        string GetFilename(string sFile){
            return System.IO.Path.GetFileName(sFile);
        }
        string GetExtension(string sFile){
            return System.IO.Path.GetExtension(sFile);
        }

        bool status(String s)
        {
            Application.DoEvents();
            if (_bAbbruch)
            {
                txt_status.Text="Abbruch durch Anwender";
                LoggerClass.log("Abbruch durch Anwender");
                _bStatus = false;
                return false;
            }
            txt_status.Text = s;
            if (swLog != null)
            {
                swLog.WriteLine(s);
                LoggerClass.log(s);
                swLog.Flush();
            }
            return true;
        }
        private bool createThumbnail(string sFileIn, string sFileThumb, string sFolder){
            bool bRet = false;
            try
            {
                Bitmap original = (Bitmap)Image.FromFile(sFolder + sFileIn, true);
                int newWidth = original.Width / 4;
                int newHeight = original.Height / 4;
                Bitmap scaled = new Bitmap(newWidth, newHeight);
                using (Graphics graphics = Graphics.FromImage(scaled))
                {
                    graphics.DrawImage(original, new Rectangle(0, 0, scaled.Width, scaled.Height));
                    original.Save(sFolder + sFileThumb, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                bRet = true;
                LoggerClass.log("Success in createThumbnail: " + "FileIn=" + sFileIn + ", FileOut=" + sFileThumb + " ,Folder=" + sFolder);
            }
            catch (OutOfMemoryException ex)
            {
                System.Diagnostics.Debug.WriteLine("OutOfMemoryException in createThumbnail: " + ex.Message + "FileIn=" + sFileIn + ", FileOut=" + sFileThumb + " ,Folder=" + sFolder);
                LoggerClass.log("OutOfMemoryException in createThumbnail: " + ex.Message + "FileIn=" + sFileIn + ", FileOut=" + sFileThumb + " ,Folder=" + sFolder);
            }
            catch (FileNotFoundException ex)
            {
                System.Diagnostics.Debug.WriteLine("FileNotFoundException in createThumbnail: " + ex.Message + "FileIn=" + sFileIn + ", FileOut=" + sFileThumb + " ,Folder=" + sFolder);
                LoggerClass.log("FileNotFoundException in createThumbnail: " + ex.Message + "FileIn=" + sFileIn + ", FileOut=" + sFileThumb + " ,Folder=" + sFolder);
            }
            catch (ArgumentException ex)
            {
                System.Diagnostics.Debug.WriteLine("ArgumentException in createThumbnail: " + ex.Message + "FileIn=" + sFileIn + ", FileOut=" + sFileThumb + " ,Folder=" + sFolder);
                LoggerClass.log("ArgumentException in createThumbnail: " + ex.Message + "FileIn=" + sFileIn + ", FileOut=" + sFileThumb + " ,Folder=" + sFolder);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception in createThumbnail: " + ex.Message + "FileIn=" + sFileIn + ", FileOut=" + sFileThumb + " ,Folder=" + sFolder);
                LoggerClass.log("Exception in createThumbnail: " + ex.Message + "FileIn=" + sFileIn + ", FileOut=" + sFileThumb + " ,Folder=" + sFolder);
            }
            return bRet;
        }
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            
            _bAbbruch = true;
        }

        private void CleanWebDir(){
            int i;
		    filesList.Items.Clear();
            if(status("Erstelle Dateiliste WebRoot...") == false)
                return;

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
		    for (i = 0; i < File1.Items.Count; i++){
			    filesList.Items.Add((File1.Items[i]));
		    }
		    //'If status("Erstelle Dateiliste WebRoot..." & File1.ListCount - 1 + " Dateien") = False Then Exit Sub
		    this.Refresh();
		    //'If status("Suche überzählige Dateien...") = False Then Exit Sub
		    this.Refresh();
		    System.Windows.Forms.Application.DoEvents();
		    sRemoveDoubleEntries(weblist, ref filesList);
    		
		    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
		    if (filesList.Items.Count == 0){
			    Utils.showInfoMsg("Es wurden keine überzähligen Dateien gefunden!", "Dubletten suchen");
			    return;
		    }
            if (Utils.showQuestionYesNo("Es wurden " + filesList.Items.Count + " überzählige Dateien gefunden." + Constants.vbCrLf + "Sollen diese jetzt aus dem Webverzeichnis gelöscht werden?", "Webverzeichnis bereinigen") ){
                if (Utils.showQuestionYesNo ("Wollen Sie die Dateien wirklich löschen?", "Überzählige Dateien löschen") ) {
                    //'On Error Resume Next
                    for (i = 0; i< filesList.Items.Count;i++){
                        Application.DoEvents();
                        string sPath = _settings.webRoot;
                        if(!sPath.EndsWith("\\"))
                            sPath+="\\";
                        try
                        {
                            System.IO.File.Delete(sPath + filesList.Items[i].ToString());
                            LoggerClass.log("CleanWeb(): '" + sPath + filesList.Items[i].ToString() + "' gelöscht");
                        }catch(Exception){
                             LoggerClass.log("CleanWeb(): '" + sPath + filesList.Items[i].ToString() + "' konnte nicht gelöscht werden!");
                       }
                        //'filesList.RemoveItem (i)
                        if (status("Lösche " + filesList.Items[i].ToString()) == false )
                            return;
                    }
                }
            }

        }

        private void bt_auf_Click(object sender, EventArgs e)
        {
            if (List2.SelectedIndex < 1)
                return;
            object oOld = List2.SelectedItem;
            int iOldIndex = List2.SelectedIndex;
            List2.Items.RemoveAt(iOldIndex);
            List2.Items.Insert(iOldIndex - 1, oOld);
            List2.SelectedIndex = iOldIndex - 1;
        }

        private void bt_ab_Click(object sender, EventArgs e)
        {
            if (List2.SelectedIndex == -1 || List2.SelectedIndex==List2.Items.Count-1)
                return;
            object oOld = List2.SelectedItem;
            int iOldIndex = List2.SelectedIndex;
            List2.Items.RemoveAt(iOldIndex);
            List2.Items.Insert(iOldIndex + 1, oOld);
            List2.SelectedIndex = iOldIndex + 1;

        }

        private void bt_view_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            string myWeb = @"file:///C:\bieder.web1\index.htm";
            p.StartInfo.FileName = myWeb;
            p.Start();
        }

    }
}
