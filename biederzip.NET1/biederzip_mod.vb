Option Strict Off
Option Explicit On
Module biederzip_mod
	Public Enum ZipAction
		zipDefault = 1
		zipFreshen = 2
		zipUpdate = 3
	End Enum
	Public Enum ZipLevel
		zipStore = 0
		zipLevel1 = 1
		zipSuperFast = 2
		zipFast = 3
		zipLevel4 = 4
		zipNormal = 5
		zipLevel6 = 6
		zipLevel7 = 7
		zipLevel8 = 8
		zipMax = 9
	End Enum
	Public AppPath As String
	Private Declare Function SendMessage Lib "user32"  Alias "SendMessageA"(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer
	'UPGRADE_WARNING: Structure BrowseInfo may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function SHBrowseForFolder Lib "shell32" (ByRef lpbi As BrowseInfo) As Integer
	Private Declare Function SHGetPathFromIDList Lib "shell32" (ByVal pidList As Integer, ByVal lpBuffer As String) As Integer
	Private Declare Function lstrcat Lib "kernel32"  Alias "lstrcatA"(ByVal lpString1 As String, ByVal lpString2 As String) As Integer
	Private Declare Function GetModuleFileName Lib "kernel32"  Alias "GetModuleFileNameA"(ByVal hModule As Integer, ByVal lpFileName As String, ByVal nSize As Integer) As Integer
	
	Private Const BIF_STATUSTEXT As Integer = &H4
	Private Const BIF_RETURNONLYFSDIRS As Short = 1
	Private Const BIF_DONTGOBELOWDOMAIN As Short = 2
	Private Const MAX_PATH As Short = 260
	
	Private Const WM_USER As Integer = &H400
	Private Const BFFM_INITIALIZED As Short = 1
	Private Const BFFM_SELCHANGED As Short = 2
	Private Const BFFM_SETSTATUSTEXT As Decimal = (WM_USER + 100)
	Private Const BFFM_SETSELECTION As Decimal = (WM_USER + 102)
	
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
	Public datenbank As Object
	Public sortField As Object
	Public webroot As Object
	Public ShowTime As Object
	Public ii As Object
	Public Counter_htm As Object
	Public Top_Gif As Object
	Public keywords_htm As Object
	Public et As Object
	Public cr As Object
	Public webkopf As Object
	Public startpage As Object
	Public iview As Object
	Public db As DAO.Database
	
	Private m_CurrentDirectory As String 'The current directory
	'UPGRADE_WARNING: Application will terminate when Sub Main() finishes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="E08DDC71-66BA-424F-A612-80AF11498FF8"'
	Public Sub Main()
		On Error GoTo dateifehler
		Dim i As Short
		If IsIDE Then AppPath = "c:\Programme\BiederDB" Else AppPath = My.Application.Info.DirectoryPath
		'UPGRADE_WARNING: Couldn't resolve default property of object ShowTime. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ShowTime = 3
		'UPGRADE_WARNING: Couldn't resolve default property of object ii. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ii = Chr(34)
		'<a href="index.htm" target="_parent"><img src="top.gif" width="600" height="60" alt border="0"></a>
		'UPGRADE_WARNING: Couldn't resolve default property of object Counter_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Counter_htm = "<img  src=" & Chr(34) & "http://cgicounter.puretec.de/cgi-bin/cnt?clsid=86ee91a0ccefec60568de1c4fd0c04601" & Chr(34) & ">"
		'UPGRADE_WARNING: Couldn't resolve default property of object ii. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Top_Gif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Top_Gif = "<a href=" + ii + "index.htm" + ii + " target=" + ii + "_parent" + ii + "><img src=" + Chr(34) + "_topback.gif" + Chr(34) + " width=" + Chr(34) + "600" + Chr(34) + " height=" + Chr(34) + "60" + Chr(34) + " alt border=" + Chr(34) + "0" + Chr(34) + "></a><br>"
		'UPGRADE_WARNING: Couldn't resolve default property of object keywords_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		keywords_htm = "<meta name=" & Chr(34) & "keywords" & Chr(34) & " content=" & Chr(34) & "Der Biedermann, Landhausmöbel, Wuppertal, Naturholz, Möbel, Tische, Schränke, Stühle, Bett, Stuhl, Tisch, Schrank, Kasten" & Chr(34) & ">"
		'UPGRADE_WARNING: Couldn't resolve default property of object et. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		et = Chr(13) ' Zeilenvorschub
		'UPGRADE_WARNING: Couldn't resolve default property of object cr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cr = Chr(13) & Chr(10)
		'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		datenbank = "c:\programme\furniture\cddatabase.mdb"
		'UPGRADE_WARNING: Couldn't resolve default property of object sortField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sortField = "HGR_ID"
		'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		webroot = "c:\bieder.web1"
		'UPGRADE_WARNING: Couldn't resolve default property of object webkopf. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		webkopf = My.Application.Info.DirectoryPath & "\_top.htm"
		'UPGRADE_WARNING: Couldn't resolve default property of object startpage. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		startpage = My.Application.Info.DirectoryPath & "\_start.htm"
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Dir(My.Application.Info.DirectoryPath & "\biederdb.ini") = "" Then write_ini()
		read_ini()
		'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Not existfile(datenbank) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			datenbank = InputBox("Bitte Datenbank angeben", "Datenbank nicht gefunden", datenbank)
			'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not existfile(datenbank) Then
				MsgBox("Schwerwiegender Fehler, kann ohne Datenbank nicht arbeiten!", MsgBoxStyle.OKOnly)
				End
			End If
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object iview. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Not existfile(iview) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object iview. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			iview = InputBox("Bitte IrfanView angeben", "Umwandlungsprogramm nicht gefunden", iview)
			'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If datenbank = "" Then
				MsgBox("Ohne IrfanView können Thumbnails nicht automatisch erstellt werden!", MsgBoxStyle.OKOnly)
			End If
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		db = DAODBEngine_definst.OpenDatabase(datenbank, False, False)
		'patch_db
		zip_frm.Show()
		'SendKeys "{F10}~"
		Exit Sub
		
dateifehler: 
		'UPGRADE_WARNING: Couldn't resolve default property of object et. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MsgBox("Fehler beim Laden der Datenbank " + datenbank & et & "Fehlernr:" & CStr(Err.Number), 16, "Problem")
		Exit Sub
		Resume Next
	End Sub
	
	Sub read_ini()
		Dim f As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(f, My.Application.Info.DirectoryPath & "\biederdb.ini", OpenMode.Input)
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
		FileClose(f)
		
	End Sub
	Public Function BrowseForFolder(ByRef owner As System.Windows.Forms.Form, ByRef Title As String, ByVal StartDir As String) As String
		'Opens a Treeview control that displays the directories in a computer
		
		Dim lpIDList As Integer
		Dim szTitle As String
		Dim sBuffer As String
		Dim tBrowseInfo As BrowseInfo
		m_CurrentDirectory = StartDir & vbNullChar
		
		szTitle = Title
		With tBrowseInfo
			.hWndOwner = owner.Handle.ToInt32
			.lpszTitle = lstrcat(szTitle, "")
			.ulFlags = BIF_RETURNONLYFSDIRS + BIF_DONTGOBELOWDOMAIN + BIF_STATUSTEXT
			'UPGRADE_WARNING: Add a delegate for AddressOf BrowseCallbackProc Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="E9E157F7-EF0C-4016-87B7-7D7FBBC6EE08"'
			.lpfnCallback = GetAddressofFunction(AddressOf BrowseCallbackProc) 'get address of function.
		End With
		
		lpIDList = SHBrowseForFolder(tBrowseInfo)
		If (lpIDList) Then
			sBuffer = Space(MAX_PATH)
			SHGetPathFromIDList(lpIDList, sBuffer)
			sBuffer = Left(sBuffer, InStr(sBuffer, vbNullChar) - 1)
			BrowseForFolder = sBuffer
		Else
			BrowseForFolder = ""
		End If
		
	End Function
	
	Private Function BrowseCallbackProc(ByVal hwnd As Integer, ByVal uMsg As Integer, ByVal lp As Integer, ByVal pData As Integer) As Integer
		
		Dim lpIDList As Integer
		Dim ret As Integer
		Dim sBuffer As String
		
		On Error Resume Next 'Sugested by MS to prevent an error from
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
		
		Dim i As Short
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
	Function existfile(ByVal DateiName As String) As Short
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
	
	Function GetPfad(ByVal s As String) As Object
		Dim f, p, e As String
		FileSplit(s, p, f, e)
		'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetPfad = p
	End Function
	Function GetFilename(ByVal s As String) As Object
		Dim f, p, e As String
		FileSplit(s, p, f, e)
		'UPGRADE_WARNING: Couldn't resolve default property of object GetFilename. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetFilename = f
	End Function
	Function GetExtension(ByVal s As String) As Object
		Dim f, p, e As String
		FileSplit(s, p, f, e)
		'UPGRADE_WARNING: Couldn't resolve default property of object GetExtension. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetExtension = e
	End Function
	
	Sub write_ini()
		
		Dim f As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(f, My.Application.Info.DirectoryPath & "\biederdb.ini", OpenMode.Output)
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
		FileClose(f)
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
End Module