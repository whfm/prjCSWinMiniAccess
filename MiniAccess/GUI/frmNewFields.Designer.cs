namespace MiniAccess
{
    partial class frmNewFields
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
            this.cmbListTable = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFieldName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbFieldType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtFieldSize = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbFieldProperty = new MetroFramework.Controls.MetroComboBox();
            this.chkAuto = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // cmbListTable
            // 
            this.cmbListTable.FormattingEnabled = true;
            this.cmbListTable.ItemHeight = 23;
            this.cmbListTable.Location = new System.Drawing.Point(119, 68);
            this.cmbListTable.Name = "cmbListTable";
            this.cmbListTable.Size = new System.Drawing.Size(228, 29);
            this.cmbListTable.TabIndex = 5;
            this.cmbListTable.UseSelectable = true;
            this.cmbListTable.SelectedIndexChanged += new System.EventHandler(this.cmbListTable_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Select a table:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 112);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Field Name:";
            // 
            // txtFieldName
            // 
            // 
            // 
            // 
            this.txtFieldName.CustomButton.Image = null;
            this.txtFieldName.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.txtFieldName.CustomButton.Name = "";
            this.txtFieldName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFieldName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFieldName.CustomButton.TabIndex = 1;
            this.txtFieldName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFieldName.CustomButton.UseSelectable = true;
            this.txtFieldName.CustomButton.Visible = false;
            this.txtFieldName.Lines = new string[0];
            this.txtFieldName.Location = new System.Drawing.Point(119, 108);
            this.txtFieldName.MaxLength = 32767;
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.PasswordChar = '\0';
            this.txtFieldName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFieldName.SelectedText = "";
            this.txtFieldName.SelectionLength = 0;
            this.txtFieldName.SelectionStart = 0;
            this.txtFieldName.ShortcutsEnabled = true;
            this.txtFieldName.ShowClearButton = true;
            this.txtFieldName.Size = new System.Drawing.Size(228, 23);
            this.txtFieldName.TabIndex = 8;
            this.txtFieldName.UseSelectable = true;
            this.txtFieldName.WaterMark = "Field Name";
            this.txtFieldName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFieldName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 147);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Field Type:";
            // 
            // cmbFieldType
            // 
            this.cmbFieldType.FormattingEnabled = true;
            this.cmbFieldType.ItemHeight = 23;
            this.cmbFieldType.Location = new System.Drawing.Point(119, 137);
            this.cmbFieldType.Name = "cmbFieldType";
            this.cmbFieldType.Size = new System.Drawing.Size(228, 29);
            this.cmbFieldType.TabIndex = 9;
            this.cmbFieldType.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 176);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Field Size:";
            // 
            // txtFieldSize
            // 
            // 
            // 
            // 
            this.txtFieldSize.CustomButton.Image = null;
            this.txtFieldSize.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.txtFieldSize.CustomButton.Name = "";
            this.txtFieldSize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFieldSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFieldSize.CustomButton.TabIndex = 1;
            this.txtFieldSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFieldSize.CustomButton.UseSelectable = true;
            this.txtFieldSize.CustomButton.Visible = false;
            this.txtFieldSize.Lines = new string[0];
            this.txtFieldSize.Location = new System.Drawing.Point(119, 172);
            this.txtFieldSize.MaxLength = 32767;
            this.txtFieldSize.Name = "txtFieldSize";
            this.txtFieldSize.PasswordChar = '\0';
            this.txtFieldSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFieldSize.SelectedText = "";
            this.txtFieldSize.SelectionLength = 0;
            this.txtFieldSize.SelectionStart = 0;
            this.txtFieldSize.ShortcutsEnabled = true;
            this.txtFieldSize.ShowClearButton = true;
            this.txtFieldSize.Size = new System.Drawing.Size(228, 23);
            this.txtFieldSize.TabIndex = 13;
            this.txtFieldSize.UseSelectable = true;
            this.txtFieldSize.WaterMark = "Field Size";
            this.txtFieldSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFieldSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::MiniAccess.Properties.Resources.icons8_delete_25;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Location = new System.Drawing.Point(272, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImage = global::MiniAccess.Properties.Resources.icons8_table_25;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreate.Location = new System.Drawing.Point(191, 260);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 28);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 209);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(96, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Field Property:";
            // 
            // cmbFieldProperty
            // 
            this.cmbFieldProperty.FormattingEnabled = true;
            this.cmbFieldProperty.ItemHeight = 23;
            this.cmbFieldProperty.Location = new System.Drawing.Point(119, 199);
            this.cmbFieldProperty.Name = "cmbFieldProperty";
            this.cmbFieldProperty.Size = new System.Drawing.Size(228, 29);
            this.cmbFieldProperty.TabIndex = 16;
            this.cmbFieldProperty.UseSelectable = true;
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(119, 239);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(95, 15);
            this.chkAuto.TabIndex = 18;
            this.chkAuto.Text = "Auto Increase";
            this.chkAuto.UseSelectable = true;
            // 
            // frmNewFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 308);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmbFieldProperty);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtFieldSize);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbFieldType);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbListTable);
            this.Name = "frmNewFields";
            this.Text = "New Fields";
            this.Load += new System.EventHandler(this.frmNewFields_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbListTable;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFieldName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbFieldType;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtFieldSize;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnCreate;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbFieldProperty;
        private MetroFramework.Controls.MetroCheckBox chkAuto;
    }
}