namespace MiniAccess
{
    partial class frmRelations
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
            this.cmbTableUn = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbTableDeux = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtRelation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbFieldDeux = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbFieldUn = new MetroFramework.Controls.MetroComboBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cmbTableUn
            // 
            this.cmbTableUn.FormattingEnabled = true;
            this.cmbTableUn.ItemHeight = 23;
            this.cmbTableUn.Location = new System.Drawing.Point(23, 90);
            this.cmbTableUn.Name = "cmbTableUn";
            this.cmbTableUn.Size = new System.Drawing.Size(213, 29);
            this.cmbTableUn.TabIndex = 0;
            this.cmbTableUn.UseSelectable = true;
            this.cmbTableUn.SelectedIndexChanged += new System.EventHandler(this.cmbTableUn_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "1st Table:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(242, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "2nd Table:";
            // 
            // cmbTableDeux
            // 
            this.cmbTableDeux.FormattingEnabled = true;
            this.cmbTableDeux.ItemHeight = 23;
            this.cmbTableDeux.Location = new System.Drawing.Point(242, 90);
            this.cmbTableDeux.Name = "cmbTableDeux";
            this.cmbTableDeux.Size = new System.Drawing.Size(213, 29);
            this.cmbTableDeux.TabIndex = 2;
            this.cmbTableDeux.UseSelectable = true;
            this.cmbTableDeux.SelectedIndexChanged += new System.EventHandler(this.cmbTableDeux_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 138);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Relation Name:";
            // 
            // txtRelation
            // 
            // 
            // 
            // 
            this.txtRelation.CustomButton.Image = null;
            this.txtRelation.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.txtRelation.CustomButton.Name = "";
            this.txtRelation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRelation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRelation.CustomButton.TabIndex = 1;
            this.txtRelation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRelation.CustomButton.UseSelectable = true;
            this.txtRelation.CustomButton.Visible = false;
            this.txtRelation.Lines = new string[0];
            this.txtRelation.Location = new System.Drawing.Point(128, 134);
            this.txtRelation.MaxLength = 32767;
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.PasswordChar = '\0';
            this.txtRelation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRelation.SelectedText = "";
            this.txtRelation.SelectionLength = 0;
            this.txtRelation.SelectionStart = 0;
            this.txtRelation.ShortcutsEnabled = true;
            this.txtRelation.ShowClearButton = true;
            this.txtRelation.Size = new System.Drawing.Size(327, 23);
            this.txtRelation.TabIndex = 5;
            this.txtRelation.UseSelectable = true;
            this.txtRelation.WaterMark = "Enter the name of the relation";
            this.txtRelation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRelation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(242, 162);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "2nd Field:";
            // 
            // cmbFieldDeux
            // 
            this.cmbFieldDeux.FormattingEnabled = true;
            this.cmbFieldDeux.ItemHeight = 23;
            this.cmbFieldDeux.Location = new System.Drawing.Point(242, 184);
            this.cmbFieldDeux.Name = "cmbFieldDeux";
            this.cmbFieldDeux.Size = new System.Drawing.Size(213, 29);
            this.cmbFieldDeux.TabIndex = 8;
            this.cmbFieldDeux.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 162);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "1st Field:";
            // 
            // cmbFieldUn
            // 
            this.cmbFieldUn.FormattingEnabled = true;
            this.cmbFieldUn.ItemHeight = 23;
            this.cmbFieldUn.Location = new System.Drawing.Point(23, 184);
            this.cmbFieldUn.Name = "cmbFieldUn";
            this.cmbFieldUn.Size = new System.Drawing.Size(213, 29);
            this.cmbFieldUn.TabIndex = 6;
            this.cmbFieldUn.UseSelectable = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::MiniAccess.Properties.Resources.icons8_delete_25;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Location = new System.Drawing.Point(380, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImage = global::MiniAccess.Properties.Resources.icons8_table_25;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreate.Location = new System.Drawing.Point(299, 230);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 28);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmRelations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 277);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cmbFieldDeux);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmbFieldUn);
            this.Controls.Add(this.txtRelation);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbTableDeux);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbTableUn);
            this.Name = "frmRelations";
            this.Text = "Relations";
            this.Load += new System.EventHandler(this.frmRelations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbTableUn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbTableDeux;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtRelation;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbFieldDeux;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbFieldUn;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnCreate;
    }
}