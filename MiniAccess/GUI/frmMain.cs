using System;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.IO;
using DAO;
using MetroFramework;
using MiniAccess.GUI;

namespace MiniAccess
{
    public partial class MiniAccess : MetroForm
    {

        //public variables to control the menustrip
        public static ToolStripMenuItem tsMenuAdd;
        public static ToolStripMenuItem tsMenuClose;
        public static ToolStripMenuItem tsFields;
        public static ToolStripMenuItem tsView;
        public static ToolStripMenuItem tsMenuOpen;


        
        public static void disableMenu() //menustrip controller
        {
            tsMenuAdd.Enabled = tsFields.Enabled = tsView.Enabled = tsMenuOpen.Enabled = false;
            tsMenuClose.Enabled = true;
            tsMenuOpen.Enabled = true;
            tsMenuAdd.Text = "You need to close the current database to create a new one.";           
        }
        
        public static void enableAdd() //menustrip controller
        {
            tsFields.Enabled = tsView.Enabled = true;
            tsMenuOpen.Enabled = false;
        }

        public static void loadTableString() //loads the table string with the table definitions
        {
            foreach (TableDef oneTable in clsDataStorage.db.TableDefs)
            {
                if (oneTable.Attributes == 0)
                {
                    clsDataStorage.tableNames.Add(oneTable.Name);
                }
            }
        }
        public MiniAccess()
        {
            InitializeComponent();
        }

        private void MiniAccess_Load(object sender, EventArgs e) //initializes the form, disble menus and sets control to global checkers
        {
            tsMenuAdd = menuNewDB;
            tsFields = menuAdd;
            tsMenuClose = menuCloseCurrent;
            tsView = menuDisplay;
            tsMenuOpen = menuOpen;

            tsView.Enabled = false;
            tsMenuClose.Enabled = false;
            tsFields.Enabled = false;
        }

        private void menuExit_Click(object sender, EventArgs e) //exit function
        {
            var confirmResult = MetroMessageBox.Show(this, "Would you like to close the application?", "Confirm Close!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void menuNewDB_Click(object sender, EventArgs e) //loads the form to create new db
        {
            frmNewDB fdb = new frmNewDB();
            fdb.MdiParent = this;
            fdb.Show();
        }

        private void menuCloseCurrent_Click(object sender, EventArgs e) //close current db
        {
            var confirmResult = MetroMessageBox.Show(this, "Would you like to close the Database?", "Confirm Close!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                disableMenu();
                if (clsDataStorage.status) { clsDataStorage.db.Close(); }
                clsDataStorage.status = false;
                menuCloseCurrent.Enabled = false;
                menuNewDB.Enabled = true;
                tsMenuAdd.Text = "Database";
            }
        }

        private void menuAddTable_Click(object sender, EventArgs e) //loads add new table form
        {
            frmTable fnt = new frmTable();
            fnt.MdiParent = this;
            fnt.Show();
        }

        private void menuOpen_Click(object sender, EventArgs e) //open existing database function
        {
            if (clsDataStorage.status) { clsDataStorage.db.Close(); }
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "Open an existing database";
            openFD.InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Database";
            openFD.Filter = "Database files(*.accdb)|*.accdb";
            openFD.FilterIndex = 2;
            openFD.RestoreDirectory = true;
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                clsDataStorage.db = clsDataStorage.dbe.OpenDatabase(openFD.FileName);
                clsDataStorage.status = true;
                disableMenu();
                enableAdd();
                menuOpen.Enabled = false;
                loadTableString();
            }
        }

        private void menuAddFields_Click(object sender, EventArgs e) //opens the add fields form
        {
            frmNewFields fnf = new frmNewFields();
            fnf.MdiParent = this;
            fnf.Show();
        }

        private void menuAddRelations_Click(object sender, EventArgs e) //opens the add relations form
        {
            frmRelations frf = new frmRelations();
            frf.MdiParent = this;
            frf.Show();
        }

        private void menuInfo_Click(object sender, EventArgs e) //displays the about info
        {
            frmAbout fra = new frmAbout();
            fra.MdiParent = this;
            fra.Show();
        }

        private void displayDataStruct_Click(object sender, EventArgs e)
        {
            frmDisplay frd = new frmDisplay();
            frd.ShowDialog();
        }

        private void displayFields_Click(object sender, EventArgs e)
        {
            frmFields frfd = new frmFields();
            frfd.ShowDialog();
        }
    }
}
