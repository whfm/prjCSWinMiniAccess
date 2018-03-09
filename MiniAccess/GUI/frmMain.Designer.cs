namespace MiniAccess
{
    partial class MiniAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniAccess));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewDB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddTable = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddFields = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddRelations = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDataStruct = new System.Windows.Forms.ToolStripMenuItem();
            this.displayFields = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.Transparent;
            this.menuBar.Dock = System.Windows.Forms.DockStyle.None;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBar.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuAdd,
            this.menuDisplay,
            this.menuInfo});
            this.menuBar.Location = new System.Drawing.Point(164, 9);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(350, 48);
            this.menuBar.Stretch = false;
            this.menuBar.TabIndex = 6;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuCloseCurrent,
            this.toolStripSeparator2,
            this.menuExit});
            this.menuFile.Image = global::MiniAccess.Properties.Resources.icons8_document_50;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(79, 44);
            this.menuFile.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewDB});
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(208, 22);
            this.menuNew.Text = "New";
            // 
            // menuNewDB
            // 
            this.menuNewDB.Name = "menuNewDB";
            this.menuNewDB.Size = new System.Drawing.Size(129, 22);
            this.menuNewDB.Text = "Database";
            this.menuNewDB.Click += new System.EventHandler(this.menuNewDB_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(208, 22);
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuCloseCurrent
            // 
            this.menuCloseCurrent.Name = "menuCloseCurrent";
            this.menuCloseCurrent.Size = new System.Drawing.Size(208, 22);
            this.menuCloseCurrent.Text = "Close Current Database";
            this.menuCloseCurrent.Click += new System.EventHandler(this.menuCloseCurrent_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuExit.Size = new System.Drawing.Size(208, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuAdd
            // 
            this.menuAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddTable,
            this.menuAddFields,
            this.menuAddRelations});
            this.menuAdd.Image = global::MiniAccess.Properties.Resources.icons8_add_database_50;
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(82, 44);
            this.menuAdd.Text = "Add";
            // 
            // menuAddTable
            // 
            this.menuAddTable.Name = "menuAddTable";
            this.menuAddTable.Size = new System.Drawing.Size(126, 22);
            this.menuAddTable.Text = "Tables";
            this.menuAddTable.Click += new System.EventHandler(this.menuAddTable_Click);
            // 
            // menuAddFields
            // 
            this.menuAddFields.Name = "menuAddFields";
            this.menuAddFields.Size = new System.Drawing.Size(126, 22);
            this.menuAddFields.Text = "Fields";
            this.menuAddFields.Click += new System.EventHandler(this.menuAddFields_Click);
            // 
            // menuAddRelations
            // 
            this.menuAddRelations.Name = "menuAddRelations";
            this.menuAddRelations.Size = new System.Drawing.Size(126, 22);
            this.menuAddRelations.Text = "Relations";
            this.menuAddRelations.Click += new System.EventHandler(this.menuAddRelations_Click);
            // 
            // menuDisplay
            // 
            this.menuDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayDataStruct,
            this.displayFields});
            this.menuDisplay.Image = global::MiniAccess.Properties.Resources.icons8_web_design_50;
            this.menuDisplay.Name = "menuDisplay";
            this.menuDisplay.Size = new System.Drawing.Size(100, 44);
            this.menuDisplay.Text = "Display";
            // 
            // displayDataStruct
            // 
            this.displayDataStruct.Name = "displayDataStruct";
            this.displayDataStruct.Size = new System.Drawing.Size(183, 22);
            this.displayDataStruct.Text = "Database Structure";
            this.displayDataStruct.Click += new System.EventHandler(this.displayDataStruct_Click);
            // 
            // displayFields
            // 
            this.displayFields.Name = "displayFields";
            this.displayFields.Size = new System.Drawing.Size(183, 22);
            this.displayFields.Text = "Fields";
            this.displayFields.Click += new System.EventHandler(this.displayFields_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.Image = global::MiniAccess.Properties.Resources.icons8_info_squared_50;
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Size = new System.Drawing.Size(81, 44);
            this.menuInfo.Text = "Info";
            this.menuInfo.Click += new System.EventHandler(this.menuInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniAccess.Properties.Resources.p1ah6hsovfgk11pnansd1jcbkjn3;
            this.pictureBox1.Location = new System.Drawing.Point(23, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MiniAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiniAccess.Properties.Resources.access1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuBar;
            this.Name = "MiniAccess";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Mini Access";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.MiniAccess_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuAddTable;
        private System.Windows.Forms.ToolStripMenuItem menuAddFields;
        private System.Windows.Forms.ToolStripMenuItem menuAddRelations;
        private System.Windows.Forms.ToolStripMenuItem menuNewDB;
        private System.Windows.Forms.ToolStripMenuItem menuInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem menuDisplay;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuCloseCurrent;
        private System.Windows.Forms.ToolStripMenuItem displayDataStruct;
        private System.Windows.Forms.ToolStripMenuItem displayFields;
    }
}

