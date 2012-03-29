namespace BiederDB3
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtHPrijsOnb = new System.Windows.Forms.TextBox();
            this.txtHPrijsBew = new System.Windows.Forms.TextBox();
            this.lstGroups = new System.Windows.Forms.ComboBox();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.CommonDialog1Open = new System.Windows.Forms.OpenFileDialog();
            this._label1_6 = new System.Windows.Forms.Label();
            this._label1_7 = new System.Windows.Forms.Label();
            this._label1_8 = new System.Windows.Forms.Label();
            this._label1_9 = new System.Windows.Forms.Label();
            this.txtWPrijsBew = new System.Windows.Forms.TextBox();
            this.btnMoveBack = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.txtWPrijsOnb = new System.Windows.Forms.TextBox();
            this.chkBewerkt = new System.Windows.Forms.CheckBox();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstHgr_Id = new System.Windows.Forms.ComboBox();
            this.txtBesteld = new System.Windows.Forms.TextBox();
            this.btnNewHgr_Id = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.txtArtNr = new System.Windows.Forms.TextBox();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.txtMaat = new System.Windows.Forms.TextBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.txtHgrId = new System.Windows.Forms.TextBox();
            this.txtBewerkt = new System.Windows.Forms.TextBox();
            this._Label4_2 = new System.Windows.Forms.Label();
            this._Label4_1 = new System.Windows.Forms.Label();
            this._Label4_0 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictFoto = new System.Windows.Forms.PictureBox();
            this._label1_5 = new System.Windows.Forms.Label();
            this._label1_0 = new System.Windows.Forms.Label();
            this._label1_1 = new System.Windows.Forms.Label();
            this._label1_2 = new System.Windows.Forms.Label();
            this._label1_3 = new System.Windows.Forms.Label();
            this._label1_4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusArtID = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusDataChanged = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkVerwendungAnderes = new System.Windows.Forms.RadioButton();
            this.chkVerwendungWeb = new System.Windows.Forms.RadioButton();
            this.chkVerwendungDia = new System.Windows.Forms.RadioButton();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictFoto)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrint.Location = new System.Drawing.Point(532, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrint.Size = new System.Drawing.Size(65, 25);
            this.btnPrint.TabIndex = 62;
            this.btnPrint.Text = "Drucken";
            this.ToolTip1.SetToolTip(this.btnPrint, "Druckt eine Kopie der aktuellen Darstellung");
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStop.Enabled = false;
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.Location = new System.Drawing.Point(484, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStop.Size = new System.Drawing.Size(41, 25);
            this.btnStop.TabIndex = 61;
            this.btnStop.Text = "Stop";
            this.ToolTip1.SetToolTip(this.btnStop, "Stoppt die DIA-Show");
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 5000;
            // 
            // txtHPrijsOnb
            // 
            this.txtHPrijsOnb.AcceptsReturn = true;
            this.txtHPrijsOnb.BackColor = System.Drawing.SystemColors.Window;
            this.txtHPrijsOnb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHPrijsOnb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHPrijsOnb.Location = new System.Drawing.Point(8, 32);
            this.txtHPrijsOnb.MaxLength = 0;
            this.txtHPrijsOnb.Name = "txtHPrijsOnb";
            this.txtHPrijsOnb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHPrijsOnb.Size = new System.Drawing.Size(65, 20);
            this.txtHPrijsOnb.TabIndex = 2;
            this.txtHPrijsOnb.Text = "Besteld";
            this.ToolTip1.SetToolTip(this.txtHPrijsOnb, "Hier eine Zahl > 0 eingeben, damit Artikel für Web publiziert wird");
            this.txtHPrijsOnb.Validated += new System.EventHandler(this.txtPrijsOnb_Validated);
            // 
            // txtHPrijsBew
            // 
            this.txtHPrijsBew.AcceptsReturn = true;
            this.txtHPrijsBew.BackColor = System.Drawing.SystemColors.Window;
            this.txtHPrijsBew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHPrijsBew.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHPrijsBew.Location = new System.Drawing.Point(88, 32);
            this.txtHPrijsBew.MaxLength = 0;
            this.txtHPrijsBew.Name = "txtHPrijsBew";
            this.txtHPrijsBew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHPrijsBew.Size = new System.Drawing.Size(73, 20);
            this.txtHPrijsBew.TabIndex = 3;
            this.txtHPrijsBew.Text = "Besteld";
            this.ToolTip1.SetToolTip(this.txtHPrijsBew, "Hier eine Zahl > 0 eingeben, damit Artikel für Web publiziert wird");
            this.txtHPrijsBew.Validated += new System.EventHandler(this.txtPrijsBew_Validated);
            // 
            // lstGroups
            // 
            this.lstGroups.BackColor = System.Drawing.SystemColors.Window;
            this.lstGroups.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstGroups.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstGroups.Location = new System.Drawing.Point(132, 42);
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstGroups.Size = new System.Drawing.Size(161, 21);
            this.lstGroups.TabIndex = 76;
            this.ToolTip1.SetToolTip(this.lstGroups, "Wählen Sie die Gruppe aus, deren Artikel Sie anzeigen/bearbeiten wollen");
            this.lstGroups.SelectedIndexChanged += new System.EventHandler(this.lstGroups_SelectedIndexChanged);
            // 
            // btnNeu
            // 
            this.btnNeu.BackColor = System.Drawing.SystemColors.Control;
            this.btnNeu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNeu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNeu.Location = new System.Drawing.Point(12, 10);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNeu.Size = new System.Drawing.Size(57, 25);
            this.btnNeu.TabIndex = 52;
            this.btnNeu.Text = "Neu";
            this.ToolTip1.SetToolTip(this.btnNeu, "Klicken um neue Daten einzugeben");
            this.btnNeu.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(444, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStart.Size = new System.Drawing.Size(41, 25);
            this.btnStart.TabIndex = 60;
            this.btnStart.Text = "Start";
            this.ToolTip1.SetToolTip(this.btnStart, "Startet die DIA-Show. Das Intervall wird unter Optionen-Einstellungen angegeben.");
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // _label1_6
            // 
            this._label1_6.AutoSize = true;
            this._label1_6.BackColor = System.Drawing.Color.Transparent;
            this._label1_6.Cursor = System.Windows.Forms.Cursors.Default;
            this._label1_6.Enabled = false;
            this._label1_6.ForeColor = System.Drawing.SystemColors.WindowText;
            this._label1_6.Location = new System.Drawing.Point(32, 56);
            this._label1_6.Name = "_label1_6";
            this._label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._label1_6.Size = new System.Drawing.Size(56, 13);
            this._label1_6.TabIndex = 37;
            this._label1_6.Text = "HEK unb.:";
            this._label1_6.Visible = false;
            // 
            // _label1_7
            // 
            this._label1_7.AutoSize = true;
            this._label1_7.BackColor = System.Drawing.Color.Transparent;
            this._label1_7.Cursor = System.Windows.Forms.Cursors.Default;
            this._label1_7.Enabled = false;
            this._label1_7.ForeColor = System.Drawing.SystemColors.WindowText;
            this._label1_7.Location = new System.Drawing.Point(32, 80);
            this._label1_7.Name = "_label1_7";
            this._label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._label1_7.Size = new System.Drawing.Size(56, 13);
            this._label1_7.TabIndex = 36;
            this._label1_7.Text = "HEK beh.:";
            this._label1_7.Visible = false;
            // 
            // _label1_8
            // 
            this._label1_8.AutoSize = true;
            this._label1_8.BackColor = System.Drawing.Color.Transparent;
            this._label1_8.Cursor = System.Windows.Forms.Cursors.Default;
            this._label1_8.ForeColor = System.Drawing.SystemColors.WindowText;
            this._label1_8.Location = new System.Drawing.Point(8, 16);
            this._label1_8.Name = "_label1_8";
            this._label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._label1_8.Size = new System.Drawing.Size(71, 13);
            this._label1_8.TabIndex = 35;
            this._label1_8.Text = "Unbehandelt:";
            // 
            // _label1_9
            // 
            this._label1_9.AutoSize = true;
            this._label1_9.BackColor = System.Drawing.Color.Transparent;
            this._label1_9.Cursor = System.Windows.Forms.Cursors.Default;
            this._label1_9.ForeColor = System.Drawing.SystemColors.WindowText;
            this._label1_9.Location = new System.Drawing.Point(88, 16);
            this._label1_9.Name = "_label1_9";
            this._label1_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._label1_9.Size = new System.Drawing.Size(58, 13);
            this._label1_9.TabIndex = 34;
            this._label1_9.Text = "Behandelt:";
            // 
            // txtWPrijsBew
            // 
            this.txtWPrijsBew.AcceptsReturn = true;
            this.txtWPrijsBew.BackColor = System.Drawing.SystemColors.Window;
            this.txtWPrijsBew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWPrijsBew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWPrijsBew.Enabled = false;
            this.txtWPrijsBew.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWPrijsBew.Location = new System.Drawing.Point(88, 80);
            this.txtWPrijsBew.MaxLength = 0;
            this.txtWPrijsBew.Name = "txtWPrijsBew";
            this.txtWPrijsBew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWPrijsBew.Size = new System.Drawing.Size(57, 20);
            this.txtWPrijsBew.TabIndex = 32;
            this.txtWPrijsBew.TabStop = false;
            this.txtWPrijsBew.Text = "Besteld";
            this.ToolTip1.SetToolTip(this.txtWPrijsBew, "Hier eine Zahl > 0 eingeben, damit Artikel für Web publiziert wird");
            this.txtWPrijsBew.Visible = false;
            // 
            // btnMoveBack
            // 
            this.btnMoveBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnMoveBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMoveBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMoveBack.Location = new System.Drawing.Point(372, 10);
            this.btnMoveBack.Name = "btnMoveBack";
            this.btnMoveBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMoveBack.Size = new System.Drawing.Size(33, 25);
            this.btnMoveBack.TabIndex = 58;
            this.btnMoveBack.Text = "<<";
            this.ToolTip1.SetToolTip(this.btnMoveBack, "Zurück");
            this.btnMoveBack.UseVisualStyleBackColor = false;
            this.btnMoveBack.Click += new System.EventHandler(this.btnMoveBack_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInsert.Location = new System.Drawing.Point(308, 10);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInsert.Size = new System.Drawing.Size(65, 25);
            this.btnInsert.TabIndex = 57;
            this.btnInsert.Text = "Einfügen";
            this.ToolTip1.SetToolTip(this.btnInsert, "Kopierte Daten einfügen");
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.Control;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCopy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCopy.Location = new System.Drawing.Point(244, 10);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCopy.Size = new System.Drawing.Size(65, 25);
            this.btnCopy.TabIndex = 56;
            this.btnCopy.Text = "Kopieren";
            this.ToolTip1.SetToolTip(this.btnCopy, "Datensatz kopieren");
            this.btnCopy.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(124, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(65, 25);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Löschen";
            this.ToolTip1.SetToolTip(this.btnDelete, "Löschen des aktuellen Datensatzes");
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(68, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(57, 25);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Sichern";
            this.ToolTip1.SetToolTip(this.btnSave, "Sichern des aktuellen Datensatzes");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(604, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(73, 25);
            this.btnClose.TabIndex = 63;
            this.btnClose.Text = "&Schliessen";
            this.ToolTip1.SetToolTip(this.btnClose, "Schliesst das Berabeiten-Fenster");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnMoveNext.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMoveNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMoveNext.Location = new System.Drawing.Point(404, 10);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMoveNext.Size = new System.Drawing.Size(33, 25);
            this.btnMoveNext.TabIndex = 59;
            this.btnMoveNext.Text = ">>";
            this.ToolTip1.SetToolTip(this.btnMoveNext, "Vor");
            this.btnMoveNext.UseVisualStyleBackColor = false;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.txtWPrijsOnb);
            this.Frame1.Controls.Add(this.txtWPrijsBew);
            this.Frame1.Controls.Add(this.txtHPrijsOnb);
            this.Frame1.Controls.Add(this.txtHPrijsBew);
            this.Frame1.Controls.Add(this._label1_6);
            this.Frame1.Controls.Add(this._label1_7);
            this.Frame1.Controls.Add(this._label1_8);
            this.Frame1.Controls.Add(this._label1_9);
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(300, 42);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(177, 105);
            this.Frame1.TabIndex = 74;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Preise";
            // 
            // txtWPrijsOnb
            // 
            this.txtWPrijsOnb.AcceptsReturn = true;
            this.txtWPrijsOnb.BackColor = System.Drawing.SystemColors.Window;
            this.txtWPrijsOnb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWPrijsOnb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWPrijsOnb.Enabled = false;
            this.txtWPrijsOnb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWPrijsOnb.Location = new System.Drawing.Point(88, 56);
            this.txtWPrijsOnb.MaxLength = 0;
            this.txtWPrijsOnb.Name = "txtWPrijsOnb";
            this.txtWPrijsOnb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWPrijsOnb.Size = new System.Drawing.Size(57, 20);
            this.txtWPrijsOnb.TabIndex = 33;
            this.txtWPrijsOnb.TabStop = false;
            this.txtWPrijsOnb.Text = "Besteld";
            this.ToolTip1.SetToolTip(this.txtWPrijsOnb, "Hier eine Zahl > 0 eingeben, damit Artikel für Web publiziert wird");
            this.txtWPrijsOnb.Visible = false;
            // 
            // chkBewerkt
            // 
            this.chkBewerkt.BackColor = System.Drawing.SystemColors.Control;
            this.chkBewerkt.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkBewerkt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkBewerkt.Location = new System.Drawing.Point(604, 115);
            this.chkBewerkt.Name = "chkBewerkt";
            this.chkBewerkt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBewerkt.Size = new System.Drawing.Size(90, 17);
            this.chkBewerkt.TabIndex = 51;
            this.chkBewerkt.Text = "Bearbeitet";
            this.chkBewerkt.UseVisualStyleBackColor = false;
            this.chkBewerkt.Validated += new System.EventHandler(this.chkBewerkt_Validated);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(188, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(57, 25);
            this.btnSearch.TabIndex = 55;
            this.btnSearch.Text = "Suchen";
            this.ToolTip1.SetToolTip(this.btnSearch, "Artikel suchen");
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lstHgr_Id
            // 
            this.lstHgr_Id.BackColor = System.Drawing.SystemColors.Window;
            this.lstHgr_Id.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstHgr_Id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstHgr_Id.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstHgr_Id.Location = new System.Drawing.Point(540, 58);
            this.lstHgr_Id.Name = "lstHgr_Id";
            this.lstHgr_Id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstHgr_Id.Size = new System.Drawing.Size(137, 21);
            this.lstHgr_Id.TabIndex = 49;
            this.ToolTip1.SetToolTip(this.lstHgr_Id, "Wählen Sie hier die Gruppe für den Artikel aus");
            this.lstHgr_Id.SelectedIndexChanged += new System.EventHandler(this.lstHgr_Id_SelectedIndexChanged);
            // 
            // txtBesteld
            // 
            this.txtBesteld.AcceptsReturn = true;
            this.txtBesteld.BackColor = System.Drawing.SystemColors.Window;
            this.txtBesteld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBesteld.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBesteld.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBesteld.Location = new System.Drawing.Point(64, 19);
            this.txtBesteld.MaxLength = 0;
            this.txtBesteld.Name = "txtBesteld";
            this.txtBesteld.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBesteld.Size = new System.Drawing.Size(57, 20);
            this.txtBesteld.TabIndex = 50;
            this.txtBesteld.Text = "Besteld";
            this.ToolTip1.SetToolTip(this.txtBesteld, "Hier eine 1 eingeben, damit Artikel für Web publiziert wird. Eine 2 eingeben, dam" +
                    "it in der DIA-Show sichtbar.");
            this.txtBesteld.TextChanged += new System.EventHandler(this.txtBesteld_TextChanged);
            this.txtBesteld.Validated += new System.EventHandler(this.txtBesteld_Validated);
            // 
            // btnNewHgr_Id
            // 
            this.btnNewHgr_Id.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewHgr_Id.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNewHgr_Id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewHgr_Id.Location = new System.Drawing.Point(540, 85);
            this.btnNewHgr_Id.Name = "btnNewHgr_Id";
            this.btnNewHgr_Id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNewHgr_Id.Size = new System.Drawing.Size(94, 21);
            this.btnNewHgr_Id.TabIndex = 71;
            this.btnNewHgr_Id.TabStop = false;
            this.btnNewHgr_Id.Text = "Neue Gruppe";
            this.ToolTip1.SetToolTip(this.btnNewHgr_Id, "Wenn Sie eine neue Gruppe anlegen wollen");
            this.btnNewHgr_Id.UseVisualStyleBackColor = false;
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.SystemColors.Control;
            this.btnFoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFoto.Location = new System.Drawing.Point(732, 182);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFoto.Size = new System.Drawing.Size(25, 21);
            this.btnFoto.TabIndex = 70;
            this.btnFoto.Text = "...";
            this.ToolTip1.SetToolTip(this.btnFoto, "Hier klicken um ein anderes Bild auszuwählen");
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // txtArtNr
            // 
            this.txtArtNr.AcceptsReturn = true;
            this.txtArtNr.BackColor = System.Drawing.SystemColors.Window;
            this.txtArtNr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArtNr.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtArtNr.Location = new System.Drawing.Point(132, 66);
            this.txtArtNr.MaxLength = 0;
            this.txtArtNr.Name = "txtArtNr";
            this.txtArtNr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtArtNr.Size = new System.Drawing.Size(161, 20);
            this.txtArtNr.TabIndex = 45;
            this.txtArtNr.Text = "ArtNr";
            this.ToolTip1.SetToolTip(this.txtArtNr, "Geben Sie hier die Artikelnummer ein");
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.AcceptsReturn = true;
            this.txtOmschrijving.BackColor = System.Drawing.SystemColors.Window;
            this.txtOmschrijving.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOmschrijving.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOmschrijving.Location = new System.Drawing.Point(20, 162);
            this.txtOmschrijving.MaxLength = 0;
            this.txtOmschrijving.Multiline = true;
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOmschrijving.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOmschrijving.Size = new System.Drawing.Size(353, 59);
            this.txtOmschrijving.TabIndex = 47;
            this.txtOmschrijving.Text = "Omschrijving";
            this.ToolTip1.SetToolTip(this.txtOmschrijving, "Geben Sie eine Beschreibung zum Artikel ein");
            this.txtOmschrijving.Validated += new System.EventHandler(this.txtOmschrijving_Validated);
            // 
            // txtMaat
            // 
            this.txtMaat.AcceptsReturn = true;
            this.txtMaat.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMaat.Location = new System.Drawing.Point(68, 98);
            this.txtMaat.MaxLength = 0;
            this.txtMaat.Name = "txtMaat";
            this.txtMaat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaat.Size = new System.Drawing.Size(225, 20);
            this.txtMaat.TabIndex = 46;
            this.txtMaat.Text = "Maat";
            this.ToolTip1.SetToolTip(this.txtMaat, "Geben Sie hier die Masse des Artikels ein");
            this.txtMaat.Validated += new System.EventHandler(this.txtMaat_Validated);
            // 
            // txtFoto
            // 
            this.txtFoto.AcceptsReturn = true;
            this.txtFoto.BackColor = System.Drawing.SystemColors.Window;
            this.txtFoto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFoto.Location = new System.Drawing.Point(388, 183);
            this.txtFoto.MaxLength = 0;
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFoto.Size = new System.Drawing.Size(338, 20);
            this.txtFoto.TabIndex = 48;
            this.txtFoto.Text = "Foto";
            this.ToolTip1.SetToolTip(this.txtFoto, "Klicken Sie auf [...] um ein anderes Bild zu wählen");
            this.txtFoto.Validated += new System.EventHandler(this.txtFoto_Validated);
            // 
            // txtHgrId
            // 
            this.txtHgrId.AcceptsReturn = true;
            this.txtHgrId.BackColor = System.Drawing.SystemColors.Window;
            this.txtHgrId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHgrId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHgrId.Enabled = false;
            this.txtHgrId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHgrId.Location = new System.Drawing.Point(700, 61);
            this.txtHgrId.MaxLength = 0;
            this.txtHgrId.Name = "txtHgrId";
            this.txtHgrId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHgrId.Size = new System.Drawing.Size(25, 13);
            this.txtHgrId.TabIndex = 68;
            this.txtHgrId.TabStop = false;
            this.txtHgrId.Text = "Hgr_ID";
            // 
            // txtBewerkt
            // 
            this.txtBewerkt.AcceptsReturn = true;
            this.txtBewerkt.BackColor = System.Drawing.SystemColors.Window;
            this.txtBewerkt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBewerkt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBewerkt.Enabled = false;
            this.txtBewerkt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBewerkt.Location = new System.Drawing.Point(700, 115);
            this.txtBewerkt.MaxLength = 0;
            this.txtBewerkt.Name = "txtBewerkt";
            this.txtBewerkt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBewerkt.Size = new System.Drawing.Size(57, 20);
            this.txtBewerkt.TabIndex = 73;
            this.txtBewerkt.TabStop = false;
            this.txtBewerkt.Text = "Bearbeitet";
            this.ToolTip1.SetToolTip(this.txtBewerkt, "Hier eine Zahl > 0 eingeben, damit Artikel für Web publiziert wird");
            this.txtBewerkt.Visible = false;
            this.txtBewerkt.Validated += new System.EventHandler(this.txtBewerkt_Validated);
            // 
            // _Label4_2
            // 
            this._Label4_2.BackColor = System.Drawing.SystemColors.Control;
            this._Label4_2.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label4_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label4_2.Location = new System.Drawing.Point(448, 388);
            this._Label4_2.Name = "_Label4_2";
            this._Label4_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label4_2.Size = new System.Drawing.Size(313, 25);
            this._Label4_2.TabIndex = 80;
            this._Label4_2.Text = "Ruf: 0202/470068 Fax: 0202/6980567";
            this._Label4_2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _Label4_1
            // 
            this._Label4_1.BackColor = System.Drawing.SystemColors.Control;
            this._Label4_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label4_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label4_1.Location = new System.Drawing.Point(448, 363);
            this._Label4_1.Name = "_Label4_1";
            this._Label4_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label4_1.Size = new System.Drawing.Size(313, 25);
            this._Label4_1.TabIndex = 79;
            this._Label4_1.Text = "Grünstr. 6, 42103 Wuppertal";
            this._Label4_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _Label4_0
            // 
            this._Label4_0.BackColor = System.Drawing.SystemColors.Control;
            this._Label4_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label4_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label4_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label4_0.Location = new System.Drawing.Point(448, 330);
            this._Label4_0.Name = "_Label4_0";
            this._Label4_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label4_0.Size = new System.Drawing.Size(313, 23);
            this._Label4_0.TabIndex = 78;
            this._Label4_0.Text = "Der Biedermann";
            this._Label4_0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(20, 42);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(97, 17);
            this.Label2.TabIndex = 75;
            this.Label2.Text = "Hauptgruppen:";
            // 
            // pictFoto
            // 
            this.pictFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictFoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictFoto.Location = new System.Drawing.Point(12, 239);
            this.pictFoto.Name = "pictFoto";
            this.pictFoto.Size = new System.Drawing.Size(427, 335);
            this.pictFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictFoto.TabIndex = 81;
            this.pictFoto.TabStop = false;
            this.ToolTip1.SetToolTip(this.pictFoto, "Doppelklicken um ein anderes Bild auszuwählen");
            this.pictFoto.Click += new System.EventHandler(this.pictFoto_Click);
            // 
            // _label1_5
            // 
            this._label1_5.AutoSize = true;
            this._label1_5.BackColor = System.Drawing.Color.Transparent;
            this._label1_5.Cursor = System.Windows.Forms.Cursors.Default;
            this._label1_5.ForeColor = System.Drawing.SystemColors.WindowText;
            this._label1_5.Location = new System.Drawing.Point(16, 19);
            this._label1_5.Name = "_label1_5";
            this._label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._label1_5.Size = new System.Drawing.Size(34, 13);
            this._label1_5.TabIndex = 72;
            this._label1_5.Text = "Best.:";
            // 
            // _label1_0
            // 
            this._label1_0.AutoSize = true;
            this._label1_0.BackColor = System.Drawing.Color.Transparent;
            this._label1_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._label1_0.ForeColor = System.Drawing.SystemColors.WindowText;
            this._label1_0.Location = new System.Drawing.Point(20, 66);
            this._label1_0.Name = "_label1_0";
            this._label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._label1_0.Size = new System.Drawing.Size(37, 13);
            this._label1_0.TabIndex = 64;
            this._label1_0.Text = "ArtNr.:";
            // 
            // _label1_1
            // 
            this._label1_1.AutoSize = true;
            this._label1_1.BackColor = System.Drawing.Color.Transparent;
            this._label1_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._label1_1.ForeColor = System.Drawing.SystemColors.WindowText;
            this._label1_1.Location = new System.Drawing.Point(20, 146);
            this._label1_1.Name = "_label1_1";
            this._label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._label1_1.Size = new System.Drawing.Size(75, 13);
            this._label1_1.TabIndex = 65;
            this._label1_1.Text = "Beschreibung:";
            // 
            // _label1_2
            // 
            this._label1_2.AutoSize = true;
            this._label1_2.BackColor = System.Drawing.Color.Transparent;
            this._label1_2.Cursor = System.Windows.Forms.Cursors.Default;
            this._label1_2.ForeColor = System.Drawing.SystemColors.WindowText;
            this._label1_2.Location = new System.Drawing.Point(20, 98);
            this._label1_2.Name = "_label1_2";
            this._label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._label1_2.Size = new System.Drawing.Size(28, 13);
            this._label1_2.TabIndex = 66;
            this._label1_2.Text = "Info:";
            // 
            // _label1_3
            // 
            this._label1_3.AutoSize = true;
            this._label1_3.BackColor = System.Drawing.Color.Transparent;
            this._label1_3.Cursor = System.Windows.Forms.Cursors.Default;
            this._label1_3.ForeColor = System.Drawing.SystemColors.WindowText;
            this._label1_3.Location = new System.Drawing.Point(385, 162);
            this._label1_3.Name = "_label1_3";
            this._label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._label1_3.Size = new System.Drawing.Size(28, 13);
            this._label1_3.TabIndex = 67;
            this._label1_3.Text = "Foto";
            // 
            // _label1_4
            // 
            this._label1_4.AutoSize = true;
            this._label1_4.BackColor = System.Drawing.Color.Transparent;
            this._label1_4.Cursor = System.Windows.Forms.Cursors.Default;
            this._label1_4.ForeColor = System.Drawing.SystemColors.WindowText;
            this._label1_4.Location = new System.Drawing.Point(492, 58);
            this._label1_4.Name = "_label1_4";
            this._label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._label1_4.Size = new System.Drawing.Size(45, 13);
            this._label1_4.TabIndex = 69;
            this._label1_4.Text = "Gruppe:";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(20, 210);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(265, 33);
            this.Label3.TabIndex = 77;
            this.Label3.Text = "Bild nicht vorhanden";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusArtID,
            this.statusDataChanged});
            this.statusStrip1.Location = new System.Drawing.Point(0, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(788, 22);
            this.statusStrip1.TabIndex = 82;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusArtID
            // 
            this.statusArtID.Name = "statusArtID";
            this.statusArtID.Size = new System.Drawing.Size(32, 17);
            this.statusArtID.Text = "-----";
            // 
            // statusDataChanged
            // 
            this.statusDataChanged.Name = "statusDataChanged";
            this.statusDataChanged.Size = new System.Drawing.Size(71, 17);
            this.statusDataChanged.Text = "unverändert";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkVerwendungDia);
            this.groupBox1.Controls.Add(this.chkVerwendungWeb);
            this.groupBox1.Controls.Add(this.chkVerwendungAnderes);
            this.groupBox1.Controls.Add(this.txtBesteld);
            this.groupBox1.Controls.Add(this._label1_5);
            this.groupBox1.Location = new System.Drawing.Point(467, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 85);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Best./Verwendung:";
            // 
            // chkVerwendungAnderes
            // 
            this.chkVerwendungAnderes.AutoSize = true;
            this.chkVerwendungAnderes.Location = new System.Drawing.Point(13, 55);
            this.chkVerwendungAnderes.Name = "chkVerwendungAnderes";
            this.chkVerwendungAnderes.Size = new System.Drawing.Size(64, 17);
            this.chkVerwendungAnderes.TabIndex = 73;
            this.chkVerwendungAnderes.TabStop = true;
            this.chkVerwendungAnderes.Text = "Anderes";
            this.chkVerwendungAnderes.UseVisualStyleBackColor = true;
            this.chkVerwendungAnderes.CheckedChanged += new System.EventHandler(this.chkVerwendungAnderes_CheckedChanged);
            // 
            // chkVerwendungWeb
            // 
            this.chkVerwendungWeb.AutoSize = true;
            this.chkVerwendungWeb.Location = new System.Drawing.Point(83, 55);
            this.chkVerwendungWeb.Name = "chkVerwendungWeb";
            this.chkVerwendungWeb.Size = new System.Drawing.Size(48, 17);
            this.chkVerwendungWeb.TabIndex = 73;
            this.chkVerwendungWeb.TabStop = true;
            this.chkVerwendungWeb.Text = "Web";
            this.chkVerwendungWeb.UseVisualStyleBackColor = true;
            this.chkVerwendungWeb.CheckedChanged += new System.EventHandler(this.chkVerwendungWeb_CheckedChanged);
            // 
            // chkVerwendungDia
            // 
            this.chkVerwendungDia.AutoSize = true;
            this.chkVerwendungDia.Location = new System.Drawing.Point(137, 55);
            this.chkVerwendungDia.Name = "chkVerwendungDia";
            this.chkVerwendungDia.Size = new System.Drawing.Size(66, 17);
            this.chkVerwendungDia.TabIndex = 73;
            this.chkVerwendungDia.TabStop = true;
            this.chkVerwendungDia.Text = "Diashow";
            this.chkVerwendungDia.UseVisualStyleBackColor = true;
            this.chkVerwendungDia.CheckedChanged += new System.EventHandler(this.chkVerwendungDia_CheckedChanged);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lstGroups);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnMoveBack);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMoveNext);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.chkBewerkt);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstHgr_Id);
            this.Controls.Add(this.btnNewHgr_Id);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.txtArtNr);
            this.Controls.Add(this.txtOmschrijving);
            this.Controls.Add(this.txtMaat);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.txtHgrId);
            this.Controls.Add(this.txtBewerkt);
            this.Controls.Add(this._Label4_2);
            this.Controls.Add(this._Label4_1);
            this.Controls.Add(this._Label4_0);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.pictFoto);
            this.Controls.Add(this._label1_0);
            this.Controls.Add(this._label1_1);
            this.Controls.Add(this._label1_2);
            this.Controls.Add(this._label1_3);
            this.Controls.Add(this._label1_4);
            this.Controls.Add(this.Label3);
            this.MinimizeBox = false;
            this.Name = "FormEdit";
            this.Text = "Daten bearbeiten";
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictFoto)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.Timer Timer1;
        public System.Windows.Forms.TextBox txtHPrijsOnb;
        public System.Windows.Forms.TextBox txtHPrijsBew;
        public System.Windows.Forms.ComboBox lstGroups;
        public System.Windows.Forms.Button btnNeu;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.OpenFileDialog CommonDialog1Open;
        public System.Windows.Forms.Label _label1_6;
        public System.Windows.Forms.Label _label1_7;
        public System.Windows.Forms.Label _label1_8;
        public System.Windows.Forms.Label _label1_9;
        public System.Windows.Forms.TextBox txtWPrijsBew;
        public System.Windows.Forms.Button btnMoveBack;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnCopy;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnMoveNext;
        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.TextBox txtWPrijsOnb;
        public System.Windows.Forms.CheckBox chkBewerkt;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.ComboBox lstHgr_Id;
        public System.Windows.Forms.TextBox txtBesteld;
        public System.Windows.Forms.Button btnNewHgr_Id;
        public System.Windows.Forms.Button btnFoto;
        public System.Windows.Forms.TextBox txtArtNr;
        public System.Windows.Forms.TextBox txtOmschrijving;
        public System.Windows.Forms.TextBox txtMaat;
        public System.Windows.Forms.TextBox txtFoto;
        public System.Windows.Forms.TextBox txtHgrId;
        public System.Windows.Forms.TextBox txtBewerkt;
        public System.Windows.Forms.Label _Label4_2;
        public System.Windows.Forms.Label _Label4_1;
        public System.Windows.Forms.Label _Label4_0;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.PictureBox pictFoto;
        public System.Windows.Forms.Label _label1_5;
        public System.Windows.Forms.Label _label1_0;
        public System.Windows.Forms.Label _label1_1;
        public System.Windows.Forms.Label _label1_2;
        public System.Windows.Forms.Label _label1_3;
        public System.Windows.Forms.Label _label1_4;
        public System.Windows.Forms.Label Label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusArtID;
        private System.Windows.Forms.ToolStripStatusLabel statusDataChanged;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chkVerwendungDia;
        private System.Windows.Forms.RadioButton chkVerwendungWeb;
        private System.Windows.Forms.RadioButton chkVerwendungAnderes;
    }
}