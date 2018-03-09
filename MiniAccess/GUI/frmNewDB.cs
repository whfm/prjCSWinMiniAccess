using DAO;
using MetroFramework.Forms;
using System.IO;
using System.Windows.Forms;
using MetroFramework;


namespace MiniAccess
{
    public partial class frmNewDB : MetroForm
    {
        public frmNewDB()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, System.EventArgs e) //triggers the create database event
        {
            if (txtPath.Text != "")
            {
                if (File.Exists(txtPath.Text)) //if the database exists, delete it
                {
                    File.Delete(txtPath.Text);
                }//creates the database
                clsDataStorage.db = clsDataStorage.dbe.CreateDatabase(txtPath.Text, LanguageConstants.dbLangGeneral);
                clsDataStorage.status = true;
                MetroMessageBox.Show(this, "Database created with success!", "New database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MiniAccess.disableMenu(); //disables the create and open menu
                MiniAccess.enableAdd(); //enables the add fields and display menu
                MiniAccess.tsMenuAdd.Enabled = false;
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "Please check the name of the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFile_Click(object sender, System.EventArgs e) //select filename to the database
        {
            if (clsDataStorage.status) { clsDataStorage.db.Close(); }
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Title = "Create new database";
            saveFD.InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Databases";
            saveFD.Filter = "Database files(*.accdb)|*.accdb";
            saveFD.RestoreDirectory = true;

            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = saveFD.FileName.ToString();
            }
            
        }

        private void btnCancel_Click(object sender, System.EventArgs e) //cancel
        {
            this.Close();
        }
    }
}
