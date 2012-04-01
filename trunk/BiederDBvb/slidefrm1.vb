Option Strict On
Option Explicit On
Friend Class slide
	Inherits System.Windows.Forms.Form
	Dim MaxRecord As Integer
	Dim AktRecord As Integer
	'UPGRADE_WARNING: Arrays in structure snap may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
    Dim snap As dao.Recordset 'Snapshot
	Dim art_liste() As String
	
	Dim SlideSpeed As Integer
	
	Private Sub ShowPic(ByRef ArtNr As String)
		Dim filename1 As String
		snap.FindFirst("ArtNr='" & ArtNr & "'")
        filename1 = snap.Fields("foto").Value.ToString
		If Not existfile(filename1) Then
			Exit Sub
		End If
		Dim destwidth As Integer
		Dim DestHeight As Integer
		Dim destx As Integer
		Dim desty As Integer
        Dim retval As Boolean
		Dim TempIndex As Object
		On Error GoTo err_Renamed
		Quelle.Image = System.Drawing.Image.FromFile(filename1)
		'UPGRADE_ISSUE: PictureBox method Ziel.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '   bildschirm.Ziel.Cls() 'HGO
        'UPGRADE_ISSUE: PictureBox method Ziel.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '   bildschirm.Ziel.Cls() 'HGO
        Dim dw, qw, qh, dh As Integer 'qw=quelle.width, qh=quelle.height, dw=bildschirm.Ziel.width, dh=bildschirm.Ziel.height
		destwidth = bildschirm.Ziel.Width
        DestHeight = Convert.ToInt16((bildschirm.Ziel.Width / Quelle.Width) * Quelle.Height)
        desty = Convert.ToInt16((bildschirm.Ziel.Height - DestHeight) / 2)
		'UPGRADE_WARNING: Couldn't resolve default property of object qw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		qw = Quelle.Width
		'UPGRADE_WARNING: Couldn't resolve default property of object qh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		qh = Quelle.Height
		'UPGRADE_WARNING: Couldn't resolve default property of object dw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dw = bildschirm.Ziel.Width
		'UPGRADE_WARNING: Couldn't resolve default property of object dh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dh = bildschirm.Ziel.Height
		'links oben
		'UPGRADE_ISSUE: Constant vbSrcErase was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_WARNING: Couldn't resolve default property of object qh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object qw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_ISSUE: PictureBox property Quell_hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'UPGRADE_ISSUE: PictureBox property Ziel.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Dim grZiel As Graphics = bildschirm.Ziel.CreateGraphics ' PictureBox1.CreateGraphics
        Dim Ziel_hdc As IntPtr ' Creating the  variable to keep the DC address
        Ziel_hdc = grZiel.GetHdc()
        Dim grQuelle As Graphics = bildschirm.Ziel.CreateGraphics ' PictureBox1.CreateGraphics
        Dim Quell_hdc As IntPtr ' Creating the  variable to keep the DC address
        Quell_hdc = grQuelle.GetHdc()

        retval = StretchBlt(Ziel_hdc, 0, desty, Convert.ToInt16(destwidth / 2), Convert.ToInt16(DestHeight / 2), Quell_hdc, 0, 0, Convert.ToInt16(qw / 2), Convert.ToInt16(qh / 2), TernaryRasterOperations.NOTSRCERASE)
        'retval = StretchBlt(Ziel_hdc, 0, desty, destwidth / 2, DestHeight / 2, Quell_hdc, 0, 0, qw / 2, qh / 2, vbSrcErase)
        pause(0.5)
        'rechts unten
        'UPGRADE_ISSUE: Constant TernaryRasterOperations.NOTSRCERASE was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        'UPGRADE_WARNING: Couldn't resolve default property of object qh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object qw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_ISSUE: PictureBox property Quell_hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'UPGRADE_ISSUE: PictureBox property Ziel.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        retval = StretchBlt(Ziel_hdc, Convert.ToInt16(destwidth / 2), Convert.ToInt16(DestHeight / 2), Convert.ToInt16(destwidth / 2), Convert.ToInt16(DestHeight / 2), _
                            Quell_hdc, Convert.ToInt16(qw / 2), Convert.ToInt16(qh / 2), Convert.ToInt16(qw / 2), Convert.ToInt16(qh / 2), TernaryRasterOperations.NOTSRCERASE)
        'retval = StretchBlt(Ziel_hdc, destwidth / 2, DestHeight / 2, destwidth / 2, DestHeight / 2, Quell_hdc, qw / 2, qh / 2, qw / 2, qh / 2, TernaryRasterOperations.NOTSRCERASE)
        bildschirm.Ziel.Refresh()
        pause(0.5)
        'links unten
        'UPGRADE_ISSUE: Constant TernaryRasterOperations.NOTSRCERASE was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        'UPGRADE_WARNING: Couldn't resolve default property of object qh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object qw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_ISSUE: PictureBox property Quell_hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'UPGRADE_ISSUE: PictureBox property Ziel.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        retval = StretchBlt(Ziel_hdc, 0, Convert.ToInt16(DestHeight / 2), Convert.ToInt16(destwidth / 2), Convert.ToInt16(DestHeight / 2), _
                            Quell_hdc, 0, Convert.ToInt16(qh / 2), Convert.ToInt16(qw / 2), Convert.ToInt16(qh / 2), TernaryRasterOperations.NOTSRCERASE)
        'retval = StretchBlt(Ziel_hdc, 0, DestHeight / 2, destwidth / 2, DestHeight / 2, Quell_hdc, 0, qh / 2, qw / 2, qh / 2, TernaryRasterOperations.NOTSRCERASE)
        bildschirm.Ziel.Refresh()
        pause(0.5)
        'rechts oben
        'UPGRADE_ISSUE: Constant vbSrcErase was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        'UPGRADE_WARNING: Couldn't resolve default property of object qh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object qw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_ISSUE: PictureBox property Quell_hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'UPGRADE_ISSUE: PictureBox property Ziel.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        retval = StretchBlt(Ziel_hdc, Convert.ToInt16(destwidth / 2), 0, Convert.ToInt16(destwidth / 2), Convert.ToInt16(DestHeight / 2), _
                            Quell_hdc, Convert.ToInt16(qw / 2), 0, Convert.ToInt16(qw / 2), Convert.ToInt16(qh / 2), TernaryRasterOperations.SRCERASE)
        bildschirm.Ziel.Refresh()
        pause(2)
        'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        'UPGRADE_WARNING: Couldn't resolve default property of object qh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object qw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_ISSUE: PictureBox property Quell_hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'UPGRADE_ISSUE: PictureBox property Ziel.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        retval = StretchBlt(Ziel_hdc, 0, desty, destwidth, DestHeight, Quell_hdc, 0, 0, qw, qh, TernaryRasterOperations.SRCCOPY)
        bildschirm.Ziel.Refresh()
        'HGO
        ''UPGRADE_ISSUE: PictureBox method Ziel.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'bildschirm.Ziel.Print()
        'bildschirm.Ziel.Font = VB6.FontChangeSize(bildschirm.Ziel.Font, 12)
        'bildschirm.Ziel.Font = VB6.FontChangeBold(bildschirm.Ziel.Font, True)
        ''If Not IsNull(snap.Fields("Hoofdgroep")) Then bildschirm.Ziel.Print " Gruppe: " + snap.Fields("Hoofdgroep")
        ''UPGRADE_ISSUE: PictureBox method Ziel.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'bildschirm.Ziel.Print(" ArtNr: ")
        ''UPGRADE_ISSUE: PictureBox method Ziel.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'bildschirm.Ziel.Print(ArtNr)
        'Dim beschreibung As String
        'beschreibung = auslesen(snap.Fields("Omschrijving"), DB_MEMO)
        'bildschirm.Ziel.Font = VB6.FontChangeSize(bildschirm.Ziel.Font, 12)
        'bildschirm.Ziel.Font = VB6.FontChangeBold(bildschirm.Ziel.Font, True)
        ''UPGRADE_ISSUE: PictureBox method Ziel.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'bildschirm.Ziel.Print(" Beschreibung: ")
        'bildschirm.Ziel.Font = VB6.FontChangeSize(bildschirm.Ziel.Font, 12)
        'bildschirm.Ziel.Font = VB6.FontChangeBold(bildschirm.Ziel.Font, False)
        ''UPGRADE_ISSUE: PictureBox method Ziel.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'bildschirm.Ziel.Print(BulletList(beschreibung))
        ''UPGRADE_ISSUE: PictureBox method Ziel.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'bildschirm.Ziel.Print(vbCrLf & "Der Biedermann - Landhausmöbel in Wuppertal")
        'bildschirm.Ziel.Font = VB6.FontChangeItalic(bildschirm.Ziel.Font, True)
        ''UPGRADE_ISSUE: PictureBox method Ziel.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'bildschirm.Ziel.Print("www.derbiedermann.de")
        bildschirm.Ziel.Font = VB6.FontChangeItalic(bildschirm.Ziel.Font, False)
        System.Windows.Forms.Application.DoEvents()
        Exit Sub
err_Renamed:
    End Sub

    Private Sub bt_close_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_close.Click
        Me.Hide()
    End Sub

    'UPGRADE_WARNING: Event chk_passwort.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chk_passwort_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chk_passwort.CheckStateChanged
        PasswortSchutzEin = chk_passwort.CheckState
    End Sub

    Private Sub cmdFullScr_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFullScr.Click
        'Reihenfolge
        'opt_reihenfolge(1)=true 'True=Normal, False=Zufall
        LoginSucceeded = False
        'UPGRADE_WARNING: Arrays in structure snap1 may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
        Dim snap1 As dao.Recordset 'Snapshot
        If opt_auswahl(0).Checked = True Then 'True=Produkt gemaess Gruppenliste, False=ALLE
            snap = db.CreateSnapshot("SELECT Artikel.*, Hoofdgroep.Hoofdgroep FROM Hoofdgroep RIGHT JOIN Artikel ON Hoofdgroep.Hgr_ID = Artikel.Hgr_ID  where Artikel.Besteld>1;")
        Else
            snap = db.CreateSnapshot("SELECT Artikel.*, Hoofdgroep.Hoofdgroep FROM Hoofdgroep RIGHT JOIN Artikel ON Hoofdgroep.Hgr_ID = Artikel.Hgr_ID  where Artikel.Besteld>1 AND Artikel.HGR_ID=" & VB6.GetItemData(GruppenListe, GruppenListe.SelectedIndex) & ";")
        End If
        '("Select * from Artikel where besteld=1")
        If ((snap.EOF) And (snap.BOF)) Or (snap.RecordCount = 0) Then
            MsgBox("Keine Artikel für Diashow markiert (Besteld>1)!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Fehler")
            snap.Close()
            Exit Sub
        End If
        Me.Hide()
        '   Set snap = db.CreateSnapshot("SELECT Artikel.*, Hoofdgroep.Hoofdgroep FROM Hoofdgroep RIGHT JOIN Artikel ON Hoofdgroep.Hgr_ID = Artikel.Hgr_ID  where Artikel.Besteld>1;")
        '("Select * from Artikel where besteld=1")
        snap.MoveLast()
        MaxRecord = snap.RecordCount - 1 'We start from 0
        snap.MoveFirst()
        ReDim art_liste(MaxRecord)
        Dim i As Integer
        For i = 0 To MaxRecord
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            art_liste(i) = snap.Fields("ArtNr").Value.ToString
            snap.MoveNext()
        Next i
        snap.MoveFirst()
        Me.Left = Convert.ToInt16(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2))
        Me.Top = Convert.ToInt16(VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2))
        'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
        Dim bildschirm1 As New bildschirm
        If bildschirm1.WindowState <> System.Windows.Forms.FormWindowState.Maximized Then
            bildschirm1.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
            bildschirm1.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height
            bildschirm1.Ziel.Width = Convert.ToInt16(VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) / VB6.TwipsPerPixelX)
            bildschirm1.Ziel.Height = Convert.ToInt16(VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) / VB6.TwipsPerPixelY)
            bildschirm1.Left = 0
            bildschirm1.Top = 0
        End If
        '
        ' Maximize the main form and make it the top-most window.
        '
        'Call SetWindowPos(bildschirm.hwnd, _
        'HWND_TOPMOST, 0&, 0&, Screen.Width, Screen.Width, _
        'SWP_SHOWWINDOW)
        '
        ' Prevent the user from using ALT+TAB to switch
        ' to another application or CTRL+ALT+DELETE to
        ' kill the Screen Saver.
        '
        'Call SystemParametersInfo(SPI_SCREENSAVERRUNNING, True, lTemp, 0)

        Me.Hide()
        Hauptform.Hide()
        'slide.WindowState = vbMinimized
        bildschirm.Visible = True
        bildschirm.Activate()
        'bildschirm.Ziel.Refresh
        System.Windows.Forms.Application.DoEvents()
        AktRecord = 0
        Diashow_Ende = False
        'UPGRADE_ISSUE: PictureBox property Ziel.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'bildschirm.Ziel.AutoRedraw = True 'HGO
        'UPGRADE_WARNING: Timer property Timer1.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
        Timer1.Interval = CShort(ShowTime) * 1000
        Timer1.Enabled = True
        Exit Sub
        Dim desty, DestHeight, destwidth, destx As Integer
        Dim retval As Boolean
        Dim grZiel As Graphics = bildschirm.Ziel.CreateGraphics ' PictureBox1.CreateGraphics
        Dim Ziel_hdc As IntPtr ' Creating the  variable to keep the DC address
        Ziel_hdc = grZiel.GetHdc()
        Dim grQuelle As Graphics = bildschirm.Ziel.CreateGraphics ' PictureBox1.CreateGraphics
        Dim Quell_hdc As IntPtr ' Creating the  variable to keep the DC address
        Quell_hdc = grQuelle.GetHdc()

        If Quelle.Width > Quelle.Height Then
            'UPGRADE_WARNING: Couldn't resolve default property of object destwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            destwidth = bildschirm.Ziel.Width
            'UPGRADE_WARNING: Couldn't resolve default property of object DestHeight. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            DestHeight = Convert.ToInt16((bildschirm.Ziel.Width / Quelle.Width) * Quelle.Height)
            'UPGRADE_WARNING: Couldn't resolve default property of object DestHeight. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object desty. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            desty = Convert.ToInt16((bildschirm.Ziel.Height - DestHeight) / 2)
            'UPGRADE_ISSUE: PictureBox property Quell_hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object DestHeight. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object destwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object desty. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_ISSUE: PictureBox property Ziel.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object retval. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            retval = StretchBlt(Ziel_hdc, 0, desty, destwidth, DestHeight, Quell_hdc, 0, 0, Quelle.Width, Quelle.Height, CType(&HCC0020, TernaryRasterOperations))
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object DestHeight. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            DestHeight = bildschirm.Ziel.Height
            'UPGRADE_WARNING: Couldn't resolve default property of object destwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            destwidth = Convert.ToInt16((bildschirm.Ziel.Height / Quelle.Height) * Quelle.Width)
            'UPGRADE_WARNING: Couldn't resolve default property of object destwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object destx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            destx = Convert.ToInt16((bildschirm.Ziel.Width - destwidth) / 2)
            'UPGRADE_ISSUE: PictureBox property Quell_hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object DestHeight. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object destwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object destx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_ISSUE: PictureBox property Ziel.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'UPGRADE_WARNING: Couldn't resolve default property of object retval. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            retval = StretchBlt(Ziel_hdc, destx, 0, destwidth, DestHeight, Quell_hdc, 0, 0, Quelle.Width, Quelle.Height, CType(&HCC0020, TernaryRasterOperations))
        End If
        bildschirm.Ziel.Refresh()
    End Sub
	
	Private Sub slide_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		AktRecord = 0
        'On Error Resume Next
		If LoginSucceeded Then
			Me.Close()
			Exit Sub
		End If
		If existfile(AppPath & "\diastart.jpg") Then
			Quelle.Image = System.Drawing.Image.FromFile(AppPath & "\diastart.jpg")
			Quelle.Refresh()
		End If
		GruppenLesen()
        chk_passwort.CheckState = CType(PasswortSchutzEin, CheckState)
	End Sub
	
	Private Sub slide_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_WARNING: Timer property Timer1.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
		Timer1.Interval = 0
		'Unload bildschirm
		'Hauptform.Visible = True
		LoginSucceeded = False
		PasswortSchutzEin = chk_passwort.CheckState
		Me.Close()
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		If LoginSucceeded Then
			Timer1.Enabled = False
		Else
			Timer1.Enabled = True
		End If
		If opt_reihenfolge(0).Checked = True Then
			Randomize()
            AktRecord = Convert.ToInt16((MaxRecord * Rnd()))
			'AktRecord = AktRecord + 1
			'If AktRecord > MaxRecord Then
			'    AktRecord = 1
			'    snap.MoveFirst
			'End If
			'snap.MoveNext
		Else
			If AktRecord > MaxRecord Then
				AktRecord = 0
			Else
				AktRecord = AktRecord + 1
				If AktRecord > MaxRecord Then AktRecord = 0
			End If
		End If
		ShowPic(art_liste(AktRecord))
		System.Windows.Forms.Application.DoEvents()
	End Sub
	Sub GruppenLesen()
        Dim i As Integer
		dy = db.CreateDynaset("SELECT * from hoofdgroep")
		dy.MoveLast()
		dy.MoveFirst()
		GruppenListe.Items.Clear()
		For i = 0 To dy.RecordCount - 1
			GruppenListe.Items.Insert(i, (dy.Fields("Hoofdgroep").Value))
            VB6.SetItemData(GruppenListe, i, Convert.ToInt16(dy.Fields("Hgr_ID").Value))
			dy.MoveNext()
		Next i
		GruppenListe.SelectedIndex = 0
		dy.MoveFirst()
	End Sub
End Class