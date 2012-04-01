Option Strict On
Option Explicit On
Imports VB = Microsoft.VisualBasic
Module Module2
	Public AppPath As String
	Public StartSeite As String
	Public Abbruch As Boolean
	Public ii As String
	Public cr As String
    Public LoadFrameSet As String
    Public Der_Biedermann As String
	Public Const Info_anfordern As String = "http://cgi05.puretec.de/cgi-bin/fb_form?clsid=86ee91a0ccefec60568de1c4fd0c0460"
    Public keywords_htm As String
    Public Head_htm As String
    Public Counter_htm As String
    Public Top_Gif As String
	'Für Hintergrundbilderverwendung
    Public bg_top As Double
    Public bg_left As Double
    Public bg_main As Double
    Public bg_artikel As Double
	
	Public iview As String
	Public ShowTime As String
	Public LoginSucceeded As Boolean
    Public PasswortSchutzEin As Double
    Public Enum StretchMode
        STRETCH_ANDSCANS = 1
        STRETCH_ORSCANS = 2
        STRETCH_DELETESCANS = 3
        STRETCH_HALFTONE = 4
    End Enum
    Public Enum TernaryRasterOperations
        SRCCOPY = &HCC0020
        SRCPAINT = &HEE0086
        SRCAND = &H8800C6
        SRCINVERT = &H660046
        SRCERASE = &H440328
        NOTSRCCOPY = &H330008
        NOTSRCERASE = &H1100A6
        MERGECOPY = &HC000CA
        MERGEPAINT = &HBB0226
        PATCOPY = &HF00021
        PATPAINT = &HFB0A09
        PATINVERT = &H5A0049
        DSTINVERT = &H550009
        BLACKNESS = &H42
        WHITENESS = &HFF0062
    End Enum
    Declare Function StretchBlt Lib "gdi32.dll" (ByVal hdcDest As IntPtr, ByVal nXOriginDest As Integer, ByVal nYOriginDest As Integer, _
        ByVal nWidthDest As Integer, ByVal nHeightDest As Integer, ByVal hdcSrc As IntPtr, ByVal nXOriginSrc As Integer, _
        ByVal nYOriginSrc As Integer, ByVal nWidthSrc As Integer, ByVal nHeightSrc As Integer, ByVal dwRop As TernaryRasterOperations) As Boolean

    '''' Public Declare Function StretchBlt Lib "gdi32.dll" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As Integer, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal hSrcWidth As Integer, ByVal nSrcHeight As Integer, ByVal dwRop As Integer) As Integer
	'Public Declare Function GetWindowRect Lib "user32" (ByVal hwnd As Long, lpRect As RECT) As Long
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    'Public Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByRef lpvParam As Any, ByVal fuWinIni As Integer) As Integer
    Public Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, _
        ByVal uParam As Integer, ByVal lpvParam As Integer, _
        ByVal fuWinIni As Integer) As Integer
	Public Const SPI_SCREENSAVERRUNNING As Short = 97
	Public Declare Sub SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer)
	
	Public Const HWND_TOPMOST As Short = -1
	Public Const HWND_TOP As Short = 0
	Public Const HWND_BOTTOM As Short = 1
	Public Const HWND_NOTOPMOST As Short = -2
	
	Public Const SWP_NOSIZE As Integer = &H1
	Public Const SWP_NOMOVE As Integer = &H2
	Public Const SWP_NOZORDER As Integer = &H4
	Public Const SWP_NOREDRAW As Integer = &H8
	Public Const SWP_NOACTIVATE As Integer = &H10
	Public Const SWP_FRAMECHANGED As Integer = &H20
	Public Const SWP_SHOWWINDOW As Integer = &H40
	Public Const SWP_HIDEWINDOW As Integer = &H80
	Public Const SWP_NOCOPYBITS As Integer = &H100
	Public Const SWP_NOOWNERZORDER As Integer = &H200
	Public Const SWP_DRAWFRAME As Integer = SWP_FRAMECHANGED
	Public Const SWP_NOREPOSITION As Integer = SWP_NOOWNERZORDER
	
	Public Declare Function ShellExecute Lib "shell32.dll"  Alias "ShellExecuteA"(ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	Public Const SW_SHOWNORMAL As Short = 1
	
	Private Const BIF_STATUSTEXT As Integer = &H4
	Private Const BIF_RETURNONLYFSDIRS As Short = 1
	Private Const BIF_DONTGOBELOWDOMAIN As Short = 2
	Private Const MAX_PATH As Short = 260
	
	Private Const WM_USER As Integer = &H400
	Private Const BFFM_INITIALIZED As Short = 1
	Private Const BFFM_SELCHANGED As Short = 2
    Private Const BFFM_SETSTATUSTEXT As Integer = (WM_USER + 100)
    Private Const BFFM_SETSELECTION As Integer = (WM_USER + 102)
	
	Private Declare Function GetModuleFileName Lib "kernel32"  Alias "GetModuleFileNameA"(ByVal hModule As Integer, ByVal lpFileName As String, ByVal nSize As Integer) As Integer
	
	Private Declare Function SendMessage Lib "user32"  Alias "SendMessageA"(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer
	'UPGRADE_WARNING: Structure BrowseInfo may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function SHBrowseForFolder Lib "shell32" (ByRef lpbi As BrowseInfo) As Integer
	Private Declare Function SHGetPathFromIDList Lib "shell32" (ByVal pidList As Integer, ByVal lpBuffer As String) As Integer
	Private Declare Function lstrcat Lib "kernel32"  Alias "lstrcatA"(ByVal lpString1 As String, ByVal lpString2 As String) As Integer
	
	Private Structure BrowseInfo
		Dim hWndOwner As Integer
		Dim pIDLRoot As Integer
		Dim pszDisplayName As Integer
		Dim lpszTitle As Integer
		Dim ulFlags As Integer
		Dim lpfnCallback As Integer
		Dim lParam As Integer
		Dim iImage As Integer
	End Structure
	
	Public Diashow_Ende As Boolean
	
	Private m_CurrentDirectory As String 'The current directory
	'
    Public datenbank As String
    Public sortField As String
    Public webroot As String
    Public webkopf As String
    Public startpage As String
	
	Public Const DB_Boolean As Short = 1
	Public Const DB_Byte As Short = 2
	Public Const DB_INTEGER As Short = 3
	Public Const DB_LONG As Short = 4
	Public Const DB_CURRENCY As Short = 5
	Public Const DB_SINGLE As Short = 6
	Public Const DB_DOUBLE As Short = 7
	Public Const DB_DATE As Short = 8
	Public Const DB_TEXT As Short = 10
	Public Const DB_LONGBINARY As Short = 11
	Public Const DB_MEMO As Short = 12
	
    Public db As dao.Database
    Public et As String
	
	'Public db As Database
    'UPGRADE_WARNING: Arrays in structure dy may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
    Public dy As dao.Recordset ' Dynaset
	'UPGRADE_WARNING: Arrays in structure dyKat may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
    Public dyKat As dao.Recordset 'Dynaset
	Public Structure Kat
        Dim ID As UShort
		Dim text As String
	End Structure
	Public kategorie() As Kat
	
	
	Structure infotype
        Dim not_null As Boolean 'Werte müssen vorhanden sein
		Dim feldname As String 'aus welchem Feld bzw. in welches Feld
		Dim size As Short 'maximale Größe
		Dim type As Short 'Datentyp ( wird durch das programm verwendet)
	End Structure
	
	'Für Shell-Funktion
	Public Const GW_HWNDNEXT As Short = 2
	Public Declare Function GetParent Lib "user32" (ByVal hwnd As Integer) As Integer
	Public Declare Function GetWindow Lib "user32" (ByVal hwnd As Integer, ByVal wCmd As Integer) As Integer
	Public Declare Function FindWindow Lib "user32"  Alias "FindWindowA"(ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
	Public Declare Function GetWindowText Lib "user32"  Alias "GetWindowTextA"(ByVal hwnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
	Public Declare Function GetWindowThreadProcessId Lib "user32" (ByVal hwnd As Integer, ByRef lpdwprocessid As Integer) As Integer
	
	'ende Declares
	
	Public Function IsReadOnly(ByRef datei As String) As Boolean
		'Liefert ReadOnly Status einer Datei
        Dim test As Integer
		If existfile(datei) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object test. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			test = GetAttr(datei) And FileAttribute.ReadOnly
			'UPGRADE_WARNING: Couldn't resolve default property of object test. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If test > 0 Then
				If MsgBox("Datei überschreiben?: " & datei, MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Achtung") = MsgBoxResult.Yes Then
					SetAttr(datei, FileAttribute.Normal)
					IsReadOnly = False
				Else
					IsReadOnly = True
				End If
			Else
				IsReadOnly = False
			End If
		Else
			IsReadOnly = False 'Datei existiert nicht
		End If
	End Function
	Public Function EscapeLink(ByVal l As String) As String
		'Wandelt Zeichen im String l in ISO-Code (zb Blank->%20)
        Dim i As Integer
        Dim tmp As String
		'UPGRADE_WARNING: Couldn't resolve default property of object tmp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		tmp = ""
		For i = 1 To Len(l)
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Select Case Asc(Mid(l, i, 1))
				Case 48 To 127
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object tmp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					tmp = tmp + Mid(l, i, 1)
				Case Else
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object tmp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					tmp = tmp + "%" + Hex(Asc(Mid(l, i, 1)))
			End Select
			'Ä %C4, ä %E4, Ö %D6, ö %F6, Ü %DC, ü %FC, ß %DF
		Next i
		'UPGRADE_WARNING: Couldn't resolve default property of object tmp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		EscapeLink = tmp
	End Function
	Function ProcIDFromWnd(ByVal hwnd As Integer) As Integer
		Dim idProc As Integer
		
		' Get PID for this HWnd
		GetWindowThreadProcessId(hwnd, idProc)
		
		' Return PID
		ProcIDFromWnd = idProc
	End Function
	
	Function GetWinHandle(ByVal hInstance As Integer) As Integer
		Dim tempHwnd As Integer
		
		' Grab the first window handle that Windows finds:
		tempHwnd = FindWindow(vbNullString, vbNullString)
		
		' Loop until you find a match or there are no more window handles:
		Do Until tempHwnd = 0
			' Check if no parent for this window
			If GetParent(tempHwnd) = 0 Then
				' Check for PID match
				If hInstance = ProcIDFromWnd(tempHwnd) Then
					' Return found handle
					GetWinHandle = tempHwnd
					' Exit search loop
					Exit Do
				End If
			End If
			
			' Get the next window handle
			tempHwnd = GetWindow(tempHwnd, GW_HWNDNEXT)
		Loop 
	End Function
	
    Function createThumbnail(ByVal src As String, ByVal th As String, ByVal verz As String) As Boolean
        'i_view32.exe c:\test.jpg /resize=(160,0) /convert=c:\test_th.jpg
        If Not existfile(iview) Or Not existfile(verz & "\" & src) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object createThumbnail. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            createThumbnail = False
            Exit Function
        End If
        Dim iInst As Integer
        Dim hWndApp As Integer
        Dim prog As String
        Dim startt As Double
        Dim timeout As Boolean
        'UPGRADE_WARNING: Couldn't resolve default property of object prog. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        prog = iview & " " & verz & "\" & src & " /resize=(160,0) /convert=" & verz & "\" & th
        'UPGRADE_WARNING: Couldn't resolve default property of object prog. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object iInst. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        iInst = Shell(prog, AppWinStyle.MinimizedFocus)
        startt = VB.Timer()
        timeout = False
        'UPGRADE_WARNING: Couldn't resolve default property of object iInst. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object hWndApp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        hWndApp = GetWinHandle(iInst)
        'UPGRADE_WARNING: Couldn't resolve default property of object hWndApp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Do While hWndApp <> 0
            System.Windows.Forms.Application.DoEvents()
            If Int(VB.Timer() - startt) > 300 Then
                timeout = True
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object iInst. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object hWndApp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            hWndApp = GetWinHandle(iInst)
            If timeout Then Exit Do
        Loop
        If timeout Then
            'UPGRADE_WARNING: Couldn't resolve default property of object createThumbnail. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            createThumbnail = False
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object createThumbnail. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            createThumbnail = True
        End If
    End Function
	Function text2htm(ByVal inp As String) As String
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If IsDbNull(inp) Or inp = "" Then
			text2htm = ii & ii
			Exit Function
		End If
        Dim l As Integer
        Dim htm As String
		'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		htm = ""
		For l = 1 To Len(inp)
			'UPGRADE_WARNING: Couldn't resolve default property of object l. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Select Case Mid(inp, l, 1)
				Case Is = "ä"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&auml;"
				Case Is = "ö"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&ouml;"
				Case Is = "ü"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&uuml;"
				Case Is = "ß"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&szlig;"
				Case Is = "Ä"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&Auml;"
				Case Is = "Ö"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&Ouml;"
				Case Is = "Ü"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&Uuml;"
				Case Is = "<"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&lt;"
				Case Is = ">"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&gt;"
				Case Is = Chr(13)
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "<br>"
				Case Is = Chr(10)
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm
				Case Is = Chr(216)
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&Oslash;"
				Case Else
					'UPGRADE_WARNING: Couldn't resolve default property of object l. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + Mid(inp, l, 1)
			End Select
		Next l
		'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		text2htm = htm
	End Function
	Function text2htmList(ByVal inp As String) As String
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If IsDbNull(inp) Or inp = "" Then
			text2htmList = ii & ii
			Exit Function
		End If
        Dim l As Integer
        Dim htm As String
		'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		htm = "<li>"
		For l = 1 To Len(inp)
			'UPGRADE_WARNING: Couldn't resolve default property of object l. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Select Case Mid(inp, l, 1)
				Case Is = "ä"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&auml;"
				Case Is = "ö"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&ouml;"
				Case Is = "ü"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&uuml;"
				Case Is = "ß"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&szlig;"
				Case Is = "Ä"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&Auml;"
				Case Is = "Ö"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&Ouml;"
				Case Is = "Ü"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&Uuml;"
				Case Is = "<"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&lt;"
				Case Is = ">"
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&gt;"
				Case Is = Chr(13)
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "</li><br><li>"
				Case Is = Chr(10)
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm
				Case Is = Chr(216)
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + "&Oslash;"
				Case Else
					'UPGRADE_WARNING: Couldn't resolve default property of object l. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					htm = htm + Mid(inp, l, 1)
			End Select
		Next l
		'UPGRADE_WARNING: Couldn't resolve default property of object htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		text2htmList = htm + "</li>"
		
	End Function
	Function BulletList(ByRef inp As String) As String
        Dim tt As String
        Dim i As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object tt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		tt = " + "
		'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		i = 1
		
		'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		While i <= Len(inp)
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Select Case Mid(inp, i, 1)
				Case Chr(10)
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object tt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					tt = tt + Mid(inp, i, 1) + " + "
				Case Else
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object tt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					tt = tt + Mid(inp, i, 1)
			End Select
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			i = i + 1
		End While
		'UPGRADE_WARNING: Couldn't resolve default property of object tt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BulletList = tt
	End Function
	Function htmValue(ByRef v As String) As String
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If IsDbNull(v) Or v = "" Then
			htmValue = ii & ii
			Exit Function
		End If
		htmValue = ii & v & ii
	End Function
	
	Sub write_ini()
		
        Dim f As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(f, AppPath & "\biederdb.ini", OpenMode.Output)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, datenbank)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, sortField)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, webroot)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, webkopf)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, startpage)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, iview)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, ShowTime)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, Str(PasswortSchutzEin))
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, StartSeite)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, Str(bg_top))
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, Str(bg_left))
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, Str(bg_main))
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, Str(bg_artikel))
		
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(f)
	End Sub
	Sub read_ini()
        'On Error Resume Next
        Dim f As Integer
        Dim v As String
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        f = FreeFile()
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FileOpen(f, AppPath & "\biederdb.ini", OpenMode.Input)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        datenbank = LineInput(f)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sortField = LineInput(f)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        webroot = LineInput(f)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        webkopf = LineInput(f)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        startpage = LineInput(f)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        iview = LineInput(f)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ShowTime = LineInput(f)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        v = LineInput(f)
        'UPGRADE_WARNING: Couldn't resolve default property of object v. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        PasswortSchutzEin = Val(v)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        StartSeite = LineInput(f)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        v = LineInput(f)
        'UPGRADE_WARNING: Couldn't resolve default property of object v. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        bg_top = Val(v)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        v = LineInput(f)
        'UPGRADE_WARNING: Couldn't resolve default property of object v. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        bg_left = Val(v)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        v = LineInput(f)
        'UPGRADE_WARNING: Couldn't resolve default property of object v. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        bg_main = Val(v)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        v = LineInput(f)
        'UPGRADE_WARNING: Couldn't resolve default property of object v. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        bg_artikel = Val(v)

        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FileClose(f)
        On Error GoTo 0
    End Sub

    Function auslesen(ByRef n As Object, ByRef typ As Short) As String
        'HGO statt n n.Value
        'UPGRADE_WARNING: VarType has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        Dim obj As Object = n 'n.value
        If VarType(obj) = 1 Then ' NULL-Value
            If typ = DB_TEXT Or typ = DB_MEMO Then auslesen = "" Else auslesen = "0"
            'UPGRADE_WARNING: VarType has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        ElseIf VarType(obj) = 8 Then  ' Stringtyp
            'UPGRADE_WARNING: Couldn't resolve default property of object n. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            auslesen = obj.ToString()
            'UPGRADE_WARNING: VarType has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        ElseIf VarType(obj) = 2 Then  ' Integer
            'UPGRADE_WARNING: Couldn't resolve default property of object n. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            auslesen = CStr(obj)
            'UPGRADE_WARNING: VarType has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        ElseIf VarType(obj) = 4 Then  ' Single
            'UPGRADE_WARNING: Couldn't resolve default property of object n. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            auslesen = VB6.Format(obj, "0.00")
            'UPGRADE_WARNING: VarType has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        ElseIf VarType(obj) = 5 Then  ' Double
            'UPGRADE_WARNING: Couldn't resolve default property of object n. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            auslesen = VB6.Format(obj, "0.00")
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object n. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            auslesen = CStr(obj.ToString())
        End If

    End Function

    Sub copy_clipboard()
        Beep()
        'Dim s As String
        'Dim i As Short
        'Dim c As System.Windows.Forms.Control
        'Dim q As New VB6.FixedLengthString(1)

        'q.Value = ";"
        'My.Computer.Clipboard.Clear() ' Löschen Zwischenablage
        's = System.Windows.Forms.Form.ActiveForm.Text & q.Value ' Erste Zeile Fenstername für späteres Einfügen
        ''UPGRADE_WARNING: Controls method Screen.ActiveForm.Controls.Count has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        'For i = 0 To System.Windows.Forms.Form.ActiveForm.Controls.Count() - 1
        '    'UPGRADE_WARNING: Form property Screen.ActiveForm.Controls has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '    c = Screen.ActiveForm.Controls(i)
        '    'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '    If TypeOf c Is System.Windows.Forms.TextBox Then
        '        s = s & c.Text & q.Value
        '    End If
        '    'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '    If TypeOf c Is System.Windows.Forms.ComboBox Then
        '        'UPGRADE_WARNING: Couldn't resolve default property of object c.ListIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        s = s & CStr(c.ListIndex) & q.Value
        '    End If
        'Next i
        'My.Computer.Clipboard.SetText(s)
    End Sub

    Sub insert_clipboard()
        Beep()
        ''On Error Resume Next
        'Dim s, p As String
        'Dim r, l, i As Short
        'Dim c As System.Windows.Forms.Control

        'If My.Computer.Clipboard.ContainsText() Then ' textformat ?
        '	s = My.Computer.Clipboard.GetText()
        '	l = 1
        '	r = InStr(l, s, ";")
        '	p = Mid(s, l, r - l)
        '	If p = System.Windows.Forms.Form.ActiveForm.Text Then ' ? gleiches Fenster
        '		'UPGRADE_WARNING: Controls method Screen.ActiveForm.Controls.Count has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		For i = 0 To System.Windows.Forms.Form.ActiveForm.Controls.Count() - 1
        '			'UPGRADE_WARNING: Form property Screen.ActiveForm.Controls has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '			c = Screen.ActiveForm.Controls(i)
        '			'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '			If TypeOf c Is System.Windows.Forms.TextBox Then ' für alle Textfelder
        '				l = r + 1
        '				r = InStr(l, s, ";")
        '				p = Mid(s, l, r - l)
        '				c.Text = p
        '			End If
        '			'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '			If TypeOf c Is System.Windows.Forms.ComboBox Then ' für alle Kombofelder
        '				l = r + 1
        '				r = InStr(l, s, ";")
        '				p = Mid(s, l, r - l)
        '				'UPGRADE_WARNING: Couldn't resolve default property of object c.ListIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '				c.ListIndex = CShort(p)
        '			End If
        '		Next i
        '	Else
        '		MsgBox("Daten passen nicht in die Eingabemaske !", 16, "PROBLEM")
        '	End If
        'Else
        '	MsgBox("Daten passen nicht in die Eingabemaske !", 16, "PROBLEM")
        'End If


    End Sub

    'UPGRADE_WARNING: Application will terminate when Sub Main() finishes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="E08DDC71-66BA-424F-A612-80AF11498FF8"'
    Public Sub Main()
        'UPGRADE_ISSUE: App property App.PrevInstance was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'If App.PrevInstance = True Then
        '	End
        '	Exit Sub
        'End If
        On Error GoTo dateifehler
        Dim i As Short
        PasswortSchutzEin = 1
        bg_top = 1
        bg_left = 1
        bg_main = 1
        bg_artikel = 1
        StartSeite = "index.htm"
        If IsIDE() Then AppPath = "c:\Programme\BiederDB" Else AppPath = My.Application.Info.DirectoryPath
        ShowTime = CStr(3)
        ii = Chr(34)
        'UPGRADE_WARNING: Couldn't resolve default property of object LoadFrameSet. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        LoadFrameSet = "<script language=" & ii & "JavaScript" & ii & vbCrLf & "><!--" & vbCrLf & "if(top.frames.length < 1)" & vbCrLf & "top.location.href=" & ii & StartSeite & ii & ";" & vbCrLf & "// -->" & vbCrLf & "</script>"
        Dim fdb As Integer
        Dim zeile As String
        If existfile(My.Application.Info.DirectoryPath & "\Der_Biedermann.txt") Then
            fdb = FreeFile()
            FileOpen(fdb, My.Application.Info.DirectoryPath & "\Der_Biedermann.txt", OpenMode.Input)
            'UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Der_Biedermann = ""
            While Not EOF(fdb)
                zeile = LineInput(fdb)
                'UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Der_Biedermann = Der_Biedermann + zeile
            End While
            FileClose(fdb)
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Der_Biedermann = "<blockquote><p>Der Biedermann, Landhausm&ouml;bel in vielen Varianten, Grünstr. 6, 42103 Wuppertal, Telefon: 0202-470068, Fax: 0202/6980567<br>&Ouml;ffnungszeiten: Mo-Fr 11-18:30 Uhr, Sa 10-16 Uhr</p></blockquote>"
        End If
        '<a href="index.htm" target="_parent"><img src="top.gif" width="600" height="60" alt border="0"></a>
        'UPGRADE_WARNING: Couldn't resolve default property of object Counter_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Counter_htm = "<img  src=" & Chr(34) & "http://cgicounter.puretec.de/cgi-bin/cnt?clsid=86ee91a0ccefec60568de1c4fd0c04601" & Chr(34) & ">"
        Keywords_Load()
        et = Chr(13) ' Zeilenvorschub
        cr = Chr(13) & Chr(10)
        'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        datenbank = AppPath & "\cddatabase.mdb"
        'UPGRADE_WARNING: Couldn't resolve default property of object sortField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sortField = "HGR_ID"
        'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        webroot = AppPath
        'UPGRADE_WARNING: Couldn't resolve default property of object webkopf. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        webkopf = AppPath & "\_top.htm"
        'UPGRADE_WARNING: Couldn't resolve default property of object startpage. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        startpage = AppPath & "\_main.htm"
        'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If Dir(AppPath & "\biederdb.ini") = "" Then write_ini()
        read_ini()
        'UPGRADE_WARNING: Couldn't resolve default property of object Top_Gif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Top_Gif = "<a href=" & ii & StartSeite & ii & " target=" & ii & "_parent" & ii & "><img src=" & Chr(34) & "_topback.gif" & Chr(34) & " width=" & Chr(34) & "600" & Chr(34) & " height=" & Chr(34) & "60" & Chr(34) & " alt border=" & Chr(34) & "0" & Chr(34) & "></a><br>"
        read_colors()
        'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Not existfile(datenbank) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            datenbank = InputBox("Bitte Datenbank angeben", "Datenbank nicht gefunden", datenbank)
            'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Not existfile(datenbank) Then
                MsgBox("Schwerwiegender Fehler, kann ohne Datenbank nicht arbeiten!", MsgBoxStyle.OkOnly)
                End
            End If
        End If
        If Not existfile(iview) Then
            iview = InputBox("Bitte IrfanView angeben", "Umwandlungsprogramm nicht gefunden", iview)
            'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If iview = "" Then
                MsgBox("Ohne IrfanView können Thumbnails nicht automatisch erstellt werden!", MsgBoxStyle.OkOnly)
            End If
        End If
        On Error GoTo 0
        'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        db = DAODBEngine_definst.OpenDatabase(datenbank, False, False)
        patch_db()
        patch_db2() ' SortOrder Feld in Hoefdgroep anhängen
        Hauptform.ShowDialog() '.Show
        'SendKeys "{F10}~"
        Exit Sub

dateifehler:
        'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        MsgBox("Fehler beim Laden der Datenbank " + datenbank & et & "Fehlernr:" & CStr(Err.Number), MsgBoxStyle.OkOnly, "Problem")
        Exit Sub
        'Resume Next ///WARNING!
    End Sub
    Sub Keywords_Load()
        Dim keyfile As String
        Dim s As String
        keyfile = AppPath & "\_keywords.htm"
        Dim f As Integer
        If existfile(keyfile) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            f = FreeFile()
            'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            FileOpen(f, keyfile, OpenMode.Input)
            'On Error Resume Next
            'UPGRADE_WARNING: Couldn't resolve default property of object keywords_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            keywords_htm = ""
            'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Do While Not EOF(f)
                'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                s = LineInput(f)
                'UPGRADE_WARNING: Couldn't resolve default property of object keywords_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                keywords_htm = keywords_htm + vbCrLf + s
            Loop
            'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            FileClose(f)
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object keywords_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            keywords_htm = "<meta name=" & Chr(34) & "keywords" & Chr(34) & " content=" & Chr(34) & "Der Biedermann, Landhausmöbel, Wuppertal, Naturholz, Möbel, Tische, Schränke, Stühle, Bett, Stuhl, Tisch, Schrank, Kasten" & Chr(34) & ">"
        End If
        On Error GoTo 0
    End Sub
    Sub patch_db()
        Dim i, max As Integer
        Dim found As Boolean
        Dim tmpdy As dao.Recordset
        tmpdy = db.CreateDynaset("select * from HoofdGroep")
        'UPGRADE_WARNING: Couldn't resolve default property of object tmpdy.Fields. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        max = tmpdy.Fields.Count
        'UPGRADE_WARNING: Couldn't resolve default property of object found. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        found = False
        'UPGRADE_WARNING: Couldn't resolve default property of object max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        For i = 0 To max - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpdy.Fields. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object found. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmpdy.Fields(i).name = "Produkttext" Then found = True
        Next i
        'UPGRADE_WARNING: Couldn't resolve default property of object found. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If found Then
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpdy.Fields. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmpdy.Fields("Produkttext").type = dao.DataTypeEnum.dbMemo Then
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpdy.Close. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                tmpdy.Close()
                Exit Sub
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpdy.Close. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                tmpdy.Close()
                MsgBox("Achtung: Das vorhandene Produkttext-Feld wird entfernt und neu angelegt, um grössere Texte erfassen zu können. Alle gespeicherten Produkttexte gehen verloren.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation)
                db.Execute(("Alter table HoofdGroep drop Produkttext ;"))
                db.Execute(("Alter table HoofdGroep add Produkttext Memo;"))
                Exit Sub
            End If
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpdy.Close. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpdy.Close()
            db.Execute(("Alter table HoofdGroep add Produkttext Memo;"))
            MsgBox("Das neue Produkttext-Feld wurde als Memofeld erstellt", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information)
        End If
    End Sub
    Sub patch_db2()
        'add a sort order field to the table HoofdGroep
        Dim i, max As Integer
        Dim found As Boolean
        Dim tmpdy As dao.Recordset

        tmpdy = db.CreateDynaset("select * from HoofdGroep")
        'UPGRADE_WARNING: Couldn't resolve default property of object tmpdy.Fields. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        max = tmpdy.Fields.Count
        'UPGRADE_WARNING: Couldn't resolve default property of object found. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        found = False
        'UPGRADE_WARNING: Couldn't resolve default property of object max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        For i = 0 To max - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpdy.Fields. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object found. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmpdy.Fields(i).name = "SortOrder" Then found = True
        Next i
        'UPGRADE_WARNING: Couldn't resolve default property of object found. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If found = False Then
            'UPGRADE_WARNING: Couldn't resolve default property of object tmpdy.Close. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tmpdy.Close()
            MsgBox("Achtung: Die vorhandene Produktgruppentabelle wird um das Feld SortOrder ergänzt", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation)
            db.Execute(("Alter table HoofdGroep add SortOrder INTEGER ;"))
            MsgBox("Das neue Feld wurde angehängt. Sie können nun die Sortierfolge unter Daten-'Gruppen sortieren' ändern", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

    End Sub
    Sub zentriereform(ByRef f As System.Windows.Forms.Form)
        f.SetBounds(Convert.ToInt32(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(f.Width)) / 2)), _
                    Convert.ToInt32(VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(f.Height)) / 2)), _
                    0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
    End Sub
    'Public Function BrowseForFolder(ByRef owner As System.Windows.Forms.Form, ByRef Title As String, ByVal StartDir As String) As String
    '	'Opens a Treeview control that displays the directories in a computer

    '	Dim lpIDList As Integer
    '	Dim szTitle As String
    '	Dim sBuffer As String
    '	Dim tBrowseInfo As BrowseInfo
    '	m_CurrentDirectory = StartDir & vbNullChar

    '	szTitle = Title
    '	With tBrowseInfo
    '		.hWndOwner = owner.Handle.ToInt32
    '		.lpszTitle = lstrcat(szTitle, "")
    '		.ulFlags = BIF_RETURNONLYFSDIRS + BIF_DONTGOBELOWDOMAIN + BIF_STATUSTEXT
    '		'UPGRADE_WARNING: Add a delegate for AddressOf BrowseCallbackProc Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="E9E157F7-EF0C-4016-87B7-7D7FBBC6EE08"'
    '           .lpfnCallback = GetAddressofFunction(AddressOf BrowseCallbackProc) 'get address of function.
    '	End With

    '	lpIDList = SHBrowseForFolder(tBrowseInfo)
    '	If (lpIDList) Then
    '		sBuffer = Space(MAX_PATH)
    '		SHGetPathFromIDList(lpIDList, sBuffer)
    '		sBuffer = Left(sBuffer, InStr(sBuffer, vbNullChar) - 1)
    '		BrowseForFolder = sBuffer
    '	Else
    '		BrowseForFolder = ""
    '	End If

    'End Function

    Private Function BrowseCallbackProc(ByVal hwnd As Integer, ByVal uMsg As Integer, ByVal lp As Integer, ByVal pData As Integer) As Integer

        Dim lpIDList As Integer
        Dim ret As Integer
        Dim sBuffer As String

        'On Error Resume Next 'Sugested by MS to prevent an error from
        'propagating back into the calling process.

        Select Case uMsg

            Case BFFM_INITIALIZED
                Call SendMessage(hwnd, BFFM_SETSELECTION, 1, m_CurrentDirectory)

            Case BFFM_SELCHANGED
                sBuffer = Space(MAX_PATH)

                ret = SHGetPathFromIDList(lp, sBuffer)
                If ret = 1 Then
                    Call SendMessage(hwnd, BFFM_SETSTATUSTEXT, 0, sBuffer)
                End If

        End Select

        BrowseCallbackProc = 0

    End Function

    ' This function allows you to assign a function pointer to a vaiable.
    Private Function GetAddressofFunction(ByRef add As Integer) As Integer
        GetAddressofFunction = add
    End Function


    ' trennt einen Dateinamen in seine Bestandteile Pfad,Name, Extension
    Sub FileSplit(ByVal s As String, ByRef path As String, ByRef file As String, ByRef ext As String)

        Dim i As Integer
        If InStrRev(s, ".") <> 0 Then ' extension
            ext = Right(s, Len(s) - InStrRev(s, "."))
            s = Left(s, InStrRev(s, ".") - 1)
        End If
        i = Len(s)
        If InStrRev(s, "\") <> 0 Then
            While Mid(s, i, 1) <> "\"
                i = i - 1
            End While
        Else
            path = ""
            file = s
            Exit Sub
        End If
        path = Left(s, i)
        file = Right(s, Len(s) - i)
    End Sub
    Function existfile(ByVal DateiName As String) As Boolean
        Dim f As Short
        On Error GoTo ExistError
        'f = FreeFile
        'Open DateiName For Input As f
        If FileLen(DateiName) > 0 Then existfile = True Else existfile = False
        Exit Function
ExistError:
        existfile = False
        'Close (f)
        Resume ExitExist
ExitExist:
        existfile = False
    End Function

    Function GetPfad(ByVal s As String) As String
        Dim f, p, e As String
        FileSplit(s, p, f, e)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GetPfad = p
    End Function
    Function GetFilename(ByVal s As String) As String
        Dim f, p, e As String
        FileSplit(s, p, f, e)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetFilename. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GetFilename = f
    End Function
    Function GetExtension(ByVal s As String) As String
        Dim f, p, e As String
        FileSplit(s, p, f, e)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetExtension. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GetExtension = e
    End Function
    Public Sub ReplaceAll(ByRef sOrigStr As String, ByVal sFindStr As String, ByVal sReplaceWithStr As String, Optional ByRef bWholeWordsOnly As Boolean = False)
        '
        ' Replaces all occurances of sFindStr with sReplaceWithStr
        '
        Dim lPos As Integer
        Dim lPos2 As Integer
        Dim sTmpStr As String
        Dim bReplaceIt As Boolean
        Dim lFindStr As Integer


        On Error GoTo vbErrorHandler

        lFindStr = Len(sFindStr)

        lPos2 = 1
        bReplaceIt = True
        sTmpStr = sOrigStr

        Do
            lPos = InStr(lPos2, sOrigStr, sFindStr)
            If lPos = 0 Then
                Exit Do
            End If
            If bWholeWordsOnly Then
                'On Error Resume Next
                If lPos = 1 Or (Mid(sOrigStr, lPos - 1, 1) = " ") Then
                    If (Mid(sOrigStr, lPos + lFindStr, 1) = " ") Or Mid(sOrigStr, lPos + lFindStr + 1, 1) = "" Then
                        bReplaceIt = True
                    Else
                        bReplaceIt = False
                    End If
                End If
            End If
            If bReplaceIt Then
                If lPos > 1 Then
                    sTmpStr = Left(sOrigStr, lPos - 1)
                Else
                    sTmpStr = ""
                End If
                sTmpStr = sTmpStr & sReplaceWithStr
                sTmpStr = sTmpStr & Mid(sOrigStr, lPos + lFindStr, Len(sOrigStr) - (lPos + lFindStr - 1))
                sOrigStr = sTmpStr
            End If
            lPos2 = lPos + 1
        Loop
        sOrigStr = sTmpStr
        Exit Sub

vbErrorHandler:
        Err.Raise(Err.Number, "StrHandler ReplaceAll", Err.Description)


    End Sub
	Private Function IsIDE() As Boolean
		'Click this button if the project name and the compiled file
		'name are the same.
		
		Dim strFileName As String
		Dim lngCount As Integer
		
		strFileName = New String(Chr(0), 255)
		lngCount = GetModuleFileName(VB6.GetHInstance.ToInt32, strFileName, 255)
		strFileName = Left(strFileName, lngCount)
		
		If UCase(Right(strFileName, 7)) <> "VB6.EXE" Then
			IsIDE = False
		Else
			IsIDE = True
		End If
	End Function
    Sub pause(ByRef p As Double)
        Dim Pausenlaenge, Start As Double
        'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Pausenlaenge. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Pausenlaenge = p ' Dauer festlegen.
        'UPGRADE_WARNING: Couldn't resolve default property of object Start. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Start = VB.Timer() ' Anfangszeit setzen.
        'UPGRADE_WARNING: Couldn't resolve default property of object Pausenlaenge. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Start. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Do While VB.Timer() < Start + Pausenlaenge
            System.Windows.Forms.Application.DoEvents() ' Steuerung an andere Prozesse
            ' abgeben.
        Loop
    End Sub
	Sub dia_exit()
		Diashow_Ende = True
		slide.Timer1.Enabled = False
		'SetWindowPos Me.hwnd, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_SHOWWINDOW Or SWP_NOMOVE Or SWP_NOSIZE
		bildschirm.Close()
		'bildschirm.Visible = False
		'bildschirm.Hide
		slide.Close()
		'slide.WindowState = vbNormal
		Hauptform.Show()
	End Sub
	
	Sub write_top_htm()
		Dim htm As String
		
		htm = "<!DOCTYPE HTML PUBLIC " & ii & "-//W3C//DTD HTML 4.0 Transitional//EN" & ii & ">"
		htm = htm & "<html>"
		htm = htm & ""
		htm = htm & "<head>"
		htm = htm & "<title>Der Biedermann, Landhausmöbel in Wuppertal</title>"
		'UPGRADE_WARNING: Couldn't resolve default property of object keywords_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		htm = htm + keywords_htm 'NEU okt 2006
		'htm = htm + "<META NAME=" + ii + "author" + ii + "CONTENT=" + ii + "HJG" + ii + ">"
		'htm = htm + "<META NAME=" + ii + "copyright" + ii + "CONTENT=" + ii + "HJG" + ii + ">"
		'htm = htm + "<META NAME=" + ii + "keywords" + ii + "CONTENT=" + ii + "Der Biedermann, Landhausm&ouml;bel, Wuppertal, Naturholz, M&ouml;bel, Tische, Schr&auml;nke, St&uuml;hle, Bett, Stuhl, Tisch, Schrank, Kasten " + ii + ">"
		'htm = htm + "<META NAME=" + ii + "description" + ii + "CONTENT=" + ii + "Naturholzm&ouml;bel im Landhausstil " + ii + ">"
		'htm = htm + "<META NAME=" + ii + "audience" + ii + "CONTENT=" + ii + "Alle" + ii + ">"
		'htm = htm + "<META NAME=" + ii + "page-type" + ii + "CONTENT=" + ii + "Möbelhandel" + ii + ">"
		'htm = htm + "<META NAME=" + ii + "robots" + ii + "CONTENT=" + ii + "INDEX,FOLLOW" + ii + ">"
		htm = htm & "</head>"
		htm = htm & "<body bgcolor=" & ii & farben(portal_bgcolor).html & ii
		htm = htm & " text=" & ii & farben(portal_txtcolor).html & ii
		htm = htm & " link=" & ii & farben(portal_link).html & ii
		htm = htm & " vlink=" & ii & farben(portal_vlink).html & ii
		htm = htm & " alink=" & ii & farben(portal_alink).html & ii & ">" & vbCrLf
		htm = htm & "<blockquote>"
		htm = htm & "<p><a href=" & ii & "index.htm" & ii & " target=" & ii & "_parent" & ii & ">"
		If bg_top = 1 Then
			htm = htm & "<img src=" & ii & "_topback.gif" & ii & " alt border=" & ii & "0" & ii & "></a><br>"
		Else
			htm = htm & "<h3>Der Biedermann</h3></a><br>"
		End If
		htm = htm & "</blockquote>"
		'UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		htm = htm + Der_Biedermann
		htm = htm & "</body>"
		htm = htm & "</html>"
        Dim f As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(f, AppPath & "\_top.htm", OpenMode.Output)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, htm)
		FileClose((f))
	End Sub
End Module