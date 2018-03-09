using System;
using MetroFramework;
using DAO;
using System.Windows.Forms;

namespace MiniAccess
{
    public partial class frmRelations : MetroFramework.Forms.MetroForm
    {
        Recordset recordSet; //public variable recordset
        public frmRelations()
        {
            InitializeComponent();
        }
        
        private void frmRelations_Load(object sender, EventArgs e)
        {
            int y = 0; 
            foreach (TableDef table in clsDataStorage.db.TableDefs) //loops through the tables
            {
                if (table.Attributes == 0) //excludes system tables
                {
                    cmbTableUn.Items.Add(table.Name); //adds the table to the combobox
                    cmbTableDeux.Items.Add(table.Name); //adds the table to the combobox
                    y++;
                }
            }
            if (y == 0) {
                //if there isnt a table, display error and close form
                MetroMessageBox.Show(this, "There are no tables in the database.\nCreate a table before trying to create a relation.");
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void cmbTableUn_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFieldUn.Items.Clear();
            recordSet = clsDataStorage.db.OpenTable(cmbTableUn.Text);
            foreach (Field field in recordSet.Fields)
            {
                cmbFieldUn.Items.Add(field.Name);
            }
            recordSet.Close();

            //opens the recordset, loads the fields from the chosen table into the fields 1 combo box.
        }

        private void cmbTableDeux_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFieldDeux.Items.Clear();
            recordSet = clsDataStorage.db.OpenTable(cmbTableDeux.Text);
            foreach (Field field in recordSet.Fields)
            {
                cmbFieldDeux.Items.Add(field.Name);
            }
            recordSet.Close();
            //opens the recordset, loads the fields from the chosen table into the fields 2 combo box.
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //triggers the creation of relationship

            bool exist = false;
            if (cmbTableUn.Text == "" || cmbTableDeux.Text == "") //check if the tables are chosen
            {
                MetroMessageBox.Show(this,"Please select the tables.");
            }
            else if (cmbTableUn.Text == cmbTableDeux.Text) //check if the tables have the same name
            {
                MetroMessageBox.Show(this,"Tables selected have to be different.");
            }
            else if (txtRelation.Text == "") //checks if the relation name was given
            {
                MetroMessageBox.Show(this,"Enter a name before creating a relation.");
            }
            else if (cmbFieldUn.Text == "" || cmbFieldDeux.Text == "") //check if the fields were chosen 
            {
                MetroMessageBox.Show(this,"Please select the fields for the relation.");
            }
            else if (clsDataStorage.db.TableDefs[cmbTableUn.Text].Fields[cmbFieldUn.Text].Type 
                != clsDataStorage.db.TableDefs[cmbTableDeux.Text].Fields[cmbFieldDeux.Text].Type) //check if fields are of same type
            {
                MetroMessageBox.Show(this,"Fields must be of the same type.");
            }
            else
            {
                foreach (Relation rl in clsDataStorage.db.Relations) //loop through the database
                    if (rl.Name == txtRelation.Text) //if a relationship with given name already exists, return error
                    {
                        MetroMessageBox.Show(this,"The relation: " + rl.Name + " already exists.");
                        exist = true;
                    }
                if (!exist)
                { //creates the relationship
                    Relation rel = clsDataStorage.db.CreateRelation();
                    rel.Name = txtRelation.Text;
                    rel.Table = cmbTableUn.Text;
                    rel.ForeignTable = cmbTableDeux.Text;
                    Field fd = rel.CreateField();
                    fd.Name = cmbFieldUn.Text;
                    fd.ForeignName = cmbFieldDeux.Text;
                    rel.Fields.Append(fd);
                    clsDataStorage.db.Relations.Append(rel);
                    MetroMessageBox.Show(this,"Relation: " + rel.Name + " was successfully created.");
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }
    }
}
