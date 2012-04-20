using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

    using ICSharpCode.SharpZipLib.Core;
    using ICSharpCode.SharpZipLib.Zip;

namespace BiederZip3
{
    public partial class FormZIP : Form
    {
        BiederDB3.BiederDBSettings2 _settings;

        public FormZIP()
        {
            InitializeComponent();
            _settings = new BiederDB3.BiederDBSettings2();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFile.Text))
                return;
            if (List1.SelectedIndex == -1)
            {
                List1.Items.Add(txtFile.Text);
            }
            else
            {
                List1.Items.Insert(List1.SelectedIndex + 1, txtFile.Text);
                List1.SelectedIndex = List1.SelectedIndex + 1;
            }

        }

        private void bt_autofill_Click(object sender, EventArgs e)
        {
            //Dim db As Database
            Cursor = System.Windows.Forms.Cursors.WaitCursor;
            enableControls(false, this);

            List1.Items.Clear();
            List1.Items.Add(_settings.datenbank);
            
            List1.Items.Add((_settings.webRoot + "\\*.*"));
            List1.Items.Add((BiederDB3.Utils.AppPath + "*.*"));

            BiederDB3.Datenbank _db = new BiederDB3.Datenbank();

            int iResult = _db.executeQuery("Drop table VList;");
            iResult = _db.executeQuery("SELECT FOTO,Art_ID INTO VList FROM Artikel where Besteld>0;");
            Application.DoEvents();

            //DataTable _dt = _db.getTable("SELECT DISTINCT FOTO INTO VList FROM Artikel where Besteld>0");
            BiederDB3.dataclasses.VList _vlist = new BiederDB3.dataclasses.VList(ref _db);
            Application.DoEvents();
            
            System.Threading.Thread.Sleep(500);
            BiederDB3.dataclasses.VList.vlist[] vListe = _vlist.getVList("");
            
            if (vListe == null)
            {
                BiederDB3.Utils.showErrorMsg("Leere Liste", "Dateiliste erstellen");
                enableControls(true, this);
                Cursor = System.Windows.Forms.Cursors.Default;
                return;
            }
            int RecordCount = vListe.Length;
            
            for (int i = 0; i < RecordCount; i++)
            {
                string sFoto ="";
                try 
	            {
                    sFoto = vListe[i].Foto;
	            }
	            catch (Exception)
	            {
	            }
                Application.DoEvents();
                if (sFoto.Length > 0)
                {
                    string t = System.IO.Path.GetDirectoryName(sFoto);
                    if(!t.EndsWith("\\"))
                        t+="\\";
                    //t = GetPfad(VList.Fields("Foto").Value);
                    vListe[i].Foto=t;
                    _vlist.update(vListe[i]);
                }
            }
            //VList = db.CreateDynaset("SELECT DISTINCT FOTO FROM VList order by FOTO");
            //VList.MoveLast();
            //VList.MoveFirst();
            for (int i = 0; i < RecordCount; i++)
            {
                Application.DoEvents();
                if (vListe[i].Foto.Length > 0)
                {
                    if(!List1.Items.Contains(vListe[i].Foto + "*.*"))
                        List1.Items.Add(vListe[i].Foto + "*.*");
                }
            }
            
            Application.DoEvents();
            Cursor = System.Windows.Forms.Cursors.Default;
            enableControls(true, this);
            _db.Dispose();  //close database file

        }
        bool enableControls(bool bEnable, Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c.HasChildren)
                    return enableControls(bEnable, c);
                if (c.Name.StartsWith("bt_") || c.Name.StartsWith("opt_") || c.Name.StartsWith("txt"))
                    c.Enabled = bEnable;
            }
            return true;
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.DereferenceLinks = true;
            ofd.InitialDirectory = BiederDB3.Utils.AppPath;
            ofd.Multiselect=false;
            if (ofd.ShowDialog() == DialogResult.OK)
                txtFile.Text = ofd.FileName;
            ofd.Dispose();
        }

        private void bt_suchdir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            //ofd.RootFolder = BiederDB3.Utils.AppPath;
            ofd.ShowNewFolderButton = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sPath = ofd.SelectedPath;
                if (!sPath.EndsWith("\\"))
                    sPath += "\\";
                txtFile.Text = sPath + "*.*";
            }
            ofd.Dispose();
        }

        private void bt_change_Click(object sender, EventArgs e)
        {
            int idx = List1.SelectedIndex;
            if(idx==-1)
                return;
            object old;
            old=List1.SelectedItem;
            List1.Items.Remove(old);
            txtFile.Text=old.ToString();
            if(idx>1)
                List1.SelectedIndex=idx-1;
        }

        private void bt_zipfilename_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = false;
            ofd.SupportMultiDottedExtensions = true;            
            ofd.CheckPathExists = true;
            ofd.DereferenceLinks = true;
            ofd.InitialDirectory = BiederDB3.Utils.AppPath;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
                txtBackupfile.Text = ofd.FileName;
            ofd.Dispose();

        }

        private void Command1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.DereferenceLinks = true;
            ofd.InitialDirectory = BiederDB3.Utils.AppPath;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
                txtFile.Text = ofd.FileName;
            ofd.Dispose();

        }

        private void bt_targetdir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            //ofd.RootFolder = BiederDB3.Utils.AppPath;
            ofd.ShowNewFolderButton = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sPath = ofd.SelectedPath;
                if (!sPath.EndsWith("\\"))
                    sPath += "\\";
                txtExtractTo.Text = sPath + "*.*";
            }
            ofd.Dispose();

        }

        private void bt_zip_start_Click(object sender, EventArgs e)
        {
            if( BiederDB3.Utils.showQuestionYesNo("Alle in der Liste aufgeführten Dateien/Verzeichnisse jetzt sichern?", "Backup erstellen")==false)
                return;
            if (System.IO.File.Exists(txtBackupfile.Text))
            {
                if (BiederDB3.Utils.showQuestionYesNo("ZIP Datei existiert bereits. Löschen?", "Datei überschreiben") == false)
                    return;
                else
                    System.IO.File.Delete(txtBackupfile.Text);
            }

            enableControls(false, this);
            
            System.Windows.Forms.Application.DoEvents();
            Cursor = System.Windows.Forms.Cursors.WaitCursor;
            List<string> Files = new List<string>();
            int i = 0;
            
            //Start the process
            //First check if there is something to do
            if (List1.Items.Count < 1)
            {
                BiederDB3.Utils.showInfoMsg("There is nothing to do!", "Backup erstellen");
                enableControls(true, this);
                return;
            }
            addLog("Starting ZIP Backup++++++++++++++++++++++++++++++++++");
            FileStream fsOut = File.Create(txtBackupfile.Text);
            ZipOutputStream zipStream = new ZipOutputStream(fsOut);

            zipStream.SetLevel(3); //0-9, 9 being the highest level of compression

            zipStream.Password = "";	// optional. Null is the same as not setting.
            //vbzip.Filename = Text2.Text;

            //Set the files to process
            for (i = 0; i < List1.Items.Count; i++)
            {
                if(!Files.Contains(List1.Items[i].ToString()))
                    Files.Add(List1.Items[i].ToString());
            }

            bool UsePathInfo = true;
            bool Use83Format = false;

            //Start the processing
            foreach (string s in Files)
            {
                if (s.EndsWith("*.*"))
                {
                    string folderName = System.IO.Path.GetDirectoryName(s);
                    System.Diagnostics.Debug.WriteLine("Adding " + folderName);
                    addLog("Adding " + folderName);
                    // This setting will strip the leading part of the folder path in the entries, to
                    // make the entries relative to the starting folder.
                    // To include the full path for each entry up to the drive root, assign folderOffset = 0.
                    int folderOffset = folderName.Length + (folderName.EndsWith("\\") ? 0 : 1);

                    CompressFolder(folderName, zipStream, folderOffset);
                }
                else
                {
                    addLog("Adding " + s);
                    System.Diagnostics.Debug.WriteLine("Adding " + s);
                    compressFile(s, zipStream);
                }
            }

            zipStream.IsStreamOwner = true;	// Makes the Close also Close the underlying stream
            zipStream.Close();

//            vbzip.@add(Files, biederzip_mod.ZipAction.zipDefault, UsePathInfo, false, Use83Format, biederzip_mod.ZipLevel.zipFast);
            Cursor = System.Windows.Forms.Cursors.Default;
            BiederDB3.Utils.showInfoMsg("Alle Dateien gesichert. Die Backup-Datei >" + txtBackupfile.Text + "< nun auf eine CD brennen und diese dann auf dem Zielsystem zum Wiederherstellen benutzen.", "Hinweis");
            enableControls(true, this);
            this.Activate();
            addLog("ZIP Backup ended ===========================");
        }
        delegate void SetTextCallback(string text);
        private void addLog(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lblFiles.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(addLog);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                lblFiles.Text = text;
                BiederDB3.LoggerClass.log(text);
                Application.DoEvents();
                //if (lblFiles.Text.Length > 2000)
                //    lblFiles.Text = "";
                //lblFiles.Text += text + "\r\n";
                //lblFiles.SelectionLength = text.Length;
                //lblFiles.SelectionStart = txtLog.Text.Length - text.Length;
                //lblFiles.ScrollToCaret();
            }
        }

        private void txtBackupfile_TextChanged(object sender, EventArgs e)
        {

        }

        #region ICSharpZipLib
        public void CreateSample(string outPathname, string password, string folderName)
        {

            FileStream fsOut = File.Create(outPathname);
            ZipOutputStream zipStream = new ZipOutputStream(fsOut);

            zipStream.SetLevel(3); //0-9, 9 being the highest level of compression

            zipStream.Password = password;	// optional. Null is the same as not setting.

            // This setting will strip the leading part of the folder path in the entries, to
            // make the entries relative to the starting folder.
            // To include the full path for each entry up to the drive root, assign folderOffset = 0.
            int folderOffset = folderName.Length + (folderName.EndsWith("\\") ? 0 : 1);

            CompressFolder(folderName, zipStream, folderOffset);

            zipStream.IsStreamOwner = true;	// Makes the Close also Close the underlying stream
            zipStream.Close();
        }
        private void compressFile(string sFile, ZipOutputStream zipStream)
        {
            FileInfo fi = new FileInfo(sFile);
            string entryName = ZipEntry.CleanName(sFile);
            ZipEntry newEntry = new ZipEntry(entryName);
            newEntry.DateTime = fi.LastWriteTime;
            newEntry.Size = fi.Length;
            zipStream.PutNextEntry(newEntry);
            // Zip the file in buffered chunks
            // the "using" will close the stream even if an exception occurs
            byte[] buffer = new byte[4096];
            addLog("Adding " + sFile);
            try
            {
                using (FileStream streamReader = File.OpenRead(sFile))
                {
                    StreamUtils.Copy(streamReader, zipStream, buffer);
                }
            }
            catch (ZipException ex)
            {
                newEntry.Comment = "could not save file";
                addLog("could not save file " + sFile);
                newEntry.Size = 0;
                System.Diagnostics.Debug.WriteLine("Exception in Zip File: '" + sFile + "', " + ex.Message);
            }
            catch (Exception ex)
            {
                newEntry.Comment = "could not save file";
                addLog("could not save file " + sFile);
                newEntry.Size = 0;
                System.Diagnostics.Debug.WriteLine("Exception in Zip File: '" + sFile + "', " + ex.Message);
            }
            zipStream.CloseEntry();
        }
        // Recurses down the folder structure
        //
        private void CompressFolder(string path, ZipOutputStream zipStream, int folderOffset)
        {

            string[] files = Directory.GetFiles(path);

            foreach (string filename in files)
            {

                FileInfo fi = new FileInfo(filename);

                string entryName = filename;//.Substring(folderOffset); // Makes the name in zip based on the folder
                entryName = ZipEntry.CleanName(entryName); // Removes drive from name and fixes slash direction
                ZipEntry newEntry = new ZipEntry(entryName);
                newEntry.DateTime = fi.LastWriteTime; // Note the zip format stores 2 second granularity

                // Specifying the AESKeySize triggers AES encryption. Allowable values are 0 (off), 128 or 256.
                //   newEntry.AESKeySize = 256;

                // To permit the zip to be unpacked by built-in extractor in WinXP and Server2003, WinZip 8, Java, and other older code,
                // you need to do one of the following: Specify UseZip64.Off, or set the Size.
                // If the file may be bigger than 4GB, or you do not need WinXP built-in compatibility, you do not need either,
                // but the zip will be in Zip64 format which not all utilities can understand.
                //   zipStream.UseZip64 = UseZip64.Off;
                newEntry.Size = fi.Length;

                zipStream.PutNextEntry(newEntry);

                // Zip the file in buffered chunks
                // the "using" will close the stream even if an exception occurs
                byte[] buffer = new byte[4096];
                addLog("Adding " + filename);
                try
                {
                    using (FileStream streamReader = File.OpenRead(filename))
                    {
                        StreamUtils.Copy(streamReader, zipStream, buffer);
                    }
                }
                catch (ZipException ex)
                {
                    newEntry.Comment = "could not save file";
                    addLog("could not save file " + filename);
                    newEntry.Size = 0;
                    System.Diagnostics.Debug.WriteLine("Exception in Zip File: '" + filename + "', " + ex.Message);
                }
                catch (Exception ex)
                {
                    newEntry.Comment = "could not save file";
                    addLog("could not save file " + filename);
                    newEntry.Size = 0;
                    System.Diagnostics.Debug.WriteLine("Exception in Zip File: '" + filename + "', " + ex.Message);
                }
                zipStream.CloseEntry();
            }
            string[] folders = Directory.GetDirectories(path);
            foreach (string folder in folders)
            {
                CompressFolder(folder, zipStream, folderOffset);
            }
        }

        public void ExtractZipFile(string archiveFilenameIn, string password, string outFolder) {
	        ZipFile zf = null;
	        try {
		        FileStream fs = File.OpenRead(archiveFilenameIn);
		        zf = new ZipFile(fs);
		        if (!String.IsNullOrEmpty(password)) {
			        zf.Password = password;		// AES encrypted entries are handled automatically
		        }
		        foreach (ZipEntry zipEntry in zf) {
			        if (!zipEntry.IsFile) {
				        continue;			// Ignore directories
			        }
			        String entryFileName = zipEntry.Name;
			        // to remove the folder from the entry:- entryFileName = Path.GetFileName(entryFileName);
			        // Optionally match entrynames against a selection list here to skip as desired.
			        // The unpacked length is available in the zipEntry.Size property.

			        byte[] buffer = new byte[4096];		// 4K is optimum
			        Stream zipStream = zf.GetInputStream(zipEntry);

			        // Manipulate the output filename here as desired.
			        String fullZipToPath = Path.Combine(outFolder, entryFileName);
			        string directoryName = Path.GetDirectoryName(fullZipToPath);
			        if (directoryName.Length > 0)
				        Directory.CreateDirectory(directoryName);

			        // Unzip file in buffered chunks. This is just as fast as unpacking to a buffer the full size
			        // of the file, but does not waste memory.
			        // The "using" will close the stream even if an exception occurs.
			        using (FileStream streamWriter = File.Create(fullZipToPath)) {
				        StreamUtils.Copy(zipStream, streamWriter, buffer);
			        }
		        }
	        } finally {
		        if (zf != null) {
			        zf.IsStreamOwner = true; // Makes close also shut the underlying stream
			        zf.Close(); // Ensure we release resources
		        }
	        }
        }
#endregion

        private void bt_TEST_Click(object sender, EventArgs e)
        {
            CreateSample(@"e:\test.zip", "", @"C:\Applicaties\Foto's artikelen\Bedden");
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
                myProcess.StartInfo.FileName = BiederDB3.Utils.AppPath + "BiederDB3.exe";
                myProcess.Start();
                myProcess.Close();
            }catch(Exception){}
            Application.Exit();            
        }
    }
}
