namespace BiederDB3
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDatei = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDaten = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroupSort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroupRename = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroupTextEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroupDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWebCleanup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCleanupData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDataEdit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDiaShow = new System.Windows.Forms.Button();
            this.btnPublish2Web = new System.Windows.Forms.Button();
            this.btnBackupRestore = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatei,
            this.mnuDaten,
            this.mnuOptions,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(395, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDatei
            // 
            this.mnuDatei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.mnuDatei.Name = "mnuDatei";
            this.mnuDatei.Size = new System.Drawing.Size(44, 20);
            this.mnuDatei.Text = "Datei";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(103, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // mnuDaten
            // 
            this.mnuDaten.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGroupSort,
            this.mnuGroupRename,
            this.mnuGroupTextEdit,
            this.mnuGroupDelete,
            this.toolStripMenuItem2,
            this.mnuWebCleanup,
            this.mnuCleanupData});
            this.mnuDaten.Name = "mnuDaten";
            this.mnuDaten.Size = new System.Drawing.Size(48, 20);
            this.mnuDaten.Text = "Daten";
            // 
            // mnuGroupSort
            // 
            this.mnuGroupSort.Name = "mnuGroupSort";
            this.mnuGroupSort.Size = new System.Drawing.Size(213, 22);
            this.mnuGroupSort.Text = "Gruppen sortieren";
            this.mnuGroupSort.Click += new System.EventHandler(this.mnuGroupSort_Click);
            // 
            // mnuGroupRename
            // 
            this.mnuGroupRename.Name = "mnuGroupRename";
            this.mnuGroupRename.Size = new System.Drawing.Size(213, 22);
            this.mnuGroupRename.Text = "Gruppe umbenennen";
            this.mnuGroupRename.Click += new System.EventHandler(this.mnuGroupRename_Click);
            // 
            // mnuGroupTextEdit
            // 
            this.mnuGroupTextEdit.Name = "mnuGroupTextEdit";
            this.mnuGroupTextEdit.Size = new System.Drawing.Size(213, 22);
            this.mnuGroupTextEdit.Text = "Gruppentexte";
            this.mnuGroupTextEdit.Click += new System.EventHandler(this.mnuGroupTextEdit_Click);
            // 
            // mnuGroupDelete
            // 
            this.mnuGroupDelete.Name = "mnuGroupDelete";
            this.mnuGroupDelete.Size = new System.Drawing.Size(213, 22);
            this.mnuGroupDelete.Text = "Gruppe löschen";
            this.mnuGroupDelete.Click += new System.EventHandler(this.mnuGroupDelete_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 22);
            this.toolStripMenuItem2.Text = "-----";
            // 
            // mnuWebCleanup
            // 
            this.mnuWebCleanup.Name = "mnuWebCleanup";
            this.mnuWebCleanup.Size = new System.Drawing.Size(213, 22);
            this.mnuWebCleanup.Text = "Für Web bereinigen";
            this.mnuWebCleanup.Click += new System.EventHandler(this.mnuWebCleanup_Click);
            // 
            // mnuCleanupData
            // 
            this.mnuCleanupData.Name = "mnuCleanupData";
            this.mnuCleanupData.Size = new System.Drawing.Size(213, 22);
            this.mnuCleanupData.Text = "Doppelte Daten bereinigen";
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettings,
            this.mnuColors});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(63, 20);
            this.mnuOptions.Text = "Optionen";
            // 
            // mnuSettings
            // 
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(162, 22);
            this.mnuSettings.Text = "Einstellungen";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // mnuColors
            // 
            this.mnuColors.Name = "mnuColors";
            this.mnuColors.Size = new System.Drawing.Size(162, 22);
            this.mnuColors.Text = "Internet Farben";
            this.mnuColors.Click += new System.EventHandler(this.mnuColors_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(24, 20);
            this.mnuHelp.Text = "?";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(108, 22);
            this.mnuAbout.Text = "Über";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // btnDataEdit
            // 
            this.btnDataEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDataEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataEdit.Location = new System.Drawing.Point(3, 3);
            this.btnDataEdit.Name = "btnDataEdit";
            this.btnDataEdit.Size = new System.Drawing.Size(389, 65);
            this.btnDataEdit.TabIndex = 1;
            this.btnDataEdit.Text = "Daten bearbeiten";
            this.btnDataEdit.UseVisualStyleBackColor = true;
            this.btnDataEdit.Click += new System.EventHandler(this.btnDataEdit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnDataEdit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDiaShow, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPublish2Web, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBackupRestore, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 287);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnDiaShow
            // 
            this.btnDiaShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiaShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiaShow.Location = new System.Drawing.Point(3, 74);
            this.btnDiaShow.Name = "btnDiaShow";
            this.btnDiaShow.Size = new System.Drawing.Size(389, 65);
            this.btnDiaShow.TabIndex = 2;
            this.btnDiaShow.Text = "Dia Show";
            this.btnDiaShow.UseVisualStyleBackColor = true;
            this.btnDiaShow.Click += new System.EventHandler(this.btnDiaShow_Click);
            // 
            // btnPublish2Web
            // 
            this.btnPublish2Web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPublish2Web.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublish2Web.Location = new System.Drawing.Point(3, 145);
            this.btnPublish2Web.Name = "btnPublish2Web";
            this.btnPublish2Web.Size = new System.Drawing.Size(389, 65);
            this.btnPublish2Web.TabIndex = 3;
            this.btnPublish2Web.Text = "Für Web publizieren";
            this.btnPublish2Web.UseVisualStyleBackColor = true;
            this.btnPublish2Web.Click += new System.EventHandler(this.btnPublish2Web_Click);
            // 
            // btnBackupRestore
            // 
            this.btnBackupRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackupRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupRestore.Location = new System.Drawing.Point(3, 216);
            this.btnBackupRestore.Name = "btnBackupRestore";
            this.btnBackupRestore.Size = new System.Drawing.Size(389, 68);
            this.btnBackupRestore.TabIndex = 4;
            this.btnBackupRestore.Text = "Backup/Restore (ZIP)";
            this.btnBackupRestore.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "BiederDB3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDatei;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuDaten;
        private System.Windows.Forms.ToolStripMenuItem mnuGroupDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuGroupRename;
        private System.Windows.Forms.ToolStripMenuItem mnuGroupTextEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuWebCleanup;
        private System.Windows.Forms.ToolStripMenuItem mnuCleanupData;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuColors;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.Button btnDataEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDiaShow;
        private System.Windows.Forms.Button btnPublish2Web;
        private System.Windows.Forms.Button btnBackupRestore;
        private System.Windows.Forms.ToolStripMenuItem mnuGroupSort;
    }
}

